namespace ForestGladeApp.Forms
{
    partial class CntrlOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlOrder));
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flwTimeLine = new System.Windows.Forms.FlowLayoutPanel();
            this.tbServiceList = new System.Windows.Forms.TableLayoutPanel();
            this.flwButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnMigration = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnAdditionalServices = new System.Windows.Forms.Button();
            this.btnGoodbyeDish = new System.Windows.Forms.Button();
            this.btnSupper = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.btnTapas = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnNuptials = new System.Windows.Forms.Button();
            this.flwServicesList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSeparate = new System.Windows.Forms.Panel();
            this.tblLayout.SuspendLayout();
            this.flwTimeLine.SuspendLayout();
            this.tbServiceList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.flwTimeLine, 0, 0);
            this.tblLayout.Controls.Add(this.tbServiceList, 2, 0);
            this.tblLayout.Controls.Add(this.pnlSeparate, 1, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(1150, 656);
            this.tblLayout.TabIndex = 0;
            // 
            // flwTimeLine
            // 
            this.flwTimeLine.AutoScroll = true;
            this.flwTimeLine.BackColor = System.Drawing.Color.White;
            this.flwTimeLine.Controls.Add(this.btnNuptials);
            this.flwTimeLine.Controls.Add(this.btnDinner);
            this.flwTimeLine.Controls.Add(this.btnDessert);
            this.flwTimeLine.Controls.Add(this.btnTapas);
            this.flwTimeLine.Controls.Add(this.btnSoup);
            this.flwTimeLine.Controls.Add(this.btnSupper);
            this.flwTimeLine.Controls.Add(this.btnGoodbyeDish);
            this.flwTimeLine.Controls.Add(this.btnAdditionalServices);
            this.flwTimeLine.Controls.Add(this.btnDrinks);
            this.flwTimeLine.Controls.Add(this.btnTrash);
            this.flwTimeLine.Controls.Add(this.btnMigration);
            this.flwTimeLine.Controls.Add(this.btnSummary);
            this.flwTimeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwTimeLine.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwTimeLine.Location = new System.Drawing.Point(0, 0);
            this.flwTimeLine.Margin = new System.Windows.Forms.Padding(0);
            this.flwTimeLine.Name = "flwTimeLine";
            this.flwTimeLine.Size = new System.Drawing.Size(400, 656);
            this.flwTimeLine.TabIndex = 0;
            this.flwTimeLine.WrapContents = false;
            // 
            // tbServiceList
            // 
            this.tbServiceList.ColumnCount = 1;
            this.tbServiceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbServiceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbServiceList.Controls.Add(this.flwButtons, 0, 0);
            this.tbServiceList.Controls.Add(this.flwServicesList, 0, 1);
            this.tbServiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServiceList.Location = new System.Drawing.Point(420, 0);
            this.tbServiceList.Margin = new System.Windows.Forms.Padding(0);
            this.tbServiceList.Name = "tbServiceList";
            this.tbServiceList.RowCount = 2;
            this.tbServiceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbServiceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbServiceList.Size = new System.Drawing.Size(730, 656);
            this.tbServiceList.TabIndex = 1;
            // 
            // flwButtons
            // 
            this.flwButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwButtons.Location = new System.Drawing.Point(0, 0);
            this.flwButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flwButtons.Name = "flwButtons";
            this.flwButtons.Size = new System.Drawing.Size(730, 50);
            this.flwButtons.TabIndex = 0;
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.Teal;
            this.btnSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnSummary.Image")));
            this.btnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummary.Location = new System.Drawing.Point(3, 509);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(359, 40);
            this.btnSummary.TabIndex = 11;
            this.btnSummary.Text = "Dalej";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnMigration
            // 
            this.btnMigration.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMigration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMigration.BackgroundImage")));
            this.btnMigration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMigration.FlatAppearance.BorderSize = 0;
            this.btnMigration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigration.Location = new System.Drawing.Point(3, 463);
            this.btnMigration.Name = "btnMigration";
            this.btnMigration.Size = new System.Drawing.Size(359, 40);
            this.btnMigration.TabIndex = 10;
            this.btnMigration.UseVisualStyleBackColor = false;
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.Maroon;
            this.btnTrash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrash.BackgroundImage")));
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Location = new System.Drawing.Point(3, 417);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(359, 40);
            this.btnTrash.TabIndex = 9;
            this.btnTrash.UseVisualStyleBackColor = false;
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Silver;
            this.btnDrinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrinks.BackgroundImage")));
            this.btnDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.Location = new System.Drawing.Point(3, 371);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(359, 40);
            this.btnDrinks.TabIndex = 8;
            this.btnDrinks.UseVisualStyleBackColor = false;
            // 
            // btnAdditionalServices
            // 
            this.btnAdditionalServices.BackColor = System.Drawing.Color.Silver;
            this.btnAdditionalServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdditionalServices.BackgroundImage")));
            this.btnAdditionalServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdditionalServices.FlatAppearance.BorderSize = 0;
            this.btnAdditionalServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditionalServices.Location = new System.Drawing.Point(3, 325);
            this.btnAdditionalServices.Name = "btnAdditionalServices";
            this.btnAdditionalServices.Size = new System.Drawing.Size(359, 40);
            this.btnAdditionalServices.TabIndex = 7;
            this.btnAdditionalServices.UseVisualStyleBackColor = false;
            // 
            // btnGoodbyeDish
            // 
            this.btnGoodbyeDish.BackColor = System.Drawing.Color.Silver;
            this.btnGoodbyeDish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoodbyeDish.BackgroundImage")));
            this.btnGoodbyeDish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoodbyeDish.FlatAppearance.BorderSize = 0;
            this.btnGoodbyeDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodbyeDish.Location = new System.Drawing.Point(3, 279);
            this.btnGoodbyeDish.Name = "btnGoodbyeDish";
            this.btnGoodbyeDish.Size = new System.Drawing.Size(359, 40);
            this.btnGoodbyeDish.TabIndex = 6;
            this.btnGoodbyeDish.UseVisualStyleBackColor = false;
            // 
            // btnSupper
            // 
            this.btnSupper.BackColor = System.Drawing.Color.Silver;
            this.btnSupper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupper.BackgroundImage")));
            this.btnSupper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupper.FlatAppearance.BorderSize = 0;
            this.btnSupper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupper.Location = new System.Drawing.Point(3, 233);
            this.btnSupper.Name = "btnSupper";
            this.btnSupper.Size = new System.Drawing.Size(359, 40);
            this.btnSupper.TabIndex = 5;
            this.btnSupper.UseVisualStyleBackColor = false;
            // 
            // btnSoup
            // 
            this.btnSoup.BackColor = System.Drawing.Color.Silver;
            this.btnSoup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoup.BackgroundImage")));
            this.btnSoup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSoup.FlatAppearance.BorderSize = 0;
            this.btnSoup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoup.Location = new System.Drawing.Point(3, 187);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(359, 40);
            this.btnSoup.TabIndex = 4;
            this.btnSoup.UseVisualStyleBackColor = false;
            // 
            // btnTapas
            // 
            this.btnTapas.BackColor = System.Drawing.Color.Silver;
            this.btnTapas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTapas.FlatAppearance.BorderSize = 0;
            this.btnTapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTapas.Image = ((System.Drawing.Image)(resources.GetObject("btnTapas.Image")));
            this.btnTapas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTapas.Location = new System.Drawing.Point(3, 141);
            this.btnTapas.Name = "btnTapas";
            this.btnTapas.Size = new System.Drawing.Size(359, 40);
            this.btnTapas.TabIndex = 3;
            this.btnTapas.Text = "Zimna płyta";
            this.btnTapas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTapas.UseVisualStyleBackColor = false;
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.Silver;
            this.btnDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDessert.FlatAppearance.BorderSize = 0;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDessert.Image = ((System.Drawing.Image)(resources.GetObject("btnDessert.Image")));
            this.btnDessert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDessert.Location = new System.Drawing.Point(3, 95);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(359, 40);
            this.btnDessert.TabIndex = 2;
            this.btnDessert.Text = "Deser";
            this.btnDessert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDessert.UseVisualStyleBackColor = false;
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.Silver;
            this.btnDinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDinner.FlatAppearance.BorderSize = 0;
            this.btnDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinner.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDinner.Image = ((System.Drawing.Image)(resources.GetObject("btnDinner.Image")));
            this.btnDinner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinner.Location = new System.Drawing.Point(3, 49);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(359, 40);
            this.btnDinner.TabIndex = 1;
            this.btnDinner.Text = "Obiad";
            this.btnDinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinner.UseVisualStyleBackColor = false;
            // 
            // btnNuptials
            // 
            this.btnNuptials.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuptials.BackColor = System.Drawing.Color.Silver;
            this.btnNuptials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuptials.FlatAppearance.BorderSize = 0;
            this.btnNuptials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuptials.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNuptials.Image = ((System.Drawing.Image)(resources.GetObject("btnNuptials.Image")));
            this.btnNuptials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuptials.Location = new System.Drawing.Point(3, 3);
            this.btnNuptials.Name = "btnNuptials";
            this.btnNuptials.Size = new System.Drawing.Size(359, 40);
            this.btnNuptials.TabIndex = 0;
            this.btnNuptials.Text = "Zaślubiny";
            this.btnNuptials.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuptials.UseVisualStyleBackColor = false;
            this.btnNuptials.Click += new System.EventHandler(this.BtnNuptials_Click);
            // 
            // flwServicesList
            // 
            this.flwServicesList.AutoScroll = true;
            this.flwServicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwServicesList.Location = new System.Drawing.Point(0, 50);
            this.flwServicesList.Margin = new System.Windows.Forms.Padding(0);
            this.flwServicesList.Name = "flwServicesList";
            this.flwServicesList.Size = new System.Drawing.Size(730, 606);
            this.flwServicesList.TabIndex = 1;
            // 
            // pnlSeparate
            // 
            this.pnlSeparate.BackColor = System.Drawing.Color.Teal;
            this.pnlSeparate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeparate.Location = new System.Drawing.Point(400, 0);
            this.pnlSeparate.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSeparate.Name = "pnlSeparate";
            this.pnlSeparate.Size = new System.Drawing.Size(20, 656);
            this.pnlSeparate.TabIndex = 2;
            // 
            // CntrlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblLayout);
            this.Name = "CntrlOrder";
            this.Size = new System.Drawing.Size(1150, 656);
            this.tblLayout.ResumeLayout(false);
            this.flwTimeLine.ResumeLayout(false);
            this.tbServiceList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.FlowLayoutPanel flwTimeLine;
        private System.Windows.Forms.TableLayoutPanel tbServiceList;
        private System.Windows.Forms.FlowLayoutPanel flwButtons;
        private System.Windows.Forms.FlowLayoutPanel flwServicesList;
        private System.Windows.Forms.Button btnNuptials;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnTapas;
        private System.Windows.Forms.Button btnSoup;
        private System.Windows.Forms.Button btnSupper;
        private System.Windows.Forms.Button btnGoodbyeDish;
        private System.Windows.Forms.Button btnAdditionalServices;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnMigration;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Panel pnlSeparate;
    }
}
