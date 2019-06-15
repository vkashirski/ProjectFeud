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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGame));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDimensionsForImage = new System.Windows.Forms.Label();
            this.pPlayerImage = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighscores = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.rbWindowed = new System.Windows.Forms.RadioButton();
            this.ebFullScreen = new System.Windows.Forms.RadioButton();
            this.gbScreenSettings = new System.Windows.Forms.GroupBox();
            this.cbSounds = new System.Windows.Forms.CheckBox();
            this.cbBackgroundMusic = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayerImage)).BeginInit();
            this.gbScreenSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.comboBox1, "Difficulty will change the time you have to answer the questions. \r\nEasy:        " +
        "  40 seconds\r\nMedium:   30 seconds\r\nHard:         20 seconds");
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Location = new System.Drawing.Point(7, 207);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lbDifficulty.TabIndex = 1;
            this.lbDifficulty.Text = "Difficulty:";
            this.toolTip1.SetToolTip(this.lbDifficulty, "Difficulty will change the time you have to answer the questions. ");
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(9, 184);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(110, 20);
            this.tbPlayerName.TabIndex = 2;
            this.tbPlayerName.Text = "Unknown";
            this.toolTip1.SetToolTip(this.tbPlayerName, "If you leave this empty your name will be by default Unknown.");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbDimensionsForImage);
            this.groupBox1.Controls.Add(this.tbPlayerName);
            this.groupBox1.Controls.Add(this.pPlayerImage);
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
            // lbDimensionsForImage
            // 
            this.lbDimensionsForImage.AutoSize = true;
            this.lbDimensionsForImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDimensionsForImage.Location = new System.Drawing.Point(43, 147);
            this.lbDimensionsForImage.Name = "lbDimensionsForImage";
            this.lbDimensionsForImage.Size = new System.Drawing.Size(33, 9);
            this.lbDimensionsForImage.TabIndex = 24;
            this.lbDimensionsForImage.Text = "220x250";
            this.toolTip1.SetToolTip(this.lbDimensionsForImage, "Size for best resolution of the image.");
            // 
            // pPlayerImage
            // 
            this.pPlayerImage.BackColor = System.Drawing.Color.Transparent;
            this.pPlayerImage.BackgroundImage = global::FinkiFeud.Properties.Resources.Default;
            this.pPlayerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPlayerImage.InitialImage = global::FinkiFeud.Properties.Resources.avatar_generic;
            this.pPlayerImage.Location = new System.Drawing.Point(9, 19);
            this.pPlayerImage.Name = "pPlayerImage";
            this.pPlayerImage.Size = new System.Drawing.Size(110, 125);
            this.pPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPlayerImage.TabIndex = 2;
            this.pPlayerImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pPlayerImage, "If you don\'t place an image there is a default one that will be placed instead.");
            this.pPlayerImage.Click += new System.EventHandler(this.pbTeam1Player1_Click);
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
            this.btnStart.Location = new System.Drawing.Point(154, 190);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(288, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start Game";
            this.toolTip1.SetToolTip(this.btnStart, resources.GetString("btnStart.ToolTip"));
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighscores
            // 
            this.btnHighscores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHighscores.BackgroundImage")));
            this.btnHighscores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHighscores.CausesValidation = false;
            this.btnHighscores.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btnHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscores.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnHighscores.Location = new System.Drawing.Point(154, 219);
            this.btnHighscores.Name = "btnHighscores";
            this.btnHighscores.Size = new System.Drawing.Size(288, 23);
            this.btnHighscores.TabIndex = 24;
            this.btnHighscores.Text = "View Top Highscores";
            this.btnHighscores.UseVisualStyleBackColor = true;
            this.btnHighscores.Click += new System.EventHandler(this.btnHighscores_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddQuestion.BackgroundImage")));
            this.btnAddQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQuestion.CausesValidation = false;
            this.btnAddQuestion.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddQuestion.Location = new System.Drawing.Point(154, 248);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(288, 23);
            this.btnAddQuestion.TabIndex = 25;
            this.btnAddQuestion.Text = "Add Question";
            this.toolTip1.SetToolTip(this.btnAddQuestion, "Add additional questions to your game. ");
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // rbWindowed
            // 
            this.rbWindowed.AutoSize = true;
            this.rbWindowed.Checked = true;
            this.rbWindowed.Location = new System.Drawing.Point(6, 28);
            this.rbWindowed.Name = "rbWindowed";
            this.rbWindowed.Size = new System.Drawing.Size(94, 17);
            this.rbWindowed.TabIndex = 28;
            this.rbWindowed.TabStop = true;
            this.rbWindowed.Text = "Window Mode";
            this.toolTip1.SetToolTip(this.rbWindowed, "You will start the game in window.");
            this.rbWindowed.UseVisualStyleBackColor = true;
            // 
            // ebFullScreen
            // 
            this.ebFullScreen.AutoSize = true;
            this.ebFullScreen.Location = new System.Drawing.Point(6, 51);
            this.ebFullScreen.Name = "ebFullScreen";
            this.ebFullScreen.Size = new System.Drawing.Size(108, 17);
            this.ebFullScreen.TabIndex = 29;
            this.ebFullScreen.Text = "Full Screen Mode";
            this.toolTip1.SetToolTip(this.ebFullScreen, "You will start the game in Full Screen.");
            this.ebFullScreen.UseVisualStyleBackColor = true;
            // 
            // gbScreenSettings
            // 
            this.gbScreenSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbScreenSettings.Controls.Add(this.ebFullScreen);
            this.gbScreenSettings.Controls.Add(this.rbWindowed);
            this.gbScreenSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.gbScreenSettings.Location = new System.Drawing.Point(154, 13);
            this.gbScreenSettings.Name = "gbScreenSettings";
            this.gbScreenSettings.Size = new System.Drawing.Size(288, 92);
            this.gbScreenSettings.TabIndex = 30;
            this.gbScreenSettings.TabStop = false;
            this.gbScreenSettings.Text = "Screen Settings";
            // 
            // cbSounds
            // 
            this.cbSounds.AutoSize = true;
            this.cbSounds.Location = new System.Drawing.Point(6, 46);
            this.cbSounds.Name = "cbSounds";
            this.cbSounds.Size = new System.Drawing.Size(62, 17);
            this.cbSounds.TabIndex = 31;
            this.cbSounds.Text = "Sounds";
            this.toolTip1.SetToolTip(this.cbSounds, "Every time you enter a correct answer, incorrect answer or the same answer a soun" +
        "d will play accordingly.");
            this.cbSounds.UseVisualStyleBackColor = true;
            // 
            // cbBackgroundMusic
            // 
            this.cbBackgroundMusic.AutoSize = true;
            this.cbBackgroundMusic.Location = new System.Drawing.Point(6, 23);
            this.cbBackgroundMusic.Name = "cbBackgroundMusic";
            this.cbBackgroundMusic.Size = new System.Drawing.Size(101, 17);
            this.cbBackgroundMusic.TabIndex = 30;
            this.cbBackgroundMusic.Text = "Start with Music";
            this.toolTip1.SetToolTip(this.cbBackgroundMusic, "Your game will begin with a song playing in the background until you start answer" +
        "ing the questions.");
            this.cbBackgroundMusic.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbSounds);
            this.groupBox2.Controls.Add(this.cbBackgroundMusic);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(154, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 73);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sound Settings";
            // 
            // ChooseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiFeud.Properties.Resources._160205104032_key_race_alert_background_full_169;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 283);
            this.Controls.Add(this.gbScreenSettings);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnHighscores);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChooseGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your game settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayerImage)).EndInit();
            this.gbScreenSettings.ResumeLayout(false);
            this.gbScreenSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pPlayerImage;
        private System.Windows.Forms.Label lbDimensionsForImage;
        private System.Windows.Forms.Button btnHighscores;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWindowed;
        private System.Windows.Forms.RadioButton ebFullScreen;
        private System.Windows.Forms.GroupBox gbScreenSettings;
        private System.Windows.Forms.CheckBox cbBackgroundMusic;
        private System.Windows.Forms.CheckBox cbSounds;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}