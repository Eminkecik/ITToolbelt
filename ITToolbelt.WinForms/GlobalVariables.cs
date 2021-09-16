using System;
using System.Configuration;
using System.IO;

namespace ITToolbelt.WinForms
{
    public static class GlobalVariables
    {
        public static string DomainName => Environment.UserDomainName;
        public static string CurrentUser => Environment.UserName;
        public static string UserWithDomain => $"{DomainName}\\{CurrentUser}";
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["ItToolbeltContext"].ConnectionString;

        public static string DocPath
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = Path.Combine(path, "ItToolbelt");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return path;
            }
        }
    }

}