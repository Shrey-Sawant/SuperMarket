namespace SuperMarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Order_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RS_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.ADD_Pro_button = new System.Windows.Forms.Button();
            this.SELLER_label = new System.Windows.Forms.Label();
            this.Date_lb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.Prod_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Print_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Cat_comboBox = new System.Windows.Forms.ComboBox();
            this.ProdPrice_label = new System.Windows.Forms.Label();
            this.ProdPrice_txtBox = new System.Windows.Forms.TextBox();
            this.ProdQty_label = new System.Windows.Forms.Label();
            this.ProdQty_txtBox = new System.Windows.Forms.TextBox();
            this.ProdName_txtBox = new System.Windows.Forms.TextBox();
            this.ProdName_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BillId_txtBox = new System.Windows.Forms.TextBox();
            this.ProdId_label = new System.Windows.Forms.Label();
            this.Product_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seller_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prod_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Order_dataGridView);
            this.panel1.Controls.Add(this.RS_label);
            this.panel1.Controls.Add(this.Amount_label);
            this.panel1.Controls.Add(this.ADD_Pro_button);
            this.panel1.Controls.Add(this.SELLER_label);
            this.panel1.Controls.Add(this.Date_lb);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Refresh_button);
            this.panel1.Controls.Add(this.Prod_dataGridView1);
            this.panel1.Controls.Add(this.Print_button);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Controls.Add(this.Cat_comboBox);
            this.panel1.Controls.Add(this.ProdPrice_label);
            this.panel1.Controls.Add(this.ProdPrice_txtBox);
            this.panel1.Controls.Add(this.ProdQty_label);
            this.panel1.Controls.Add(this.ProdQty_txtBox);
            this.panel1.Controls.Add(this.ProdName_txtBox);
            this.panel1.Controls.Add(this.ProdName_label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BillId_txtBox);
            this.panel1.Controls.Add(this.ProdId_label);
            this.panel1.Controls.Add(this.Product_Title);
            this.panel1.Location = new System.Drawing.Point(102, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 793);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.SeaShell;
            this.Delete_btn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.DarkOrange;
            this.Delete_btn.Location = new System.Drawing.Point(1031, 720);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(109, 44);
            this.Delete_btn.TabIndex = 31;
            this.Delete_btn.Text = "DELETE";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1083, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Rs";
            // 
            // Order_dataGridView
            // 
            this.Order_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Order_dataGridView.ColumnHeadersHeight = 30;
            this.Order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Order_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namw,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Order_dataGridView.Location = new System.Drawing.Point(498, 90);
            this.Order_dataGridView.Name = "Order_dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Order_dataGridView.RowHeadersWidth = 51;
            this.Order_dataGridView.RowTemplate.Height = 24;
            this.Order_dataGridView.Size = new System.Drawing.Size(753, 567);
            this.Order_dataGridView.TabIndex = 28;
            this.Order_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_dataGridView_CellClick);
            this.Order_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_dataGridView_CellContentClick);
            // 
            // ID
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ProdID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Namw
            // 
            this.Namw.HeaderText = "ProdName";
            this.Namw.MinimumWidth = 6;
            this.Namw.Name = "Namw";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quatity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // RS_label
            // 
            this.RS_label.AutoSize = true;
            this.RS_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS_label.Location = new System.Drawing.Point(1171, 660);
            this.RS_label.Name = "RS_label";
            this.RS_label.Size = new System.Drawing.Size(0, 30);
            this.RS_label.TabIndex = 27;
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Amount_label.Location = new System.Drawing.Point(951, 660);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(136, 30);
            this.Amount_label.TabIndex = 26;
            this.Amount_label.Text = "AMOUNT";
            // 
            // ADD_Pro_button
            // 
            this.ADD_Pro_button.BackColor = System.Drawing.Color.SeaShell;
            this.ADD_Pro_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_Pro_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.ADD_Pro_button.Location = new System.Drawing.Point(107, 329);
            this.ADD_Pro_button.Name = "ADD_Pro_button";
            this.ADD_Pro_button.Size = new System.Drawing.Size(239, 44);
            this.ADD_Pro_button.TabIndex = 24;
            this.ADD_Pro_button.Text = "ADD PRODUCT";
            this.ADD_Pro_button.UseVisualStyleBackColor = false;
            this.ADD_Pro_button.Click += new System.EventHandler(this.ADD_Pro_button_Click);
            // 
            // SELLER_label
            // 
            this.SELLER_label.AutoSize = true;
            this.SELLER_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELLER_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SELLER_label.Location = new System.Drawing.Point(16, 25);
            this.SELLER_label.Name = "SELLER_label";
            this.SELLER_label.Size = new System.Drawing.Size(129, 30);
            this.SELLER_label.TabIndex = 23;
            this.SELLER_label.Text = "SELLER";
            // 
            // Date_lb
            // 
            this.Date_lb.AutoSize = true;
            this.Date_lb.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date_lb.Location = new System.Drawing.Point(1097, 25);
            this.Date_lb.Name = "Date_lb";
            this.Date_lb.Size = new System.Drawing.Size(92, 30);
            this.Date_lb.TabIndex = 22;
            this.Date_lb.Text = "DATE";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SuperMarket.Properties.Resources.White_background;
            this.pictureBox4.Location = new System.Drawing.Point(187, 246);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 7);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SuperMarket.Properties.Resources.White_background;
            this.pictureBox3.Location = new System.Drawing.Point(189, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 7);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SuperMarket.Properties.Resources.White_background;
            this.pictureBox2.Location = new System.Drawing.Point(187, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 7);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Refresh_button
            // 
            this.Refresh_button.BackColor = System.Drawing.Color.SeaShell;
            this.Refresh_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Refresh_button.Location = new System.Drawing.Point(291, 380);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(129, 37);
            this.Refresh_button.TabIndex = 18;
            this.Refresh_button.Text = "REFRESH";
            this.Refresh_button.UseVisualStyleBackColor = false;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // Prod_dataGridView1
            // 
            this.Prod_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Prod_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prod_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prod_dataGridView1.Location = new System.Drawing.Point(29, 422);
            this.Prod_dataGridView1.Name = "Prod_dataGridView1";
            this.Prod_dataGridView1.RowHeadersWidth = 51;
            this.Prod_dataGridView1.RowTemplate.Height = 24;
            this.Prod_dataGridView1.Size = new System.Drawing.Size(397, 358);
            this.Prod_dataGridView1.TabIndex = 16;
            this.Prod_dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prod_dataGridView1_CellClick);
            this.Prod_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prod_dataGridView_CellContentClick);
            // 
            // Print_button
            // 
            this.Print_button.BackColor = System.Drawing.Color.SeaShell;
            this.Print_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Print_button.Location = new System.Drawing.Point(887, 720);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(109, 44);
            this.Print_button.TabIndex = 14;
            this.Print_button.Text = "PRINT";
            this.Print_button.UseVisualStyleBackColor = false;
            this.Print_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.SeaShell;
            this.Add_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Add_button.Location = new System.Drawing.Point(751, 720);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(109, 44);
            this.Add_button.TabIndex = 13;
            this.Add_button.Text = "ADD";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Cat_comboBox
            // 
            this.Cat_comboBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_comboBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.Cat_comboBox.FormattingEnabled = true;
            this.Cat_comboBox.Location = new System.Drawing.Point(29, 380);
            this.Cat_comboBox.Name = "Cat_comboBox";
            this.Cat_comboBox.Size = new System.Drawing.Size(256, 36);
            this.Cat_comboBox.TabIndex = 12;
            this.Cat_comboBox.Text = "Select Category";
            this.Cat_comboBox.SelectionChangeCommitted += new System.EventHandler(this.Cat_comboBox_SelectionChangeCommitted);
            // 
            // ProdPrice_label
            // 
            this.ProdPrice_label.AutoSize = true;
            this.ProdPrice_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdPrice_label.Location = new System.Drawing.Point(13, 220);
            this.ProdPrice_label.Name = "ProdPrice_label";
            this.ProdPrice_label.Size = new System.Drawing.Size(101, 30);
            this.ProdPrice_label.TabIndex = 9;
            this.ProdPrice_label.Text = "PRICE";
            // 
            // ProdPrice_txtBox
            // 
            this.ProdPrice_txtBox.BackColor = System.Drawing.Color.DarkOrange;
            this.ProdPrice_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdPrice_txtBox.Enabled = false;
            this.ProdPrice_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice_txtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProdPrice_txtBox.Location = new System.Drawing.Point(189, 223);
            this.ProdPrice_txtBox.Name = "ProdPrice_txtBox";
            this.ProdPrice_txtBox.Size = new System.Drawing.Size(268, 23);
            this.ProdPrice_txtBox.TabIndex = 8;
            // 
            // ProdQty_label
            // 
            this.ProdQty_label.AutoSize = true;
            this.ProdQty_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdQty_label.Location = new System.Drawing.Point(1, 276);
            this.ProdQty_label.Name = "ProdQty_label";
            this.ProdQty_label.Size = new System.Drawing.Size(163, 30);
            this.ProdQty_label.TabIndex = 7;
            this.ProdQty_label.Text = "QUANTITY";
            // 
            // ProdQty_txtBox
            // 
            this.ProdQty_txtBox.BackColor = System.Drawing.Color.DarkOrange;
            this.ProdQty_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdQty_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty_txtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProdQty_txtBox.Location = new System.Drawing.Point(189, 279);
            this.ProdQty_txtBox.Name = "ProdQty_txtBox";
            this.ProdQty_txtBox.Size = new System.Drawing.Size(268, 23);
            this.ProdQty_txtBox.TabIndex = 6;
            // 
            // ProdName_txtBox
            // 
            this.ProdName_txtBox.BackColor = System.Drawing.Color.DarkOrange;
            this.ProdName_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdName_txtBox.Enabled = false;
            this.ProdName_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName_txtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProdName_txtBox.Location = new System.Drawing.Point(189, 156);
            this.ProdName_txtBox.Name = "ProdName_txtBox";
            this.ProdName_txtBox.Size = new System.Drawing.Size(268, 23);
            this.ProdName_txtBox.TabIndex = 5;
            // 
            // ProdName_label
            // 
            this.ProdName_label.AutoSize = true;
            this.ProdName_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdName_label.Location = new System.Drawing.Point(3, 156);
            this.ProdName_label.Name = "ProdName_label";
            this.ProdName_label.Size = new System.Drawing.Size(177, 30);
            this.ProdName_label.TabIndex = 4;
            this.ProdName_label.Text = "PRODNAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperMarket.Properties.Resources.White_background;
            this.pictureBox1.Location = new System.Drawing.Point(185, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 7);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BillId_txtBox
            // 
            this.BillId_txtBox.BackColor = System.Drawing.Color.DarkOrange;
            this.BillId_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillId_txtBox.Enabled = false;
            this.BillId_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillId_txtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BillId_txtBox.Location = new System.Drawing.Point(189, 90);
            this.BillId_txtBox.Name = "BillId_txtBox";
            this.BillId_txtBox.Size = new System.Drawing.Size(268, 23);
            this.BillId_txtBox.TabIndex = 2;
            // 
            // ProdId_label
            // 
            this.ProdId_label.AutoSize = true;
            this.ProdId_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdId_label.Location = new System.Drawing.Point(24, 90);
            this.ProdId_label.Name = "ProdId_label";
            this.ProdId_label.Size = new System.Drawing.Size(121, 30);
            this.ProdId_label.TabIndex = 1;
            this.ProdId_label.Text = "BILLID";
            // 
            // Product_Title
            // 
            this.Product_Title.AutoSize = true;
            this.Product_Title.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Title.Location = new System.Drawing.Point(541, 0);
            this.Product_Title.Name = "Product_Title";
            this.Product_Title.Size = new System.Drawing.Size(200, 41);
            this.Product_Title.TabIndex = 0;
            this.Product_Title.Text = "SELLING";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(1391, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(1345, -9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(1, 761);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "LOGOUT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // seller_button
            // 
            this.seller_button.FlatAppearance.BorderSize = 0;
            this.seller_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seller_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_button.ForeColor = System.Drawing.Color.Coral;
            this.seller_button.Location = new System.Drawing.Point(-17, 121);
            this.seller_button.Name = "seller_button";
            this.seller_button.Size = new System.Drawing.Size(113, 64);
            this.seller_button.TabIndex = 33;
            this.seller_button.Text = "Seller\r\nInfo\r\n";
            this.seller_button.UseVisualStyleBackColor = true;
            this.seller_button.Click += new System.EventHandler(this.seller_button_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 838);
            this.Controls.Add(this.seller_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prod_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.DataGridView Prod_dataGridView1;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox Cat_comboBox;
        private System.Windows.Forms.Label ProdPrice_label;
        private System.Windows.Forms.TextBox ProdPrice_txtBox;
        private System.Windows.Forms.Label ProdQty_label;
        private System.Windows.Forms.TextBox ProdQty_txtBox;
        private System.Windows.Forms.TextBox ProdName_txtBox;
        private System.Windows.Forms.Label ProdName_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox BillId_txtBox;
        private System.Windows.Forms.Label ProdId_label;
        private System.Windows.Forms.Label Product_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Date_lb;
        private System.Windows.Forms.Button ADD_Pro_button;
        private System.Windows.Forms.Label SELLER_label;
        private System.Windows.Forms.Label RS_label;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.DataGridView Order_dataGridView;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seller_button;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}