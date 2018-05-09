namespace Snake_and_Ladder
{
    partial class Form2
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
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.Dice5 = new System.Windows.Forms.PictureBox();
            this.Dice6 = new System.Windows.Forms.PictureBox();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Board = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.CurrentPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.Player1Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(757, 156);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(130, 32);
            this.Player1Name.TabIndex = 54;
            this.Player1Name.Text = "Name Here";
            this.Player1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2Name
            // 
            this.Player2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.Player2Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.Location = new System.Drawing.Point(757, 188);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(130, 32);
            this.Player2Name.TabIndex = 55;
            this.Player2Name.Text = "Name Here";
            this.Player2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice2
            // 
            this.Dice2.Image = global::Snake_and_Ladder.Properties.Resources._2;
            this.Dice2.Location = new System.Drawing.Point(762, 427);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(125, 112);
            this.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice2.TabIndex = 61;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.Image = global::Snake_and_Ladder.Properties.Resources._3;
            this.Dice3.Location = new System.Drawing.Point(762, 427);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(125, 112);
            this.Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice3.TabIndex = 60;
            this.Dice3.TabStop = false;
            // 
            // Dice4
            // 
            this.Dice4.Image = global::Snake_and_Ladder.Properties.Resources._4;
            this.Dice4.Location = new System.Drawing.Point(762, 427);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(125, 112);
            this.Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice4.TabIndex = 59;
            this.Dice4.TabStop = false;
            // 
            // Dice5
            // 
            this.Dice5.Image = global::Snake_and_Ladder.Properties.Resources._5;
            this.Dice5.Location = new System.Drawing.Point(760, 427);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(125, 112);
            this.Dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice5.TabIndex = 58;
            this.Dice5.TabStop = false;
            // 
            // Dice6
            // 
            this.Dice6.Image = global::Snake_and_Ladder.Properties.Resources._6;
            this.Dice6.Location = new System.Drawing.Point(760, 427);
            this.Dice6.Name = "Dice6";
            this.Dice6.Size = new System.Drawing.Size(125, 112);
            this.Dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice6.TabIndex = 57;
            this.Dice6.TabStop = false;
            // 
            // Dice1
            // 
            this.Dice1.Image = global::Snake_and_Ladder.Properties.Resources._1;
            this.Dice1.Location = new System.Drawing.Point(760, 427);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(125, 112);
            this.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice1.TabIndex = 56;
            this.Dice1.TabStop = false;
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Board.Image = global::Snake_and_Ladder.Properties.Resources.FinalBoard;
            this.Board.Location = new System.Drawing.Point(1, 0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(910, 612);
            this.Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.Image = global::Snake_and_Ladder.Properties.Resources.reset;
            this.Reset.Location = new System.Drawing.Point(827, 556);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(69, 28);
            this.Reset.TabIndex = 62;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::Snake_and_Ladder.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(752, 556);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(69, 28);
            this.Exit.TabIndex = 63;
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Snake_and_Ladder.Properties.Resources.rolldice;
            this.button2.Location = new System.Drawing.Point(743, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 47);
            this.button2.TabIndex = 64;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(40, 556);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(25, 25);
            this.Player1.TabIndex = 65;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(40, 514);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(25, 25);
            this.Player2.TabIndex = 66;
            this.Player2.TabStop = false;
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.CurrentPlayer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayer.Location = new System.Drawing.Point(784, 328);
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.Size = new System.Drawing.Size(101, 21);
            this.CurrentPlayer.TabIndex = 67;
            this.CurrentPlayer.Text = "Name Here";
            this.CurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 615);
            this.Controls.Add(this.CurrentPlayer);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice6);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Board);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Player1Name;
        public System.Windows.Forms.Label Player2Name;
        public System.Windows.Forms.PictureBox Board;
        public System.Windows.Forms.PictureBox Dice1;
        public System.Windows.Forms.PictureBox Dice6;
        public System.Windows.Forms.PictureBox Dice5;
        public System.Windows.Forms.PictureBox Dice4;
        public System.Windows.Forms.PictureBox Dice3;
        public System.Windows.Forms.PictureBox Dice2;
        public System.Windows.Forms.Button Reset;
        public System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox Player1;
        public System.Windows.Forms.PictureBox Player2;
        public System.Windows.Forms.Label CurrentPlayer;
    }
}