
namespace Shop
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSelectCatShow = new System.Windows.Forms.ComboBox();
            this.buttonShow = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelManageProducts = new System.Windows.Forms.Label();
            this.labelSelling = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelSellers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.comboBoxSelectCatShow);
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.dataGridViewProducts);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.comboBoxSelectCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 608);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxSelectCatShow
            // 
            this.comboBoxSelectCatShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelectCatShow.FormattingEnabled = true;
            this.comboBoxSelectCatShow.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBoxSelectCatShow.Location = new System.Drawing.Point(650, 21);
            this.comboBoxSelectCatShow.Name = "comboBoxSelectCatShow";
            this.comboBoxSelectCatShow.Size = new System.Drawing.Size(247, 33);
            this.comboBoxSelectCatShow.TabIndex = 21;
            this.comboBoxSelectCatShow.Text = "Select Category";
            // 
            // buttonShow
            // 
            this.buttonShow.Animated = true;
            this.buttonShow.AutoRoundedCorners = true;
            this.buttonShow.BorderRadius = 25;
            this.buttonShow.BorderThickness = 2;
            this.buttonShow.CheckedState.Parent = this.buttonShow;
            this.buttonShow.CustomImages.Parent = this.buttonShow;
            this.buttonShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonShow.DisabledState.Parent = this.buttonShow;
            this.buttonShow.FillColor = System.Drawing.Color.White;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonShow.ForeColor = System.Drawing.Color.Purple;
            this.buttonShow.HoverState.Parent = this.buttonShow;
            this.buttonShow.Location = new System.Drawing.Point(943, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.ShadowDecoration.Parent = this.buttonShow;
            this.buttonShow.Size = new System.Drawing.Size(128, 52);
            this.buttonShow.TabIndex = 20;
            this.buttonShow.Text = "SHOW";
            // 
            // dataGridViewProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.Location = new System.Drawing.Point(448, 62);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(725, 427);
            this.dataGridViewProducts.TabIndex = 19;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewProducts.ThemeStyle.ReadOnly = false;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewProducts.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Animated = true;
            this.buttonDelete.AutoRoundedCorners = true;
            this.buttonDelete.BorderRadius = 28;
            this.buttonDelete.BorderThickness = 2;
            this.buttonDelete.CheckedState.Parent = this.buttonDelete;
            this.buttonDelete.CustomImages.Parent = this.buttonDelete;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.DisabledState.Parent = this.buttonDelete;
            this.buttonDelete.FillColor = System.Drawing.Color.White;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Purple;
            this.buttonDelete.HoverState.Parent = this.buttonDelete;
            this.buttonDelete.Location = new System.Drawing.Point(284, 340);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShadowDecoration.Parent = this.buttonDelete;
            this.buttonDelete.Size = new System.Drawing.Size(131, 59);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Animated = true;
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BorderRadius = 28;
            this.buttonEdit.BorderThickness = 2;
            this.buttonEdit.CheckedState.Parent = this.buttonEdit;
            this.buttonEdit.CustomImages.Parent = this.buttonEdit;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.DisabledState.Parent = this.buttonEdit;
            this.buttonEdit.FillColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEdit.ForeColor = System.Drawing.Color.Purple;
            this.buttonEdit.HoverState.Parent = this.buttonEdit;
            this.buttonEdit.Location = new System.Drawing.Point(157, 340);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Parent = this.buttonEdit;
            this.buttonEdit.Size = new System.Drawing.Size(99, 59);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Animated = true;
            this.buttonAdd.AutoRoundedCorners = true;
            this.buttonAdd.BorderRadius = 28;
            this.buttonAdd.BorderThickness = 2;
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.DisabledState.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Purple;
            this.buttonAdd.HoverState.Parent = this.buttonAdd;
            this.buttonAdd.Location = new System.Drawing.Point(23, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(99, 59);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(167, 270);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(247, 33);
            this.comboBoxSelectCategory.TabIndex = 15;
            this.comboBoxSelectCategory.Text = "Select Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Animated = true;
            this.textBoxPrice.BorderRadius = 5;
            this.textBoxPrice.BorderThickness = 2;
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.DefaultText = "";
            this.textBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.DisabledState.Parent = this.textBoxPrice;
            this.textBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.FocusedState.Parent = this.textBoxPrice;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.HoverState.Parent = this.textBoxPrice;
            this.textBoxPrice.Location = new System.Drawing.Point(167, 197);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PasswordChar = '\0';
            this.textBoxPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxPrice.PlaceholderText = "Price";
            this.textBoxPrice.SelectedText = "";
            this.textBoxPrice.ShadowDecoration.Parent = this.textBoxPrice;
            this.textBoxPrice.Size = new System.Drawing.Size(247, 42);
            this.textBoxPrice.TabIndex = 13;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(18, 210);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 29);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Price";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Animated = true;
            this.textBoxAmount.BorderRadius = 5;
            this.textBoxAmount.BorderThickness = 2;
            this.textBoxAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAmount.DefaultText = "";
            this.textBoxAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAmount.DisabledState.Parent = this.textBoxAmount;
            this.textBoxAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAmount.FocusedState.Parent = this.textBoxAmount;
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAmount.HoverState.Parent = this.textBoxAmount;
            this.textBoxAmount.Location = new System.Drawing.Point(167, 135);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.PasswordChar = '\0';
            this.textBoxAmount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxAmount.PlaceholderText = "Amount";
            this.textBoxAmount.SelectedText = "";
            this.textBoxAmount.ShadowDecoration.Parent = this.textBoxAmount;
            this.textBoxAmount.Size = new System.Drawing.Size(247, 42);
            this.textBoxAmount.TabIndex = 11;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(18, 148);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(100, 29);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxID
            // 
            this.textBoxID.Animated = true;
            this.textBoxID.BorderRadius = 5;
            this.textBoxID.BorderThickness = 2;
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxID.DefaultText = "";
            this.textBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.DisabledState.Parent = this.textBoxID;
            this.textBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.FocusedState.Parent = this.textBoxID;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.HoverState.Parent = this.textBoxID;
            this.textBoxID.Location = new System.Drawing.Point(167, 21);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxID.PlaceholderText = "ID";
            this.textBoxID.SelectedText = "";
            this.textBoxID.ShadowDecoration.Parent = this.textBoxID;
            this.textBoxID.Size = new System.Drawing.Size(247, 42);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Animated = true;
            this.textBoxName.BorderRadius = 5;
            this.textBoxName.BorderThickness = 2;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.Parent = this.textBoxName;
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedState.Parent = this.textBoxName;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoverState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(167, 76);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(247, 42);
            this.textBoxName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(18, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 29);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(18, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(38, 29);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(1170, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 17);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelManageProducts
            // 
            this.labelManageProducts.AutoSize = true;
            this.labelManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManageProducts.Location = new System.Drawing.Point(924, 63);
            this.labelManageProducts.Name = "labelManageProducts";
            this.labelManageProducts.Size = new System.Drawing.Size(264, 36);
            this.labelManageProducts.TabIndex = 13;
            this.labelManageProducts.Text = "Manage Products";
            // 
            // labelSelling
            // 
            this.labelSelling.AutoSize = true;
            this.labelSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelling.Location = new System.Drawing.Point(316, 23);
            this.labelSelling.Name = "labelSelling";
            this.labelSelling.Size = new System.Drawing.Size(113, 36);
            this.labelSelling.TabIndex = 20;
            this.labelSelling.Text = "Selling";
            this.labelSelling.Click += new System.EventHandler(this.labelSelling_Click);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategories.Location = new System.Drawing.Point(142, 23);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(168, 36);
            this.labelCategories.TabIndex = 19;
            this.labelCategories.Text = "Categories";
            this.labelCategories.Click += new System.EventHandler(this.labelCategories_Click);
            // 
            // labelSellers
            // 
            this.labelSellers.AutoSize = true;
            this.labelSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellers.Location = new System.Drawing.Point(23, 23);
            this.labelSellers.Name = "labelSellers";
            this.labelSellers.Size = new System.Drawing.Size(113, 36);
            this.labelSellers.TabIndex = 18;
            this.labelSellers.Text = "Sellers";
            this.labelSellers.Click += new System.EventHandler(this.labelSellers_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 722);
            this.Controls.Add(this.labelSelling);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.labelSellers);
            this.Controls.Add(this.labelManageProducts);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private Guna.UI2.WinForms.Guna2TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxSelectCatShow;
        private Guna.UI2.WinForms.Guna2Button buttonShow;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelManageProducts;
        private System.Windows.Forms.Label labelSelling;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelSellers;
    }
}