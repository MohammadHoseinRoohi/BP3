using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice3.Entities.Base;

namespace Practice3.Entities
{
    public class Book : Thing
    {
        public required string Title { get; set; }
        public string? Writer { get; set; }
        public string? Translator { get; set; }
        public string? Publisher { get; set; }
        public string? Genre { get; set; }
        public double Price { get; set; }
    }
}