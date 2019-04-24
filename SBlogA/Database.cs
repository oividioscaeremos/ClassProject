using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBlogA
{
    public static class Database
    {
        public static void configure()
        {
            var config = new Configuration();
            config.Configure();
        }

        public static void openSession()
        {

        }

        public static void closeSession()
        {

        }
    }
}