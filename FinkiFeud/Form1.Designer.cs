namespace FinkiFeud
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Game_Title = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Navy;
            this.btnStart.Location = new System.Drawing.Point(304, 190);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(207, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "NEW GAME";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(304, 251);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 54);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Game_Title
            // 
            this.Game_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Game_Title.BackColor = System.Drawing.Color.Transparent;
            this.Game_Title.BackgroundImage = global::FinkiFeud.Properties.Resources.FinkiFeud;
            this.Game_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Game_Title.FlatAppearance.BorderSize = 0;
            this.Game_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Game_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Game_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Game_Title.Location = new System.Drawing.Point(213, 39);
            this.Game_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(500, 143);
            this.Game_Title.TabIndex = 2;
            this.Game_Title.TabStop = false;
            this.Game_Title.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 395);
            this.Controls.Add(this.Game_Title);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Feud";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button Game_Title;
    }
}

