using NW.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NW.WebApp.Controllers
{
    public class NorthwindController : Controller
    {
        protected IRepository r;

        public NorthwindController()
            : this(null) { }

        public NorthwindController(IRepository r)
        {
            if (r == null)
            {
                string connStr = GetConnStr();
                this.r = RepositoryFactory.GetRepository(GetConnStr());
            } else
            {
                this.r = r;
            }
        }

        private string GetConnStr()
        {
            return ConfigurationManager.
                ConnectionStrings["connStr"].ConnectionString;
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            // fdgfd
        }
    }
}