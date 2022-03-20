using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace efcodefirstapproach.Models
{
    public class studentcontext: DbContext 
    {
        public DbSet<student> students { get; set; }
    }
}