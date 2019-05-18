namespace ForestGladeApp.Forms
{
    partial class IngredientCntrlNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientCntrlNew));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblNutries = new System.Windows.Forms.TableLayoutPanel();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnNewIngredient = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbAlegrens = new System.Windows.Forms.CheckedListBox();
            this.tblMain.SuspendLayout();
            this.tblNutries.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblNutries, 0, 6);
            this.tblMain.Controls.Add(this.txtPrize, 0, 3);
            this.tblMain.Controls.Add(this.txtUnit, 0, 2);
            this.tblMain.Controls.Add(this.btnNewIngredient, 0, 0);
            this.tblMain.Controls.Add(this.txtName, 0, 1);
            this.tblMain.Controls.Add(this.cbAlegrens, 0, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(410, 393);
            this.tblMain.TabIndex = 0;
            // 
            // tblNutries
            // 
            this.tblNutries.ColumnCount = 2;
            this.tblNutries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNutries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNutries.Controls.Add(this.txtCarbs, 1, 2);
            this.tblNutries.Controls.Add(this.txtFat, 1, 1);
            this.tblNutries.Controls.Add(this.txtProtein, 1, 0);
            this.tblNutries.Controls.Add(this.label3, 0, 1);
            this.tblNutries.Controls.Add(this.label1, 0, 0);
            this.tblNutries.Controls.Add(this.label2, 0, 2);
            this.tblNutries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNutries.Location = new System.Drawing.Point(0, 296);
            this.tblNutries.Margin = new System.Windows.Forms.Padding(0);
            this.tblNutries.Name = "tblNutries";
            this.tblNutries.RowCount = 3;
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNutries.Size = new System.Drawing.Size(410, 97);
            this.tblNutries.TabIndex = 23;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarbs.BackColor = System.Drawing.Color.White;
            this.txtCarbs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarbs.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCarbs.Location = new System.Drawing.Point(208, 68);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(199, 24);
            this.txtCarbs.TabIndex = 21;
            this.txtCarbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCarbs.TextChanged += new System.EventHandler(this.TxtCarbs_TextChanged);
            // 
            // txtFat
            // 
            this.txtFat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFat.BackColor = System.Drawing.Color.White;
            this.txtFat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFat.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFat.Location = new System.Drawing.Point(208, 36);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(199, 24);
            this.txtFat.TabIndex = 20;
            this.txtFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFat.TextChanged += new System.EventHandler(this.TxtFat_TextChanged);
            // 
            // txtProtein
            // 
            this.txtProtein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProtein.BackColor = System.Drawing.Color.White;
            this.txtProtein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProtein.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProtein.Location = new System.Drawing.Point(208, 4);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(199, 24);
            this.txtProtein.TabIndex = 19;
            this.txtProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProtein.TextChanged += new System.EventHandler(this.TxtProtein_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(60, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tłuszcz [na 100g]";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Białko [na 100g]";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Węglowodany [na 100g]";
            // 
            // txtPrize
            // 
            this.txtPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrize.BackColor = System.Drawing.Color.White;
            this.txtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrize.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrize.Location = new System.Drawing.Point(3, 128);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(404, 24);
            this.txtPrize.TabIndex = 20;
            this.txtPrize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrize.TextChanged += new System.EventHandler(this.TxtPrize_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUnit.Location = new System.Drawing.Point(3, 88);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(404, 24);
            this.txtUnit.TabIndex = 19;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnit.TextChanged += new System.EventHandler(this.TxtUnit_TextChanged);
            // 
            // btnNewIngredient
            // 
            this.btnNewIngredient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewIngredient.BackgroundImage")));
            this.btnNewIngredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewIngredient.FlatAppearance.BorderSize = 0;
            this.btnNewIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewIngredient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewIngredient.Location = new System.Drawing.Point(3, 3);
            this.btnNewIngredient.Name = "btnNewIngredient";
            this.btnNewIngredient.Size = new System.Drawing.Size(401, 34);
            this.btnNewIngredient.TabIndex = 17;
            this.btnNewIngredient.UseVisualStyleBackColor = true;
            this.btnNewIngredient.Click += new System.EventHandler(this.BtnNewIngredient_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(3, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 24);
            this.txtName.TabIndex = 18;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // cbAlegrens
            // 
            this.cbAlegrens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAlegrens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAlegrens.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAlegrens.FormattingEnabled = true;
            this.cbAlegrens.Items.AddRange(new object[] {
            "gluten",
            "jaja kurze",
            "laktoza",
            "orzechy",
            "owoce cytrusowe",
            "ryby i skorupiaki",
            "sezam",
            "soja"});
            this.cbAlegrens.Location = new System.Drawing.Point(0, 200);
            this.cbAlegrens.Margin = new System.Windows.Forms.Padding(0);
            this.cbAlegrens.Name = "cbAlegrens";
            this.cbAlegrens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbAlegrens.Size = new System.Drawing.Size(410, 96);
            this.cbAlegrens.TabIndex = 22;
            this.cbAlegrens.SelectedIndexChanged += new System.EventHandler(this.CbAlegrens_SelectedIndexChanged);
            // 
            // IngredientCntrlNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Name = "IngredientCntrlNew";
            this.Size = new System.Drawing.Size(410, 393);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblNutries.ResumeLayout(false);
            this.tblNutries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnNewIngredient;
        private System.Windows.Forms.TextBox txtPrize;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckedListBox cbAlegrens;
        private System.Windows.Forms.TableLayoutPanel tblNutries;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
