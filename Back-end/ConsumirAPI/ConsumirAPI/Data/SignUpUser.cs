using System;
using System.Collections.Generic;

namespace ConsumirAPI.Data
{
    public partial class SignUpUser
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string EmailSignUp { get; set; } = null!;
        public string PasswordSignUp { get; set; } = null!;
    }
}
