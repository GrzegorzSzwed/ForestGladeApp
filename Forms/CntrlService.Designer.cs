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
            this.cntrlServicePanel = new System.Windows.Forms.Panel();
            this.btnEditService = new System.Windows.Forms.Button();
            this.cntrlServiceLblName = new System.Windows.Forms.Label();
            this.cntrlServiceLblCategory = new System.Windows.Forms.Label();
            this.cntrlServiceLblPrize = new System.Windows.Forms.Label();
            this.cntrlServiceZl = new System.Windows.Forms.Label();
            this.cntrlPnlServiceView = new System.Windows.Forms.Panel();
            this.cntrlPnlServiceEdit = new System.Windows.Forms.Panel();
            this.cntrlServicePnlEditService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlTxtName = new System.Windows.Forms.TextBox();
            this.cntrlTxtDiscount = new System.Windows.Forms.TextBox();
            this.cntrlTxtUnit = new System.Windows.Forms.TextBox();
            this.cntrlTxtPrize = new System.Windows.Forms.TextBox();
            this.cntrlTxtCategory = new System.Windows.Forms.TextBox();
            this.cntrlServiceAvailableAmount = new System.Windows.Forms.Label();
            this.cntrlTxtCurrent = new System.Windows.Forms.TextBox();
            this.cntrlTxtCritical = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlServiceImage)).BeginInit();
            this.cntrlServicePanel.SuspendLayout();
            this.cntrlPnlServiceView.SuspendLayout();
            this.cntrlPnlServiceEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntrlServiceImage
            // 
            this.cntrlServiceImage.BackColor = System.Drawing.Color.Silver;
            this.cntrlServiceImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlServiceImage.BackgroundImage")));
            this.cntrlServiceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cntrlServiceImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.cntrlServiceImage.Location = new System.Drawing.Point(0, 0);
            this.cntrlServiceImage.Name = "cntrlServiceImage";
            this.cntrlServiceImage.Size = new System.Drawing.Size(205, 88);
            this.cntrlServiceImage.TabIndex = 0;
            this.cntrlServiceImage.TabStop = false;
            // 
            // cntrlServicePanel
            // 
            this.cntrlServicePanel.BackColor = System.Drawing.Color.Teal;
            this.cntrlServicePanel.Controls.Add(this.btnEditService);
            this.cntrlServicePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cntrlServicePanel.Location = new System.Drawing.Point(0, 88);
            this.cntrlServicePanel.Name = "cntrlServicePanel";
            this.cntrlServicePanel.Size = new System.Drawing.Size(205, 37);
            this.cntrlServicePanel.TabIndex = 1;
            // 
            // btnEditService
            // 
            this.btnEditService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditService.BackColor = System.Drawing.Color.Teal;
            this.btnEditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditService.BackgroundImage")));
            this.btnEditService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditService.FlatAppearance.BorderSize = 0;
            this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditService.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditService.Location = new System.Drawing.Point(163, 2);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(34, 31);
            this.btnEditService.TabIndex = 6;
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // cntrlServiceLblName
            // 
            this.cntrlServiceLblName.AutoSize = true;
            this.cntrlServiceLblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceLblName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cntrlServiceLblName.Location = new System.Drawing.Point(3, 19);
            this.cntrlServiceLblName.Name = "cntrlServiceLblName";
            this.cntrlServiceLblName.Size = new System.Drawing.Size(78, 23);
            this.cntrlServiceLblName.TabIndex = 2;
            this.cntrlServiceLblName.Text = "Nazwa";
            // 
            // cntrlServiceLblCategory
            // 
            this.cntrlServiceLblCategory.AutoSize = true;
            this.cntrlServiceLblCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceLblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cntrlServiceLblCategory.Location = new System.Drawing.Point(3, 54);
            this.cntrlServiceLblCategory.Name = "cntrlServiceLblCategory";
            this.cntrlServiceLblCategory.Size = new System.Drawing.Size(91, 21);
            this.cntrlServiceLblCategory.TabIndex = 3;
            this.cntrlServiceLblCategory.Text = "Kategoria";
            // 
            // cntrlServiceLblPrize
            // 
            this.cntrlServiceLblPrize.AutoSize = true;
            this.cntrlServiceLblPrize.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceLblPrize.ForeColor = System.Drawing.Color.Teal;
            this.cntrlServiceLblPrize.Location = new System.Drawing.Point(39, 158);
            this.cntrlServiceLblPrize.Name = "cntrlServiceLblPrize";
            this.cntrlServiceLblPrize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cntrlServiceLblPrize.Size = new System.Drawing.Size(72, 34);
            this.cntrlServiceLblPrize.TabIndex = 4;
            this.cntrlServiceLblPrize.Text = "000";
            this.cntrlServiceLblPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntrlServiceZl
            // 
            this.cntrlServiceZl.AutoSize = true;
            this.cntrlServiceZl.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceZl.ForeColor = System.Drawing.Color.Teal;
            this.cntrlServiceZl.Location = new System.Drawing.Point(148, 158);
            this.cntrlServiceZl.Name = "cntrlServiceZl";
            this.cntrlServiceZl.Size = new System.Drawing.Size(41, 34);
            this.cntrlServiceZl.TabIndex = 5;
            this.cntrlServiceZl.Text = "zł";
            // 
            // cntrlPnlServiceView
            // 
            this.cntrlPnlServiceView.Controls.Add(this.cntrlServiceAvailableAmount);
            this.cntrlPnlServiceView.Controls.Add(this.cntrlServiceLblName);
            this.cntrlPnlServiceView.Controls.Add(this.cntrlServiceZl);
            this.cntrlPnlServiceView.Controls.Add(this.cntrlServiceLblCategory);
            this.cntrlPnlServiceView.Controls.Add(this.cntrlServiceLblPrize);
            this.cntrlPnlServiceView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cntrlPnlServiceView.Location = new System.Drawing.Point(0, 125);
            this.cntrlPnlServiceView.Name = "cntrlPnlServiceView";
            this.cntrlPnlServiceView.Size = new System.Drawing.Size(205, 210);
            this.cntrlPnlServiceView.TabIndex = 6;
            this.cntrlPnlServiceView.MouseEnter += new System.EventHandler(this.cntrlPnlServiceView_MouseEnter);
            this.cntrlPnlServiceView.MouseLeave += new System.EventHandler(this.cntrlPnlServiceView_MouseLeave);
            // 
            // cntrlPnlServiceEdit
            // 
            this.cntrlPnlServiceEdit.Controls.Add(this.label2);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtCritical);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtCurrent);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlServicePnlEditService);
            this.cntrlPnlServiceEdit.Controls.Add(this.label1);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtName);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtDiscount);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtUnit);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtPrize);
            this.cntrlPnlServiceEdit.Controls.Add(this.cntrlTxtCategory);
            this.cntrlPnlServiceEdit.Location = new System.Drawing.Point(0, 125);
            this.cntrlPnlServiceEdit.Name = "cntrlPnlServiceEdit";
            this.cntrlPnlServiceEdit.Size = new System.Drawing.Size(205, 210);
            this.cntrlPnlServiceEdit.TabIndex = 7;
            // 
            // cntrlServicePnlEditService
            // 
            this.cntrlServicePnlEditService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cntrlServicePnlEditService.BackColor = System.Drawing.Color.White;
            this.cntrlServicePnlEditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlServicePnlEditService.BackgroundImage")));
            this.cntrlServicePnlEditService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cntrlServicePnlEditService.FlatAppearance.BorderSize = 0;
            this.cntrlServicePnlEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cntrlServicePnlEditService.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServicePnlEditService.Location = new System.Drawing.Point(154, 37);
            this.cntrlServicePnlEditService.Name = "cntrlServicePnlEditService";
            this.cntrlServicePnlEditService.Size = new System.Drawing.Size(43, 41);
            this.cntrlServicePnlEditService.TabIndex = 7;
            this.cntrlServicePnlEditService.UseVisualStyleBackColor = false;
            this.cntrlServicePnlEditService.Click += new System.EventHandler(this.cntrlServicePnlEditService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(130, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // cntrlTxtName
            // 
            this.cntrlTxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtName.Location = new System.Drawing.Point(0, 34);
            this.cntrlTxtName.Name = "cntrlTxtName";
            this.cntrlTxtName.Size = new System.Drawing.Size(123, 27);
            this.cntrlTxtName.TabIndex = 6;
            // 
            // cntrlTxtDiscount
            // 
            this.cntrlTxtDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtDiscount.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtDiscount.Location = new System.Drawing.Point(0, 138);
            this.cntrlTxtDiscount.Name = "cntrlTxtDiscount";
            this.cntrlTxtDiscount.Size = new System.Drawing.Size(124, 27);
            this.cntrlTxtDiscount.TabIndex = 11;
            // 
            // cntrlTxtUnit
            // 
            this.cntrlTxtUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtUnit.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtUnit.Location = new System.Drawing.Point(129, 103);
            this.cntrlTxtUnit.Name = "cntrlTxtUnit";
            this.cntrlTxtUnit.Size = new System.Drawing.Size(68, 27);
            this.cntrlTxtUnit.TabIndex = 10;
            // 
            // cntrlTxtPrize
            // 
            this.cntrlTxtPrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtPrize.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtPrize.Location = new System.Drawing.Point(-1, 103);
            this.cntrlTxtPrize.Name = "cntrlTxtPrize";
            this.cntrlTxtPrize.Size = new System.Drawing.Size(124, 27);
            this.cntrlTxtPrize.TabIndex = 8;
            // 
            // cntrlTxtCategory
            // 
            this.cntrlTxtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtCategory.Location = new System.Drawing.Point(-1, 70);
            this.cntrlTxtCategory.Name = "cntrlTxtCategory";
            this.cntrlTxtCategory.Size = new System.Drawing.Size(124, 27);
            this.cntrlTxtCategory.TabIndex = 7;
            // 
            // cntrlServiceAvailableAmount
            // 
            this.cntrlServiceAvailableAmount.AutoSize = true;
            this.cntrlServiceAvailableAmount.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlServiceAvailableAmount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cntrlServiceAvailableAmount.Location = new System.Drawing.Point(3, 90);
            this.cntrlServiceAvailableAmount.Name = "cntrlServiceAvailableAmount";
            this.cntrlServiceAvailableAmount.Size = new System.Drawing.Size(89, 21);
            this.cntrlServiceAvailableAmount.TabIndex = 6;
            this.cntrlServiceAvailableAmount.Text = "Dostępne";
            // 
            // cntrlTxtCurrent
            // 
            this.cntrlTxtCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtCurrent.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtCurrent.Location = new System.Drawing.Point(26, 175);
            this.cntrlTxtCurrent.Name = "cntrlTxtCurrent";
            this.cntrlTxtCurrent.Size = new System.Drawing.Size(55, 27);
            this.cntrlTxtCurrent.TabIndex = 12;
            // 
            // cntrlTxtCritical
            // 
            this.cntrlTxtCritical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlTxtCritical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlTxtCritical.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlTxtCritical.Location = new System.Drawing.Point(124, 175);
            this.cntrlTxtCritical.Name = "cntrlTxtCritical";
            this.cntrlTxtCritical.Size = new System.Drawing.Size(58, 27);
            this.cntrlTxtCritical.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(87, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // CntrlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cntrlServicePanel);
            this.Controls.Add(this.cntrlServiceImage);
            this.Controls.Add(this.cntrlPnlServiceView);
            this.Controls.Add(this.cntrlPnlServiceEdit);
            this.Name = "CntrlService";
            this.Size = new System.Drawing.Size(205, 335);
            ((System.ComponentModel.ISupportInitialize)(this.cntrlServiceImage)).EndInit();
            this.cntrlServicePanel.ResumeLayout(false);
            this.cntrlPnlServiceView.ResumeLayout(false);
            this.cntrlPnlServiceView.PerformLayout();
            this.cntrlPnlServiceEdit.ResumeLayout(false);
            this.cntrlPnlServiceEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cntrlServiceImage;
        private System.Windows.Forms.Panel cntrlServicePanel;
        private System.Windows.Forms.Label cntrlServiceLblName;
        private System.Windows.Forms.Label cntrlServiceLblCategory;
        private System.Windows.Forms.Label cntrlServiceLblPrize;
        private System.Windows.Forms.Label cntrlServiceZl;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Panel cntrlPnlServiceView;
        private System.Windows.Forms.Panel cntrlPnlServiceEdit;
        private System.Windows.Forms.TextBox cntrlTxtName;
        private System.Windows.Forms.Button cntrlServicePnlEditService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cntrlTxtDiscount;
        private System.Windows.Forms.TextBox cntrlTxtUnit;
        private System.Windows.Forms.TextBox cntrlTxtPrize;
        private System.Windows.Forms.TextBox cntrlTxtCategory;
        private System.Windows.Forms.Label cntrlServiceAvailableAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cntrlTxtCritical;
        private System.Windows.Forms.TextBox cntrlTxtCurrent;
    }
}
