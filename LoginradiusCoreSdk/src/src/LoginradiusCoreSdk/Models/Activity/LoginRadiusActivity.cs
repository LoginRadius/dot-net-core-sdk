﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginradiusCoreSdk.Models.Activity
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LoginRadiusActivity
    {
        public string ActivityId
        {
            get;
            set;
        }
        public string ActivityUrl
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }

        public string Published
        {
            get;
            set;
        }
        public string Updated
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string ProfileUrl
        {
            get;
            set;
        }

        public string ImageUrl
        {
            get;
            set;
        }

        public string TotalReply
        {
            get;
            set;
        }
        public string ReplyUrl
        {
            get;
            set;
        }


        public string TotalPlusOneRs
        {
            get;
            set;
        }
        public string PlusOneRsUrl
        {
            get;
            set;
        }


        public string TotalReShares
        {
            get;
            set;
        }
        public string ReShareUrl
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public List<Attchments> Attchments
        {
            get;
            set;
        }

    }
    public class Attchments
    {
        public string AttchmentType
        {
            get;
            set;
        }
        public string AttchmentName
        {
            get;
            set;
        }
        public string AttchmentUrl
        {
            get;
            set;
        }
    }
}
