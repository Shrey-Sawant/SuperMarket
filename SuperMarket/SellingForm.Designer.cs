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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SELL_LIST_label = new System.Windows.Forms.Label();
            this.Order_dataGridView = new System.Windows.Forms.DataGridView();
            this.RS_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Bill_dataGridView = new System.Windows.Forms.DataGridView();
            this.ADD_Pro_button = new System.Windows.Forms.Button();
            this.SELLER_label = new System.Windows.Forms.Label();
            this.Date_lb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.Prod_dataGridView = new System.Windows.Forms.DataGridView();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prod_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.SELL_LIST_label);
            this.panel1.Controls.Add(this.Order_dataGridView);
            this.panel1.Controls.Add(this.RS_label);
            this.panel1.Controls.Add(this.Amount_label);
            this.panel1.Controls.Add(this.Bill_dataGridView);
            this.panel1.Controls.Add(this.ADD_Pro_button);
            this.panel1.Controls.Add(this.SELLER_label);
            this.panel1.Controls.Add(this.Date_lb);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Refresh_button);
            this.panel1.Controls.Add(this.Prod_dataGridView);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Edit_button);
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
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 767);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SELL_LIST_label
            // 
            this.SELL_LIST_label.AutoSize = true;
            this.SELL_LIST_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_LIST_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SELL_LIST_label.Location = new System.Drawing.Point(781, 407);
            this.SELL_LIST_label.Name = "SELL_LIST_label";
            this.SELL_LIST_label.Size = new System.Drawing.Size(180, 30);
            this.SELL_LIST_label.TabIndex = 29;
            this.SELL_LIST_label.Text = "SELLS LIST";
            // 
            // Order_dataGridView
            // 
            this.Order_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_dataGridView.ColumnHeadersHeight = 30;
            this.Order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Order_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namw,
            this.Price,
            this.Quantity,
            this.Total});
            this.Order_dataGridView.Location = new System.Drawing.Point(515, 75);
            this.Order_dataGridView.Name = "Order_dataGridView";
            this.Order_dataGridView.RowHeadersWidth = 51;
            this.Order_dataGridView.RowTemplate.Height = 24;
            this.Order_dataGridView.Size = new System.Drawing.Size(753, 274);
            this.Order_dataGridView.TabIndex = 28;
            // 
            // RS_label
            // 
            this.RS_label.AutoSize = true;
            this.RS_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS_label.Location = new System.Drawing.Point(1005, 352);
            this.RS_label.Name = "RS_label";
            this.RS_label.Size = new System.Drawing.Size(44, 30);
            this.RS_label.TabIndex = 27;
            this.RS_label.Text = "Rs";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Amount_label.Location = new System.Drawing.Point(870, 352);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(136, 30);
            this.Amount_label.TabIndex = 26;
            this.Amount_label.Text = "AMOUNT";
            // 
            // Bill_dataGridView
            // 
            this.Bill_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill_dataGridView.Location = new System.Drawing.Point(515, 440);
            this.Bill_dataGridView.Name = "Bill_dataGridView";
            this.Bill_dataGridView.RowHeadersWidth = 51;
            this.Bill_dataGridView.RowTemplate.Height = 24;
            this.Bill_dataGridView.Size = new System.Drawing.Size(753, 274);
            this.Bill_dataGridView.TabIndex = 25;
            this.Bill_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_dataGridView_CellContentClick);
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
            this.Refresh_button.Location = new System.Drawing.Point(309, 379);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(109, 37);
            this.Refresh_button.TabIndex = 18;
            this.Refresh_button.Text = "REFRESH";
            this.Refresh_button.UseVisualStyleBackColor = false;
            // 
            // Prod_dataGridView
            // 
            this.Prod_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Prod_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prod_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prod_dataGridView.Location = new System.Drawing.Point(29, 422);
            this.Prod_dataGridView.Name = "Prod_dataGridView";
            this.Prod_dataGridView.RowHeadersWidth = 51;
            this.Prod_dataGridView.RowTemplate.Height = 24;
            this.Prod_dataGridView.Size = new System.Drawing.Size(411, 342);
            this.Prod_dataGridView.TabIndex = 16;
            this.Prod_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prod_dataGridView_CellContentClick);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.SeaShell;
            this.Delete_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Delete_button.Location = new System.Drawing.Point(940, 720);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(109, 44);
            this.Delete_button.TabIndex = 15;
            this.Delete_button.Text = "DELETE";
            this.Delete_button.UseVisualStyleBackColor = false;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.SeaShell;
            this.Edit_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Edit_button.Location = new System.Drawing.Point(812, 720);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(109, 44);
            this.Edit_button.TabIndex = 14;
            this.Edit_button.Text = "PRINT";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.SeaShell;
            this.Add_button.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Add_button.Location = new System.Drawing.Point(676, 720);
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
            this.ProdPrice_txtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
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
            this.ProdQty_txtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
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
            this.ProdName_txtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
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
            this.BillId_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillId_txtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
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
            this.button1.Location = new System.Drawing.Point(1389, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle7;
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 791);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prod_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.DataGridView Prod_dataGridView;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
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
        private System.Windows.Forms.DataGridView Bill_dataGridView;
        private System.Windows.Forms.Label SELL_LIST_label;
        private System.Windows.Forms.DataGridView Order_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}