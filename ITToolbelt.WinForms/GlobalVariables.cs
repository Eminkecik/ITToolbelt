using System;
using System.Configuration;

namespace ITToolbelt.WinForms
{
    public static class GlobalVariables
    {
        public static string DomainName => Environment.UserDomainName;
        public static string CurrentUser => Environment.UserName;
        public static string UserWithDomain => $"{DomainName}\\{CurrentUser}";
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["ItToolbeltContext"].ConnectionString;
    }
}