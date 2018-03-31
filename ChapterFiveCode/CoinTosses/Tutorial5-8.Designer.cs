namespace CoinTosses
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
            this.btnToss = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbTails = new System.Windows.Forms.PictureBox();
            this.pbHeads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(12, 226);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(107, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbTails
            // 
            this.pbTails.Image = global::CoinTosses.Properties.Resources.Tails1;
            this.pbTails.Location = new System.Drawing.Point(12, 23);
            this.pbTails.Name = "pbTails";
            this.pbTails.Size = new System.Drawing.Size(170, 170);
            this.pbTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTails.TabIndex = 3;
            this.pbTails.TabStop = false;
            this.pbTails.Visible = false;
            // 
            // pbHeads
            // 
            this.pbHeads.Image = global::CoinTosses.Properties.Resources.Heads1;
            this.pbHeads.Location = new System.Drawing.Point(12, 23);
            this.pbHeads.Name = "pbHeads";
            this.pbHeads.Size = new System.Drawing.Size(170, 170);
            this.pbHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeads.TabIndex = 2;
            this.pbHeads.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 261);
            this.Controls.Add(this.pbTails);
            this.Controls.Add(this.pbHeads);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToss);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.pbTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbHeads;
        private System.Windows.Forms.PictureBox pbTails;
    }
}

