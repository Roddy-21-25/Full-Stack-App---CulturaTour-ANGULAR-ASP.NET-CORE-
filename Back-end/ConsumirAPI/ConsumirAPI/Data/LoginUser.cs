using System;
using System.Collections.Generic;

namespace ConsumirAPI.Data
{
    public partial class LoginUser
    {
        public int Id { get; set; }
        public string EmailLogin { get; set; } = null!;
        public string PasswordLogin { get; set; } = null!;
    }
}
