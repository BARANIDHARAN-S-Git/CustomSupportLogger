﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace CustomSupportLogger.Models
{
    public class UserInfoModel
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string password { get; set; }
    }
}