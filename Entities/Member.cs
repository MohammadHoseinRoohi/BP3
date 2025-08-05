using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice3.Enums;

namespace Practice3.Entities
{
    public class Member
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public  Gender Gender { get; set; }
        public double PhoneNumber { get; set; }
        public double Password { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
    }
}