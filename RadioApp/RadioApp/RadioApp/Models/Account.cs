﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioApp.Models
{
    public class Account
    {
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Username")]

        public string Username { get; set; }
        [JsonProperty("Password")]

        public string Password { get; set; }
    }
}
