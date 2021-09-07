﻿using System;
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
                List<Index> indexes = serverContext.Database.SqlQuery<Index>("SELECT S.name as [Schema],T.name as [Table],I.name as [IndexName],DDIPS.avg_fragmentation_in_percent as Fragmantation,DDIPS.page_count as [PageCount] FROM sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, NULL) AS DDIPS INNER JOIN sys.tables T on T.object_id = DDIPS.object_id INNER JOIN sys.schemas S on T.schema_id = S.schema_id INNER JOIN sys.indexes I ON I.object_id = DDIPS.object_id AND DDIPS.index_id = I.index_id WHERE DDIPS.database_id = DB_ID() and I.name is not null AND  DDIPS.avg_fragmentation_in_percent > 0 ORDER BY [Schema], [Table], IndexName").ToList();
                return indexes;
            }
        }
    }
}