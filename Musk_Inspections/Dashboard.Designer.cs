namespace Musk_Inspections
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOpenCreateReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.lblInspector = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.tbInspector = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(20, 24);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOpenCreateReport
            // 
            this.btnOpenCreateReport.Location = new System.Drawing.Point(96, 24);
            this.btnOpenCreateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCreateReport.Name = "btnOpenCreateReport";
            this.btnOpenCreateReport.Size = new System.Drawing.Size(56, 23);
            this.btnOpenCreateReport.TabIndex = 1;
            this.btnOpenCreateReport.Text = "Report";
            this.btnOpenCreateReport.UseVisualStyleBackColor = true;
            this.btnOpenCreateReport.Click += new System.EventHandler(this.btnOpenCreateReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 6);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(866, 24);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(52, 23);
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Text = "Log off";
            this.btnLogOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // cbMonths
            // 
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonths.Location = new System.Drawing.Point(579, 117);
            this.cbMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(92, 21);
            this.cbMonths.TabIndex = 5;
            // 
            // lblInspector
            // 
            this.lblInspector.AutoSize = true;
            this.lblInspector.Location = new System.Drawing.Point(279, 118);
            this.lblInspector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(51, 13);
            this.lblInspector.TabIndex = 7;
            this.lblInspector.Text = "Inspector";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(546, 119);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(68, 119);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 10;
            this.lblSite.Text = "Site";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(813, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(684, 119);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(98, 116);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(176, 20);
            this.tbSite.TabIndex = 13;
            // 
            // tbInspector
            // 
            this.tbInspector.Location = new System.Drawing.Point(335, 117);
            this.tbInspector.Name = "tbInspector";
            this.tbInspector.Size = new System.Drawing.Size(197, 20);
            this.tbInspector.TabIndex = 14;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(20, 150);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(883, 266);
            this.dgv.TabIndex = 15;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 558);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tbInspector);
            this.Controls.Add(this.tbSite);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInspector);
            this.Controls.Add(this.cbMonths);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenCreateReport);
            this.Controls.Add(this.btnHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOpenCreateReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.Label lblInspector;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.TextBox tbInspector;
        private System.Windows.Forms.DataGridView dgv;
    }
}