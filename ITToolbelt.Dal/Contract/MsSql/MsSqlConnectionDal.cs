using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using Microsoft.SqlServer.Management.Smo;
using Database = ITToolbelt.Entity.EntityClass.Database;
using Table = ITToolbelt.Entity.EntityClass.Table;
using ITToolbelt.Dal.Contract.Extensions;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlConnectionDal : IConnectionDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MsSqlConnectionDal(ConnectInfo connectInfo)
        {
            ConnectInfo = ConnectInfo;
        }

        public bool AddConnection(Connection connection)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                context.Connections.Add(connection);
                return context.SaveChanges();
            }
        }

        public List<Connection> GetConnections(bool updateFromServer)
        {
            List<Connection> connections;
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                connections = context.Connections.ToList();


                if (!updateFromServer)
                {
                    return connections;
                }
                foreach (Connection connection in connections)
                {
                    try
                    {
                        using (DbContext msSqlServerContext = ExtensionMethods.GetServerContext(new ConnectInfo(connection.ConnectionString, connection.DbServerTypeCode)))
                        {
                            Connection conFromServer = msSqlServerContext.Database.SqlQuery<Connection>(
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

                context.SaveChanges();
            }

            return connections;
        }

        public List<Database> GetDatabases()
        {
            using (DbContext msSqlServerContext = ExtensionMethods.GetServerContext(ConnectInfo))
            {
                List<Database> databases = msSqlServerContext.Database.SqlQuery<Database>("select database_id as Id, name as Name, state as [State] from sys.databases")
                    .ToList();
                return databases;
            }
        }

        public List<Table> GetTables()
        {
            using (DbContext msSqlServerContext = ExtensionMethods.GetServerContext(ConnectInfo))
            {
                List<Table> tables = msSqlServerContext.Database.SqlQuery<Table>("select DB_ID() as DatabaseId, s.schema_id SchemaId, t.object_id TableId, DB_NAME() as DatabaseName ,s.name as SchemaName, t.name as TableName from sys.tables t join sys.schemas s on t.schema_id = s.schema_id where t.type = 'U'")
                    .ToList();
                return tables;
            }
        }
    }
}