﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormIndexes : Form
    {
        private readonly BackgroundWorker backgroundWorker;
        public FormIndexes()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void RefreshConnections()
        {
            ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectionString);
            List<Connection> connections = connectionManager.GetConnections(false);

            foreach (Connection connection in connections)
            {
                TreeNode treeNode = new TreeNode
                {
                    Name = connection.ConnectionString,
                    Text = connection.Name,
                    Tag = TreeNodeType.Database
                };

                treeViewConnections.Invoke(
                    new Action(delegate
                    {
                        treeViewConnections.Nodes.Add(treeNode);
                    }));
                //treeViewConnections.Nodes.Add(treeNode);
            }
        }

        private void treeViewConnections_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode treeNode = e.Node;
            if (treeNode == null || treeNode.Tag == null)
            {
                return;
            }

            TreeNodeType treeNodeType;
            if (!Enum.TryParse(treeNode.Tag.ToString(), out treeNodeType))
            {
                return;
            }

            switch (treeNodeType)
            {
                case TreeNodeType.Database:
                    GetDatabases(treeNode);
                    break;
                case TreeNodeType.Table:
                    break;
                case TreeNodeType.Index:
                    break;
                default:
                    return;
            }
        }

        private void GetDatabases(TreeNode treeNode)
        {
            ConnectionManager connectionManager = new ConnectionManager(treeNode.Name);
            List<Database> databases = connectionManager.GetDatabases();

            if (databases.Count > 0)
            {
                treeNode.Nodes.Clear();
            }

            foreach (Database database in databases)
            {
                treeNode.Nodes.Add(database.Id.ToString(), database.Name);
            }

            treeNode.Expand();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshConnections();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBarStatus.StartStopMarque();
        }
    }
}
