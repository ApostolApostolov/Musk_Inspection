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
            this.addUser = new System.Windows.Forms.Button();
            this.removeUser = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.listReports = new System.Windows.Forms.Button();
            this.viewDocx = new System.Windows.Forms.Button();
            this.viewPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(12, 12);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(247, 38);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // removeUser
            // 
            this.removeUser.Location = new System.Drawing.Point(12, 56);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(247, 38);
            this.removeUser.TabIndex = 1;
            this.removeUser.Text = "Remove User";
            this.removeUser.UseVisualStyleBackColor = true;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // editUser
            // 
            this.editUser.Location = new System.Drawing.Point(12, 100);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(247, 38);
            this.editUser.TabIndex = 2;
            this.editUser.Text = "Edit User";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // listReports
            // 
            this.listReports.Location = new System.Drawing.Point(12, 144);
            this.listReports.Name = "listReports";
            this.listReports.Size = new System.Drawing.Size(247, 38);
            this.listReports.TabIndex = 3;
            this.listReports.Text = "List Reports";
            this.listReports.UseVisualStyleBackColor = true;
            this.listReports.Click += new System.EventHandler(this.listReports_Click);
            // 
            // viewDocx
            // 
            this.viewDocx.Location = new System.Drawing.Point(12, 188);
            this.viewDocx.Name = "viewDocx";
            this.viewDocx.Size = new System.Drawing.Size(247, 38);
            this.viewDocx.TabIndex = 4;
            this.viewDocx.Text = "View Docx";
            this.viewDocx.UseVisualStyleBackColor = true;
            this.viewDocx.Click += new System.EventHandler(this.viewDocx_Click);
            // 
            // viewPdf
            // 
            this.viewPdf.Location = new System.Drawing.Point(12, 232);
            this.viewPdf.Name = "viewPdf";
            this.viewPdf.Size = new System.Drawing.Size(247, 38);
            this.viewPdf.TabIndex = 5;
            this.viewPdf.Text = "View PDF";
            this.viewPdf.UseVisualStyleBackColor = true;
            this.viewPdf.Click += new System.EventHandler(this.viewPdf_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 284);
            this.Controls.Add(this.viewPdf);
            this.Controls.Add(this.viewDocx);
            this.Controls.Add(this.listReports);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.removeUser);
            this.Controls.Add(this.addUser);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button removeUser;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Button listReports;
        private System.Windows.Forms.Button viewDocx;
        private System.Windows.Forms.Button viewPdf;
    }
}