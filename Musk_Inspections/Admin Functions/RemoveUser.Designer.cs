namespace Musk_Inspections.Admin_Functions
{
    partial class RemoveUser
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
            this.un = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.sureCB = new System.Windows.Forms.CheckBox();
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
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.Location = new System.Drawing.Point(27, 66);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(116, 25);
            this.un.TabIndex = 10;
            this.un.Text = "Username:";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(25, 15);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(202, 33);
            this.Header.TabIndex = 9;
            this.Header.Text = "Remove User:";
            // 
            // sureCB
            // 
            this.sureCB.AutoSize = true;
            this.sureCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureCB.Location = new System.Drawing.Point(155, 99);
            this.sureCB.Name = "sureCB";
            this.sureCB.Size = new System.Drawing.Size(160, 29);
            this.sureCB.TabIndex = 14;
            this.sureCB.Text = "Are You Sure?";
            this.sureCB.UseVisualStyleBackColor = true;
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 219);
            this.Controls.Add(this.sureCB);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.unText);
            this.Controls.Add(this.un);
            this.Controls.Add(this.Header);
            this.Name = "RemoveUser";
            this.Text = "Remove User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox unText;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.CheckBox sureCB;
    }
}