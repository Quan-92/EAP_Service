using EAP_Service.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Service.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base ("name=EAPService")
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}