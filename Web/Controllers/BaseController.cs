﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;

namespace Web.Controllers
{
    public class BaseController<T> : GenericController<T,DataContext> where T:class
    {
        // GET: Base
    }
}