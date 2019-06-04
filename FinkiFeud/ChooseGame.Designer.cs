namespace FinkiFeud
{
    partial class ChooseGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGame));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.tbTeam1Player1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbTeam1Player1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighscores = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.loadPreviousGame = new System.Windows.Forms.Button();
            this.rbWindowed = new System.Windows.Forms.RadioButton();
            this.ebFullScreen = new System.Windows.Forms.RadioButton();
            this.gbScreenSettings = new System.Windows.Forms.GroupBox();
            this.cbSounds = new System.Windows.Forms.CheckBox();
            this.cbBackgroundMusic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1Player1)).BeginInit();
            this.gbScreenSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(9, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Easy";
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Location = new System.Drawing.Point(7, 207);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lbDifficulty.TabIndex = 1;
            this.lbDifficulty.Text = "Difficulty:";
            // 
            // tbTeam1Player1
            // 
            this.tbTeam1Player1.Location = new System.Drawing.Point(9, 184);
            this.tbTeam1Player1.Name = "tbTeam1Player1";
            this.tbTeam1Player1.Size = new System.Drawing.Size(110, 20);
            this.tbTeam1Player1.TabIndex = 2;
            this.tbTeam1Player1.Text = "Unknown";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbTeam1Player1);
            this.groupBox1.Controls.Add(this.pbTeam1Player1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbDifficulty);
            this.groupBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Location = new System.Drawing.Point(5, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 261);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Player Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 9);
            this.label11.TabIndex = 24;
            this.label11.Text = "220x250";
            // 
            // pbTeam1Player1
            // 
            this.pbTeam1Player1.BackColor = System.Drawing.Color.Transparent;
            this.pbTeam1Player1.BackgroundImage = global::FinkiFeud.Properties.Resources.Default;
            this.pbTeam1Player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTeam1Player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeam1Player1.InitialImage = global::FinkiFeud.Properties.Resources.avatar_generic;
            this.pbTeam1Player1.Location = new System.Drawing.Point(9, 19);
            this.pbTeam1Player1.Name = "pbTeam1Player1";
            this.pbTeam1Player1.Size = new System.Drawing.Size(110, 125);
            this.pbTeam1Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeam1Player1.TabIndex = 2;
            this.pbTeam1Player1.TabStop = false;
            this.pbTeam1Player1.Click += new System.EventHandler(this.pbTeam1Player1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.BackgroundImage = global::FinkiFeud.Properties.Resources._160205104032_key_race_alert_background_full_169;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnStart.Location = new System.Drawing.Point(154, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(288, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighscores
            // 
            this.btnHighscores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHighscores.BackgroundImage")));
            this.btnHighscores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHighscores.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btnHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscores.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnHighscores.Location = new System.Drawing.Point(154, 187);
            this.btnHighscores.Name = "btnHighscores";
            this.btnHighscores.Size = new System.Drawing.Size(288, 23);
            this.btnHighscores.TabIndex = 24;
            this.btnHighscores.Text = "View Highscores";
            this.btnHighscores.UseVisualStyleBackColor = true;
            this.btnHighscores.Click += new System.EventHandler(this.btnHighscores_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddQuestion.BackgroundImage")));
            this.btnAddQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQuestion.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddQuestion.Location = new System.Drawing.Point(154, 216);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(288, 23);
            this.btnAddQuestion.TabIndex = 25;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // loadPreviousGame
            // 
            this.loadPreviousGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loadPreviousGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadPreviousGame.BackgroundImage")));
            this.loadPreviousGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadPreviousGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.loadPreviousGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPreviousGame.ForeColor = System.Drawing.Color.FloralWhite;
            this.loadPreviousGame.Location = new System.Drawing.Point(154, 245);
            this.loadPreviousGame.Name = "loadPreviousGame";
            this.loadPreviousGame.Size = new System.Drawing.Size(288, 23);
            this.loadPreviousGame.TabIndex = 26;
            this.loadPreviousGame.Text = "Load Previous Game";
            this.loadPreviousGame.UseVisualStyleBackColor = false;
            this.loadPreviousGame.Click += new System.EventHandler(this.loadPreviousGame_Click);
            // 
            // rbWindowed
            // 
            this.rbWindowed.AutoSize = true;
            this.rbWindowed.Checked = true;
            this.rbWindowed.Location = new System.Drawing.Point(6, 19);
            this.rbWindowed.Name = "rbWindowed";
            this.rbWindowed.Size = new System.Drawing.Size(94, 17);
            this.rbWindowed.TabIndex = 28;
            this.rbWindowed.TabStop = true;
            this.rbWindowed.Text = "Window Mode";
            this.rbWindowed.UseVisualStyleBackColor = true;
            // 
            // ebFullScreen
            // 
            this.ebFullScreen.AutoSize = true;
            this.ebFullScreen.Location = new System.Drawing.Point(6, 42);
            this.ebFullScreen.Name = "ebFullScreen";
            this.ebFullScreen.Size = new System.Drawing.Size(108, 17);
            this.ebFullScreen.TabIndex = 29;
            this.ebFullScreen.Text = "Full Screen Mode";
            this.ebFullScreen.UseVisualStyleBackColor = true;
            // 
            // gbScreenSettings
            // 
            this.gbScreenSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbScreenSettings.Controls.Add(this.cbSounds);
            this.gbScreenSettings.Controls.Add(this.cbBackgroundMusic);
            this.gbScreenSettings.Controls.Add(this.ebFullScreen);
            this.gbScreenSettings.Controls.Add(this.rbWindowed);
            this.gbScreenSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.gbScreenSettings.Location = new System.Drawing.Point(154, 13);
            this.gbScreenSettings.Name = "gbScreenSettings";
            this.gbScreenSettings.Size = new System.Drawing.Size(123, 139);
            this.gbScreenSettings.TabIndex = 30;
            this.gbScreenSettings.TabStop = false;
            this.gbScreenSettings.Text = "Screen Settings";
            // 
            // cbSounds
            // 
            this.cbSounds.AutoSize = true;
            this.cbSounds.Location = new System.Drawing.Point(6, 116);
            this.cbSounds.Name = "cbSounds";
            this.cbSounds.Size = new System.Drawing.Size(62, 17);
            this.cbSounds.TabIndex = 31;
            this.cbSounds.Text = "Sounds";
            this.cbSounds.UseVisualStyleBackColor = true;
            // 
            // cbBackgroundMusic
            // 
            this.cbBackgroundMusic.AutoSize = true;
            this.cbBackgroundMusic.Location = new System.Drawing.Point(6, 93);
            this.cbBackgroundMusic.Name = "cbBackgroundMusic";
            this.cbBackgroundMusic.Size = new System.Drawing.Size(101, 17);
            this.cbBackgroundMusic.TabIndex = 30;
            this.cbBackgroundMusic.Text = "Start with Music";
            this.cbBackgroundMusic.UseVisualStyleBackColor = true;
            // 
            // ChooseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiFeud.Properties.Resources._160205104032_key_race_alert_background_full_169;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 283);
            this.Controls.Add(this.gbScreenSettings);
            this.Controls.Add(this.loadPreviousGame);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnHighscores);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your game settings";
            this.Load += new System.EventHandler(this.ChooseGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1Player1)).EndInit();
            this.gbScreenSettings.ResumeLayout(false);
            this.gbScreenSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.TextBox tbTeam1Player1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbTeam1Player1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHighscores;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button loadPreviousGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWindowed;
        private System.Windows.Forms.RadioButton ebFullScreen;
        private System.Windows.Forms.GroupBox gbScreenSettings;
        private System.Windows.Forms.CheckBox cbBackgroundMusic;
        private System.Windows.Forms.CheckBox cbSounds;
    }
}