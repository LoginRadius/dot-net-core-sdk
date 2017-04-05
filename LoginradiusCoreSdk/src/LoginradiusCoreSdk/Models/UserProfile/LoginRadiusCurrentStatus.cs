﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginradiusCoreSdk.Models.UserProfile
{
    public class LoginRadiusCurrentStatus
    {
        /// <summary>
        /// Linkedin : <id> node
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Linkedin : <name> node
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Linkedin : <proficiency> node
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Linkedin : <proficiency> node
        /// </summary>
        public string CreatedDate { get; set; }

    }
}
