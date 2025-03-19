namespace _30506478_EPOS
{
    partial class ThaiFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPadThai = new System.Windows.Forms.Button();
            this.btnRoti = new System.Windows.Forms.Button();
            this.btnPhat = new System.Windows.Forms.Button();
            this.btnDrunken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food from Thailand";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPadThai
            // 
            this.btnPadThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPadThai.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnPadThai.Location = new System.Drawing.Point(140, 91);
            this.btnPadThai.Name = "btnPadThai";
            this.btnPadThai.Size = new System.Drawing.Size(135, 59);
            this.btnPadThai.TabIndex = 2;
            this.btnPadThai.Text = "Pad Thai";
            this.btnPadThai.UseVisualStyleBackColor = false;
            this.btnPadThai.Click += new System.EventHandler(this.btnPadThai_Click);
            // 
            // btnRoti
            // 
            this.btnRoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRoti.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnRoti.Location = new System.Drawing.Point(474, 91);
            this.btnRoti.Name = "btnRoti";
            this.btnRoti.Size = new System.Drawing.Size(135, 59);
            this.btnRoti.TabIndex = 3;
            this.btnRoti.Text = "Roti Canai";
            this.btnRoti.UseVisualStyleBackColor = false;
            this.btnRoti.Click += new System.EventHandler(this.btnRoti_Click);
            // 
            // btnPhat
            // 
            this.btnPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPhat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPhat.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnPhat.Location = new System.Drawing.Point(140, 267);
            this.btnPhat.Name = "btnPhat";
            this.btnPhat.Size = new System.Drawing.Size(135, 59);
            this.btnPhat.TabIndex = 4;
            this.btnPhat.Text = "Phat Kaphrao";
            this.btnPhat.UseVisualStyleBackColor = false;
            this.btnPhat.Click += new System.EventHandler(this.btnPhat_Click);
            // 
            // btnDrunken
            // 
            this.btnDrunken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDrunken.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnDrunken.Location = new System.Drawing.Point(474, 267);
            this.btnDrunken.Name = "btnDrunken";
            this.btnDrunken.Size = new System.Drawing.Size(135, 59);
            this.btnDrunken.TabIndex = 5;
            this.btnDrunken.Text = "Drunken Noodles";
            this.btnDrunken.UseVisualStyleBackColor = false;
            this.btnDrunken.Click += new System.EventHandler(this.btnDrunken_Click);
            // 
            // ThaiFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrunken);
            this.Controls.Add(this.btnPhat);
            this.Controls.Add(this.btnRoti);
            this.Controls.Add(this.btnPadThai);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "ThaiFood";
            this.Text = "ThaiFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPadThai;
        private System.Windows.Forms.Button btnRoti;
        private System.Windows.Forms.Button btnPhat;
        private System.Windows.Forms.Button btnDrunken;
    }
}