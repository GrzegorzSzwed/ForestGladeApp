namespace ForestGladeApp.Forms
{
    partial class OrderCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCalendar));
            this.CntrlOrderCalendarInitDate = new System.Windows.Forms.MonthCalendar();
            this.CntrlOrderCalendarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CntrlOrderCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.CntrlOrderCalendarCmbCategory = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CntrlOrderCalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CntrlOrderCalendarInitDate
            // 
            this.CntrlOrderCalendarInitDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.CntrlOrderCalendarInitDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlOrderCalendarInitDate.Location = new System.Drawing.Point(7, 107);
            this.CntrlOrderCalendarInitDate.Name = "CntrlOrderCalendarInitDate";
            this.CntrlOrderCalendarInitDate.TabIndex = 0;
            this.CntrlOrderCalendarInitDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CntrlOrderCalendarInitDate_DateSelected);
            // 
            // CntrlOrderCalendarPanel
            // 
            this.CntrlOrderCalendarPanel.BackColor = System.Drawing.Color.Teal;
            this.CntrlOrderCalendarPanel.Controls.Add(this.pictureBox1);
            this.CntrlOrderCalendarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CntrlOrderCalendarPanel.Location = new System.Drawing.Point(0, 0);
            this.CntrlOrderCalendarPanel.Name = "CntrlOrderCalendarPanel";
            this.CntrlOrderCalendarPanel.Size = new System.Drawing.Size(427, 62);
            this.CntrlOrderCalendarPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CntrlOrderCalendarEndDate
            // 
            this.CntrlOrderCalendarEndDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlOrderCalendarEndDate.Location = new System.Drawing.Point(226, 107);
            this.CntrlOrderCalendarEndDate.Name = "CntrlOrderCalendarEndDate";
            this.CntrlOrderCalendarEndDate.TabIndex = 3;
            this.CntrlOrderCalendarEndDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CntrlOrderCalendarEndDate_DateSelected);
            // 
            // CntrlOrderCalendarCmbCategory
            // 
            this.CntrlOrderCalendarCmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CntrlOrderCalendarCmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CntrlOrderCalendarCmbCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlOrderCalendarCmbCategory.FormattingEnabled = true;
            this.CntrlOrderCalendarCmbCategory.Items.AddRange(new object[] {
            "Wesele",
            "Wellness",
            "Sherwood",
            "Domki",
            "Grill i ognisko",
            "Piknik",
            "Inne",
            "Basen",
            "Gastronomia"});
            this.CntrlOrderCalendarCmbCategory.Location = new System.Drawing.Point(152, 333);
            this.CntrlOrderCalendarCmbCategory.Name = "CntrlOrderCalendarCmbCategory";
            this.CntrlOrderCalendarCmbCategory.Size = new System.Drawing.Size(266, 31);
            this.CntrlOrderCalendarCmbCategory.TabIndex = 4;
            this.CntrlOrderCalendarCmbCategory.SelectedIndexChanged += new System.EventHandler(this.CntrlOrderCalendarCmbCategory_SelectedIndexChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStart.Location = new System.Drawing.Point(69, 75);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(59, 23);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(283, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Koniec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategoria";
            // 
            // OrderCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.CntrlOrderCalendarCmbCategory);
            this.Controls.Add(this.CntrlOrderCalendarEndDate);
            this.Controls.Add(this.CntrlOrderCalendarPanel);
            this.Controls.Add(this.CntrlOrderCalendarInitDate);
            this.Name = "OrderCalendar";
            this.Size = new System.Drawing.Size(427, 388);
            this.MouseEnter += new System.EventHandler(this.OrderCalendar_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.OrderCalendar_MouseLeave);
            this.CntrlOrderCalendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CntrlOrderCalendarInitDate;
        private System.Windows.Forms.Panel CntrlOrderCalendarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar CntrlOrderCalendarEndDate;
        private System.Windows.Forms.ComboBox CntrlOrderCalendarCmbCategory;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
