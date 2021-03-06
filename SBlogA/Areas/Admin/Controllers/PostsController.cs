﻿using SBlogA.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBlogA.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        [Authorize(Roles = "admin")]
        [SelectedTab("post")]
        public ActionResult Index()
        {
            return View();
        }
    }
}