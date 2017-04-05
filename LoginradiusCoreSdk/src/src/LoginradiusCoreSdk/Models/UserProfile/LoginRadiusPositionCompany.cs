﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginradiusCoreSdk.Models.UserProfile
{
    public class LoginRadiusPositionCompany
    {
        /// <summary>
        /// Facebook : employer and Linkedin : <company><name> node
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Linkedin : <company><type> node
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Linkedin : <company><industry> node
        /// </summary>
        public string Industry { get; set; }
    }
}
