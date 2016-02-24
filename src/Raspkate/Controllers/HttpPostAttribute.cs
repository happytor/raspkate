﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspkate.Controllers
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HttpPostAttribute : HttpMethodAttribute
    {
        public HttpPostAttribute()
            : base("POST")
        { }
    }
}
