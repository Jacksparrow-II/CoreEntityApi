﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Models.Common
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

    }
}
