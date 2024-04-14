﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Accounts.Dto
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
    }
}
