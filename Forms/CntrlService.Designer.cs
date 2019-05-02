namespace ForestGladeApp.Forms
{
    partial class CntrlService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlService));
            this.cntrlServiceImage = new System.Windows.Forms.PictureBox();
            this.btnEditService = new System.Windows.Forms.Button();
            this.cntrlServiceLblName = new System.Windows.Forms.Label();
            this.cntrlServiceLblPrize = new System.Windows.Forms.Label();
            this.cntrlServiceZl = new System.Windows.Forms.Label();
            this.cntrlPnlServiceEdit = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cntrlTxtName = new System.Windows.Forms.TextBox();
            this.cntrlTxtCritical = new System.Windows.Forms.TextBox();
            this.cntrlTxtCategory = new System.Windows.Forms.TextBox();
            this.cntrlTxtCurrent = new System.Windows.Forms.TextBox();
            this.cntrlTxtUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlTxtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cntrlTxtPrize = new System.Windows.Forms.TextBox();
            this.cntrlServicePnlEditService = new System.Windows.Forms.Button();
            this.tblCntrlService = new System.Windows.Forms.TableLayoutPanel();
            this.cntrlServicePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cntrlServicePnlBackground = new System.Windows.Forms.Panel();
            this.cntrlServiceLblDescription = new System.Windows.Forms.Label();
            this.cntrlPnlServiceView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cntrlRtxtDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlServiceImage)).BeginInit();
            this.cntrlPnlServiceEdit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tblCntrlService.SuspendLayout();
            this.cntrlServicePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cntrlServicePnlBackground.SuspendLayout();
            this.cntrlPnlServiceView.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntrlServiceImage
            // 
            this.cntrlServiceImage.BackColor = System.Drawing.Color.Silver;
            this.cntrlServiceImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlServiceImage.BackgroundImage")));
            this.cntrlServiceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cntrlServiceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlServiceImage.Location = new System.Drawing.Point(3, 3);
            this.cntrlServiceImage.Name = "cntrlServiceImage";
            this.cntrlServiceImage.Size = new System.Drawing.Size(94, 94);
            this.cntrlServiceImage.TabIndex = 0;
            this.cntrlServiceImage.TabStop = false;
            // 
            // btnEditService
            // 
            this.btnEditService.BackColor = System.Drawing.Color.Teal;
            this.btnEditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditService.BackgroundImage")));
            this.btnEditService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditService.FlatAppearance.BorderSize = 0;
            this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditService.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditService.Location = new System.Drawing.Point(753, 3);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(44, 94);
            this.btnEditService.TabIndex = 6;
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // cntrlServiceLblName
            // 
            this.cntrlServiceLblName.AutoSize = true;
            this.cntrlServiceLblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceLblName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cntrlServiceLblName.Location = new System.Drawing.Point(3, 0);
            this.cntrlServiceLblName.Name = "cntrlServiceLblName";
            this.cntrlServiceLblName.Size = new System.Drawing.Size(78, 23);
            this.cntrlServiceLblName.TabIndex = 2;
            this.cntrlServiceLblName.Text = "Nazwa";
            // 
            // cntrlServiceLblPrize
            // 
            this.cntrlServiceLblPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cntrlServiceLblPrize.AutoSize = true;
            this.cntrlServiceLblPrize.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceLblPrize.ForeColor = System.Drawing.Color.Teal;
            this.cntrlServiceLblPrize.Location = new System.Drawing.Point(614, 33);
            this.cntrlServiceLblPrize.Name = "cntrlServiceLblPrize";
            this.cntrlServiceLblPrize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cntrlServiceLblPrize.Size = new System.Drawing.Size(72, 34);
            this.cntrlServiceLblPrize.TabIndex = 4;
            this.cntrlServiceLblPrize.Text = "000";
            this.cntrlServiceLblPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntrlServiceZl
            // 
            this.cntrlServiceZl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cntrlServiceZl.AutoSize = true;
            this.cntrlServiceZl.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceZl.ForeColor = System.Drawing.Color.Teal;
            this.cntrlServiceZl.Location = new System.Drawing.Point(704, 33);
            this.cntrlServiceZl.Name = "cntrlServiceZl";
            this.cntrlServiceZl.Size = new System.Drawing.Size(41, 34);
            this.cntrlServiceZl.TabIndex = 5;
            this.cntrlServiceZl.Text = "zł";
            // 
            // cntrlPnlServiceEdit
            // 
            this.cntrlPnlServiceEdit.Controls.Add(this.tableLayoutPanel1);
            this.cntrlPnlServiceEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlPnlServiceEdit.Location = new System.Drawing.Point(0, 0);
            this.cntrlPnlServiceEdit.Name = "cntrlPnlServiceEdit";
            this.cntrlPnlServiceEdit.Size = new System.Drawing.Size(800, 100);
            this.cntrlPnlServiceEdit.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cntrlTxtPrize, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cntrlServicePnlEditService, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(136, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // cntrlTxtName
            // 
            this.cntrlTxtName.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlTxtName.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtName.Location = new System.Drawing.Point(3, 3);
            this.cntrlTxtName.Name = "cntrlTxtName";
            this.cntrlTxtName.Size = new System.Drawing.Size(156, 20);
            this.cntrlTxtName.TabIndex = 6;
            // 
            // cntrlTxtCritical
            // 
            this.cntrlTxtCritical.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtCritical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtCritical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlTxtCritical.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtCritical.Location = new System.Drawing.Point(171, 3);
            this.cntrlTxtCritical.Name = "cntrlTxtCritical";
            this.cntrlTxtCritical.Size = new System.Drawing.Size(114, 20);
            this.cntrlTxtCritical.TabIndex = 13;
            // 
            // cntrlTxtCategory
            // 
            this.cntrlTxtCategory.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlTxtCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtCategory.Location = new System.Drawing.Point(165, 3);
            this.cntrlTxtCategory.Name = "cntrlTxtCategory";
            this.cntrlTxtCategory.Size = new System.Drawing.Size(156, 20);
            this.cntrlTxtCategory.TabIndex = 7;
            // 
            // cntrlTxtCurrent
            // 
            this.cntrlTxtCurrent.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlTxtCurrent.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtCurrent.Location = new System.Drawing.Point(3, 3);
            this.cntrlTxtCurrent.Name = "cntrlTxtCurrent";
            this.cntrlTxtCurrent.Size = new System.Drawing.Size(114, 20);
            this.cntrlTxtCurrent.TabIndex = 12;
            // 
            // cntrlTxtUnit
            // 
            this.cntrlTxtUnit.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlTxtUnit.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtUnit.Location = new System.Drawing.Point(327, 3);
            this.cntrlTxtUnit.Name = "cntrlTxtUnit";
            this.cntrlTxtUnit.Size = new System.Drawing.Size(158, 20);
            this.cntrlTxtUnit.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(436, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // cntrlTxtDiscount
            // 
            this.cntrlTxtDiscount.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlTxtDiscount.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtDiscount.Location = new System.Drawing.Point(291, 3);
            this.cntrlTxtDiscount.Name = "cntrlTxtDiscount";
            this.cntrlTxtDiscount.Size = new System.Drawing.Size(114, 20);
            this.cntrlTxtDiscount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(704, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "zł";
            // 
            // cntrlTxtPrize
            // 
            this.cntrlTxtPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cntrlTxtPrize.BackColor = System.Drawing.Color.Gray;
            this.cntrlTxtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtPrize.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtPrize.Location = new System.Drawing.Point(603, 36);
            this.cntrlTxtPrize.Name = "cntrlTxtPrize";
            this.cntrlTxtPrize.Size = new System.Drawing.Size(94, 27);
            this.cntrlTxtPrize.TabIndex = 8;
            // 
            // cntrlServicePnlEditService
            // 
            this.cntrlServicePnlEditService.BackColor = System.Drawing.Color.White;
            this.cntrlServicePnlEditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlServicePnlEditService.BackgroundImage")));
            this.cntrlServicePnlEditService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cntrlServicePnlEditService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlServicePnlEditService.FlatAppearance.BorderSize = 0;
            this.cntrlServicePnlEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cntrlServicePnlEditService.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServicePnlEditService.Location = new System.Drawing.Point(753, 3);
            this.cntrlServicePnlEditService.Name = "cntrlServicePnlEditService";
            this.cntrlServicePnlEditService.Size = new System.Drawing.Size(44, 94);
            this.cntrlServicePnlEditService.TabIndex = 7;
            this.cntrlServicePnlEditService.UseVisualStyleBackColor = false;
            this.cntrlServicePnlEditService.Click += new System.EventHandler(this.cntrlServicePnlEditService_Click);
            // 
            // tblCntrlService
            // 
            this.tblCntrlService.ColumnCount = 5;
            this.tblCntrlService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCntrlService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCntrlService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCntrlService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCntrlService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCntrlService.Controls.Add(this.cntrlServiceImage, 0, 0);
            this.tblCntrlService.Controls.Add(this.cntrlServicePanel, 1, 0);
            this.tblCntrlService.Controls.Add(this.btnEditService, 4, 0);
            this.tblCntrlService.Controls.Add(this.cntrlServiceZl, 3, 0);
            this.tblCntrlService.Controls.Add(this.cntrlServiceLblPrize, 2, 0);
            this.tblCntrlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCntrlService.Location = new System.Drawing.Point(0, 0);
            this.tblCntrlService.Name = "tblCntrlService";
            this.tblCntrlService.RowCount = 1;
            this.tblCntrlService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCntrlService.Size = new System.Drawing.Size(800, 100);
            this.tblCntrlService.TabIndex = 8;
            // 
            // cntrlServicePanel
            // 
            this.cntrlServicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlServicePanel.Controls.Add(this.tableLayoutPanel2);
            this.cntrlServicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlServicePanel.Location = new System.Drawing.Point(103, 3);
            this.cntrlServicePanel.Name = "cntrlServicePanel";
            this.cntrlServicePanel.Size = new System.Drawing.Size(494, 94);
            this.cntrlServicePanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cntrlServiceLblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cntrlServicePnlBackground, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cntrlServicePnlBackground
            // 
            this.cntrlServicePnlBackground.BackColor = System.Drawing.Color.LightGray;
            this.cntrlServicePnlBackground.Controls.Add(this.cntrlServiceLblDescription);
            this.cntrlServicePnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlServicePnlBackground.Location = new System.Drawing.Point(3, 29);
            this.cntrlServicePnlBackground.Name = "cntrlServicePnlBackground";
            this.cntrlServicePnlBackground.Size = new System.Drawing.Size(488, 62);
            this.cntrlServicePnlBackground.TabIndex = 3;
            this.cntrlServicePnlBackground.MouseEnter += new System.EventHandler(this.cntrlServicePnlBackground_MouseEnter);
            this.cntrlServicePnlBackground.MouseLeave += new System.EventHandler(this.cntrlServicePnlBackground_MouseLeave);
            // 
            // cntrlServiceLblDescription
            // 
            this.cntrlServiceLblDescription.AutoSize = true;
            this.cntrlServiceLblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlServiceLblDescription.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceLblDescription.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cntrlServiceLblDescription.Location = new System.Drawing.Point(0, 0);
            this.cntrlServiceLblDescription.Name = "cntrlServiceLblDescription";
            this.cntrlServiceLblDescription.Size = new System.Drawing.Size(47, 21);
            this.cntrlServiceLblDescription.TabIndex = 3;
            this.cntrlServiceLblDescription.Text = "Opis";
            // 
            // cntrlPnlServiceView
            // 
            this.cntrlPnlServiceView.Controls.Add(this.tblCntrlService);
            this.cntrlPnlServiceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlPnlServiceView.Location = new System.Drawing.Point(0, 0);
            this.cntrlPnlServiceView.Name = "cntrlPnlServiceView";
            this.cntrlPnlServiceView.Size = new System.Drawing.Size(800, 100);
            this.cntrlPnlServiceView.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(494, 94);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.cntrlTxtCategory, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cntrlTxtUnit, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cntrlTxtName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(488, 25);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.cntrlRtxtDescription, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(488, 57);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cntrlTxtDiscount, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.cntrlTxtCurrent, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cntrlTxtCritical, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(482, 20);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // cntrlRtxtDescription
            // 
            this.cntrlRtxtDescription.BackColor = System.Drawing.Color.White;
            this.cntrlRtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlRtxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntrlRtxtDescription.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlRtxtDescription.Location = new System.Drawing.Point(3, 3);
            this.cntrlRtxtDescription.Name = "cntrlRtxtDescription";
            this.cntrlRtxtDescription.Size = new System.Drawing.Size(482, 25);
            this.cntrlRtxtDescription.TabIndex = 1;
            this.cntrlRtxtDescription.Text = "";
            // 
            // CntrlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cntrlPnlServiceView);
            this.Controls.Add(this.cntrlPnlServiceEdit);
            this.Name = "CntrlService";
            this.Size = new System.Drawing.Size(800, 100);
            ((System.ComponentModel.ISupportInitialize)(this.cntrlServiceImage)).EndInit();
            this.cntrlPnlServiceEdit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tblCntrlService.ResumeLayout(false);
            this.tblCntrlService.PerformLayout();
            this.cntrlServicePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.cntrlServicePnlBackground.ResumeLayout(false);
            this.cntrlServicePnlBackground.PerformLayout();
            this.cntrlPnlServiceView.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cntrlServiceImage;
        private System.Windows.Forms.Label cntrlServiceLblName;
        private System.Windows.Forms.Label cntrlServiceLblPrize;
        private System.Windows.Forms.Label cntrlServiceZl;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Panel cntrlPnlServiceEdit;
        private System.Windows.Forms.TextBox cntrlTxtName;
        private System.Windows.Forms.Button cntrlServicePnlEditService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cntrlTxtDiscount;
        private System.Windows.Forms.TextBox cntrlTxtUnit;
        private System.Windows.Forms.TextBox cntrlTxtPrize;
        private System.Windows.Forms.TextBox cntrlTxtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cntrlTxtCritical;
        private System.Windows.Forms.TextBox cntrlTxtCurrent;
        private System.Windows.Forms.TableLayoutPanel tblCntrlService;
        private System.Windows.Forms.Panel cntrlServicePanel;
        private System.Windows.Forms.Panel cntrlPnlServiceView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel cntrlServicePnlBackground;
        private System.Windows.Forms.Label cntrlServiceLblDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RichTextBox cntrlRtxtDescription;
    }
}
