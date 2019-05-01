namespace ForestGladeApp.Forms
{
    partial class CntrlUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlUser));
            this.CntrlUserPanelView = new System.Windows.Forms.Panel();
            this.CntrlUserLblName = new System.Windows.Forms.Label();
            this.CntrlUserAvatar = new System.Windows.Forms.PictureBox();
            this.CntrlUserLblSurname = new System.Windows.Forms.Label();
            this.CntrlUserLblMail = new System.Windows.Forms.Label();
            this.CntrlUserLblPermission = new System.Windows.Forms.Label();
            this.CntrlUserLblPhone = new System.Windows.Forms.Label();
            this.CntrlUserPnlEdit = new System.Windows.Forms.Panel();
            this.cntrlUserTxtName = new System.Windows.Forms.TextBox();
            this.CntrlUserTxtSurname = new System.Windows.Forms.TextBox();
            this.CntrlUserTxtMail = new System.Windows.Forms.TextBox();
            this.CntrlUserTxtPhone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CntrlUserCmbPermission = new System.Windows.Forms.ComboBox();
            this.CntrlUserBtnAddUser = new System.Windows.Forms.Button();
            this.CntrlUserAddUser = new System.Windows.Forms.Button();
            this.CntrlUserPanelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CntrlUserAvatar)).BeginInit();
            this.CntrlUserPnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CntrlUserPanelView
            // 
            this.CntrlUserPanelView.BackColor = System.Drawing.Color.Teal;
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserBtnAddUser);
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserLblPhone);
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserLblPermission);
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserLblMail);
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserLblSurname);
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserLblName);
            this.CntrlUserPanelView.Controls.Add(this.CntrlUserAvatar);
            this.CntrlUserPanelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CntrlUserPanelView.Location = new System.Drawing.Point(0, 0);
            this.CntrlUserPanelView.Name = "CntrlUserPanelView";
            this.CntrlUserPanelView.Size = new System.Drawing.Size(267, 195);
            this.CntrlUserPanelView.TabIndex = 0;
            // 
            // CntrlUserLblName
            // 
            this.CntrlUserLblName.AutoSize = true;
            this.CntrlUserLblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserLblName.Location = new System.Drawing.Point(98, 18);
            this.CntrlUserLblName.Name = "CntrlUserLblName";
            this.CntrlUserLblName.Size = new System.Drawing.Size(46, 21);
            this.CntrlUserLblName.TabIndex = 1;
            this.CntrlUserLblName.Text = "Imię";
            this.CntrlUserLblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CntrlUserAvatar
            // 
            this.CntrlUserAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CntrlUserAvatar.BackgroundImage")));
            this.CntrlUserAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CntrlUserAvatar.Location = new System.Drawing.Point(0, 0);
            this.CntrlUserAvatar.Name = "CntrlUserAvatar";
            this.CntrlUserAvatar.Size = new System.Drawing.Size(92, 78);
            this.CntrlUserAvatar.TabIndex = 0;
            this.CntrlUserAvatar.TabStop = false;
            // 
            // CntrlUserLblSurname
            // 
            this.CntrlUserLblSurname.AutoSize = true;
            this.CntrlUserLblSurname.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserLblSurname.Location = new System.Drawing.Point(98, 39);
            this.CntrlUserLblSurname.Name = "CntrlUserLblSurname";
            this.CntrlUserLblSurname.Size = new System.Drawing.Size(110, 23);
            this.CntrlUserLblSurname.TabIndex = 2;
            this.CntrlUserLblSurname.Text = "Nazwisko";
            this.CntrlUserLblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CntrlUserLblMail
            // 
            this.CntrlUserLblMail.AutoSize = true;
            this.CntrlUserLblMail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserLblMail.Location = new System.Drawing.Point(3, 90);
            this.CntrlUserLblMail.Name = "CntrlUserLblMail";
            this.CntrlUserLblMail.Size = new System.Drawing.Size(45, 21);
            this.CntrlUserLblMail.TabIndex = 3;
            this.CntrlUserLblMail.Text = "Mail";
            this.CntrlUserLblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CntrlUserLblPermission
            // 
            this.CntrlUserLblPermission.AutoSize = true;
            this.CntrlUserLblPermission.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserLblPermission.Location = new System.Drawing.Point(3, 120);
            this.CntrlUserLblPermission.Name = "CntrlUserLblPermission";
            this.CntrlUserLblPermission.Size = new System.Drawing.Size(106, 21);
            this.CntrlUserLblPermission.TabIndex = 4;
            this.CntrlUserLblPermission.Text = "Użytkownik";
            this.CntrlUserLblPermission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CntrlUserLblPhone
            // 
            this.CntrlUserLblPhone.AutoSize = true;
            this.CntrlUserLblPhone.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserLblPhone.Location = new System.Drawing.Point(3, 150);
            this.CntrlUserLblPhone.Name = "CntrlUserLblPhone";
            this.CntrlUserLblPhone.Size = new System.Drawing.Size(73, 21);
            this.CntrlUserLblPhone.TabIndex = 5;
            this.CntrlUserLblPhone.Text = "Telefon";
            this.CntrlUserLblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CntrlUserPnlEdit
            // 
            this.CntrlUserPnlEdit.BackColor = System.Drawing.Color.White;
            this.CntrlUserPnlEdit.Controls.Add(this.CntrlUserAddUser);
            this.CntrlUserPnlEdit.Controls.Add(this.CntrlUserCmbPermission);
            this.CntrlUserPnlEdit.Controls.Add(this.pictureBox1);
            this.CntrlUserPnlEdit.Controls.Add(this.CntrlUserTxtPhone);
            this.CntrlUserPnlEdit.Controls.Add(this.CntrlUserTxtMail);
            this.CntrlUserPnlEdit.Controls.Add(this.CntrlUserTxtSurname);
            this.CntrlUserPnlEdit.Controls.Add(this.cntrlUserTxtName);
            this.CntrlUserPnlEdit.Location = new System.Drawing.Point(7, 201);
            this.CntrlUserPnlEdit.Name = "CntrlUserPnlEdit";
            this.CntrlUserPnlEdit.Size = new System.Drawing.Size(245, 198);
            this.CntrlUserPnlEdit.TabIndex = 6;
            // 
            // cntrlUserTxtName
            // 
            this.cntrlUserTxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cntrlUserTxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntrlUserTxtName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlUserTxtName.Location = new System.Drawing.Point(101, 10);
            this.cntrlUserTxtName.Name = "cntrlUserTxtName";
            this.cntrlUserTxtName.Size = new System.Drawing.Size(123, 27);
            this.cntrlUserTxtName.TabIndex = 7;
            // 
            // CntrlUserTxtSurname
            // 
            this.CntrlUserTxtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CntrlUserTxtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CntrlUserTxtSurname.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserTxtSurname.Location = new System.Drawing.Point(101, 43);
            this.CntrlUserTxtSurname.Name = "CntrlUserTxtSurname";
            this.CntrlUserTxtSurname.Size = new System.Drawing.Size(123, 27);
            this.CntrlUserTxtSurname.TabIndex = 8;
            // 
            // CntrlUserTxtMail
            // 
            this.CntrlUserTxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CntrlUserTxtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CntrlUserTxtMail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserTxtMail.Location = new System.Drawing.Point(3, 91);
            this.CntrlUserTxtMail.Name = "CntrlUserTxtMail";
            this.CntrlUserTxtMail.Size = new System.Drawing.Size(147, 27);
            this.CntrlUserTxtMail.TabIndex = 9;
            // 
            // CntrlUserTxtPhone
            // 
            this.CntrlUserTxtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CntrlUserTxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CntrlUserTxtPhone.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserTxtPhone.Location = new System.Drawing.Point(3, 157);
            this.CntrlUserTxtPhone.Name = "CntrlUserTxtPhone";
            this.CntrlUserTxtPhone.Size = new System.Drawing.Size(147, 27);
            this.CntrlUserTxtPhone.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 78);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CntrlUserCmbPermission
            // 
            this.CntrlUserCmbPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CntrlUserCmbPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CntrlUserCmbPermission.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CntrlUserCmbPermission.FormattingEnabled = true;
            this.CntrlUserCmbPermission.Items.AddRange(new object[] {
            "klient",
            "pracownik"});
            this.CntrlUserCmbPermission.Location = new System.Drawing.Point(3, 122);
            this.CntrlUserCmbPermission.Name = "CntrlUserCmbPermission";
            this.CntrlUserCmbPermission.Size = new System.Drawing.Size(168, 29);
            this.CntrlUserCmbPermission.TabIndex = 12;
            // 
            // CntrlUserBtnAddUser
            // 
            this.CntrlUserBtnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CntrlUserBtnAddUser.BackgroundImage")));
            this.CntrlUserBtnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CntrlUserBtnAddUser.FlatAppearance.BorderSize = 0;
            this.CntrlUserBtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CntrlUserBtnAddUser.Location = new System.Drawing.Point(207, 140);
            this.CntrlUserBtnAddUser.Name = "CntrlUserBtnAddUser";
            this.CntrlUserBtnAddUser.Size = new System.Drawing.Size(55, 45);
            this.CntrlUserBtnAddUser.TabIndex = 6;
            this.CntrlUserBtnAddUser.UseVisualStyleBackColor = true;
            this.CntrlUserBtnAddUser.Click += new System.EventHandler(this.CntrlUserBtnAddUser_Click);
            // 
            // CntrlUserAddUser
            // 
            this.CntrlUserAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CntrlUserAddUser.BackgroundImage")));
            this.CntrlUserAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CntrlUserAddUser.FlatAppearance.BorderSize = 0;
            this.CntrlUserAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CntrlUserAddUser.Location = new System.Drawing.Point(192, 157);
            this.CntrlUserAddUser.Name = "CntrlUserAddUser";
            this.CntrlUserAddUser.Size = new System.Drawing.Size(32, 27);
            this.CntrlUserAddUser.TabIndex = 7;
            this.CntrlUserAddUser.UseVisualStyleBackColor = true;
            this.CntrlUserAddUser.Click += new System.EventHandler(this.CntrlUserAddUser_Click);
            // 
            // CntrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CntrlUserPnlEdit);
            this.Controls.Add(this.CntrlUserPanelView);
            this.Name = "CntrlUser";
            this.Size = new System.Drawing.Size(267, 389);
            this.CntrlUserPanelView.ResumeLayout(false);
            this.CntrlUserPanelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CntrlUserAvatar)).EndInit();
            this.CntrlUserPnlEdit.ResumeLayout(false);
            this.CntrlUserPnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CntrlUserPanelView;
        private System.Windows.Forms.Label CntrlUserLblName;
        private System.Windows.Forms.PictureBox CntrlUserAvatar;
        private System.Windows.Forms.Label CntrlUserLblMail;
        private System.Windows.Forms.Label CntrlUserLblSurname;
        private System.Windows.Forms.Label CntrlUserLblPhone;
        private System.Windows.Forms.Label CntrlUserLblPermission;
        private System.Windows.Forms.Panel CntrlUserPnlEdit;
        private System.Windows.Forms.TextBox cntrlUserTxtName;
        private System.Windows.Forms.ComboBox CntrlUserCmbPermission;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CntrlUserTxtPhone;
        private System.Windows.Forms.TextBox CntrlUserTxtMail;
        private System.Windows.Forms.TextBox CntrlUserTxtSurname;
        private System.Windows.Forms.Button CntrlUserBtnAddUser;
        private System.Windows.Forms.Button CntrlUserAddUser;
    }
}
