namespace _30506478_EPOS
{
    partial class PreviousOrders
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
            this.btnBacktoMain = new System.Windows.Forms.Button();
            this.tblPreviousOrders = new System.Windows.Forms.DataGridView();
            this.Food_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_of_Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size_of_Meal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPreviousOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBacktoMain
            // 
            this.btnBacktoMain.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBacktoMain.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBacktoMain.Location = new System.Drawing.Point(660, 382);
            this.btnBacktoMain.Name = "btnBacktoMain";
            this.btnBacktoMain.Size = new System.Drawing.Size(120, 53);
            this.btnBacktoMain.TabIndex = 0;
            this.btnBacktoMain.Text = "Back";
            this.btnBacktoMain.UseVisualStyleBackColor = false;
            this.btnBacktoMain.Click += new System.EventHandler(this.btnBacktoMain_Click);
            // 
            // tblPreviousOrders
            // 
            this.tblPreviousOrders.AllowUserToAddRows = false;
            this.tblPreviousOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblPreviousOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPreviousOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Food_Name,
            this.Cost_of_Food,
            this.Size_of_Meal,
            this.Amount_Ordered,
            this.Total});
            this.tblPreviousOrders.Location = new System.Drawing.Point(115, 59);
            this.tblPreviousOrders.Name = "tblPreviousOrders";
            this.tblPreviousOrders.Size = new System.Drawing.Size(544, 256);
            this.tblPreviousOrders.TabIndex = 1;
            // 
            // Food_Name
            // 
            this.Food_Name.HeaderText = "Food_Name";
            this.Food_Name.Name = "Food_Name";
            // 
            // Cost_of_Food
            // 
            this.Cost_of_Food.HeaderText = "Cost_of_Food";
            this.Cost_of_Food.Name = "Cost_of_Food";
            // 
            // Size_of_Meal
            // 
            this.Size_of_Meal.HeaderText = "Size_of_Meal";
            this.Size_of_Meal.Name = "Size_of_Meal";
            // 
            // Amount_Ordered
            // 
            this.Amount_Ordered.HeaderText = "Amount_Ordered";
            this.Amount_Ordered.Name = "Amount_Ordered";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(26, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(12, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(111, 368);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 4;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAverage.Location = new System.Drawing.Point(132, 410);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 20);
            this.lblAverage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F);
            this.label3.Location = new System.Drawing.Point(420, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Previous Orders";
            // 
            // PreviousOrders
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(792, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblPreviousOrders);
            this.Controls.Add(this.btnBacktoMain);
            this.Load += new System.EventHandler(this.PreviousOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPreviousOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView tblPrevOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnBacktoMain;
        private System.Windows.Forms.DataGridView tblPreviousOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_of_Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size_of_Meal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Ordered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
    }
}