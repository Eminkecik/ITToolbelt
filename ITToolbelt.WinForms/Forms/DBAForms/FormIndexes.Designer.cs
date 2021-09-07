
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndexes));
            this.treeViewConnections = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxIndex = new System.Windows.Forms.GroupBox();
            this.dataGridViewIndexes = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1.SuspendLayout();
            this.groupBoxIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewConnections
            // 
            this.treeViewConnections.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewConnections.Location = new System.Drawing.Point(0, 0);
            this.treeViewConnections.Name = "treeViewConnections";
            this.treeViewConnections.Size = new System.Drawing.Size(195, 637);
            this.treeViewConnections.TabIndex = 0;
            this.treeViewConnections.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewConnections_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(195, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 99);
            this.panel1.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = global::ITToolbelt.WinForms.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(717, 12);
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
            this.groupBoxIndex.Location = new System.Drawing.Point(195, 99);
            this.groupBoxIndex.Name = "groupBoxIndex";
            this.groupBoxIndex.Size = new System.Drawing.Size(804, 538);
            this.groupBoxIndex.TabIndex = 2;
            this.groupBoxIndex.TabStop = false;
            this.groupBoxIndex.Text = "Indexes";
            // 
            // dataGridViewIndexes
            // 
            this.dataGridViewIndexes.AllowUserToAddRows = false;
            this.dataGridViewIndexes.AllowUserToDeleteRows = false;
            this.dataGridViewIndexes.AllowUserToOrderColumns = true;
            this.dataGridViewIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIndexes.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIndexes.Name = "dataGridViewIndexes";
            this.dataGridViewIndexes.ReadOnly = true;
            this.dataGridViewIndexes.Size = new System.Drawing.Size(798, 519);
            this.dataGridViewIndexes.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarStatus});
            this.statusStrip.Location = new System.Drawing.Point(195, 615);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(804, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBarStatus
            // 
            this.toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            this.toolStripProgressBarStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // FormIndexes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 637);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxIndex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeViewConnections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIndexes";
            this.Text = "Index Manager";
            this.panel1.ResumeLayout(false);
            this.groupBoxIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
    }
}