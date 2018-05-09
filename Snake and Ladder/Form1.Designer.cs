namespace Snake_and_Ladder
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
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.Aboutus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1Label
            // 
            this.Player1Label.BackColor = System.Drawing.Color.Black;
            this.Player1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player1Label.Location = new System.Drawing.Point(480, 189);
            this.Player1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(152, 30);
            this.Player1Label.TabIndex = 0;
            this.Player1Label.Text = "Player1";
            this.Player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2Label
            // 
            this.Player2Label.BackColor = System.Drawing.Color.Black;
            this.Player2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player2Label.Location = new System.Drawing.Point(480, 248);
            this.Player2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(152, 30);
            this.Player2Label.TabIndex = 1;
            this.Player2Label.Text = "Player2";
            this.Player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(680, 191);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(202, 26);
            this.Player1Name.TabIndex = 2;
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(680, 248);
            this.Player2Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(202, 26);
            this.Player2Name.TabIndex = 3;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(332, 351);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(166, 66);
            this.Play.TabIndex = 5;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Aboutus
            // 
            this.Aboutus.Location = new System.Drawing.Point(637, 351);
            this.Aboutus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Aboutus.Name = "Aboutus";
            this.Aboutus.Size = new System.Drawing.Size(166, 66);
            this.Aboutus.TabIndex = 6;
            this.Aboutus.Text = "About Us";
            this.Aboutus.UseVisualStyleBackColor = true;
            this.Aboutus.Click += new System.EventHandler(this.Aboutus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_and_Ladder.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(1060, 528);
            this.Controls.Add(this.Aboutus);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Snake And Ladder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Player1Label;
        public System.Windows.Forms.Label Player2Label;
        public System.Windows.Forms.TextBox Player1Name;
        public System.Windows.Forms.TextBox Player2Name;
        public System.Windows.Forms.Button Play;
        public System.Windows.Forms.Button Aboutus;

    }
}

