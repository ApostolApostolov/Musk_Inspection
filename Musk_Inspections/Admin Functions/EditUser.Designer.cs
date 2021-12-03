namespace Musk_Inspections.Admin_Functions
{
    partial class EditUser
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
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.unText = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.sureCB = new System.Windows.Forms.CheckBox();
            this.pwText = new System.Windows.Forms.TextBox();
            this.lnText = new System.Windows.Forms.TextBox();
            this.fnText = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getUser = new System.Windows.Forms.Button();
            this.showPw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(537, 178);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(126, 26);
            this.accept.TabIndex = 13;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(377, 178);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 26);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // unText
            // 
            this.unText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unText.Location = new System.Drawing.Point(155, 67);
            this.unText.Name = "unText";
            this.unText.Size = new System.Drawing.Size(160, 26);
            this.unText.TabIndex = 11;
            this.unText.TextChanged += new System.EventHandler(this.unText_TextChanged);
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(27, 66);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(116, 25);
            this.fn.TabIndex = 10;
            this.fn.Text = "Username:";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(25, 15);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(143, 33);
            this.Header.TabIndex = 9;
            this.Header.Text = "Edit User:";
            // 
            // sureCB
            // 
            this.sureCB.AutoSize = true;
            this.sureCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureCB.Location = new System.Drawing.Point(503, 131);
            this.sureCB.Name = "sureCB";
            this.sureCB.Size = new System.Drawing.Size(160, 29);
            this.sureCB.TabIndex = 15;
            this.sureCB.Text = "Are You Sure?";
            this.sureCB.UseVisualStyleBackColor = true;
            // 
            // pwText
            // 
            this.pwText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwText.Location = new System.Drawing.Point(500, 99);
            this.pwText.Name = "pwText";
            this.pwText.PasswordChar = '*';
            this.pwText.Size = new System.Drawing.Size(169, 26);
            this.pwText.TabIndex = 21;
            // 
            // lnText
            // 
            this.lnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnText.Location = new System.Drawing.Point(500, 67);
            this.lnText.Name = "lnText";
            this.lnText.Size = new System.Drawing.Size(169, 26);
            this.lnText.TabIndex = 20;
            // 
            // fnText
            // 
            this.fnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnText.Location = new System.Drawing.Point(500, 35);
            this.fnText.Name = "fnText";
            this.fnText.Size = new System.Drawing.Size(169, 26);
            this.fnText.TabIndex = 19;
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(382, 98);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(112, 25);
            this.pw.TabIndex = 18;
            this.pw.Text = "Password:";
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(373, 66);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(121, 25);
            this.ln.TabIndex = 17;
            this.ln.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name:";
            // 
            // getUser
            // 
            this.getUser.Location = new System.Drawing.Point(155, 100);
            this.getUser.Name = "getUser";
            this.getUser.Size = new System.Drawing.Size(160, 23);
            this.getUser.TabIndex = 22;
            this.getUser.Text = "Get User";
            this.getUser.UseVisualStyleBackColor = true;
            this.getUser.Click += new System.EventHandler(this.getUser_Click);
            // 
            // showPw
            // 
            this.showPw.AutoSize = true;
            this.showPw.Location = new System.Drawing.Point(387, 137);
            this.showPw.Name = "showPw";
            this.showPw.Size = new System.Drawing.Size(102, 17);
            this.showPw.TabIndex = 23;
            this.showPw.Text = "Show Password";
            this.showPw.UseVisualStyleBackColor = true;
            this.showPw.CheckedChanged += new System.EventHandler(this.showPw_CheckedChanged);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 219);
            this.Controls.Add(this.showPw);
            this.Controls.Add(this.getUser);
            this.Controls.Add(this.pwText);
            this.Controls.Add(this.lnText);
            this.Controls.Add(this.fnText);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sureCB);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.unText);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.Header);
            this.Name = "EditUser";
            this.Text = "Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox unText;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.CheckBox sureCB;
        private System.Windows.Forms.TextBox pwText;
        private System.Windows.Forms.TextBox lnText;
        private System.Windows.Forms.TextBox fnText;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getUser;
        private System.Windows.Forms.CheckBox showPw;
    }
}