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
        public string ConnectionString { get; }

        public MySqlIndexDal(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Index> GetIndexes()
        {

            List<Index> indexes;
            using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString))
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
            return null;
            //using (MsSqlServerContext msSqlServerContext = new MsSqlServerContext(ConnectionString))
            //{
            //    string sql = $"SELECT ColumnName = col.name, SortType = (case ic.is_descending_key when 0 then 'ASCENDING' when 1 then 'DESCENDING' end), [Type] = tp.name, IsInclude = ic.is_included_column FROM sys.indexes ind INNER JOIN sys.index_columns ic ON  ind.object_id = ic.object_id and ind.index_id = ic.index_id INNER JOIN sys.columns col ON ic.object_id = col.object_id and ic.column_id = col.column_id join sys.types tp on col.user_type_id = tp.user_type_id WHERE ind.name = '{index.IndexName}' ORDER BY col.name";
            //    try
            //    {
            //        List<Column> columns = msSqlServerContext.Database.SqlQuery<Column>(sql).ToList();
            //        return columns;
            //    }
            //    catch (Exception e)
            //    {
            //        return null;
            //    }
            //}
        }
    }
}