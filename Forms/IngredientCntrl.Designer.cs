namespace ForestGladeApp.Forms
{
    partial class IngredientCntrl
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLayout.Controls.Add(this.lblUnit, 1, 0);
            this.tblLayout.Controls.Add(this.lblName, 0, 0);
            this.tblLayout.Controls.Add(this.txtCount, 2, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(500, 70);
            this.tblLayout.TabIndex = 0;
            this.tblLayout.MouseEnter += new System.EventHandler(this.TblLayout_MouseEnter);
            this.tblLayout.MouseLeave += new System.EventHandler(this.TblLayout_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(3, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa produktu";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCount.Location = new System.Drawing.Point(403, 23);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(94, 24);
            this.txtCount.TabIndex = 2;
            this.txtCount.Click += new System.EventHandler(this.TxtCount_Click);
            this.txtCount.Leave += new System.EventHandler(this.TxtCount_Leave);
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnit.AutoSize = true;
            this.lblUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnit.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnit.Location = new System.Drawing.Point(310, 23);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(87, 23);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "Jednostka";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IngredientCntrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IngredientCntrl";
            this.Size = new System.Drawing.Size(500, 70);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCount;
    }
}
