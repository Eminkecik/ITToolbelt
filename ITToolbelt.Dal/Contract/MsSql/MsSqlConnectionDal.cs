using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using Database = ITToolbelt.Entity.EntityClass.Database;
using Table = ITToolbelt.Entity.EntityClass.Table;
using ITToolbelt.Dal.Contract.MySql;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using System.Data.SqlClient;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlConnectionDal : IConnectionDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MsSqlConnectionDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
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
                    switch (connection.DbServerTypeCode)
                    {
                        case DbServerType.MsSql:
                            GetServerProperties(connection);
                            break;
                        case DbServerType.MySql:
                            MySqlConnectionDal.GetServerProperties(connection);
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
                using (SqlConnection sqlConnection = new SqlConnection(connection.ConnectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand { Connection = sqlConnection };
                    sqlCommand.CommandText =
                        "SELECT SERVERPROPERTY('MachineName') as MachineName," + //0
                        "SERVERPROPERTY('ServerName') AS ServerName, " + //1
                        "SERVERPROPERTY('Edition') AS Edition, " + //2
                        "SERVERPROPERTY('ProductLevel') AS ProductLevel, " + //3
                        "SERVERPROPERTY('ProductUpdateLevel') as ProductUpdateLevel, " + //4
                        "SERVERPROPERTY('ProductVersion') AS ProductVersion, " + //5
                        "SERVERPROPERTY('Collation') AS Collation, " + //6
                        "SERVERPROPERTY('ProductMajorVersion') AS ProductMajorVersion, " + //7
                        "SERVERPROPERTY('ProductMinorVersion') as ProductMinorVersion, " + //8
                        "SERVERPROPERTY('InstanceName') as InstanceName";
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        connection.MachineName = sqlDataReader.GetSqlString(0).IsNull ? String.Empty : sqlDataReader.GetSqlString(0).Value;
                        connection.ServerName = sqlDataReader.GetSqlString(1).IsNull ? String.Empty : sqlDataReader.GetSqlString(1).Value;
                        connection.Edition = sqlDataReader.GetSqlString(2).IsNull ? String.Empty : sqlDataReader.GetSqlString(2).Value;
                        connection.ProductLevel = sqlDataReader.GetSqlString(3).IsNull ? String.Empty : sqlDataReader.GetSqlString(3).Value;
                        connection.ProductUpdateLevel = sqlDataReader.GetSqlString(4).IsNull ? String.Empty : sqlDataReader.GetSqlString(4).Value;
                        connection.ProductVersion = sqlDataReader.GetSqlString(5).IsNull ? String.Empty : sqlDataReader.GetSqlString(5).Value;
                        connection.Collation = sqlDataReader.GetSqlString(6).IsNull ? String.Empty : sqlDataReader.GetSqlString(6).Value;
                        connection.ProductMajorVersion = sqlDataReader.GetSqlString(7).IsNull ? String.Empty : sqlDataReader.GetSqlString(7).Value;
                        connection.ProductMinorVersion = sqlDataReader.GetSqlString(8).IsNull ? String.Empty : sqlDataReader.GetSqlString(8).Value;

                        if (!sqlDataReader.IsDBNull(9))
                        {
                            connection.InstanceName = sqlDataReader.GetSqlString(9).IsNull
                            ? String.Empty
                            : sqlDataReader.GetSqlString(9).Value;
                        }
                        else
                        {
                            connection.InstanceName = null;
                        }
                    }


                    connection.ConnectionInfo = "Success";
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
            List<Database> databases;
            using (SqlConnection msSqlServerContext = new SqlConnection(ConnectInfo.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand { Connection = msSqlServerContext };
                sqlCommand.CommandText = "select database_id as Id, name as Name, state as [State] from sys.databases";
                try
                {
                    msSqlServerContext.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        databases = new List<Database>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Database database = new Database
                        {
                            Id = sqlDataReader.GetInt32(0),
                            Name = sqlDataReader.GetString(1),
                            State = sqlDataReader.GetByte(2)
                        };
                        databases.Add(database);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
                finally
                {
                    if (msSqlServerContext.State != ConnectionState.Closed)
                    {
                        msSqlServerContext.Close();
                    }
                }

                return databases;
            }
        }

        public List<Table> GetTables()
        {
            List<Table> tables;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectInfo.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand { Connection = sqlConnection };
                sqlCommand.CommandText = "select DB_ID() as DatabaseId, " + //0
                                         "s.schema_id SchemaId, " + //1
                                         "t.object_id TableId, " + //2
                                         "DB_NAME() as DatabaseName, " + //3
                                         "s.name as SchemaName, " + //4
                                         "t.name as TableName " + //5
                                         "from sys.tables t join sys.schemas s on t.schema_id = s.schema_id where t.type = 'U'";
                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        tables = new List<Table>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Table database = new Table
                        {
                            DatabaseId = sqlDataReader.GetInt16(0),
                            SchemaId = sqlDataReader.GetInt32(1),
                            TableId = sqlDataReader.GetInt32(2),
                            DatabaseName = sqlDataReader.GetString(3),
                            SchemaName = sqlDataReader.GetString(4),
                            TableName = sqlDataReader.GetString(5),
                        };
                        tables.Add(database);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }

                return tables;
            }

        }

        public bool Delete(int connectionId)
        {
            using (ItToolbeltContext context = new ItToolbeltContext(ConnectInfo.ConnectionString))
            {
                Connection connection = context.Connections.FirstOrDefault(c => c.Id == connectionId);
                if (connection is null)
                {
                    return false;
                }

                context.Connections.Remove(connection);
                bool changes = context.SaveChanges();
                return changes;
            }
        }
    }
}