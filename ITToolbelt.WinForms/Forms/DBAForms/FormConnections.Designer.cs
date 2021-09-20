
namespace ITToolbelt.WinForms.Forms.DBAForms
{
    partial class FormConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnections));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarConnections = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbServerTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUpdateLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMajorVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMinorVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbServerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonColumnSelection = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddMySql = new System.Windows.Forms.Button();
            this.buttonAddMsSql = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonColumnSelection);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAddMySql);
            this.panel1.Controls.Add(this.buttonAddMsSql);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 99);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxConnections
            // 
            this.groupBoxConnections.Controls.Add(this.statusStrip1);
            this.groupBoxConnections.Controls.Add(this.dataGridViewConnections);
            this.groupBoxConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConnections.Location = new System.Drawing.Point(0, 99);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(1050, 489);
            this.groupBoxConnections.TabIndex = 1;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Connections";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarConnections});
            this.statusStrip1.Location = new System.Drawing.Point(3, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1044, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBarConnections
            // 
            this.toolStripProgressBarConnections.Name = "toolStripProgressBarConnections";
            this.toolStripProgressBarConnections.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarConnections.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // dataGridViewConnections
            // 
            this.dataGridViewConnections.AllowUserToAddRows = false;
            this.dataGridViewConnections.AllowUserToDeleteRows = false;
            this.dataGridViewConnections.AllowUserToOrderColumns = true;
            this.dataGridViewConnections.AutoGenerateColumns = false;
            this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.dbServerTypeCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.serverNameDataGridViewTextBoxColumn,
            this.ınstanceNameDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.productLevelDataGridViewTextBoxColumn,
            this.productUpdateLevelDataGridViewTextBoxColumn,
            this.productVersionDataGridViewTextBoxColumn,
            this.collationDataGridViewTextBoxColumn,
            this.productMajorVersionDataGridViewTextBoxColumn,
            this.productMinorVersionDataGridViewTextBoxColumn,
            this.dbServerTypeDataGridViewTextBoxColumn,
            this.connectionInfoDataGridViewTextBoxColumn});
            this.dataGridViewConnections.DataSource = this.connectionBindingSource;
            this.dataGridViewConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConnections.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewConnections.Name = "dataGridViewConnections";
            this.dataGridViewConnections.ReadOnly = true;
            this.dataGridViewConnections.Size = new System.Drawing.Size(1044, 470);
            this.dataGridViewConnections.TabIndex = 0;
            this.dataGridViewConnections.Tag = "D95F4EAE6C5946C98A1E34E717EEE2AA";
            this.dataGridViewConnections.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewConnections_RowPrePaint);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbServerTypeCodeDataGridViewTextBoxColumn
            // 
            this.dbServerTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "DbServerTypeCode";
            this.dbServerTypeCodeDataGridViewTextBoxColumn.HeaderText = "DB Server Type Code";
            this.dbServerTypeCodeDataGridViewTextBoxColumn.Name = "dbServerTypeCodeDataGridViewTextBoxColumn";
            this.dbServerTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Connection Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionStringDataGridViewTextBoxColumn
            // 
            this.connectionStringDataGridViewTextBoxColumn.DataPropertyName = "ConnectionString";
            this.connectionStringDataGridViewTextBoxColumn.HeaderText = "Connection String";
            this.connectionStringDataGridViewTextBoxColumn.Name = "connectionStringDataGridViewTextBoxColumn";
            this.connectionStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Creation Date";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "Date of update";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "Machine Name";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverNameDataGridViewTextBoxColumn
            // 
            this.serverNameDataGridViewTextBoxColumn.DataPropertyName = "ServerName";
            this.serverNameDataGridViewTextBoxColumn.HeaderText = "Server Name";
            this.serverNameDataGridViewTextBoxColumn.Name = "serverNameDataGridViewTextBoxColumn";
            this.serverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstanceNameDataGridViewTextBoxColumn
            // 
            this.ınstanceNameDataGridViewTextBoxColumn.DataPropertyName = "InstanceName";
            this.ınstanceNameDataGridViewTextBoxColumn.HeaderText = "Instance Name";
            this.ınstanceNameDataGridViewTextBoxColumn.Name = "ınstanceNameDataGridViewTextBoxColumn";
            this.ınstanceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "Edition";
            this.editionDataGridViewTextBoxColumn.HeaderText = "Edition";
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            this.editionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productLevelDataGridViewTextBoxColumn
            // 
            this.productLevelDataGridViewTextBoxColumn.DataPropertyName = "ProductLevel";
            this.productLevelDataGridViewTextBoxColumn.HeaderText = "Product Level";
            this.productLevelDataGridViewTextBoxColumn.Name = "productLevelDataGridViewTextBoxColumn";
            this.productLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productUpdateLevelDataGridViewTextBoxColumn
            // 
            this.productUpdateLevelDataGridViewTextBoxColumn.DataPropertyName = "ProductUpdateLevel";
            this.productUpdateLevelDataGridViewTextBoxColumn.HeaderText = "Product Update Level";
            this.productUpdateLevelDataGridViewTextBoxColumn.Name = "productUpdateLevelDataGridViewTextBoxColumn";
            this.productUpdateLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productVersionDataGridViewTextBoxColumn
            // 
            this.productVersionDataGridViewTextBoxColumn.DataPropertyName = "ProductVersion";
            this.productVersionDataGridViewTextBoxColumn.HeaderText = "Product Version";
            this.productVersionDataGridViewTextBoxColumn.Name = "productVersionDataGridViewTextBoxColumn";
            this.productVersionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collationDataGridViewTextBoxColumn
            // 
            this.collationDataGridViewTextBoxColumn.DataPropertyName = "Collation";
            this.collationDataGridViewTextBoxColumn.HeaderText = "Collation";
            this.collationDataGridViewTextBoxColumn.Name = "collationDataGridViewTextBoxColumn";
            this.collationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productMajorVersionDataGridViewTextBoxColumn
            // 
            this.productMajorVersionDataGridViewTextBoxColumn.DataPropertyName = "ProductMajorVersion";
            this.productMajorVersionDataGridViewTextBoxColumn.HeaderText = "Product Major Version";
            this.productMajorVersionDataGridViewTextBoxColumn.Name = "productMajorVersionDataGridViewTextBoxColumn";
            this.productMajorVersionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productMinorVersionDataGridViewTextBoxColumn
            // 
            this.productMinorVersionDataGridViewTextBoxColumn.DataPropertyName = "ProductMinorVersion";
            this.productMinorVersionDataGridViewTextBoxColumn.HeaderText = "Product Minor Version";
            this.productMinorVersionDataGridViewTextBoxColumn.Name = "productMinorVersionDataGridViewTextBoxColumn";
            this.productMinorVersionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbServerTypeDataGridViewTextBoxColumn
            // 
            this.dbServerTypeDataGridViewTextBoxColumn.DataPropertyName = "DbServerType";
            this.dbServerTypeDataGridViewTextBoxColumn.HeaderText = "DB Server Type";
            this.dbServerTypeDataGridViewTextBoxColumn.Name = "dbServerTypeDataGridViewTextBoxColumn";
            this.dbServerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionInfoDataGridViewTextBoxColumn
            // 
            this.connectionInfoDataGridViewTextBoxColumn.DataPropertyName = "ConnectionInfo";
            this.connectionInfoDataGridViewTextBoxColumn.HeaderText = "Connection Info";
            this.connectionInfoDataGridViewTextBoxColumn.Name = "connectionInfoDataGridViewTextBoxColumn";
            this.connectionInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Connection);
            // 
            // buttonColumnSelection
            // 
            this.buttonColumnSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColumnSelection.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            this.buttonColumnSelection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonColumnSelection.Location = new System.Drawing.Point(882, 12);
            this.buttonColumnSelection.Name = "buttonColumnSelection";
            this.buttonColumnSelection.Size = new System.Drawing.Size(75, 75);
            this.buttonColumnSelection.TabIndex = 0;
            this.buttonColumnSelection.Text = "Column Selection";
            this.buttonColumnSelection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonColumnSelection.UseVisualStyleBackColor = true;
            this.buttonColumnSelection.Click += new System.EventHandler(this.buttonColumnSelection_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = global::ITToolbelt.WinForms.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(963, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 75);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh From Server";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddMySql
            // 
            this.buttonAddMySql.Image = global::ITToolbelt.WinForms.Properties.Resources.MySQL;
            this.buttonAddMySql.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddMySql.Location = new System.Drawing.Point(93, 12);
            this.buttonAddMySql.Name = "buttonAddMySql";
            this.buttonAddMySql.Size = new System.Drawing.Size(75, 75);
            this.buttonAddMySql.TabIndex = 0;
            this.buttonAddMySql.Text = "Add MySQL Connection";
            this.buttonAddMySql.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddMySql.UseVisualStyleBackColor = true;
            this.buttonAddMySql.Click += new System.EventHandler(this.buttonAddMySql_Click);
            // 
            // buttonAddMsSql
            // 
            this.buttonAddMsSql.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddMsSql.Image")));
            this.buttonAddMsSql.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddMsSql.Location = new System.Drawing.Point(12, 12);
            this.buttonAddMsSql.Name = "buttonAddMsSql";
            this.buttonAddMsSql.Size = new System.Drawing.Size(75, 75);
            this.buttonAddMsSql.TabIndex = 0;
            this.buttonAddMsSql.Text = "Add MsSQL Connection";
            this.buttonAddMsSql.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddMsSql.UseVisualStyleBackColor = true;
            this.buttonAddMsSql.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(174, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 75);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Edit Connection";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 588);
            this.Controls.Add(this.groupBoxConnections);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnections";
            this.Text = "Connections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnections_FormClosing);
            this.Load += new System.EventHandler(this.FormConnections_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxConnections.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddMsSql;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.DataGridView dataGridViewConnections;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbServerTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstanceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUpdateLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMajorVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMinorVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbServerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonColumnSelection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarConnections;
        private System.Windows.Forms.Button buttonAddMySql;
        private System.Windows.Forms.Button buttonEdit;
    }
}