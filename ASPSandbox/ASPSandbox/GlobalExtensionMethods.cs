using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPSandbox
{
    public static class GlobalExtensionMethods
    {
        public static SessionObject GetSessionObject(this HttpContext current)
        {
            return current != null ? (SessionObject)current.Session["__SessionObject"] : null;
        }
        public static SessionObject GetSessionObject(this HttpContextBase current)
        {
            return current != null ? (SessionObject)current.Session["__SessionObject"] : null;
        }
    }
}