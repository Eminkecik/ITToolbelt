using System;
using System.Data.Entity;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Dal.Contract.MySql;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Dal.Contract.Extensions
{
    public class ExtensionMethods
    {
        public static DbContext GetServerContext(ConnectInfo connectInfo)
        {
            switch (connectInfo.DatabaseType)
            {
                case DbServerType.MsSql:
                    return new MsSqlServerContext(connectInfo.ConnectionString);
                case DbServerType.MySql:
                    return new MySqlServerContext(connectInfo.ConnectionString);
                default:
                    return null;
            }
        }
    }
}