namespace Musk_Inspections
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.addUser = new System.Windows.Forms.Button();
            this.removeUser = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.viewPdf = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.HeaderUsers = new System.Windows.Forms.Label();
            this.HeaderDocs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.IndianRed;
            this.addUser.Location = new System.Drawing.Point(12, 90);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(247, 38);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // removeUser
            // 
            this.removeUser.BackColor = System.Drawing.Color.IndianRed;
            this.removeUser.Location = new System.Drawing.Point(12, 134);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(247, 38);
            this.removeUser.TabIndex = 1;
            this.removeUser.Text = "Remove User";
            this.removeUser.UseVisualStyleBackColor = false;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // editUser
            // 
            this.editUser.BackColor = System.Drawing.Color.IndianRed;
            this.editUser.Location = new System.Drawing.Point(12, 178);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(247, 38);
            this.editUser.TabIndex = 2;
            this.editUser.Text = "Edit User";
            this.editUser.UseVisualStyleBackColor = false;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // viewPdf
            // 
            this.viewPdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewPdf.Location = new System.Drawing.Point(12, 272);
            this.viewPdf.Name = "viewPdf";
            this.viewPdf.Size = new System.Drawing.Size(247, 38);
            this.viewPdf.TabIndex = 5;
            this.viewPdf.Text = "View PDF";
            this.viewPdf.UseVisualStyleBackColor = false;
            this.viewPdf.Click += new System.EventHandler(this.viewPdf_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(162, 316);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(96, 25);
            this.logout.TabIndex = 6;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(75, 20);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(118, 24);
            this.Header.TabIndex = 7;
            this.Header.Text = "Admin Panel";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderUsers
            // 
            this.HeaderUsers.AutoSize = true;
            this.HeaderUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderUsers.Location = new System.Drawing.Point(12, 63);
            this.HeaderUsers.Name = "HeaderUsers";
            this.HeaderUsers.Size = new System.Drawing.Size(63, 24);
            this.HeaderUsers.TabIndex = 8;
            this.HeaderUsers.Text = "Users:";
            this.HeaderUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderDocs
            // 
            this.HeaderDocs.AutoSize = true;
            this.HeaderDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderDocs.Location = new System.Drawing.Point(12, 245);
            this.HeaderDocs.Name = "HeaderDocs";
            this.HeaderDocs.Size = new System.Drawing.Size(111, 24);
            this.HeaderDocs.TabIndex = 9;
            this.HeaderDocs.Text = "Documents:";
            this.HeaderDocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Musk_Inspections.Properties.Resources.Musk_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeaderDocs);
            this.Controls.Add(this.HeaderUsers);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.viewPdf);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.removeUser);
            this.Controls.Add(this.addUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button removeUser;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Button viewPdf;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label HeaderUsers;
        private System.Windows.Forms.Label HeaderDocs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}