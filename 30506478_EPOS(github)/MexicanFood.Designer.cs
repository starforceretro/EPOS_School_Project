namespace _30506478_EPOS
{
    partial class MexicanFood
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
            this.btnEnchilada = new System.Windows.Forms.Button();
            this.btnNacho = new System.Windows.Forms.Button();
            this.btnChurro = new System.Windows.Forms.Button();
            this.btnBurrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food from Mexico";
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
            // btnEnchilada
            // 
            this.btnEnchilada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnchilada.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnEnchilada.Location = new System.Drawing.Point(124, 111);
            this.btnEnchilada.Name = "btnEnchilada";
            this.btnEnchilada.Size = new System.Drawing.Size(144, 61);
            this.btnEnchilada.TabIndex = 2;
            this.btnEnchilada.Text = "Enchiladas";
            this.btnEnchilada.UseVisualStyleBackColor = false;
            this.btnEnchilada.Click += new System.EventHandler(this.btnEnchilada_Click);
            // 
            // btnNacho
            // 
            this.btnNacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNacho.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnNacho.Location = new System.Drawing.Point(476, 111);
            this.btnNacho.Name = "btnNacho";
            this.btnNacho.Size = new System.Drawing.Size(144, 61);
            this.btnNacho.TabIndex = 3;
            this.btnNacho.Text = "Nacho\'s";
            this.btnNacho.UseVisualStyleBackColor = false;
            this.btnNacho.Click += new System.EventHandler(this.btnNacho_Click);
            // 
            // btnChurro
            // 
            this.btnChurro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChurro.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnChurro.Location = new System.Drawing.Point(124, 288);
            this.btnChurro.Name = "btnChurro";
            this.btnChurro.Size = new System.Drawing.Size(144, 61);
            this.btnChurro.TabIndex = 4;
            this.btnChurro.Text = "Churro\'s";
            this.btnChurro.UseVisualStyleBackColor = false;
            this.btnChurro.Click += new System.EventHandler(this.btnChurro_Click);
            // 
            // btnBurrito
            // 
            this.btnBurrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBurrito.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.btnBurrito.Location = new System.Drawing.Point(476, 288);
            this.btnBurrito.Name = "btnBurrito";
            this.btnBurrito.Size = new System.Drawing.Size(144, 61);
            this.btnBurrito.TabIndex = 5;
            this.btnBurrito.Text = "Burriro\'s";
            this.btnBurrito.UseVisualStyleBackColor = false;
            this.btnBurrito.Click += new System.EventHandler(this.btnBurrito_Click);
            // 
            // MexicanFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBurrito);
            this.Controls.Add(this.btnChurro);
            this.Controls.Add(this.btnNacho);
            this.Controls.Add(this.btnEnchilada);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "MexicanFood";
            this.Text = "MexicanFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEnchilada;
        private System.Windows.Forms.Button btnNacho;
        private System.Windows.Forms.Button btnChurro;
        private System.Windows.Forms.Button btnBurrito;
    }
}