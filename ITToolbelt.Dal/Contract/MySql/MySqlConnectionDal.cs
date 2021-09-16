using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.Extensions;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using Database = ITToolbelt.Entity.EntityClass.Database;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlConnectionDal : IConnectionDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MySqlConnectionDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }
        public bool AddConnection(Connection connection)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                context.Connections.Add(connection);
                return context.SaveChanges();
            }
        }

        public List<Connection> GetConnections(bool updateFromServer)
        {
            List<Connection> connections;
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                connections = context.Connections.ToList();


                if (!updateFromServer)
                {
                    return connections;
                }
                foreach (Connection connection in connections)
                {
                    switch (connection.DbServerTypeCode)
                    {
                        case DbServerType.MsSql:
                            MsSqlConnectionDal.GetServerProperties(connection);
                            break;
                        case DbServerType.MySql:
                            GetServerProperties(connection);
                            break;
                        default:
                            break;
                    }
                }

                context.SaveChanges();
            }

            return connections;
        }

        public static void GetServerProperties(Connection connection)
        {
            try
            {
                using (MySqlServerContext mySqlServerContext = new MySqlServerContext(connection.ConnectionString))
                {
                    Connection conFromServer = mySqlServerContext.Database.SqlQuery<Connection>(
                            "SELECT SERVERPROPERTY('MachineName') as MachineName, SERVERPROPERTY('ServerName') AS ServerName, SERVERPROPERTY('Edition') AS Edition, SERVERPROPERTY('ProductLevel') AS ProductLevel, SERVERPROPERTY('ProductUpdateLevel') as ProductUpdateLevel, SERVERPROPERTY('ProductVersion') AS ProductVersion, SERVERPROPERTY('Collation') AS Collation, SERVERPROPERTY('ProductMajorVersion') AS ProductMajorVersion, SERVERPROPERTY('ProductMinorVersion') as ProductMinorVersion, SERVERPROPERTY('InstanceName') as InstanceName")
                        .FirstOrDefault();

                    connection.MachineName = conFromServer.MachineName;
                    connection.ServerName = conFromServer.ServerName;
                    connection.Edition = conFromServer.Edition;
                    connection.ProductLevel = conFromServer.ProductLevel;
                    connection.ProductUpdateLevel = conFromServer.ProductUpdateLevel;
                    connection.ProductVersion = conFromServer.ProductVersion;
                    connection.Collation = conFromServer.Collation;
                    connection.ProductMajorVersion = conFromServer.ProductMajorVersion;
                    connection.ProductMinorVersion = conFromServer.ProductMinorVersion;
                    connection.InstanceName = conFromServer.InstanceName;
                    connection.ConnectionInfo = "Successful";
                }
            }
            catch (Exception e)
            {
                connection.ConnectionInfo = "Failed";
            }
            finally
            {
                connection.ModifiedDate = DateTime.Now;
            }
        }

        public List<Database> GetDatabases()
        {
            using (DbContext mySqlServerContext = ExtensionMethods.GetServerContext(ConnectInfo))
            {
                List<Database> databases = mySqlServerContext.Database.SqlQuery<Database>("select database_id as Id, name as Name, state as [State] from sys.databases")
                    .ToList();
                return databases;
            }
        }

        public List<Table> GetTables()
        {
            using (DbContext mySqlServerContext = ExtensionMethods.GetServerContext(ConnectInfo))
            {
                List<Table> tables = mySqlServerContext.Database.SqlQuery<Table>("select DB_ID() as DatabaseId, s.schema_id SchemaId, t.object_id TableId, DB_NAME() as DatabaseName ,s.name as SchemaName, t.name as TableName from sys.tables t join sys.schemas s on t.schema_id = s.schema_id where t.type = 'U'")
                    .ToList();
                return tables;
            }
        }
    }
}