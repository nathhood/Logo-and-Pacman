namespace WindowsFormsApplication1
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
            this.playButton = new System.Windows.Forms.Button();
            this.countdowText = new System.Windows.Forms.Label();
            this.PacManButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(95, 52);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(196, 79);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseLeave += new System.EventHandler(this.PlayButtonHoverOn);
            this.playButton.MouseHover += new System.EventHandler(this.PlayButtonHoverOff);
            // 
            // countdowText
            // 
            this.countdowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdowText.ForeColor = System.Drawing.Color.White;
            this.countdowText.Location = new System.Drawing.Point(52, 215);
            this.countdowText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countdowText.Name = "countdowText";
            this.countdowText.Size = new System.Drawing.Size(287, 28);
            this.countdowText.TabIndex = 1;
            this.countdowText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdowText.Click += new System.EventHandler(this.PlayButtonHoverOff);
            // 
            // PacManButton
            // 
            this.PacManButton.Location = new System.Drawing.Point(155, 277);
            this.PacManButton.Name = "PacManButton";
            this.PacManButton.Size = new System.Drawing.Size(75, 32);
            this.PacManButton.TabIndex = 2;
            this.PacManButton.Text = "Run";
            this.PacManButton.UseVisualStyleBackColor = true;
            this.PacManButton.Click += new System.EventHandler(this.runPacManButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.PacManButton);
            this.Controls.Add(this.countdowText);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Arcade Central";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label countdowText;
        private System.Windows.Forms.Button PacManButton;
    }
}

