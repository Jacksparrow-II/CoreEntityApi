using System;
using System.Collections.Generic;

namespace CoreEntityApi.Models1.Entity
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
