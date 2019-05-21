namespace ForestGladeApp.Forms
{
    partial class ServiceCntrlMngmt
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceCntrlMngmt));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblImage = new System.Windows.Forms.Label();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flwIngredietns = new System.Windows.Forms.FlowLayoutPanel();
            this.flwMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnListIngredients = new System.Windows.Forms.Button();
            this.btnNewIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flwMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(220, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 20);
            this.txtName.TabIndex = 7;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtName_MouseClick);
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(121, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Promocja:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(161, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ilość:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxtDescription.Location = new System.Drawing.Point(220, 83);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(321, 131);
            this.rtxtDescription.TabIndex = 9;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.TextChanged += new System.EventHandler(this.RtxtDescription_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(157, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cena:";
            // 
            // txtPrize
            // 
            this.txtPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrize.Location = new System.Drawing.Point(220, 267);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(321, 20);
            this.txtPrize.TabIndex = 11;
            this.txtPrize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPrize_MouseClick);
            this.txtPrize.TextChanged += new System.EventHandler(this.TxtPrize_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(118, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Jednostka:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAmount.Location = new System.Drawing.Point(220, 307);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(321, 20);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtAmount_MouseClick);
            this.txtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(162, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Opis:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDiscount.Location = new System.Drawing.Point(220, 347);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(321, 20);
            this.txtDiscount.TabIndex = 13;
            this.txtDiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtDiscount_MouseClick);
            this.txtDiscount.TextChanged += new System.EventHandler(this.TxtDiscount_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(118, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategoria:";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "porcja",
            "sztuka",
            "litr",
            "kilogram",
            "roboczogodzina",
            "godzina"});
            this.cmbUnit.Location = new System.Drawing.Point(220, 223);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(321, 28);
            this.cmbUnit.TabIndex = 10;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.CmbUnit_SelectedIndexChanged);
            this.cmbUnit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmbUnit_MouseClick);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(143, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(328, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(217, 514);
            this.picture.Margin = new System.Windows.Forms.Padding(0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(327, 137);
            this.picture.TabIndex = 16;
            this.picture.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "obiad",
            "deser",
            "zimna płyta",
            "kolacja pierwsza",
            "kolacja druga",
            "kolacja na pożegnanie",
            "zimne napoje",
            "gorące napoje",
            "alkohol",
            "usługi weselne",
            "grill",
            "wellness",
            "domki",
            "inne usługi gastronomiczne",
            "inne"});
            this.cmbCategory.Location = new System.Drawing.Point(220, 46);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(321, 28);
            this.cmbCategory.TabIndex = 8;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);
            this.cmbCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmbCategory_MouseClick);
            // 
            // lblIngredients
            // 
            this.lblIngredients.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIngredients.Location = new System.Drawing.Point(124, 435);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(90, 21);
            this.lblIngredients.TabIndex = 17;
            this.lblIngredients.Text = "Składniki:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblImage, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.picture, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIngredients, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.rtxtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPrize, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbUnit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.listIngredients, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 651);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblImage
            // 
            this.lblImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImage.Location = new System.Drawing.Point(139, 572);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(75, 21);
            this.lblImage.TabIndex = 20;
            this.lblImage.Text = "Zdjęcie:";
            // 
            // listIngredients
            // 
            this.listIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.ItemHeight = 16;
            this.listIngredients.Location = new System.Drawing.Point(217, 377);
            this.listIngredients.Margin = new System.Windows.Forms.Padding(0);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(327, 137);
            this.listIngredients.TabIndex = 21;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblMain.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1089, 651);
            this.tblMain.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flwIngredietns, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flwMenu, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(544, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(545, 651);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // flwIngredietns
            // 
            this.flwIngredietns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwIngredietns.Location = new System.Drawing.Point(0, 50);
            this.flwIngredietns.Margin = new System.Windows.Forms.Padding(0);
            this.flwIngredietns.Name = "flwIngredietns";
            this.flwIngredietns.Size = new System.Drawing.Size(545, 601);
            this.flwIngredietns.TabIndex = 0;
            // 
            // flwMenu
            // 
            this.flwMenu.Controls.Add(this.btnRefresh);
            this.flwMenu.Controls.Add(this.btnListIngredients);
            this.flwMenu.Controls.Add(this.btnNewIngredient);
            this.flwMenu.Controls.Add(this.btnAdd);
            this.flwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwMenu.Location = new System.Drawing.Point(0, 0);
            this.flwMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flwMenu.Name = "flwMenu";
            this.flwMenu.Size = new System.Drawing.Size(545, 50);
            this.flwMenu.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(493, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 44);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnListIngredients
            // 
            this.btnListIngredients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListIngredients.BackgroundImage")));
            this.btnListIngredients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListIngredients.FlatAppearance.BorderSize = 0;
            this.btnListIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnListIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListIngredients.Location = new System.Drawing.Point(438, 3);
            this.btnListIngredients.Name = "btnListIngredients";
            this.btnListIngredients.Size = new System.Drawing.Size(49, 44);
            this.btnListIngredients.TabIndex = 17;
            this.btnListIngredients.UseVisualStyleBackColor = true;
            this.btnListIngredients.Click += new System.EventHandler(this.BtnListIngredients_Click);
            // 
            // btnNewIngredient
            // 
            this.btnNewIngredient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewIngredient.BackgroundImage")));
            this.btnNewIngredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewIngredient.FlatAppearance.BorderSize = 0;
            this.btnNewIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewIngredient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewIngredient.Location = new System.Drawing.Point(383, 3);
            this.btnNewIngredient.Name = "btnNewIngredient";
            this.btnNewIngredient.Size = new System.Drawing.Size(49, 44);
            this.btnNewIngredient.TabIndex = 16;
            this.btnNewIngredient.UseVisualStyleBackColor = true;
            this.btnNewIngredient.Click += new System.EventHandler(this.BtnNewIngredient_Click);
            // 
            // ServiceCntrlMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ServiceCntrlMngmt";
            this.Size = new System.Drawing.Size(1089, 651);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flwMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flwIngredietns;
        private System.Windows.Forms.FlowLayoutPanel flwMenu;
        private System.Windows.Forms.Button btnNewIngredient;
        private System.Windows.Forms.Button btnListIngredients;
        private System.Windows.Forms.Button btnRefresh;
    }
}
