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
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnNewIngredient = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbAlegrens = new System.Windows.Forms.CheckedListBox();
            this.tblNutries = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tblNutries.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.txtPrize, 0, 3);
            this.tblMain.Controls.Add(this.txtUnit, 0, 2);
            this.tblMain.Controls.Add(this.btnNewIngredient, 0, 0);
            this.tblMain.Controls.Add(this.txtName, 0, 1);
            this.tblMain.Controls.Add(this.cbAlegrens, 0, 5);
            this.tblMain.Controls.Add(this.tblNutries, 0, 6);
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
            this.tblMain.Size = new System.Drawing.Size(413, 421);
            this.tblMain.TabIndex = 0;
            // 
            // txtPrize
            // 
            this.txtPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrize.BackColor = System.Drawing.Color.White;
            this.txtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrize.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrize.Location = new System.Drawing.Point(4, 128);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(404, 24);
            this.txtPrize.TabIndex = 20;
            this.txtPrize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPrize_MouseClick);
            this.txtPrize.TextChanged += new System.EventHandler(this.TxtPrize_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUnit.Location = new System.Drawing.Point(4, 88);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(404, 24);
            this.txtUnit.TabIndex = 19;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtUnit_MouseClick);
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
            this.btnNewIngredient.Size = new System.Drawing.Size(407, 34);
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
            this.txtName.Location = new System.Drawing.Point(4, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 24);
            this.txtName.TabIndex = 18;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtName_MouseClick);
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
            this.cbAlegrens.Size = new System.Drawing.Size(413, 110);
            this.cbAlegrens.TabIndex = 22;
            this.cbAlegrens.SelectedIndexChanged += new System.EventHandler(this.CbAlegrens_SelectedIndexChanged);
            // 
            // tblNutries
            // 
            this.tblNutries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblNutries.ColumnCount = 2;
            this.tblNutries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNutries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNutries.Controls.Add(this.label4, 0, 3);
            this.tblNutries.Controls.Add(this.txtCarbs, 1, 2);
            this.tblNutries.Controls.Add(this.txtFat, 1, 1);
            this.tblNutries.Controls.Add(this.txtProtein, 1, 0);
            this.tblNutries.Controls.Add(this.label3, 0, 1);
            this.tblNutries.Controls.Add(this.label1, 0, 0);
            this.tblNutries.Controls.Add(this.label2, 0, 2);
            this.tblNutries.Controls.Add(this.txtCalories, 1, 3);
            this.tblNutries.Location = new System.Drawing.Point(1, 310);
            this.tblNutries.Margin = new System.Windows.Forms.Padding(0);
            this.tblNutries.Name = "tblNutries";
            this.tblNutries.RowCount = 4;
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNutries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNutries.Size = new System.Drawing.Size(410, 111);
            this.tblNutries.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(84, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kcal [na 100g]";
            // 
            // txtCarbs
            // 
            this.txtCarbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarbs.BackColor = System.Drawing.Color.White;
            this.txtCarbs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarbs.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCarbs.Location = new System.Drawing.Point(208, 57);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(199, 24);
            this.txtCarbs.TabIndex = 21;
            this.txtCarbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCarbs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCarbs_MouseClick);
            this.txtCarbs.TextChanged += new System.EventHandler(this.TxtCarbs_TextChanged);
            // 
            // txtFat
            // 
            this.txtFat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFat.BackColor = System.Drawing.Color.White;
            this.txtFat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFat.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFat.Location = new System.Drawing.Point(208, 30);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(199, 24);
            this.txtFat.TabIndex = 20;
            this.txtFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtFat_MouseClick);
            this.txtFat.TextChanged += new System.EventHandler(this.TxtFat_TextChanged);
            // 
            // txtProtein
            // 
            this.txtProtein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProtein.BackColor = System.Drawing.Color.White;
            this.txtProtein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProtein.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProtein.Location = new System.Drawing.Point(208, 3);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(199, 24);
            this.txtProtein.TabIndex = 19;
            this.txtProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProtein.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtProtein_MouseClick);
            this.txtProtein.TextChanged += new System.EventHandler(this.TxtProtein_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(60, 29);
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
            this.label1.Location = new System.Drawing.Point(69, 2);
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
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Węglowodany [na 100g]";
            // 
            // txtCalories
            // 
            this.txtCalories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalories.BackColor = System.Drawing.Color.White;
            this.txtCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalories.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCalories.Location = new System.Drawing.Point(208, 84);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(199, 24);
            this.txtCalories.TabIndex = 23;
            this.txtCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCalories_MouseClick);
            this.txtCalories.TextChanged += new System.EventHandler(this.TxtCalories_TextChanged);
            // 
            // IngredientCntrlNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Name = "IngredientCntrlNew";
            this.Size = new System.Drawing.Size(413, 421);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalories;
    }
}
