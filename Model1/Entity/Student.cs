using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Model1.Entity
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
