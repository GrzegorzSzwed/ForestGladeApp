namespace ForestGladeApp.Forms
{
    partial class ServiceCntrl
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
            this.lblName = new System.Windows.Forms.Label();
            this.pictureService = new System.Windows.Forms.PictureBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.tblServiceControl = new System.Windows.Forms.TableLayoutPanel();
            this.tblCntrlService02 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInterrupt = new System.Windows.Forms.Panel();
            this.cb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureService)).BeginInit();
            this.tblServiceControl.SuspendLayout();
            this.tblCntrlService02.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(15, 5);
            this.lblName.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa";
            // 
            // pictureService
            // 
            this.pictureService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureService.Location = new System.Drawing.Point(474, 3);
            this.pictureService.Name = "pictureService";
            this.pictureService.Size = new System.Drawing.Size(94, 111);
            this.pictureService.TabIndex = 1;
            this.pictureService.TabStop = false;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDescription.Location = new System.Drawing.Point(3, 38);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(445, 76);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            // 
            // tblServiceControl
            // 
            this.tblServiceControl.ColumnCount = 4;
            this.tblServiceControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServiceControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblServiceControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblServiceControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblServiceControl.Controls.Add(this.tblCntrlService02, 0, 0);
            this.tblServiceControl.Controls.Add(this.pictureService, 2, 0);
            this.tblServiceControl.Controls.Add(this.pnlInterrupt, 1, 0);
            this.tblServiceControl.Controls.Add(this.cb, 3, 0);
            this.tblServiceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblServiceControl.Location = new System.Drawing.Point(0, 0);
            this.tblServiceControl.Margin = new System.Windows.Forms.Padding(0);
            this.tblServiceControl.Name = "tblServiceControl";
            this.tblServiceControl.RowCount = 1;
            this.tblServiceControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServiceControl.Size = new System.Drawing.Size(611, 117);
            this.tblServiceControl.TabIndex = 3;
            // 
            // tblCntrlService02
            // 
            this.tblCntrlService02.ColumnCount = 1;
            this.tblCntrlService02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCntrlService02.Controls.Add(this.rtxtDescription, 0, 1);
            this.tblCntrlService02.Controls.Add(this.lblName, 0, 0);
            this.tblCntrlService02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCntrlService02.Location = new System.Drawing.Point(0, 0);
            this.tblCntrlService02.Margin = new System.Windows.Forms.Padding(0);
            this.tblCntrlService02.Name = "tblCntrlService02";
            this.tblCntrlService02.RowCount = 2;
            this.tblCntrlService02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCntrlService02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblCntrlService02.Size = new System.Drawing.Size(451, 117);
            this.tblCntrlService02.TabIndex = 0;
            // 
            // pnlInterrupt
            // 
            this.pnlInterrupt.BackColor = System.Drawing.Color.Teal;
            this.pnlInterrupt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInterrupt.Location = new System.Drawing.Point(451, 0);
            this.pnlInterrupt.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInterrupt.Name = "pnlInterrupt";
            this.pnlInterrupt.Size = new System.Drawing.Size(20, 117);
            this.pnlInterrupt.TabIndex = 2;
            // 
            // cb
            // 
            this.cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(582, 50);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(18, 17);
            this.cb.TabIndex = 3;
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.Cb_CheckedChanged);
            // 
            // ServiceCntrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblServiceControl);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 5, 20);
            this.Name = "ServiceCntrl";
            this.Size = new System.Drawing.Size(611, 117);
            ((System.ComponentModel.ISupportInitialize)(this.pictureService)).EndInit();
            this.tblServiceControl.ResumeLayout(false);
            this.tblServiceControl.PerformLayout();
            this.tblCntrlService02.ResumeLayout(false);
            this.tblCntrlService02.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureService;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TableLayoutPanel tblServiceControl;
        private System.Windows.Forms.TableLayoutPanel tblCntrlService02;
        private System.Windows.Forms.Panel pnlInterrupt;
        private System.Windows.Forms.CheckBox cb;
    }
}
