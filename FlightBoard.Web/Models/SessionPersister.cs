// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.SessionPersister
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;
using System.Web;

namespace FlightBoard.Web.Models
{
    public static class SessionPersister
    {
        private static string USERNAME = "username";
        private static string DISPLAYNAME = "displayName";
        private static string USERID = "userId";
        private static string ROLES = "roles";
        private static string EMAILADDRESS = "emailAddress";
        private static string ISADMIN = "isAdmin";

        public static string Username
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                if (HttpContext.Current.Session[SessionPersister.USERNAME] != null)
                    return HttpContext.Current.Session[SessionPersister.USERNAME] as string;
                return (string)null;
            }
            set
            {
                HttpContext.Current.Session[SessionPersister.USERNAME] = (object)value;
            }
        }

        public static string DisplayName
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                if (HttpContext.Current.Session[SessionPersister.DISPLAYNAME] != null)
                    return HttpContext.Current.Session[SessionPersister.DISPLAYNAME] as string;
                return (string)null;
            }
            set
            {
                HttpContext.Current.Session[SessionPersister.DISPLAYNAME] = (object)value;
            }
        }

        public static int UserId
        {
            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session[SessionPersister.USERID] == null)
                    return 0;
                return Convert.ToInt32(HttpContext.Current.Session[SessionPersister.USERID]);
            }
            set
            {
                HttpContext.Current.Session[SessionPersister.USERID] = (object)value;
            }
        }

        public static int Roles
        {
            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session[SessionPersister.ROLES] == null)
                    return 0;
                return Convert.ToInt32(HttpContext.Current.Session[SessionPersister.ROLES]);
            }
            set
            {
                HttpContext.Current.Session[SessionPersister.ROLES] = (object)value;
            }
        }

        public static string EmailAddress
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                if (HttpContext.Current.Session[SessionPersister.EMAILADDRESS] != null)
                    return HttpContext.Current.Session[SessionPersister.EMAILADDRESS] as string;
                return (string)null;
            }
            set
            {
                HttpContext.Current.Session[SessionPersister.EMAILADDRESS] = (object)value;
            }
        }

        public static bool? IsAdmin
        {
            get
            {
                if (HttpContext.Current == null)
                    return new bool?(false);
                if (HttpContext.Current.Session[SessionPersister.ISADMIN] != null)
                    return HttpContext.Current.Session[SessionPersister.ISADMIN] as bool?;
                return new bool?();
            }
            set
            {
                HttpContext.Current.Session[SessionPersister.ISADMIN] = (object)value;
            }
        }
    }
}
