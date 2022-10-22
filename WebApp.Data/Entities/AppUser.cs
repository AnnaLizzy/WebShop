﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace WebApp.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  Dob { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
