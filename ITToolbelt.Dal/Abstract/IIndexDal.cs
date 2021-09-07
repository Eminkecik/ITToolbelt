using System.Collections.Generic;
using ITToolbelt.Entity.EntityClass;

namespace ITToolbelt.Dal.Abstract
{
    public interface IIndexDal
    {
        List<Index> GetIndexes();
    }
}