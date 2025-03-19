namespace _30506478_EPOS
{
    partial class GermanFood
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
            this.btnBrat = new System.Windows.Forms.Button();
            this.btnSchnitzel = new System.Windows.Forms.Button();
            this.btnApfel = new System.Windows.Forms.Button();
            this.btnSauer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food from Germany";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBrat
            // 
            this.btnBrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBrat.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnBrat.Location = new System.Drawing.Point(157, 74);
            this.btnBrat.Name = "btnBrat";
            this.btnBrat.Size = new System.Drawing.Size(139, 56);
            this.btnBrat.TabIndex = 2;
            this.btnBrat.Text = "Bratwurst";
            this.btnBrat.UseVisualStyleBackColor = false;
            this.btnBrat.Click += new System.EventHandler(this.btnBrat_Click);
            // 
            // btnSchnitzel
            // 
            this.btnSchnitzel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSchnitzel.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnSchnitzel.Location = new System.Drawing.Point(460, 74);
            this.btnSchnitzel.Name = "btnSchnitzel";
            this.btnSchnitzel.Size = new System.Drawing.Size(139, 56);
            this.btnSchnitzel.TabIndex = 3;
            this.btnSchnitzel.Text = "Schnitzel";
            this.btnSchnitzel.UseVisualStyleBackColor = false;
            this.btnSchnitzel.Click += new System.EventHandler(this.btnSchnitzel_Click);
            // 
            // btnApfel
            // 
            this.btnApfel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnApfel.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnApfel.Location = new System.Drawing.Point(157, 262);
            this.btnApfel.Name = "btnApfel";
            this.btnApfel.Size = new System.Drawing.Size(139, 56);
            this.btnApfel.TabIndex = 4;
            this.btnApfel.Text = "Apfelstrudel";
            this.btnApfel.UseVisualStyleBackColor = false;
            this.btnApfel.Click += new System.EventHandler(this.btnApfel_Click);
            // 
            // btnSauer
            // 
            this.btnSauer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSauer.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnSauer.Location = new System.Drawing.Point(460, 262);
            this.btnSauer.Name = "btnSauer";
            this.btnSauer.Size = new System.Drawing.Size(139, 56);
            this.btnSauer.TabIndex = 5;
            this.btnSauer.Text = "Sauerkraut";
            this.btnSauer.UseVisualStyleBackColor = false;
            this.btnSauer.Click += new System.EventHandler(this.btnSauer_Click);
            // 
            // GermanFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSauer);
            this.Controls.Add(this.btnApfel);
            this.Controls.Add(this.btnSchnitzel);
            this.Controls.Add(this.btnBrat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "GermanFood";
            this.Text = "GermanFood";
            this.Load += new System.EventHandler(this.GermanFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBrat;
        private System.Windows.Forms.Button btnSchnitzel;
        private System.Windows.Forms.Button btnApfel;
        private System.Windows.Forms.Button btnSauer;
    }
}