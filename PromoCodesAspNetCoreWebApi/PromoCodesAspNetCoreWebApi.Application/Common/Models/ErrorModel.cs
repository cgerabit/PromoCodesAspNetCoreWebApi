﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCodesAspNetCoreWebApi.Application.Common.Models
{
    public class ErrorModel
    {
        public string Message { get; set; }
        public Dictionary<string, object> Data { get; set; }
    }
}
