using System;
using System.Collections.Generic;
using System.Data;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;
using MySql.Data.MySqlClient;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlIndexDal : IIndexDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MySqlIndexDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public List<Index> GetIndexes()
        {

            List<Index> indexes;
            using (MySqlConnection sqlConnection = new MySqlConnection(ConnectInfo.ConnectionString))
            {
                MySqlCommand sqlCommand = new MySqlCommand { Connection = sqlConnection };
                sqlCommand.CommandText = "select null 'Schema', " +
                                         "TABLE_NAME, " +
                                         "INDEX_NAME, " +
                                         "IS_VISIBLE, " +
                                         "null Fragmantation, " +
                                         "null PageCount from INFORMATION_SCHEMA.STATISTICS WHERE TABLE_SCHEMA = @dbName";
                sqlCommand.Parameters.AddWithValue("@dbName", sqlConnection.Database);

                try
                {
                    sqlConnection.Open();
                    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        indexes = new List<Index>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Index database = new Index
                        {
                           // Schema = sqlDataReader.GetString(0),
                            Table = sqlDataReader.GetString(1),
                            IndexName = sqlDataReader.GetString(2),
                            State = sqlDataReader.GetString(3),
                           // Fragmantation = (double?)sqlDataReader.GetDouble(4),
                           // PageCount = sqlDataReader.GetInt64(5)
                        };
                        indexes.Add(database);
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

                return indexes;
            }
        }

        public bool SetDisable(Index index)
        {
            return false;
            //using (MsSqlServerContext msSqlServerContext = new MsSqlServerContext(ConnectionString))
            //{
            //    string sql = $"ALTER INDEX [{index.IndexName}] ON [{index.Schema}].[{index.Table}] DISABLE";
            //    try
            //    {
            //        msSqlServerContext.Database.ExecuteSqlCommand(sql);
            //        return true;
            //    }
            //    catch (Exception e)
            //    {
            //        return false;
            //    }
            //}
        }

        public List<Column> GetColumns(Index index)
        {
            List<Column> indexes;
            using (MySqlConnection sqlConnection = new MySqlConnection(ConnectInfo.ConnectionString))
            {
                MySqlCommand sqlCommand = new MySqlCommand { Connection = sqlConnection };
                sqlCommand.CommandText = "select null 'type', COLUMN_NAME, 0 'IsInclude', null 'SortType' from INFORMATION_SCHEMA.STATISTICS WHERE TABLE_SCHEMA = @dbName and TABLE_NAME = @table AND INDEX_NAME = @index";
                sqlCommand.Parameters.AddWithValue("@dbName", sqlConnection.Database);
                sqlCommand.Parameters.AddWithValue("@table", index.Table);
                sqlCommand.Parameters.AddWithValue("@index", index.IndexName);

                try
                {
                    sqlConnection.Open();
                    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        indexes = new List<Column>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Column database = new Column
                        {
                           // Type = sqlDataReader.GetString(0),
                            ColumnName = sqlDataReader.GetString(1),
                           // IsInclude = sqlDataReader.GetBoolean(2),
                           // SortType = sqlDataReader.GetString(3)
                        };
                        indexes.Add(database);
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

                return indexes;
            }
        }
    }
}