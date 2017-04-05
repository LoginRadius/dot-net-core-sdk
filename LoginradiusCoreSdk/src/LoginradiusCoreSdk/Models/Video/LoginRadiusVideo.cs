﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginradiusCoreSdk.Models.Video
{
    public class LoginRadiusVideo
    {
        public List<Data> Data { get; set; }
        public string NextCursor { get; set; }
    }
    public class Data
    {
        public string EmbedHtml { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public object DirectLink { get; set; }
        public string Source { get; set; }
        public string UpdatedDate { get; set; }
        public string OwnerName { get; set; }
        public string CreatedDate { get; set; }
        public object Duration { get; set; }
        public string OwnerId { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
