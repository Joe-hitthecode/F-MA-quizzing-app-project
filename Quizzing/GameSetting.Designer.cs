
namespace quizzing
{
    partial class GameSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSetting));
            System.Windows.Forms.Button button1;
            this.Team1 = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Player3 = new System.Windows.Forms.TextBox();
            this.Player4 = new System.Windows.Forms.TextBox();
            this.Sub1 = new System.Windows.Forms.TextBox();
            this.Sub2 = new System.Windows.Forms.TextBox();
            this.Coach1 = new System.Windows.Forms.TextBox();
            this.Coach2 = new System.Windows.Forms.TextBox();
            this.T2_Substitute2 = new System.Windows.Forms.TextBox();
            this.T2_Substitute1 = new System.Windows.Forms.TextBox();
            this.T2_Player4 = new System.Windows.Forms.TextBox();
            this.T2_Player3 = new System.Windows.Forms.TextBox();
            this.T2_Player2 = new System.Windows.Forms.TextBox();
            this.T2_Player1 = new System.Windows.Forms.TextBox();
            this.Team2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Team1
            // 
            this.Team1.AcceptsTab = true;
            this.Team1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Team1.Location = new System.Drawing.Point(203, 216);
            this.Team1.MaxLength = 28;
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(327, 27);
            this.Team1.TabIndex = 1;
            this.Team1.TextChanged += new System.EventHandler(this.Team1_TextChanged);
            this.Team1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeamKeypress);
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(208, 301);
            this.Player1.MaxLength = 21;
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(282, 27);
            this.Player1.TabIndex = 3;
            this.Player1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player1);
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(207, 343);
            this.Player2.MaxLength = 21;
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(282, 27);
            this.Player2.TabIndex = 5;
            this.Player2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player2);
            // 
            // Player3
            // 
            this.Player3.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.Location = new System.Drawing.Point(208, 384);
            this.Player3.MaxLength = 21;
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(282, 27);
            this.Player3.TabIndex = 8;
            this.Player3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player3);
            // 
            // Player4
            // 
            this.Player4.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4.Location = new System.Drawing.Point(208, 426);
            this.Player4.MaxLength = 21;
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(282, 27);
            this.Player4.TabIndex = 10;
            this.Player4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player4);
            // 
            // Sub1
            // 
            this.Sub1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub1.Location = new System.Drawing.Point(206, 507);
            this.Sub1.MaxLength = 21;
            this.Sub1.Name = "Sub1";
            this.Sub1.Size = new System.Drawing.Size(291, 27);
            this.Sub1.TabIndex = 14;
            this.Sub1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sub1);
            // 
            // Sub2
            // 
            this.Sub2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub2.Location = new System.Drawing.Point(206, 545);
            this.Sub2.MaxLength = 21;
            this.Sub2.Name = "Sub2";
            this.Sub2.Size = new System.Drawing.Size(291, 27);
            this.Sub2.TabIndex = 17;
            this.Sub2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sub2);
            // 
            // Coach1
            // 
            this.Coach1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coach1.Location = new System.Drawing.Point(216, 634);
            this.Coach1.MaxLength = 21;
            this.Coach1.Name = "Coach1";
            this.Coach1.Size = new System.Drawing.Size(286, 27);
            this.Coach1.TabIndex = 19;
            this.Coach1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coach);
            // 
            // Coach2
            // 
            this.Coach2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coach2.Location = new System.Drawing.Point(888, 634);
            this.Coach2.MaxLength = 21;
            this.Coach2.Name = "Coach2";
            this.Coach2.Size = new System.Drawing.Size(282, 27);
            this.Coach2.TabIndex = 39;
            this.Coach2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coach2);
            // 
            // T2_Substitute2
            // 
            this.T2_Substitute2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2_Substitute2.Location = new System.Drawing.Point(885, 545);
            this.T2_Substitute2.MaxLength = 21;
            this.T2_Substitute2.Name = "T2_Substitute2";
            this.T2_Substitute2.Size = new System.Drawing.Size(282, 27);
            this.T2_Substitute2.TabIndex = 37;
            this.T2_Substitute2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sub4);
            // 
            // T2_Substitute1
            // 
            this.T2_Substitute1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2_Substitute1.Location = new System.Drawing.Point(885, 504);
            this.T2_Substitute1.MaxLength = 21;
            this.T2_Substitute1.Name = "T2_Substitute1";
            this.T2_Substitute1.Size = new System.Drawing.Size(282, 27);
            this.T2_Substitute1.TabIndex = 34;
            this.T2_Substitute1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sub3);
            // 
            // T2_Player4
            // 
            this.T2_Player4.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2_Player4.Location = new System.Drawing.Point(885, 425);
            this.T2_Player4.MaxLength = 21;
            this.T2_Player4.Name = "T2_Player4";
            this.T2_Player4.Size = new System.Drawing.Size(282, 27);
            this.T2_Player4.TabIndex = 30;
            this.T2_Player4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player8);
            // 
            // T2_Player3
            // 
            this.T2_Player3.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2_Player3.Location = new System.Drawing.Point(885, 381);
            this.T2_Player3.MaxLength = 21;
            this.T2_Player3.Name = "T2_Player3";
            this.T2_Player3.Size = new System.Drawing.Size(282, 27);
            this.T2_Player3.TabIndex = 29;
            this.T2_Player3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player7);
            // 
            // T2_Player2
            // 
            this.T2_Player2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2_Player2.Location = new System.Drawing.Point(885, 343);
            this.T2_Player2.MaxLength = 21;
            this.T2_Player2.Name = "T2_Player2";
            this.T2_Player2.Size = new System.Drawing.Size(282, 27);
            this.T2_Player2.TabIndex = 26;
            this.T2_Player2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player6);
            // 
            // T2_Player1
            // 
            this.T2_Player1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2_Player1.Location = new System.Drawing.Point(884, 298);
            this.T2_Player1.MaxLength = 21;
            this.T2_Player1.Name = "T2_Player1";
            this.T2_Player1.Size = new System.Drawing.Size(282, 27);
            this.T2_Player1.TabIndex = 25;
            this.T2_Player1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.player5);
            // 
            // Team2
            // 
            this.Team2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2.Location = new System.Drawing.Point(879, 213);
            this.Team2.MaxLength = 28;
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(327, 27);
            this.Team2.TabIndex = 23;
            this.Team2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeamB);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1333, 805);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.Info;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            button1.Location = new System.Drawing.Point(524, 583);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(155, 57);
            button1.TabIndex = 47;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click_1);
            button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // GameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(button1);
            this.Controls.Add(this.Coach2);
            this.Controls.Add(this.T2_Substitute2);
            this.Controls.Add(this.T2_Substitute1);
            this.Controls.Add(this.T2_Player4);
            this.Controls.Add(this.T2_Player3);
            this.Controls.Add(this.T2_Player2);
            this.Controls.Add(this.T2_Player1);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Coach1);
            this.Controls.Add(this.Sub2);
            this.Controls.Add(this.Sub1);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameSetting";
            this.Text = "GameSetting";
            this.Load += new System.EventHandler(this.GameSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Team1;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.TextBox Player3;
        private System.Windows.Forms.TextBox Player4;
        private System.Windows.Forms.TextBox Sub1;
        private System.Windows.Forms.TextBox Sub2;
        private System.Windows.Forms.TextBox Coach1;
        private System.Windows.Forms.TextBox Coach2;
        private System.Windows.Forms.TextBox T2_Substitute2;
        private System.Windows.Forms.TextBox T2_Substitute1;
        private System.Windows.Forms.TextBox T2_Player4;
        private System.Windows.Forms.TextBox T2_Player3;
        private System.Windows.Forms.TextBox T2_Player2;
        private System.Windows.Forms.TextBox T2_Player1;
        private System.Windows.Forms.TextBox Team2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}