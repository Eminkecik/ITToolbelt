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
                List<Index> indexes = serverContext.Database.SqlQuery<Index>("SELECT S.name as [Schema],T.name as [Table],I.name as [IndexName], [State] = (case I.is_disabled when 1 then 'DISABLED' WHEN 0 THEN 'ENABLED' END), DDIPS.avg_fragmentation_in_percent as Fragmantation,DDIPS.page_count as [PageCount]  FROM sys.indexes I join sys.tables T on I.object_id = T.object_id join sys.schemas S on T.schema_id = S.schema_id LEFT join sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, NULL) AS DDIPS on DDIPS.object_id = T.object_id AND DDIPS.index_id = I.index_id ORDER BY [Schema], [Table], IndexName").ToList();
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
    }
}