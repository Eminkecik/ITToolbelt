using System.Collections.Generic;
using System.Windows.Forms;
using ITToolbelt.Bll.ExternalLibraries;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using Ninject;

namespace ITToolbelt.Bll.Managers
{
    public class UserManager
    {
        private IUserDal iUserDal;

        public UserManager(ConnectInfo connectInfo)
        {
            iUserDal = new NinjectModules(connectInfo).StandartKernel.Get<IUserDal>();
        }

        public List<User> GetAll()
        {
            List<User> users = iUserDal.GetAll();
            return users;
        }
    }
}