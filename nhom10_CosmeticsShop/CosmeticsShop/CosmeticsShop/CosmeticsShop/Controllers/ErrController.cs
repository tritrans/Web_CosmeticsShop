﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmeticsShop.Controllers
{
    public class ErrController : Controller
    {
        // GET: NotFound
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}