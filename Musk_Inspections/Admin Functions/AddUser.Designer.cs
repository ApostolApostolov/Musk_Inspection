namespace Musk_Inspections.Admin_Functions
{
    partial class AddUser
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
            this.Header = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.fnText = new System.Windows.Forms.TextBox();
            this.lnText = new System.Windows.Forms.TextBox();
            this.pwText = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(144, 33);
            this.Header.TabIndex = 0;
            this.Header.Text = "Add User:";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(14, 60);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(122, 25);
            this.fn.TabIndex = 1;
            this.fn.Text = "First Name:";
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(14, 97);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(121, 25);
            this.ln.TabIndex = 2;
            this.ln.Text = "Last Name:";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(14, 134);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(112, 25);
            this.pw.TabIndex = 3;
            this.pw.Text = "Password:";
            // 
            // fnText
            // 
            this.fnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnText.Location = new System.Drawing.Point(142, 61);
            this.fnText.Name = "fnText";
            this.fnText.Size = new System.Drawing.Size(169, 26);
            this.fnText.TabIndex = 4;
            // 
            // lnText
            // 
            this.lnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnText.Location = new System.Drawing.Point(142, 98);
            this.lnText.Name = "lnText";
            this.lnText.Size = new System.Drawing.Size(169, 26);
            this.lnText.TabIndex = 5;
            // 
            // pwText
            // 
            this.pwText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwText.Location = new System.Drawing.Point(142, 135);
            this.pwText.Name = "pwText";
            this.pwText.Size = new System.Drawing.Size(169, 26);
            this.pwText.TabIndex = 6;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(364, 172);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 26);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(524, 172);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(126, 26);
            this.accept.TabIndex = 8;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheck.Location = new System.Drawing.Point(364, 135);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(188, 24);
            this.adminCheck.TabIndex = 9;
            this.adminCheck.Text = "Is this User an Admin?";
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 219);
            this.Controls.Add(this.adminCheck);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pwText);
            this.Controls.Add(this.lnText);
            this.Controls.Add(this.fnText);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.Header);
            this.Name = "AddUser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox fnText;
        private System.Windows.Forms.TextBox lnText;
        private System.Windows.Forms.TextBox pwText;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.CheckBox adminCheck;
    }
}