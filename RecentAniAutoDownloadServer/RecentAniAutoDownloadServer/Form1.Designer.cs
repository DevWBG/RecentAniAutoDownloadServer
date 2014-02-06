namespace RecentAniAutoDownloadServer
{
    partial class fm_main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ChangeTeam = new System.Windows.Forms.Button();
            this.bt_SettingTeam = new System.Windows.Forms.Button();
            this.tb_Team = new System.Windows.Forms.TextBox();
            this.bt_AniDelete = new System.Windows.Forms.Button();
            this.bt_AniInput = new System.Windows.Forms.Button();
            this.tb_AniString = new System.Windows.Forms.TextBox();
            this.bt_twiddelete = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.tb_IDString = new System.Windows.Forms.TextBox();
            this.bt_twidinput = new System.Windows.Forms.Button();
            this.list_TweetUser = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_AniString = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_ChangeTeam);
            this.groupBox1.Controls.Add(this.bt_SettingTeam);
            this.groupBox1.Controls.Add(this.tb_Team);
            this.groupBox1.Controls.Add(this.bt_AniDelete);
            this.groupBox1.Controls.Add(this.bt_AniInput);
            this.groupBox1.Controls.Add(this.tb_AniString);
            this.groupBox1.Controls.Add(this.bt_twiddelete);
            this.groupBox1.Controls.Add(this.bt_Refresh);
            this.groupBox1.Controls.Add(this.bt_Stop);
            this.groupBox1.Controls.Add(this.bt_Start);
            this.groupBox1.Controls.Add(this.tb_IDString);
            this.groupBox1.Controls.Add(this.bt_twidinput);
            this.groupBox1.Controls.Add(this.list_TweetUser);
            this.groupBox1.Location = new System.Drawing.Point(348, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // bt_ChangeTeam
            // 
            this.bt_ChangeTeam.Location = new System.Drawing.Point(129, 381);
            this.bt_ChangeTeam.Name = "bt_ChangeTeam";
            this.bt_ChangeTeam.Size = new System.Drawing.Size(114, 23);
            this.bt_ChangeTeam.TabIndex = 12;
            this.bt_ChangeTeam.Text = "Change Team";
            this.bt_ChangeTeam.UseVisualStyleBackColor = true;
            this.bt_ChangeTeam.Click += new System.EventHandler(this.bt_ChangeTeam_Click);
            // 
            // bt_SettingTeam
            // 
            this.bt_SettingTeam.Location = new System.Drawing.Point(6, 381);
            this.bt_SettingTeam.Name = "bt_SettingTeam";
            this.bt_SettingTeam.Size = new System.Drawing.Size(116, 23);
            this.bt_SettingTeam.TabIndex = 11;
            this.bt_SettingTeam.Text = "Setting Team";
            this.bt_SettingTeam.UseVisualStyleBackColor = true;
            this.bt_SettingTeam.Click += new System.EventHandler(this.bt_SettingTeam_Click);
            // 
            // tb_Team
            // 
            this.tb_Team.Location = new System.Drawing.Point(6, 353);
            this.tb_Team.Name = "tb_Team";
            this.tb_Team.Size = new System.Drawing.Size(237, 21);
            this.tb_Team.TabIndex = 10;
            // 
            // bt_AniDelete
            // 
            this.bt_AniDelete.Location = new System.Drawing.Point(131, 325);
            this.bt_AniDelete.Name = "bt_AniDelete";
            this.bt_AniDelete.Size = new System.Drawing.Size(114, 23);
            this.bt_AniDelete.TabIndex = 9;
            this.bt_AniDelete.Text = "Ani Delete";
            this.bt_AniDelete.UseVisualStyleBackColor = true;
            this.bt_AniDelete.Click += new System.EventHandler(this.bt_AniDelete_Click);
            // 
            // bt_AniInput
            // 
            this.bt_AniInput.Location = new System.Drawing.Point(8, 324);
            this.bt_AniInput.Name = "bt_AniInput";
            this.bt_AniInput.Size = new System.Drawing.Size(116, 23);
            this.bt_AniInput.TabIndex = 8;
            this.bt_AniInput.Text = "Ani Input";
            this.bt_AniInput.UseVisualStyleBackColor = true;
            this.bt_AniInput.Click += new System.EventHandler(this.bt_AniInput_Click);
            // 
            // tb_AniString
            // 
            this.tb_AniString.Location = new System.Drawing.Point(8, 258);
            this.tb_AniString.Name = "tb_AniString";
            this.tb_AniString.Size = new System.Drawing.Size(237, 21);
            this.tb_AniString.TabIndex = 7;
            // 
            // bt_twiddelete
            // 
            this.bt_twiddelete.Location = new System.Drawing.Point(130, 214);
            this.bt_twiddelete.Name = "bt_twiddelete";
            this.bt_twiddelete.Size = new System.Drawing.Size(114, 23);
            this.bt_twiddelete.TabIndex = 6;
            this.bt_twiddelete.Text = "UserID Delete";
            this.bt_twiddelete.UseVisualStyleBackColor = true;
            this.bt_twiddelete.Click += new System.EventHandler(this.bt_twiddelete_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.Location = new System.Drawing.Point(169, 409);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(75, 23);
            this.bt_Refresh.TabIndex = 5;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = true;
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(87, 410);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(75, 23);
            this.bt_Stop.TabIndex = 4;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(6, 409);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 3;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // tb_IDString
            // 
            this.tb_IDString.Location = new System.Drawing.Point(7, 188);
            this.tb_IDString.Name = "tb_IDString";
            this.tb_IDString.Size = new System.Drawing.Size(237, 21);
            this.tb_IDString.TabIndex = 2;
            // 
            // bt_twidinput
            // 
            this.bt_twidinput.Location = new System.Drawing.Point(7, 215);
            this.bt_twidinput.Name = "bt_twidinput";
            this.bt_twidinput.Size = new System.Drawing.Size(116, 23);
            this.bt_twidinput.TabIndex = 1;
            this.bt_twidinput.Text = "UserID input";
            this.bt_twidinput.UseVisualStyleBackColor = true;
            this.bt_twidinput.Click += new System.EventHandler(this.bt_twidinput_Click);
            // 
            // list_TweetUser
            // 
            this.list_TweetUser.FormattingEnabled = true;
            this.list_TweetUser.ItemHeight = 12;
            this.list_TweetUser.Location = new System.Drawing.Point(7, 21);
            this.list_TweetUser.Name = "list_TweetUser";
            this.list_TweetUser.Size = new System.Drawing.Size(237, 160);
            this.list_TweetUser.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_AniString);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serch List";
            // 
            // list_AniString
            // 
            this.list_AniString.FormattingEnabled = true;
            this.list_AniString.ItemHeight = 12;
            this.list_AniString.Location = new System.Drawing.Point(7, 20);
            this.list_AniString.Name = "list_AniString";
            this.list_AniString.Size = new System.Drawing.Size(316, 412);
            this.list_AniString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start Ep";
            // 
            // fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fm_main";
            this.Text = "Recent Ani Auto Download";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_AniDelete;
        private System.Windows.Forms.Button bt_AniInput;
        private System.Windows.Forms.TextBox tb_AniString;
        private System.Windows.Forms.Button bt_twiddelete;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.TextBox tb_IDString;
        private System.Windows.Forms.Button bt_twidinput;
        private System.Windows.Forms.ListBox list_TweetUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_AniString;
        private System.Windows.Forms.Button bt_ChangeTeam;
        private System.Windows.Forms.Button bt_SettingTeam;
        private System.Windows.Forms.TextBox tb_Team;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

