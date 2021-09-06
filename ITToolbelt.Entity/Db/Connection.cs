using System;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Entity.Db
{
    public class Connection
    {
        public int Id { get; set; }
        public DbServerType DbServerType { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region FromServer

        public string MachineName { get; set; }
        public string ServerName { get; set; }
        public string Edition { get; set; }
        public string ProductLevel { get; set; }
        public string ProductUpdateLevel { get; set; }
        public string ProductVersion { get; set; }
        public string Collation { get; set; }
        public string ProductMajorVersion { get; set; }
        public string ProductMinorVersion { get; set; }

        #endregion FromServer
    }
}