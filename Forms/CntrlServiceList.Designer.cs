namespace ForestGladeApp.Forms
{
    partial class CntrlServiceList
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
            this.LblNameCntrlService = new System.Windows.Forms.Label();
            this.pnlServiceCntrlServiceList = new System.Windows.Forms.Panel();
            this.lblCategoryServiceList = new System.Windows.Forms.Label();
            this.CheckBCntrlServiceList = new System.Windows.Forms.CheckBox();
            this.pnlServiceCntrlServiceList.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNameCntrlService
            // 
            this.LblNameCntrlService.AutoSize = true;
            this.LblNameCntrlService.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblNameCntrlService.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNameCntrlService.Location = new System.Drawing.Point(0, 0);
            this.LblNameCntrlService.Name = "LblNameCntrlService";
            this.LblNameCntrlService.Size = new System.Drawing.Size(53, 17);
            this.LblNameCntrlService.TabIndex = 0;
            this.LblNameCntrlService.Text = "Nazwa";
            // 
            // pnlServiceCntrlServiceList
            // 
            this.pnlServiceCntrlServiceList.BackColor = System.Drawing.Color.LightGray;
            this.pnlServiceCntrlServiceList.Controls.Add(this.lblCategoryServiceList);
            this.pnlServiceCntrlServiceList.Controls.Add(this.LblNameCntrlService);
            this.pnlServiceCntrlServiceList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlServiceCntrlServiceList.Location = new System.Drawing.Point(0, 0);
            this.pnlServiceCntrlServiceList.Name = "pnlServiceCntrlServiceList";
            this.pnlServiceCntrlServiceList.Size = new System.Drawing.Size(285, 23);
            this.pnlServiceCntrlServiceList.TabIndex = 1;
            this.pnlServiceCntrlServiceList.MouseEnter += new System.EventHandler(this.pnlServiceCntrlServiceList_MouseEnter);
            this.pnlServiceCntrlServiceList.MouseLeave += new System.EventHandler(this.pnlServiceCntrlServiceList_MouseLeave);
            // 
            // lblCategoryServiceList
            // 
            this.lblCategoryServiceList.AutoSize = true;
            this.lblCategoryServiceList.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCategoryServiceList.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategoryServiceList.Location = new System.Drawing.Point(211, 0);
            this.lblCategoryServiceList.Name = "lblCategoryServiceList";
            this.lblCategoryServiceList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCategoryServiceList.Size = new System.Drawing.Size(74, 17);
            this.lblCategoryServiceList.TabIndex = 1;
            this.lblCategoryServiceList.Text = "Kategoria";
            // 
            // CheckBCntrlServiceList
            // 
            this.CheckBCntrlServiceList.AutoSize = true;
            this.CheckBCntrlServiceList.BackColor = System.Drawing.Color.LightGray;
            this.CheckBCntrlServiceList.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckBCntrlServiceList.FlatAppearance.BorderSize = 0;
            this.CheckBCntrlServiceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBCntrlServiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBCntrlServiceList.Location = new System.Drawing.Point(318, 0);
            this.CheckBCntrlServiceList.Name = "CheckBCntrlServiceList";
            this.CheckBCntrlServiceList.Size = new System.Drawing.Size(45, 23);
            this.CheckBCntrlServiceList.TabIndex = 2;
            this.CheckBCntrlServiceList.Text = "00";
            this.CheckBCntrlServiceList.UseVisualStyleBackColor = false;
            this.CheckBCntrlServiceList.CheckedChanged += new System.EventHandler(this.CheckBCntrlServiceList_CheckedChanged);
            // 
            // CntrlServiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.CheckBCntrlServiceList);
            this.Controls.Add(this.pnlServiceCntrlServiceList);
            this.Name = "CntrlServiceList";
            this.Size = new System.Drawing.Size(363, 23);
            this.pnlServiceCntrlServiceList.ResumeLayout(false);
            this.pnlServiceCntrlServiceList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNameCntrlService;
        private System.Windows.Forms.Panel pnlServiceCntrlServiceList;
        private System.Windows.Forms.CheckBox CheckBCntrlServiceList;
        private System.Windows.Forms.Label lblCategoryServiceList;
    }
}
