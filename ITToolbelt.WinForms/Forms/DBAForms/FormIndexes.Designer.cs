
namespace ITToolbelt.WinForms.Forms.DBAForms
{
    partial class FormIndexes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndexes));
            this.treeViewConnections = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGetColumns = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxIndex = new System.Windows.Forms.GroupBox();
            this.dataGridViewIndexes = new System.Windows.Forms.DataGridView();
            this.schemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ındexNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fragmantationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxColumns = new System.Windows.Forms.GroupBox();
            this.groupBoxInclude = new System.Windows.Forms.GroupBox();
            this.listViewIncludes = new System.Windows.Forms.ListView();
            this.groupBoxIndexColumns = new System.Windows.Forms.GroupBox();
            this.listViewColumns = new System.Windows.Forms.ListView();
            this.columnHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInclude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBoxIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxColumns.SuspendLayout();
            this.groupBoxInclude.SuspendLayout();
            this.groupBoxIndexColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewConnections
            // 
            this.treeViewConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewConnections.Location = new System.Drawing.Point(3, 16);
            this.treeViewConnections.Name = "treeViewConnections";
            this.treeViewConnections.Size = new System.Drawing.Size(256, 676);
            this.treeViewConnections.TabIndex = 0;
            this.treeViewConnections.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewConnections_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGetColumns);
            this.panel1.Controls.Add(this.buttonDisable);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 99);
            this.panel1.TabIndex = 1;
            // 
            // buttonGetColumns
            // 
            this.buttonGetColumns.Image = global::ITToolbelt.WinForms.Properties.Resources.key;
            this.buttonGetColumns.Location = new System.Drawing.Point(93, 12);
            this.buttonGetColumns.Name = "buttonGetColumns";
            this.buttonGetColumns.Size = new System.Drawing.Size(75, 75);
            this.buttonGetColumns.TabIndex = 1;
            this.buttonGetColumns.Text = "GetColumns";
            this.buttonGetColumns.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGetColumns.UseVisualStyleBackColor = true;
            this.buttonGetColumns.Click += new System.EventHandler(this.buttonGetColumns_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Enabled = false;
            this.buttonDisable.Image = global::ITToolbelt.WinForms.Properties.Resources.block;
            this.buttonDisable.Location = new System.Drawing.Point(12, 12);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(75, 75);
            this.buttonDisable.TabIndex = 1;
            this.buttonDisable.Text = "Set Disable";
            this.buttonDisable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = global::ITToolbelt.WinForms.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(796, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 75);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBoxIndex
            // 
            this.groupBoxIndex.Controls.Add(this.dataGridViewIndexes);
            this.groupBoxIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIndex.Location = new System.Drawing.Point(262, 99);
            this.groupBoxIndex.Name = "groupBoxIndex";
            this.groupBoxIndex.Size = new System.Drawing.Size(574, 574);
            this.groupBoxIndex.TabIndex = 2;
            this.groupBoxIndex.TabStop = false;
            this.groupBoxIndex.Text = "Indexes";
            // 
            // dataGridViewIndexes
            // 
            this.dataGridViewIndexes.AllowUserToAddRows = false;
            this.dataGridViewIndexes.AllowUserToDeleteRows = false;
            this.dataGridViewIndexes.AllowUserToOrderColumns = true;
            this.dataGridViewIndexes.AutoGenerateColumns = false;
            this.dataGridViewIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndexes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schemaDataGridViewTextBoxColumn,
            this.tableDataGridViewTextBoxColumn,
            this.ındexNameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.fragmantationDataGridViewTextBoxColumn,
            this.pageCountDataGridViewTextBoxColumn});
            this.dataGridViewIndexes.DataSource = this.indexBindingSource;
            this.dataGridViewIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIndexes.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIndexes.Name = "dataGridViewIndexes";
            this.dataGridViewIndexes.ReadOnly = true;
            this.dataGridViewIndexes.Size = new System.Drawing.Size(568, 555);
            this.dataGridViewIndexes.TabIndex = 0;
            this.dataGridViewIndexes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewIndexes_DataError);
            this.dataGridViewIndexes.SelectionChanged += new System.EventHandler(this.dataGridViewIndexes_SelectionChanged);
            // 
            // schemaDataGridViewTextBoxColumn
            // 
            this.schemaDataGridViewTextBoxColumn.DataPropertyName = "Schema";
            this.schemaDataGridViewTextBoxColumn.HeaderText = "Schema Name";
            this.schemaDataGridViewTextBoxColumn.Name = "schemaDataGridViewTextBoxColumn";
            this.schemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Table Name";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ındexNameDataGridViewTextBoxColumn
            // 
            this.ındexNameDataGridViewTextBoxColumn.DataPropertyName = "IndexName";
            this.ındexNameDataGridViewTextBoxColumn.HeaderText = "Index Name";
            this.ındexNameDataGridViewTextBoxColumn.Name = "ındexNameDataGridViewTextBoxColumn";
            this.ındexNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fragmantationDataGridViewTextBoxColumn
            // 
            this.fragmantationDataGridViewTextBoxColumn.DataPropertyName = "Fragmantation";
            this.fragmantationDataGridViewTextBoxColumn.HeaderText = "AVG Fragmantation";
            this.fragmantationDataGridViewTextBoxColumn.Name = "fragmantationDataGridViewTextBoxColumn";
            this.fragmantationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageCountDataGridViewTextBoxColumn
            // 
            this.pageCountDataGridViewTextBoxColumn.DataPropertyName = "PageCount";
            this.pageCountDataGridViewTextBoxColumn.HeaderText = "Page Count";
            this.pageCountDataGridViewTextBoxColumn.Name = "pageCountDataGridViewTextBoxColumn";
            this.pageCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexBindingSource
            // 
            this.indexBindingSource.DataSource = typeof(ITToolbelt.Entity.EntityClass.Index);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarStatus});
            this.statusStrip.Location = new System.Drawing.Point(262, 673);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(883, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBarStatus
            // 
            this.toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            this.toolStripProgressBarStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 695);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewConnections);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 695);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections";
            // 
            // groupBoxColumns
            // 
            this.groupBoxColumns.Controls.Add(this.groupBoxInclude);
            this.groupBoxColumns.Controls.Add(this.groupBoxIndexColumns);
            this.groupBoxColumns.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxColumns.Location = new System.Drawing.Point(836, 99);
            this.groupBoxColumns.Name = "groupBoxColumns";
            this.groupBoxColumns.Size = new System.Drawing.Size(309, 574);
            this.groupBoxColumns.TabIndex = 5;
            this.groupBoxColumns.TabStop = false;
            this.groupBoxColumns.Text = "Index Columns";
            // 
            // groupBoxInclude
            // 
            this.groupBoxInclude.Controls.Add(this.listViewIncludes);
            this.groupBoxInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInclude.Location = new System.Drawing.Point(3, 350);
            this.groupBoxInclude.Name = "groupBoxInclude";
            this.groupBoxInclude.Size = new System.Drawing.Size(303, 221);
            this.groupBoxInclude.TabIndex = 1;
            this.groupBoxInclude.TabStop = false;
            this.groupBoxInclude.Text = "Include Columns";
            // 
            // listViewIncludes
            // 
            this.listViewIncludes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInclude,
            this.columnHeaderIType});
            this.listViewIncludes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewIncludes.GridLines = true;
            this.listViewIncludes.HideSelection = false;
            this.listViewIncludes.Location = new System.Drawing.Point(3, 16);
            this.listViewIncludes.Name = "listViewIncludes";
            this.listViewIncludes.Size = new System.Drawing.Size(297, 202);
            this.listViewIncludes.TabIndex = 0;
            this.listViewIncludes.UseCompatibleStateImageBehavior = false;
            this.listViewIncludes.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxIndexColumns
            // 
            this.groupBoxIndexColumns.Controls.Add(this.listViewColumns);
            this.groupBoxIndexColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxIndexColumns.Location = new System.Drawing.Point(3, 16);
            this.groupBoxIndexColumns.Name = "groupBoxIndexColumns";
            this.groupBoxIndexColumns.Size = new System.Drawing.Size(303, 334);
            this.groupBoxIndexColumns.TabIndex = 0;
            this.groupBoxIndexColumns.TabStop = false;
            this.groupBoxIndexColumns.Text = "Columns";
            // 
            // listViewColumns
            // 
            this.listViewColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderColumn,
            this.Sort,
            this.columnHeaderType});
            this.listViewColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewColumns.GridLines = true;
            this.listViewColumns.HideSelection = false;
            this.listViewColumns.Location = new System.Drawing.Point(3, 16);
            this.listViewColumns.Name = "listViewColumns";
            this.listViewColumns.Size = new System.Drawing.Size(297, 315);
            this.listViewColumns.TabIndex = 0;
            this.listViewColumns.UseCompatibleStateImageBehavior = false;
            this.listViewColumns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderColumn
            // 
            this.columnHeaderColumn.Text = "Column";
            this.columnHeaderColumn.Width = 120;
            // 
            // Sort
            // 
            this.Sort.Text = "Sort";
            this.Sort.Width = 80;
            // 
            // columnHeaderInclude
            // 
            this.columnHeaderInclude.Text = "Column";
            this.columnHeaderInclude.Width = 120;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            // 
            // columnHeaderIType
            // 
            this.columnHeaderIType.Text = "Type";
            // 
            // FormIndexes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 695);
            this.Controls.Add(this.groupBoxIndex);
            this.Controls.Add(this.groupBoxColumns);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIndexes";
            this.Text = "Index Manager";
            this.panel1.ResumeLayout(false);
            this.groupBoxIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxColumns.ResumeLayout(false);
            this.groupBoxInclude.ResumeLayout(false);
            this.groupBoxIndexColumns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewConnections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxIndex;
        private System.Windows.Forms.DataGridView dataGridViewIndexes;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource indexBindingSource;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ındexNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fragmantationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxColumns;
        private System.Windows.Forms.GroupBox groupBoxInclude;
        private System.Windows.Forms.ListView listViewIncludes;
        private System.Windows.Forms.GroupBox groupBoxIndexColumns;
        private System.Windows.Forms.ListView listViewColumns;
        private System.Windows.Forms.Button buttonGetColumns;
        private System.Windows.Forms.ColumnHeader columnHeaderColumn;
        private System.Windows.Forms.ColumnHeader Sort;
        private System.Windows.Forms.ColumnHeader columnHeaderInclude;
        private System.Windows.Forms.ColumnHeader columnHeaderIType;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
    }
}