namespace ShopriteGroupLimited_Inventory_system
{
    partial class SellingScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellDGV1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.ProdPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.ProdName = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.Billid = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.PCatCombo = new System.Windows.Forms.ComboBox();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.ProdQty = new Guna.UI.WinForms.GunaLineTextBox();
            this.BillDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.DateLb = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.SellerNameLb = new Guna.UI.WinForms.GunaLabel();
            this.AddPB = new Guna.UI.WinForms.GunaButton();
            this.OrderDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.Amount = new Guna.UI.WinForms.GunaLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmtLb = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.AmtLb);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.AddPB);
            this.panel1.Controls.Add(this.SellerNameLb);
            this.panel1.Controls.Add(this.DateLb);
            this.panel1.Controls.Add(this.BillDGV);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaButton8);
            this.panel1.Controls.Add(this.PCatCombo);
            this.panel1.Controls.Add(this.SellDGV1);
            this.panel1.Controls.Add(this.gunaButton7);
            this.panel1.Controls.Add(this.gunaButton6);
            this.panel1.Controls.Add(this.gunaButton5);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.Billid);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 715);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellDGV1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.SellDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.SellDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellDGV1.BackgroundColor = System.Drawing.Color.White;
            this.SellDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellDGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SellDGV1.ColumnHeadersHeight = 28;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellDGV1.DefaultCellStyle = dataGridViewCellStyle9;
            this.SellDGV1.EnableHeadersVisualStyles = false;
            this.SellDGV1.GridColor = System.Drawing.Color.IndianRed;
            this.SellDGV1.Location = new System.Drawing.Point(607, 395);
            this.SellDGV1.Name = "SellDGV1";
            this.SellDGV1.RowHeadersVisible = false;
            this.SellDGV1.RowHeadersWidth = 62;
            this.SellDGV1.RowTemplate.Height = 28;
            this.SellDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV1.Size = new System.Drawing.Size(346, 304);
            this.SellDGV1.TabIndex = 27;
            this.SellDGV1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SellDGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellDGV1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellDGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellDGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellDGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellDGV1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellDGV1.ThemeStyle.GridColor = System.Drawing.Color.IndianRed;
            this.SellDGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.IndianRed;
            this.SellDGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellDGV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellDGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellDGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellDGV1.ThemeStyle.HeaderStyle.Height = 28;
            this.SellDGV1.ThemeStyle.ReadOnly = false;
            this.SellDGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellDGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellDGV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellDGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellDGV1.ThemeStyle.RowsStyle.Height = 28;
            this.SellDGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.SellDGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellDGV1_CellContentClick);
            // 
            // gunaButton7
            // 
            this.gunaButton7.AnimationHoverSpeed = 0.07F;
            this.gunaButton7.AnimationSpeed = 0.03F;
            this.gunaButton7.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton7.BaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton7.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.White;
            this.gunaButton7.Image = null;
            this.gunaButton7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton7.Location = new System.Drawing.Point(372, 635);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.Tan;
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.gunaButton7.OnHoverImage = null;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton7.Radius = 10;
            this.gunaButton7.Size = new System.Drawing.Size(75, 38);
            this.gunaButton7.TabIndex = 26;
            this.gunaButton7.Text = "DELETE";
            this.gunaButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = null;
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Location = new System.Drawing.Point(260, 635);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.Tan;
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 10;
            this.gunaButton6.Size = new System.Drawing.Size(75, 38);
            this.gunaButton6.TabIndex = 25;
            this.gunaButton6.Text = "PRINT";
            this.gunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(147, 635);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.Tan;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(75, 38);
            this.gunaButton5.TabIndex = 24;
            this.gunaButton5.Text = "ADD";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.Tan;
            this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPrice.Enabled = false;
            this.ProdPrice.FocusedLineColor = System.Drawing.Color.IndianRed;
            this.ProdPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.Color.White;
            this.ProdPrice.LineColor = System.Drawing.Color.White;
            this.ProdPrice.Location = new System.Drawing.Point(776, 181);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.PasswordChar = '\0';
            this.ProdPrice.SelectedText = "";
            this.ProdPrice.Size = new System.Drawing.Size(177, 46);
            this.ProdPrice.TabIndex = 21;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.Tan;
            this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdName.Enabled = false;
            this.ProdName.FocusedLineColor = System.Drawing.Color.IndianRed;
            this.ProdName.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.Color.White;
            this.ProdName.LineColor = System.Drawing.Color.White;
            this.ProdName.Location = new System.Drawing.Point(776, 110);
            this.ProdName.Name = "ProdName";
            this.ProdName.PasswordChar = '\0';
            this.ProdName.SelectedText = "";
            this.ProdName.Size = new System.Drawing.Size(177, 46);
            this.ProdName.TabIndex = 20;
            this.ProdName.TextChanged += new System.EventHandler(this.CatNameTb_TextChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(690, 196);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(71, 31);
            this.gunaLabel4.TabIndex = 15;
            this.gunaLabel4.Text = "PRICE";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(635, 126);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(126, 31);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "PRODNAME";
            // 
            // Billid
            // 
            this.Billid.BackColor = System.Drawing.Color.Tan;
            this.Billid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Billid.FocusedLineColor = System.Drawing.Color.IndianRed;
            this.Billid.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billid.ForeColor = System.Drawing.Color.White;
            this.Billid.LineColor = System.Drawing.Color.White;
            this.Billid.Location = new System.Drawing.Point(776, 48);
            this.Billid.Name = "Billid";
            this.Billid.PasswordChar = '\0';
            this.Billid.SelectedText = "";
            this.Billid.Size = new System.Drawing.Size(177, 46);
            this.Billid.TabIndex = 13;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(686, 63);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 31);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "BILLID";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(430, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(114, 50);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Selling";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // PCatCombo
            // 
            this.PCatCombo.BackColor = System.Drawing.Color.Tan;
            this.PCatCombo.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCatCombo.ForeColor = System.Drawing.Color.White;
            this.PCatCombo.FormattingEnabled = true;
            this.PCatCombo.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.PCatCombo.Location = new System.Drawing.Point(607, 357);
            this.PCatCombo.Name = "PCatCombo";
            this.PCatCombo.Size = new System.Drawing.Size(167, 32);
            this.PCatCombo.TabIndex = 28;
            this.PCatCombo.Text = "   Select Category";
            // 
            // gunaButton8
            // 
            this.gunaButton8.AnimationHoverSpeed = 0.07F;
            this.gunaButton8.AnimationSpeed = 0.03F;
            this.gunaButton8.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton8.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton8.ForeColor = System.Drawing.Color.White;
            this.gunaButton8.Image = null;
            this.gunaButton8.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton8.Location = new System.Drawing.Point(878, 357);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.Tan;
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.gunaButton8.OnHoverImage = null;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 10;
            this.gunaButton8.Size = new System.Drawing.Size(75, 32);
            this.gunaButton8.TabIndex = 30;
            this.gunaButton8.Text = "Refresh";
            this.gunaButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(647, 257);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(114, 31);
            this.gunaLabel5.TabIndex = 31;
            this.gunaLabel5.Text = "QUANTITY";
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.Tan;
            this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQty.FocusedLineColor = System.Drawing.Color.IndianRed;
            this.ProdQty.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.ForeColor = System.Drawing.Color.White;
            this.ProdQty.LineColor = System.Drawing.Color.White;
            this.ProdQty.Location = new System.Drawing.Point(776, 242);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.PasswordChar = '\0';
            this.ProdQty.SelectedText = "";
            this.ProdQty.Size = new System.Drawing.Size(177, 46);
            this.ProdQty.TabIndex = 32;
            // 
            // BillDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BillDGV.ColumnHeadersHeight = 28;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.BillDGV.EnableHeadersVisualStyles = false;
            this.BillDGV.GridColor = System.Drawing.Color.IndianRed;
            this.BillDGV.Location = new System.Drawing.Point(20, 417);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersVisible = false;
            this.BillDGV.RowHeadersWidth = 62;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(539, 195);
            this.BillDGV.TabIndex = 33;
            this.BillDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.GridColor = System.Drawing.Color.IndianRed;
            this.BillDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.IndianRed;
            this.BillDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.BillDGV.ThemeStyle.ReadOnly = false;
            this.BillDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDGV.ThemeStyle.RowsStyle.Height = 28;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DateLb
            // 
            this.DateLb.AutoSize = true;
            this.DateLb.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.ForeColor = System.Drawing.Color.White;
            this.DateLb.Location = new System.Drawing.Point(85, 11);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(68, 35);
            this.DateLb.TabIndex = 34;
            this.DateLb.Text = "Date:";
            this.DateLb.Click += new System.EventHandler(this.DateLb_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(1180, 1);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.Tan;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 15;
            this.gunaButton4.Size = new System.Drawing.Size(40, 49);
            this.gunaButton4.TabIndex = 13;
            this.gunaButton4.Text = "x";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // SellerNameLb
            // 
            this.SellerNameLb.AutoSize = true;
            this.SellerNameLb.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameLb.ForeColor = System.Drawing.Color.White;
            this.SellerNameLb.Location = new System.Drawing.Point(788, 11);
            this.SellerNameLb.Name = "SellerNameLb";
            this.SellerNameLb.Size = new System.Drawing.Size(70, 35);
            this.SellerNameLb.TabIndex = 35;
            this.SellerNameLb.Text = "Seller";
            // 
            // AddPB
            // 
            this.AddPB.AnimationHoverSpeed = 0.07F;
            this.AddPB.AnimationSpeed = 0.03F;
            this.AddPB.BackColor = System.Drawing.Color.Transparent;
            this.AddPB.BaseColor = System.Drawing.Color.IndianRed;
            this.AddPB.BorderColor = System.Drawing.Color.Black;
            this.AddPB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddPB.FocusedColor = System.Drawing.Color.Empty;
            this.AddPB.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPB.ForeColor = System.Drawing.Color.White;
            this.AddPB.Image = null;
            this.AddPB.ImageSize = new System.Drawing.Size(20, 20);
            this.AddPB.Location = new System.Drawing.Point(741, 306);
            this.AddPB.Name = "AddPB";
            this.AddPB.OnHoverBaseColor = System.Drawing.Color.Tan;
            this.AddPB.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddPB.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.AddPB.OnHoverImage = null;
            this.AddPB.OnPressedColor = System.Drawing.Color.Black;
            this.AddPB.Radius = 10;
            this.AddPB.Size = new System.Drawing.Size(169, 32);
            this.AddPB.TabIndex = 36;
            this.AddPB.Text = "Add Product";
            this.AddPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddPB.Click += new System.EventHandler(this.AddPB_Click);
            // 
            // OrderDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.OrderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDGV.ColumnHeadersHeight = 35;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDGV.EnableHeadersVisualStyles = false;
            this.OrderDGV.GridColor = System.Drawing.Color.IndianRed;
            this.OrderDGV.Location = new System.Drawing.Point(20, 93);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersVisible = false;
            this.OrderDGV.RowHeadersWidth = 62;
            this.OrderDGV.RowTemplate.Height = 28;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(539, 195);
            this.OrderDGV.TabIndex = 37;
            this.OrderDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.GridColor = System.Drawing.Color.IndianRed;
            this.OrderDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.IndianRed;
            this.OrderDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderDGV.ThemeStyle.HeaderStyle.Height = 35;
            this.OrderDGV.ThemeStyle.ReadOnly = false;
            this.OrderDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderDGV.ThemeStyle.RowsStyle.Height = 28;
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(215, 357);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(145, 50);
            this.gunaLabel6.TabIndex = 38;
            this.gunaLabel6.Text = "Sells List";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.White;
            this.Amount.Location = new System.Drawing.Point(182, 291);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(178, 38);
            this.Amount.TabIndex = 39;
            this.Amount.Text = "Amount Cedis:";
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Prodid";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // PName
            // 
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 8;
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // AmtLb
            // 
            this.AmtLb.AutoSize = true;
            this.AmtLb.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtLb.ForeColor = System.Drawing.Color.White;
            this.AmtLb.Location = new System.Drawing.Point(356, 291);
            this.AmtLb.Name = "AmtLb";
            this.AmtLb.Size = new System.Drawing.Size(33, 38);
            this.AmtLb.TabIndex = 40;
            this.AmtLb.Text = "0";
            this.AmtLb.Click += new System.EventHandler(this.AmtLb_Click);
            // 
            // SellingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1257, 775);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingScreen";
            this.Load += new System.EventHandler(this.SellingScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView SellDGV1;
        private Guna.UI.WinForms.GunaButton gunaButton7;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaLineTextBox ProdPrice;
        private Guna.UI.WinForms.GunaLineTextBox ProdName;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox Billid;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ComboBox PCatCombo;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaLineTextBox ProdQty;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel DateLb;
        private Guna.UI.WinForms.GunaDataGridView BillDGV;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaLabel SellerNameLb;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDataGridView OrderDGV;
        private Guna.UI.WinForms.GunaButton AddPB;
        private Guna.UI.WinForms.GunaLabel Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI.WinForms.GunaLabel AmtLb;
    }
}