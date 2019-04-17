using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBlogA.Infrastructure
{
    public class SelectedTab : ActionFilterAttribute
    {
        private readonly string _selectedTab;
        public SelectedTab(String selectedTab)
        {
                _selectedTab = selectedTab;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.SelectedTab = _selectedTab;
        }

    }
}