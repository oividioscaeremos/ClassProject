﻿using SBlogA.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBlogA.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Authorize(Roles ="admin")]
        // GET: Admin/Users
        [SelectedTab("users")]
        public ActionResult Index()
        {
            return View();
        }
    }
}