﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiCrudCodeFirstApproach.Models
{
    public class EmployeeDBContext:DbContext
    {
       public DbSet<Employee> Employees { get; set;}
    }
}