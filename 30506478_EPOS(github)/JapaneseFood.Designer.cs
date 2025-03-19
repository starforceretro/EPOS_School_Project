namespace _30506478_EPOS
{
    partial class JapaneseFood
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
            this.btnOni = new System.Windows.Forms.Button();
            this.btnMochi = new System.Windows.Forms.Button();
            this.btnOkowa = new System.Windows.Forms.Button();
            this.BtnOya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food from Japan";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(717, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOni
            // 
            this.btnOni.BackColor = System.Drawing.Color.Red;
            this.btnOni.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnOni.Location = new System.Drawing.Point(120, 82);
            this.btnOni.Name = "btnOni";
            this.btnOni.Size = new System.Drawing.Size(138, 57);
            this.btnOni.TabIndex = 2;
            this.btnOni.Text = "Onigiri";
            this.btnOni.UseVisualStyleBackColor = false;
            this.btnOni.Click += new System.EventHandler(this.btnOni_Click);
            // 
            // btnMochi
            // 
            this.btnMochi.BackColor = System.Drawing.Color.Red;
            this.btnMochi.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnMochi.Location = new System.Drawing.Point(466, 82);
            this.btnMochi.Name = "btnMochi";
            this.btnMochi.Size = new System.Drawing.Size(138, 57);
            this.btnMochi.TabIndex = 3;
            this.btnMochi.Text = "Mochi";
            this.btnMochi.UseVisualStyleBackColor = false;
            this.btnMochi.Click += new System.EventHandler(this.btnMochi_Click);
            // 
            // btnOkowa
            // 
            this.btnOkowa.BackColor = System.Drawing.Color.Red;
            this.btnOkowa.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnOkowa.Location = new System.Drawing.Point(120, 249);
            this.btnOkowa.Name = "btnOkowa";
            this.btnOkowa.Size = new System.Drawing.Size(138, 57);
            this.btnOkowa.TabIndex = 4;
            this.btnOkowa.Text = "Okowa";
            this.btnOkowa.UseVisualStyleBackColor = false;
            this.btnOkowa.Click += new System.EventHandler(this.btnOkowa_Click);
            // 
            // BtnOya
            // 
            this.BtnOya.BackColor = System.Drawing.Color.Red;
            this.BtnOya.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.BtnOya.Location = new System.Drawing.Point(466, 249);
            this.BtnOya.Name = "BtnOya";
            this.BtnOya.Size = new System.Drawing.Size(138, 57);
            this.BtnOya.TabIndex = 5;
            this.BtnOya.Text = "Oyakudon";
            this.BtnOya.UseVisualStyleBackColor = false;
            this.BtnOya.Click += new System.EventHandler(this.BtnOya_Click);
            // 
            // JapaneseFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOya);
            this.Controls.Add(this.btnOkowa);
            this.Controls.Add(this.btnMochi);
            this.Controls.Add(this.btnOni);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "JapaneseFood";
            this.Text = "JapaneseFood";
            this.Load += new System.EventHandler(this.JapaneseFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOni;
        private System.Windows.Forms.Button btnMochi;
        private System.Windows.Forms.Button btnOkowa;
        private System.Windows.Forms.Button BtnOya;
    }
}