﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wedding.Controllers
{
    public class WeddingController : Controller
    {
        //
        // GET: /Wedding/

        public ActionResult Index()
        {
            return View("Index");
        }

    }
}