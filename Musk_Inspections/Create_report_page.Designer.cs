namespace Musk_Inspections
{
    partial class Create_report_page
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFormButton = new System.Windows.Forms.Button();
            this.pForms = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Health, Safety, Quality and Enviromental Site Inspection"});
            this.comboBox1.Location = new System.Drawing.Point(97, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // openFormButton
            // 
            this.openFormButton.Location = new System.Drawing.Point(440, 20);
            this.openFormButton.Name = "openFormButton";
            this.openFormButton.Size = new System.Drawing.Size(75, 23);
            this.openFormButton.TabIndex = 2;
            this.openFormButton.Text = "Open";
            this.openFormButton.UseVisualStyleBackColor = true;
            this.openFormButton.Click += new System.EventHandler(this.openFormButton_Click);
            // 
            // pForms
            // 
            this.pForms.AutoScroll = true;
            this.pForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pForms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pForms.Location = new System.Drawing.Point(0, 49);
            this.pForms.Name = "pForms";
            this.pForms.Size = new System.Drawing.Size(1538, 904);
            this.pForms.TabIndex = 3;
            this.pForms.Paint += new System.Windows.Forms.PaintEventHandler(this.pForms_Paint);
            // 
            // Create_report_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 953);
            this.Controls.Add(this.pForms);
            this.Controls.Add(this.openFormButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Create_report_page";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button openFormButton;
        private System.Windows.Forms.Panel pForms;
    }
}