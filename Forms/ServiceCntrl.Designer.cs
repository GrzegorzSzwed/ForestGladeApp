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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(69, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa";
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.btnShow, 0, 2);
            this.tblLayout.Controls.Add(this.lblCategory, 0, 1);
            this.tblLayout.Controls.Add(this.lblName, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 3;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout.Size = new System.Drawing.Size(216, 272);
            this.tblLayout.TabIndex = 1;
            this.tblLayout.MouseEnter += new System.EventHandler(this.TblLayout_MouseEnter);
            this.tblLayout.MouseLeave += new System.EventHandler(this.TblLayout_MouseLeave);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.Location = new System.Drawing.Point(60, 177);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 25);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategoria";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Teal;
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(3, 220);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(210, 49);
            this.btnShow.TabIndex = 2;
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // ServiceCntrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblLayout);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 5, 20);
            this.Name = "ServiceCntrl";
            this.Size = new System.Drawing.Size(216, 272);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblCategory;
    }
}
