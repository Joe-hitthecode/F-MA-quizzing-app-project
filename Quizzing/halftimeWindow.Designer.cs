
namespace quizzing
{
    partial class halftimeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(halftimeWindow));
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(2, -2);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(804, 252);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox32.TabIndex = 92;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Click += new System.EventHandler(this.pictureBox32_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(269, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 32);
            this.button1.TabIndex = 93;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // halftimeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox32);
            this.Name = "halftimeWindow";
            this.Text = "halftimeWindow";
            this.Load += new System.EventHandler(this.halftimeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.Button button1;
    }
}