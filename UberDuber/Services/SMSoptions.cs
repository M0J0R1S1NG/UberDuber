﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UberDuber.Services
{
    public class SMSoptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
        public string accountSid { get; set; }
        public string authToken { get; set; }
    }
}
