namespace FinkiFeud
{
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Game_Title = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPlayerIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerIcon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTime
            // 
            this.questionTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionTime.AutoSize = true;
            this.questionTime.BackColor = System.Drawing.Color.Transparent;
            this.questionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTime.ForeColor = System.Drawing.SystemColors.Control;
            this.questionTime.Location = new System.Drawing.Point(605, 141);
            this.questionTime.Name = "questionTime";
            this.questionTime.Size = new System.Drawing.Size(127, 91);
            this.questionTime.TabIndex = 0;
            this.questionTime.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(126, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 85);
            this.label2.TabIndex = 20;
            this.label2.Text = "0";
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer1.CausesValidation = false;
            this.answer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer1.Image = global::FinkiFeud.Properties.Resources.QuestionMark;
            this.answer1.Location = new System.Drawing.Point(3, 3);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(353, 67);
            this.answer1.TabIndex = 0;
            this.answer1.UseVisualStyleBackColor = false;
            // 
            // answer5
            // 
            this.answer5.AutoSize = true;
            this.answer5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer5.CausesValidation = false;
            this.answer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer5.Image = ((System.Drawing.Image)(resources.GetObject("answer5.Image")));
            this.answer5.Location = new System.Drawing.Point(362, 3);
            this.answer5.Name = "answer5";
            this.answer5.Size = new System.Drawing.Size(353, 67);
            this.answer5.TabIndex = 1;
            this.answer5.UseVisualStyleBackColor = false;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer2.CausesValidation = false;
            this.answer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer2.Image = ((System.Drawing.Image)(resources.GetObject("answer2.Image")));
            this.answer2.Location = new System.Drawing.Point(3, 76);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(353, 67);
            this.answer2.TabIndex = 2;
            this.answer2.UseVisualStyleBackColor = false;
            // 
            // answer6
            // 
            this.answer6.AutoSize = true;
            this.answer6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer6.CausesValidation = false;
            this.answer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer6.Image = ((System.Drawing.Image)(resources.GetObject("answer6.Image")));
            this.answer6.Location = new System.Drawing.Point(362, 76);
            this.answer6.Name = "answer6";
            this.answer6.Size = new System.Drawing.Size(353, 67);
            this.answer6.TabIndex = 5;
            this.answer6.UseVisualStyleBackColor = false;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer3.CausesValidation = false;
            this.answer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer3.Image = ((System.Drawing.Image)(resources.GetObject("answer3.Image")));
            this.answer3.Location = new System.Drawing.Point(3, 149);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(353, 67);
            this.answer3.TabIndex = 6;
            this.answer3.UseVisualStyleBackColor = false;
            // 
            // answer7
            // 
            this.answer7.AutoSize = true;
            this.answer7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer7.CausesValidation = false;
            this.answer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer7.Image = ((System.Drawing.Image)(resources.GetObject("answer7.Image")));
            this.answer7.Location = new System.Drawing.Point(362, 149);
            this.answer7.Name = "answer7";
            this.answer7.Size = new System.Drawing.Size(353, 67);
            this.answer7.TabIndex = 7;
            this.answer7.UseVisualStyleBackColor = false;
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer4.CausesValidation = false;
            this.answer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer4.Image = ((System.Drawing.Image)(resources.GetObject("answer4.Image")));
            this.answer4.Location = new System.Drawing.Point(3, 222);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(353, 67);
            this.answer4.TabIndex = 9;
            this.answer4.UseVisualStyleBackColor = false;
            // 
            // answer8
            // 
            this.answer8.AutoSize = true;
            this.answer8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.answer8.CausesValidation = false;
            this.answer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answer8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answer8.Image = ((System.Drawing.Image)(resources.GetObject("answer8.Image")));
            this.answer8.Location = new System.Drawing.Point(362, 222);
            this.answer8.Name = "answer8";
            this.answer8.Size = new System.Drawing.Size(353, 67);
            this.answer8.TabIndex = 10;
            this.answer8.UseVisualStyleBackColor = false;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(311, 697);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(530, 60);
            this.tbAnswer.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(847, 697);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 60);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "TRY";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox2.Location = new System.Drawing.Point(56, 689);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 68);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "PLAYER NAME";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Game_Title
            // 
            this.Game_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Game_Title.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Game_Title.BackColor = System.Drawing.Color.Transparent;
            this.Game_Title.BackgroundImage = global::FinkiFeud.Properties.Resources.FinkiFeud;
            this.Game_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Game_Title.FlatAppearance.BorderSize = 0;
            this.Game_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Game_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Game_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Game_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Game_Title.Location = new System.Drawing.Point(416, 12);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(491, 126);
            this.Game_Title.TabIndex = 26;
            this.Game_Title.TabStop = false;
            this.Game_Title.UseVisualStyleBackColor = false;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuestion.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbQuestion.Font = new System.Drawing.Font("Kristen ITC", 20F);
            this.tbQuestion.ForeColor = System.Drawing.Color.DarkOrange;
            this.tbQuestion.Location = new System.Drawing.Point(308, 266);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(718, 118);
            this.tbQuestion.TabIndex = 27;
            this.tbQuestion.Text = "We asked the students of Finki, how much time did you spend in college and they a" +
    "nswered: ";
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pbPlayerIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPlayerIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayerIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerIcon.Image")));
            this.pbPlayerIcon.Location = new System.Drawing.Point(56, 432);
            this.pbPlayerIcon.Name = "pbPlayerIcon";
            this.pbPlayerIcon.Size = new System.Drawing.Size(220, 250);
            this.pbPlayerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerIcon.TabIndex = 2;
            this.pbPlayerIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1062, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 118);
            this.button1.TabIndex = 13;
            this.button1.Text = "SKIP QUESTION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1062, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 60);
            this.button2.TabIndex = 29;
            this.button2.Text = "FINISH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackgroundImage = global::FinkiFeud.Properties.Resources._20190306_FamilyFeudLive_1929x1327_BACKGROUND_0;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.answer8, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.answer1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.answer4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.answer2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.answer7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.answer3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.answer5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.answer6, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(308, 390);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(718, 292);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // MainGame
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 779);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.Game_Title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPlayerIcon);
            this.Controls.Add(this.questionTime);
            this.Controls.Add(this.button1);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerIcon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button answer5;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer7;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer8;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Game_Title;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPlayerIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}