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
            this.components = new System.ComponentModel.Container();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOpenCreateReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InspetionLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.cbInspectors = new System.Windows.Forms.ComboBox();
            this.lblInspector = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inspectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inpectionsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interventionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outstandingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wordfileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDFfileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muskDBDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musk_DBDS = new Musk_Inspections.Musk_DBDS();
            this.inspectionTableAdapter = new Musk_Inspections.Musk_DBDSTableAdapters.InspectionTableAdapter();
            this.inspectorsTableAdapter = new Musk_Inspections.Musk_DBDSTableAdapters.InspectorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muskDBDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musk_DBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(26, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 28);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOpenCreateReport
            // 
            this.btnOpenCreateReport.Location = new System.Drawing.Point(128, 30);
            this.btnOpenCreateReport.Name = "btnOpenCreateReport";
            this.btnOpenCreateReport.Size = new System.Drawing.Size(74, 28);
            this.btnOpenCreateReport.TabIndex = 1;
            this.btnOpenCreateReport.Text = "Report";
            this.btnOpenCreateReport.UseVisualStyleBackColor = true;
            this.btnOpenCreateReport.Click += new System.EventHandler(this.btnOpenCreateReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(1154, 30);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(69, 28);
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Text = "Log off";
            this.btnLogOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inpectionsidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.siteidDataGridViewTextBoxColumn,
            this.workAreaDataGridViewTextBoxColumn,
            this.inspectoridDataGridViewTextBoxColumn,
            this.interventionsDataGridViewTextBoxColumn,
            this.outstandingDataGridViewCheckBoxColumn,
            this.wordfileDataGridViewTextBoxColumn,
            this.pDFfileDataGridViewTextBoxColumn,
            this.InspetionLink});
            this.dataGridView1.DataSource = this.inspectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(95, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 484);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InspetionLink
            // 
            this.InspetionLink.HeaderText = "Inspection";
            this.InspetionLink.Name = "InspetionLink";
            this.InspetionLink.ReadOnly = true;
            this.InspetionLink.Text = "View";
            this.InspetionLink.UseColumnTextForLinkValue = true;
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataMember = "Inspection";
            this.inspectionBindingSource.DataSource = this.muskDBDSBindingSource;
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
            this.cbMonths.Location = new System.Drawing.Point(772, 144);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(121, 24);
            this.cbMonths.TabIndex = 5;
            // 
            // cbInspectors
            // 
            this.cbInspectors.FormattingEnabled = true;
            this.cbInspectors.Location = new System.Drawing.Point(525, 144);
            this.cbInspectors.Name = "cbInspectors";
            this.cbInspectors.Size = new System.Drawing.Size(121, 24);
            this.cbInspectors.TabIndex = 6;
            // 
            // lblInspector
            // 
            this.lblInspector.AutoSize = true;
            this.lblInspector.Location = new System.Drawing.Point(453, 147);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(66, 17);
            this.lblInspector.TabIndex = 7;
            this.lblInspector.Text = "Inspector";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(728, 147);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(266, 144);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(121, 24);
            this.cbSite.TabIndex = 9;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(228, 147);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(32, 17);
            this.lblSite.TabIndex = 10;
            this.lblSite.Text = "Site";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1084, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(912, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // inspectorsBindingSource
            // 
            this.inspectorsBindingSource.DataMember = "Inspectors";
            this.inspectorsBindingSource.DataSource = this.muskDBDSBindingSource;
            // 
            // inpectionsidDataGridViewTextBoxColumn
            // 
            this.inpectionsidDataGridViewTextBoxColumn.DataPropertyName = "Inpections_id";
            this.inpectionsidDataGridViewTextBoxColumn.HeaderText = "Inpections_id";
            this.inpectionsidDataGridViewTextBoxColumn.Name = "inpectionsidDataGridViewTextBoxColumn";
            this.inpectionsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.inpectionsidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteidDataGridViewTextBoxColumn
            // 
            this.siteidDataGridViewTextBoxColumn.DataPropertyName = "Site_id";
            this.siteidDataGridViewTextBoxColumn.HeaderText = "Site_id";
            this.siteidDataGridViewTextBoxColumn.Name = "siteidDataGridViewTextBoxColumn";
            this.siteidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workAreaDataGridViewTextBoxColumn
            // 
            this.workAreaDataGridViewTextBoxColumn.DataPropertyName = "Work_Area";
            this.workAreaDataGridViewTextBoxColumn.HeaderText = "Work_Area";
            this.workAreaDataGridViewTextBoxColumn.Name = "workAreaDataGridViewTextBoxColumn";
            this.workAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectoridDataGridViewTextBoxColumn
            // 
            this.inspectoridDataGridViewTextBoxColumn.DataPropertyName = "Inspector_id";
            this.inspectoridDataGridViewTextBoxColumn.HeaderText = "Inspector_id";
            this.inspectoridDataGridViewTextBoxColumn.Name = "inspectoridDataGridViewTextBoxColumn";
            this.inspectoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interventionsDataGridViewTextBoxColumn
            // 
            this.interventionsDataGridViewTextBoxColumn.DataPropertyName = "Interventions";
            this.interventionsDataGridViewTextBoxColumn.HeaderText = "Interventions";
            this.interventionsDataGridViewTextBoxColumn.Name = "interventionsDataGridViewTextBoxColumn";
            this.interventionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outstandingDataGridViewCheckBoxColumn
            // 
            this.outstandingDataGridViewCheckBoxColumn.DataPropertyName = "Outstanding";
            this.outstandingDataGridViewCheckBoxColumn.HeaderText = "Outstanding";
            this.outstandingDataGridViewCheckBoxColumn.Name = "outstandingDataGridViewCheckBoxColumn";
            this.outstandingDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // wordfileDataGridViewTextBoxColumn
            // 
            this.wordfileDataGridViewTextBoxColumn.DataPropertyName = "Word_file";
            this.wordfileDataGridViewTextBoxColumn.HeaderText = "Word_file";
            this.wordfileDataGridViewTextBoxColumn.Name = "wordfileDataGridViewTextBoxColumn";
            this.wordfileDataGridViewTextBoxColumn.ReadOnly = true;
            this.wordfileDataGridViewTextBoxColumn.Visible = false;
            // 
            // pDFfileDataGridViewTextBoxColumn
            // 
            this.pDFfileDataGridViewTextBoxColumn.DataPropertyName = "PDF_file";
            this.pDFfileDataGridViewTextBoxColumn.HeaderText = "PDF_file";
            this.pDFfileDataGridViewTextBoxColumn.Name = "pDFfileDataGridViewTextBoxColumn";
            this.pDFfileDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDFfileDataGridViewTextBoxColumn.Visible = false;
            // 
            // muskDBDSBindingSource
            // 
            this.muskDBDSBindingSource.DataSource = this.musk_DBDS;
            this.muskDBDSBindingSource.Position = 0;
            // 
            // musk_DBDS
            // 
            this.musk_DBDS.DataSetName = "Musk_DBDS";
            this.musk_DBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspectionTableAdapter
            // 
            this.inspectionTableAdapter.ClearBeforeFill = true;
            // 
            // inspectorsTableAdapter
            // 
            this.inspectorsTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 687);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cbSite);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInspector);
            this.Controls.Add(this.cbInspectors);
            this.Controls.Add(this.cbMonths);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenCreateReport);
            this.Controls.Add(this.btnHome);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muskDBDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musk_DBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOpenCreateReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.ComboBox cbInspectors;
        private System.Windows.Forms.Label lblInspector;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource muskDBDSBindingSource;
        private Musk_DBDS musk_DBDS;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private Musk_DBDSTableAdapters.InspectionTableAdapter inspectionTableAdapter;
        private System.Windows.Forms.BindingSource inspectorsBindingSource;
        private Musk_DBDSTableAdapters.InspectorsTableAdapter inspectorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inpectionsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interventionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outstandingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordfileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDFfileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn InspetionLink;
    }
}