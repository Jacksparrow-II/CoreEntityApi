using System;
using System.Collections.Generic;

namespace CoreEntityApi.Model.Entity
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public string Cource { get; set; }
        public decimal? Marks { get; set; }
    }
}
