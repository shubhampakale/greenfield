﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double DailyAllowance { get; set; }
        public int Workingdays { get; set; }
        public DateTime Joindate { get; set; }
        public bool IsConfirmed { get; set; }

    }
}