using System.Collections.Generic;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Bll.Managers
{
    public class IndexManager
    {
        private IIndexDal iIndexDal;

        public IndexManager(string connectionString)
        {
            iIndexDal = new MsSqlIndexDal(connectionString);
        }

        public List<Index> GetIndexes()
        {
            List<Index> indexes = iIndexDal.GetIndexes();
            return indexes;
        }
    }
}