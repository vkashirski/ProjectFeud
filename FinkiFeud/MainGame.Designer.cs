using System;
using System.Windows.Forms;

namespace FinkiFeud
{
    [Serializable]
    partial class MainGame
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

        protected override void OnResize(EventArgs e)
        {
            this.Visible = false;
            base.OnResize(e);
            this.Visible = true;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.questionTime = new System.Windows.Forms.Label();
            this.lbPoints = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer5 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer6 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer7 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.answer8 = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Game_Title = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPlayerIcon = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.Button();
            this.tbPlayerName = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // questionTime
            // 
            this.questionTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionTime.BackColor = System.Drawing.Color.Transparent;
            this.questionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTime.ForeColor = System.Drawing.SystemColors.Control;
            this.questionTime.Location = new System.Drawing.Point(580, 141);
            this.questionTime.Name = "questionTime";
            this.questionTime.Size = new System.Drawing.Size(127, 91);
            this.questionTime.TabIndex = 0;
            this.questionTime.Text = "40";
            this.questionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPoints
            // 
            this.lbPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPoints.BackColor = System.Drawing.Color.Transparent;
            this.lbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoints.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbPoints.Location = new System.Drawing.Point(35, 339);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(220, 85);
            this.lbPoints.TabIndex = 20;
            this.lbPoints.Text = "0";
            this.lbPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer1
            // 
            this.answer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer1.BackgroundImage")));
            this.answer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer1.CausesValidation = false;
            this.answer1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer1.Image = ((System.Drawing.Image)(resources.GetObject("answer1.Image")));
            this.answer1.Location = new System.Drawing.Point(293, 430);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(356, 58);
            this.answer1.TabIndex = 0;
            this.answer1.UseVisualStyleBackColor = false;
            // 
            // answer5
            // 
            this.answer5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer5.BackgroundImage")));
            this.answer5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer5.CausesValidation = false;
            this.answer5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer5.Image = ((System.Drawing.Image)(resources.GetObject("answer5.Image")));
            this.answer5.Location = new System.Drawing.Point(655, 430);
            this.answer5.Name = "answer5";
            this.answer5.Size = new System.Drawing.Size(355, 58);
            this.answer5.TabIndex = 1;
            this.answer5.UseVisualStyleBackColor = false;
            // 
            // answer2
            // 
            this.answer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer2.BackgroundImage")));
            this.answer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer2.CausesValidation = false;
            this.answer2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer2.Image = ((System.Drawing.Image)(resources.GetObject("answer2.Image")));
            this.answer2.Location = new System.Drawing.Point(293, 494);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(356, 58);
            this.answer2.TabIndex = 2;
            this.answer2.UseVisualStyleBackColor = false;
            // 
            // answer6
            // 
            this.answer6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer6.BackgroundImage")));
            this.answer6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer6.CausesValidation = false;
            this.answer6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer6.Image = ((System.Drawing.Image)(resources.GetObject("answer6.Image")));
            this.answer6.Location = new System.Drawing.Point(655, 494);
            this.answer6.Name = "answer6";
            this.answer6.Size = new System.Drawing.Size(355, 58);
            this.answer6.TabIndex = 5;
            this.answer6.UseVisualStyleBackColor = false;
            // 
            // answer3
            // 
            this.answer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer3.BackgroundImage")));
            this.answer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer3.CausesValidation = false;
            this.answer3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer3.Image = ((System.Drawing.Image)(resources.GetObject("answer3.Image")));
            this.answer3.Location = new System.Drawing.Point(293, 558);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(356, 58);
            this.answer3.TabIndex = 6;
            this.answer3.UseVisualStyleBackColor = false;
            // 
            // answer7
            // 
            this.answer7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer7.BackgroundImage")));
            this.answer7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer7.CausesValidation = false;
            this.answer7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer7.Image = ((System.Drawing.Image)(resources.GetObject("answer7.Image")));
            this.answer7.Location = new System.Drawing.Point(655, 558);
            this.answer7.Name = "answer7";
            this.answer7.Size = new System.Drawing.Size(355, 58);
            this.answer7.TabIndex = 7;
            this.answer7.UseVisualStyleBackColor = false;
            // 
            // answer4
            // 
            this.answer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer4.BackgroundImage")));
            this.answer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer4.CausesValidation = false;
            this.answer4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer4.Image = ((System.Drawing.Image)(resources.GetObject("answer4.Image")));
            this.answer4.Location = new System.Drawing.Point(293, 624);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(356, 58);
            this.answer4.TabIndex = 9;
            this.answer4.UseVisualStyleBackColor = false;
            // 
            // answer8
            // 
            this.answer8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answer8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer8.BackgroundImage")));
            this.answer8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer8.CausesValidation = false;
            this.answer8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answer8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer8.Image = ((System.Drawing.Image)(resources.GetObject("answer8.Image")));
            this.answer8.Location = new System.Drawing.Point(655, 624);
            this.answer8.Name = "answer8";
            this.answer8.Size = new System.Drawing.Size(355, 58);
            this.answer8.TabIndex = 10;
            this.answer8.UseVisualStyleBackColor = false;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(293, 688);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(532, 60);
            this.tbAnswer.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.BackgroundImage = global::FinkiFeud.Properties.Resources.Green_button;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Kristen ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSubmit.Location = new System.Drawing.Point(831, 688);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 60);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "TRY";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Game_Title
            // 
            this.Game_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Game_Title.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Game_Title.BackColor = System.Drawing.Color.Transparent;
            this.Game_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Game_Title.FlatAppearance.BorderSize = 0;
            this.Game_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Game_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Game_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Game_Title.Image = global::FinkiFeud.Properties.Resources.FinkiFeud;
            this.Game_Title.Location = new System.Drawing.Point(12, 12);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(1260, 126);
            this.Game_Title.TabIndex = 26;
            this.Game_Title.TabStop = false;
            this.Game_Title.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbPlayerIcon
            // 
            this.pbPlayerIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPlayerIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayerIcon.Image = global::FinkiFeud.Properties.Resources.avatar_generic;
            this.pbPlayerIcon.Location = new System.Drawing.Point(35, 430);
            this.pbPlayerIcon.Name = "pbPlayerIcon";
            this.pbPlayerIcon.Size = new System.Drawing.Size(220, 250);
            this.pbPlayerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerIcon.TabIndex = 2;
            this.pbPlayerIcon.TabStop = false;
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSkip.BackColor = System.Drawing.Color.DarkGray;
            this.btnSkip.BackgroundImage = global::FinkiFeud.Properties.Resources._160205104032_key_race_alert_background_full_169;
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSkip.Location = new System.Drawing.Point(1079, 296);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(170, 83);
            this.btnSkip.TabIndex = 13;
            this.btnSkip.Text = "SKIP QUESTION";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.BackColor = System.Drawing.Color.Red;
            this.btnFinish.BackgroundImage = global::FinkiFeud.Properties.Resources._160205104032_key_race_alert_background_full_1691;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFinish.Location = new System.Drawing.Point(1079, 688);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(170, 60);
            this.btnFinish.TabIndex = 29;
            this.btnFinish.Text = "FINISH";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQuestion.BackgroundImage = global::FinkiFeud.Properties.Resources._160205104032_key_race_alert_background_full_169;
            this.tbQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbQuestion.Font = new System.Drawing.Font("Kristen ITC", 18F);
            this.tbQuestion.ForeColor = System.Drawing.Color.DarkOrange;
            this.tbQuestion.Location = new System.Drawing.Point(293, 248);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(717, 176);
            this.tbQuestion.TabIndex = 32;
            this.tbQuestion.Text = "We asked the students of Finki, how much time did you spend in college and they a" +
    "nswered: ";
            this.tbQuestion.UseVisualStyleBackColor = false;
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.tbPlayerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPlayerName.FlatAppearance.BorderSize = 0;
            this.tbPlayerName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tbPlayerName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tbPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayerName.ForeColor = System.Drawing.Color.DarkOrange;
            this.tbPlayerName.Location = new System.Drawing.Point(6, 686);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(281, 62);
            this.tbPlayerName.TabIndex = 33;
            this.tbPlayerName.Text = "PlayerName";
            this.tbPlayerName.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPause.Location = new System.Drawing.Point(1100, 538);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(123, 38);
            this.btnPause.TabIndex = 34;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // MainGame
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.answer8);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.answer7);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.answer5);
            this.Controls.Add(this.answer6);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.Game_Title);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.pbPlayerIcon);
            this.Controls.Add(this.questionTime);
            this.Controls.Add(this.btnSkip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinkiFued";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTime;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Button answer5;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer7;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer8;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button Game_Title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPlayerIcon;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button tbQuestion;
        private System.Windows.Forms.Button tbPlayerName;
        private Button btnPause;
    }
}