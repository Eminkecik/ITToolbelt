using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private TreeNodeType backWorkerFlag;
        private readonly BackgroundWorker backgroundWorker;
        public FormIndexes()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            backWorkerFlag = TreeNodeType.Connection;
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
                    Tag = TreeNodeType.Connection
                };

                treeViewConnections.Invoke(
                    new Action(delegate
                    {
                        treeViewConnections.Nodes.Add(treeNode);
                    }));
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
                case TreeNodeType.Connection:
                    backWorkerFlag = TreeNodeType.Database;
                    toolStripProgressBarStatus.StartStopMarque();
                    backgroundWorker.RunWorkerAsync(argument: treeNode);
                    break;
                case TreeNodeType.Database:
                    backWorkerFlag = TreeNodeType.Table;
                    toolStripProgressBarStatus.StartStopMarque();
                    backgroundWorker.RunWorkerAsync(argument: treeNode);
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

            treeViewConnections.Invoke(
                new Action(delegate
                {
                    if (databases.Count > 0)
                    {
                        treeNode.Nodes.Clear();
                    }

                    foreach (Database database in databases)
                    {
                        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(treeNode.Name)
                        {
                            InitialCatalog = database.Name
                        };
                        TreeNode dbNode = new TreeNode
                        {
                            Name = connectionStringBuilder.ConnectionString,
                            Text = database.Name,
                            Tag = TreeNodeType.Database
                        };
                        treeNode.Nodes.Add(dbNode);
                    }

                    treeNode.Expand();
                }));
        }

        private void GetTables(TreeNode treeNode)
        {
            ConnectionManager connectionManager = new ConnectionManager(treeNode.Name);
            List<Table> tables = connectionManager.GetTables();

            treeViewConnections.Invoke(
                new Action(delegate
                {
                    if (tables.Count > 0)
                    {
                        treeNode.Nodes.Clear();
                    }

                    foreach (Table table in tables)
                    {
                        TreeNode dbNode = new TreeNode
                        {
                            Name = table.TableName,
                            Text = $"[{table.SchemaName}].[{table.TableName}]",
                            Tag = TreeNodeType.Table
                        };
                        treeNode.Nodes.Add(dbNode);
                    }

                    treeNode.Expand();
                }));
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            TreeNode treeNode;
            switch (backWorkerFlag)
            {
                case TreeNodeType.Connection:
                    RefreshConnections();
                    break;
                case TreeNodeType.Database:
                    treeNode = e.Argument as TreeNode;
                    GetDatabases(treeNode);
                    break;
                case TreeNodeType.Table:
                    treeNode = e.Argument as TreeNode;
                    GetTables(treeNode);
                    break;
                case TreeNodeType.Index:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBarStatus.StartStopMarque();
        }
    }
}
