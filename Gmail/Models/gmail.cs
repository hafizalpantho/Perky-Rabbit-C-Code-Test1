﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gmail.Models
{
    public class gmail
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
    }
}