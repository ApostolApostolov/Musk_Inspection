namespace Musk_Inspections.Admin_Functions
{
    partial class ViewDocx
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
            this.fnText = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(322, 33);
            this.Header.TabIndex = 1;
            this.Header.Text = "View Report Document:";
            // 
            // fnText
            // 
            this.fnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnText.Location = new System.Drawing.Point(141, 62);
            this.fnText.Name = "fnText";
            this.fnText.Size = new System.Drawing.Size(169, 26);
            this.fnText.TabIndex = 6;
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(13, 61);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(122, 25);
            this.fn.TabIndex = 5;
            this.fn.Text = "First Name:";
            // 
            // ViewDocx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 219);
            this.Controls.Add(this.fnText);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.Header);
            this.Name = "ViewDocx";
            this.Text = "ViewDocx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox fnText;
        private System.Windows.Forms.Label fn;
    }
}