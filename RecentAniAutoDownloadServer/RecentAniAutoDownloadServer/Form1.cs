using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;
using System.Threading;
using Tweetinvi;
using TwitterToken;
using TweetinCore;
using oAuthConnection;
using TweetinCore.Enum;
using TweetinCore.Events;
using TweetinCore.Interfaces;
using TweetinCore.Interfaces.oAuth;
using TweetinCore.Interfaces.StreamInvi;
using TweetinCore.Interfaces.TwitterToken;
using oAuthConnection.Utils;
using UILibrary;
using UILibrary.ViewModel;

namespace RecentAniAutoDownloadServer
{
    public struct AniName
    {
        public string name;
        public string Ep;
    }


    public partial class fm_main : Form
    {

        private bool ThreadStopCheck = false;
        private List<AniName> Ani = new List<AniName>();

        IToken newtoken = new Token(
                                    "1347431911-h0lbbAFF5LuO9Ew4wHITjj3q9fP4XfghYxW9AhO",
                                    "F12IXZwCTTU7ubTOp2T6FvKAhcvTqn6CaWjcb4ANbk",
                                    "P8jtO2jIf3QwE6bfoahMw",
                                    "FzfnuQ8isiQwNZKnK909MfJ3ylT4r6fzg0Akt6FHJM");

        public fm_main()
        {
            InitializeComponent();
            bt_ChangeTeam.Enabled = false;
            bt_Stop.Enabled = false;
            AniName AniTemp;


            if (File.Exists("setting.txt"))
            {
                StreamReader sr = new StreamReader("setting.txt");
                while(sr.Peek() >= 0)
                {
                    AniTemp.name = sr.ReadLine();
                    AniTemp.Ep = sr.ReadLine();
                    Ani.Add(AniTemp);
                }
                sr.Close();
            }
            else
            {
                FileStream fs = new FileStream("setting.txt", FileMode.Create);
                fs.Close();
            }

            if(File.Exists("UserList.txt"))
            {
                StreamReader sr = new StreamReader("UserList.txt");
                while(sr.Peek() >= 0)
                {
                    list_TweetUser.Items.Add(sr.ReadLine());
                }
            }
            else
            {
                FileStream fs = new FileStream("UserList.txt", FileMode.Create);
                fs.Close();
            }
        }

        private void bt_AniInput_Click(object sender, EventArgs e)
        {
            if (tb_AniString.Text != "")
            {
                if (tb_Ep.Text != "")
                {
                    AniName AniTemp;
                    AniTemp.name = tb_AniString.Text;
                    AniTemp.Ep = tb_Ep.Text;
                    list_AniString.Items.Add(tb_AniString.Text);
                    Ani.Add(AniTemp);
                }
                else
                {
                    MessageBox.Show("Input Ep");
                }
            }
            else
            {
                MessageBox.Show("Input Aniname");
            }
        }

        private void bt_AniDelete_Click(object sender, EventArgs e)
        {
            Ani.RemoveAt(list_AniString.SelectedIndex);
            list_AniString.Items.RemoveAt(list_AniString.SelectedIndex);
        }

        private void bt_twidinput_Click(object sender, EventArgs e)
        {
            list_TweetUser.Items.Add(tb_IDString.Text);
        }

        private void bt_twiddelete_Click(object sender, EventArgs e)
        {
            list_TweetUser.Items.RemoveAt(list_TweetUser.SelectedIndex);
        }

        private void bt_SettingTeam_Click(object sender, EventArgs e)
        {
            tb_Team.Enabled = false;
            bt_SettingTeam.Enabled = false;
            bt_ChangeTeam.Enabled = true;
        }

        private void bt_ChangeTeam_Click(object sender, EventArgs e)
        {
            tb_Team.Enabled = true;
            bt_SettingTeam.Enabled = true;
            bt_ChangeTeam.Enabled = false;
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            Thread AutoRefresh = new Thread(new ThreadStart(SendDownloadQuery));

            bt_Start.Enabled = false;
            bt_Stop.Enabled = true;
            bt_Refresh.Enabled = false;

            ThreadStopCheck = true;
            AutoRefresh.Start();
        }

        private void SendDownloadQuery()
        {
            while(ThreadStopCheck)
            {
                RssReader rss = new RssReader();
                rss.FeedUrl = "https://www.tokyotosho.info/rss.php?filter=1,10,7";
                

                foreach(RssItem item in rss.Execute())
                {
                    int i = 0;

                    for (int j = 0; j < Ani.Count; j++ )
                    {
                        item.Title.Replace('_', ' ');

                        if (item.Title.Contains("1280x720") || item.Title.Contains("1920x1080")
                            || item.Title.Contains("1080p") || item.Title.Contains("720p"))
                        {
                            item.Title.Replace("1280x720", "");
                            item.Title.Replace("1920x1080", "");
                            item.Title.Replace("1080p", "");
                            item.Title.Replace("720p", "");

                            if (item.Title.Contains(Ani[j].name) && item.Title.Contains(Ani[j].Ep))
                            {
                                WebClient webClient = new WebClient();
                                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(fake2);
                                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(fake);
                                webClient.DownloadFileAsync(new Uri(item.Link), item.Title + ".torrent");

                                int Ep = Convert.ToInt32(Ani[j].Ep);
                                ++Ep;
                                AniName Variable = Ani[j];
                                Variable.Ep = Convert.ToString(Ep);
                                Ani[i] = Variable;
                                TweetToPerson(Ani[j], list_TweetUser);
                            }

                            i++;
                        }

                    }
                }
                Thread.Sleep(60000);
            }
            bt_Refresh.Enabled = true;
            Thread.CurrentThread.Abort();
        }

        private void fake(object sender, DownloadProgressChangedEventArgs e)
        {

        }

        private void fake2(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            bt_Start.Enabled = true;
            bt_Stop.Enabled = false;
            
            ThreadStopCheck = false;
        }

        private void TweetToPerson(AniName structAni, ListBox UserList)
        {
            foreach (string User in UserList.Items)
            {
                if(User.Equals("@ThanksForPlay"))
                {
                    var tweet = new Tweet(User + " " + structAni.name + "의 " + structAni.Ep +
                        "화가 새롭게 업데이트 되었어, 지금 다운로드 받고 있으니까 조금만 기다려줘.", newtoken);
                    tweet.Publish();
                }
                
            }
        }

    }
}
