using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice3.Entities.Base;

namespace Practice3.Entities
{
    public class Borrow : Thing
    {
        public required Book Book { get; set; }
        public required Member Member { get; set; }
        public DateTime BorrowTime { get; set; }
        public DateTime? ReturnTime { get; set; }
    }
}