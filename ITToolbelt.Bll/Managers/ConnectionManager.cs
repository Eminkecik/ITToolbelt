using System;
using System.Collections.Generic;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Bll.Managers
{
    public class ConnectionManager
    {
        private IConnectionDal iConnectionDal;

        public ConnectionManager(string connectionString)
        {
            iConnectionDal = new MsSqlConnectionDal(connectionString);
        }

        public bool Add(Connection connection)
        {
            connection.CreateDate = DateTime.Now;

            bool b = iConnectionDal.AddConnection(connection);
            return b;
        }

        public List<Connection> GetConnections(bool updateFromServer)
        {
            List<Connection> connections = iConnectionDal.GetConnections(updateFromServer);
            return connections;
        }
    }
}