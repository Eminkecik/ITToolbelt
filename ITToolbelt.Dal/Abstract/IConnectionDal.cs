using System.Collections.Generic;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Abstract
{
    public interface IConnectionDal
    {
        bool AddConnection(Connection connection);
        List<Connection> GetConnections(bool updateFromServer);
    }
}