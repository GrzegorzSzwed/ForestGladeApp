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
            this.tbLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flwListServices = new System.Windows.Forms.FlowLayoutPanel();
            this.flwChapters = new System.Windows.Forms.FlowLayoutPanel();
            this.flwFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnWeddingNuptials = new System.Windows.Forms.Button();
            this.btnWeddingLunch = new System.Windows.Forms.Button();
            this.btnWeddingTapas = new System.Windows.Forms.Button();
            this.btnWeddingFirstSupper = new System.Windows.Forms.Button();
            this.btnWeddingSecondSupper = new System.Windows.Forms.Button();
            this.btnWeddingThirdSupper = new System.Windows.Forms.Button();
            this.btnWeddingDrinks = new System.Windows.Forms.Button();
            this.btnWeddingOther = new System.Windows.Forms.Button();
            this.tbLayout.SuspendLayout();
            this.flwChapters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayout
            // 
            this.tbLayout.ColumnCount = 3;
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout.Controls.Add(this.flwListServices, 2, 1);
            this.tbLayout.Controls.Add(this.flwChapters, 0, 1);
            this.tbLayout.Controls.Add(this.flwFilters, 2, 0);
            this.tbLayout.Controls.Add(this.cmbCategories, 0, 0);
            this.tbLayout.Location = new System.Drawing.Point(29, 18);
            this.tbLayout.Name = "tbLayout";
            this.tbLayout.RowCount = 2;
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout.Size = new System.Drawing.Size(968, 530);
            this.tbLayout.TabIndex = 0;
            // 
            // flwListServices
            // 
            this.flwListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwListServices.Location = new System.Drawing.Point(430, 50);
            this.flwListServices.Margin = new System.Windows.Forms.Padding(0);
            this.flwListServices.Name = "flwListServices";
            this.flwListServices.Size = new System.Drawing.Size(538, 480);
            this.flwListServices.TabIndex = 0;
            // 
            // flwChapters
            // 
            this.flwChapters.Controls.Add(this.btnWeddingNuptials);
            this.flwChapters.Controls.Add(this.btnWeddingLunch);
            this.flwChapters.Controls.Add(this.btnWeddingTapas);
            this.flwChapters.Controls.Add(this.btnWeddingFirstSupper);
            this.flwChapters.Controls.Add(this.btnWeddingSecondSupper);
            this.flwChapters.Controls.Add(this.btnWeddingThirdSupper);
            this.flwChapters.Controls.Add(this.btnWeddingDrinks);
            this.flwChapters.Controls.Add(this.btnWeddingOther);
            this.flwChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwChapters.Location = new System.Drawing.Point(0, 50);
            this.flwChapters.Margin = new System.Windows.Forms.Padding(0);
            this.flwChapters.Name = "flwChapters";
            this.flwChapters.Size = new System.Drawing.Size(400, 480);
            this.flwChapters.TabIndex = 1;
            // 
            // flwFilters
            // 
            this.flwFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwFilters.Location = new System.Drawing.Point(430, 0);
            this.flwFilters.Margin = new System.Windows.Forms.Padding(0);
            this.flwFilters.Name = "flwFilters";
            this.flwFilters.Size = new System.Drawing.Size(538, 50);
            this.flwFilters.TabIndex = 2;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Items.AddRange(new object[] {
            "Wesele",
            "Restauracja",
            "Sauna",
            "Domki",
            "Grill",
            "Inne"});
            this.cmbCategories.Location = new System.Drawing.Point(3, 12);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(394, 31);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.CmbCategories_SelectedIndexChanged);
            // 
            // btnWeddingNuptials
            // 
            this.btnWeddingNuptials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingNuptials.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingNuptials.Location = new System.Drawing.Point(3, 3);
            this.btnWeddingNuptials.Name = "btnWeddingNuptials";
            this.btnWeddingNuptials.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingNuptials.TabIndex = 0;
            this.btnWeddingNuptials.Text = "zaręczyny";
            this.btnWeddingNuptials.UseVisualStyleBackColor = true;
            // 
            // btnWeddingLunch
            // 
            this.btnWeddingLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingLunch.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingLunch.Location = new System.Drawing.Point(3, 41);
            this.btnWeddingLunch.Name = "btnWeddingLunch";
            this.btnWeddingLunch.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingLunch.TabIndex = 1;
            this.btnWeddingLunch.Text = "obiad";
            this.btnWeddingLunch.UseVisualStyleBackColor = true;
            this.btnWeddingLunch.Click += new System.EventHandler(this.BtnWeddingLunch_Click);
            // 
            // btnWeddingTapas
            // 
            this.btnWeddingTapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingTapas.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingTapas.Location = new System.Drawing.Point(3, 79);
            this.btnWeddingTapas.Name = "btnWeddingTapas";
            this.btnWeddingTapas.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingTapas.TabIndex = 2;
            this.btnWeddingTapas.Text = "zimna płyta";
            this.btnWeddingTapas.UseVisualStyleBackColor = true;
            // 
            // btnWeddingFirstSupper
            // 
            this.btnWeddingFirstSupper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingFirstSupper.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingFirstSupper.Location = new System.Drawing.Point(3, 117);
            this.btnWeddingFirstSupper.Name = "btnWeddingFirstSupper";
            this.btnWeddingFirstSupper.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingFirstSupper.TabIndex = 3;
            this.btnWeddingFirstSupper.Text = "pierwsza kolacja";
            this.btnWeddingFirstSupper.UseVisualStyleBackColor = true;
            // 
            // btnWeddingSecondSupper
            // 
            this.btnWeddingSecondSupper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingSecondSupper.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingSecondSupper.Location = new System.Drawing.Point(3, 155);
            this.btnWeddingSecondSupper.Name = "btnWeddingSecondSupper";
            this.btnWeddingSecondSupper.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingSecondSupper.TabIndex = 4;
            this.btnWeddingSecondSupper.Text = "druga kolacja";
            this.btnWeddingSecondSupper.UseVisualStyleBackColor = true;
            // 
            // btnWeddingThirdSupper
            // 
            this.btnWeddingThirdSupper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingThirdSupper.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingThirdSupper.Location = new System.Drawing.Point(3, 193);
            this.btnWeddingThirdSupper.Name = "btnWeddingThirdSupper";
            this.btnWeddingThirdSupper.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingThirdSupper.TabIndex = 5;
            this.btnWeddingThirdSupper.Text = "pożegnalna kolacja";
            this.btnWeddingThirdSupper.UseVisualStyleBackColor = true;
            // 
            // btnWeddingDrinks
            // 
            this.btnWeddingDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingDrinks.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingDrinks.Location = new System.Drawing.Point(3, 231);
            this.btnWeddingDrinks.Name = "btnWeddingDrinks";
            this.btnWeddingDrinks.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingDrinks.TabIndex = 6;
            this.btnWeddingDrinks.Text = "napoje";
            this.btnWeddingDrinks.UseVisualStyleBackColor = true;
            // 
            // btnWeddingOther
            // 
            this.btnWeddingOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeddingOther.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeddingOther.Location = new System.Drawing.Point(3, 269);
            this.btnWeddingOther.Name = "btnWeddingOther";
            this.btnWeddingOther.Size = new System.Drawing.Size(361, 32);
            this.btnWeddingOther.TabIndex = 7;
            this.btnWeddingOther.Text = "dodatkowe usługi";
            this.btnWeddingOther.UseVisualStyleBackColor = true;
            // 
            // CntrlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbLayout);
            this.Name = "CntrlOrder";
            this.Size = new System.Drawing.Size(1150, 656);
            this.tbLayout.ResumeLayout(false);
            this.flwChapters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLayout;
        private System.Windows.Forms.FlowLayoutPanel flwListServices;
        private System.Windows.Forms.FlowLayoutPanel flwChapters;
        private System.Windows.Forms.FlowLayoutPanel flwFilters;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnWeddingNuptials;
        private System.Windows.Forms.Button btnWeddingLunch;
        private System.Windows.Forms.Button btnWeddingTapas;
        private System.Windows.Forms.Button btnWeddingFirstSupper;
        private System.Windows.Forms.Button btnWeddingSecondSupper;
        private System.Windows.Forms.Button btnWeddingThirdSupper;
        private System.Windows.Forms.Button btnWeddingDrinks;
        private System.Windows.Forms.Button btnWeddingOther;
    }
}
