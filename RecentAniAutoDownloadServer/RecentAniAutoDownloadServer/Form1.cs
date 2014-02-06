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
        private List<AniName> Ani;

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
            AniName AniTemp;
            AniTemp.name = tb_AniString.Text;
            list_AniString.Items.Add(tb_AniString.Text);
        }

        private void bt_AniDelete_Click(object sender, EventArgs e)
        {
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
            Thread AutoRefresh = new Thread(new ThreadStart(Refresh));

            bt_Start.Enabled = false;
            bt_Stop.Enabled = true;
            bt_Refresh.Enabled = false;

            ThreadStopCheck = true;
            AutoRefresh.Start();
        }

        private void Refresh()
        {
            while(ThreadStopCheck)
            {
                RssReader rss = new RssReader();
                rss.FeedUrl = "https://www.tokyotosho.info/rss.php?filter=1,10,8,7";
                foreach(RssItem item in rss.Execute())
                {
                    foreach(string temp in list_AniString.Items)
                    {
                        if(item.Title.Contains("1280x720") || item.Title.Contains("1920x1080"))
                        {
                            item.Title.Replace("1280x720", "");
                            item.Title.Replace("1920x1080", "");
                            if(item.Title.Contains(temp))
                            {

                            }
                        }
                    }
                }
                Thread.Sleep(60000);
            }
            bt_Refresh.Enabled = true;
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            bt_Start.Enabled = true;
            bt_Stop.Enabled = false;
            
            ThreadStopCheck = false;
        }

    }
}
