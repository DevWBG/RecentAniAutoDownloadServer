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
    public partial class fm_main : Form
    {

        private bool ThreadStopCheck = false;

        public fm_main()
        {
            InitializeComponent();
            bt_ChangeTeam.Enabled = false;
            bt_Stop.Enabled = false;
        }

        private void bt_AniInput_Click(object sender, EventArgs e)
        {
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
                RssReader Reader = RssReader.CreateAndCache("https://www.tokyotosho.info/rss.php?filter=1,10,8,7", new TimeSpan(2, 0, 0));
                string sPattern = null;
                foreach(RssItem item in Reader.Items)
                {
                    //Input item string in sPattern with regex
                    //Add Team Name
                    foreach(string temp in list_AniString.Items)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(temp, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {

                        }
                    }
                }
            }
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            bt_Start.Enabled = true;
            bt_Stop.Enabled = false;
            bt_Refresh.Enabled = true;

            ThreadStopCheck = false;
        }

    }
}
