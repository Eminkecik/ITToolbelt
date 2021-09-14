using System;
using System.Collections.Generic;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlIndexDal : IIndexDal
    {
        public string ConnectionString { get; }

        public MsSqlIndexDal(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Index> GetIndexes()
        {
            using (ServerContext serverContext = new ServerContext(ConnectionString))
            {
                List<Index> indexes = serverContext.Database.SqlQuery<Index>("SELECT S.name as [Schema],T.name as [Table],I.name as [IndexName], [State] = (case I.is_disabled when 1 then 'DISABLED' WHEN 0 THEN 'ENABLED' END), DDIPS.avg_fragmentation_in_percent as Fragmantation,DDIPS.page_count as [PageCount] FROM sys.indexes I join sys.tables T on I.object_id = T.object_id join sys.schemas S on T.schema_id = S.schema_id LEFT join sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, NULL) AS DDIPS on DDIPS.object_id = T.object_id AND DDIPS.index_id = I.index_id where I.[name] is not null ORDER BY [Schema], [Table], IndexName").ToList();
                return indexes;
            }
        }

        public bool SetDisable(Index index)
        {
            using (ServerContext serverContext = new ServerContext(ConnectionString))
            {
                string sql = $"ALTER INDEX [{index.IndexName}] ON [{index.Schema}].[{index.Table}] DISABLE";
                try
                {
                    serverContext.Database.ExecuteSqlCommand(sql);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public List<Column> GetColumns(Index index)
        {
            
                using (ServerContext serverContext = new ServerContext(ConnectionString))
                {
                    string sql = $"SELECT ColumnName = col.name, SortType = (case ic.is_descending_key when 0 then 'ASCENDING' when 1 then 'DESCENDING' end), [Type] = tp.name, IsInclude = ic.is_included_column FROM sys.indexes ind INNER JOIN sys.index_columns ic ON  ind.object_id = ic.object_id and ind.index_id = ic.index_id INNER JOIN sys.columns col ON ic.object_id = col.object_id and ic.column_id = col.column_id join sys.types tp on col.user_type_id = tp.user_type_id WHERE ind.name = '{index.IndexName}' ORDER BY col.name";
                    try
                    {
                        List<Column> columns = serverContext.Database.SqlQuery<Column>(sql).ToList();
                        return columns;
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            
        }
    }
}