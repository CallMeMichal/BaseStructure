﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseStructure.Contracts.ModelsToApi.Request
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
