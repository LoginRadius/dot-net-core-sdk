﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginradiusCoreSdk.Models.Group
{
    public class LoginRadiusGroup
    {
        public string Description { get; set; }
        public object MemberCount { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string Logo { get; set; }
        public string Type { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
