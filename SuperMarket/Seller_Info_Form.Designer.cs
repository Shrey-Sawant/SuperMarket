namespace SuperMarket
{
    partial class Seller_Info_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SELL_LIST_label = new System.Windows.Forms.Label();
            this.Bill_dataGridView = new System.Windows.Forms.DataGridView();
            this.Product_Title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seller_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.SELL_LIST_label);
            this.panel1.Controls.Add(this.Bill_dataGridView);
            this.panel1.Controls.Add(this.Product_Title);
            this.panel1.Location = new System.Drawing.Point(126, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 793);
            this.panel1.TabIndex = 2;
            // 
            // SELL_LIST_label
            // 
            this.SELL_LIST_label.AutoSize = true;
            this.SELL_LIST_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_LIST_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SELL_LIST_label.Location = new System.Drawing.Point(575, 107);
            this.SELL_LIST_label.Name = "SELL_LIST_label";
            this.SELL_LIST_label.Size = new System.Drawing.Size(180, 30);
            this.SELL_LIST_label.TabIndex = 29;
            this.SELL_LIST_label.Text = "SELLS LIST";
            // 
            // Bill_dataGridView
            // 
            this.Bill_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Bill_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_dataGridView.Location = new System.Drawing.Point(166, 162);
            this.Bill_dataGridView.Name = "Bill_dataGridView";
            this.Bill_dataGridView.RowHeadersWidth = 51;
            this.Bill_dataGridView.RowTemplate.Height = 24;
            this.Bill_dataGridView.Size = new System.Drawing.Size(1044, 489);
            this.Bill_dataGridView.TabIndex = 25;
            this.Bill_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_dataGridView_CellContentClick);
            // 
            // Product_Title
            // 
            this.Product_Title.AutoSize = true;
            this.Product_Title.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Title.Location = new System.Drawing.Point(448, 12);
            this.Product_Title.Name = "Product_Title";
            this.Product_Title.Size = new System.Drawing.Size(484, 41);
            this.Product_Title.TabIndex = 0;
            this.Product_Title.Text = "SELLER INFORMATION";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(1323, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(1377, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 799);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "LOGOUT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // seller_button
            // 
            this.seller_button.FlatAppearance.BorderSize = 0;
            this.seller_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seller_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_button.ForeColor = System.Drawing.Color.Coral;
            this.seller_button.Location = new System.Drawing.Point(7, 148);
            this.seller_button.Name = "seller_button";
            this.seller_button.Size = new System.Drawing.Size(113, 38);
            this.seller_button.TabIndex = 32;
            this.seller_button.Text = "Selling";
            this.seller_button.UseVisualStyleBackColor = true;
            this.seller_button.Click += new System.EventHandler(this.seller_button_Click);
            // 
            // Sellling_SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 838);
            this.Controls.Add(this.seller_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sellling_SellerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Sellling_SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SELL_LIST_label;
        private System.Windows.Forms.DataGridView Bill_dataGridView;
        private System.Windows.Forms.Label Product_Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seller_button;
    }
}