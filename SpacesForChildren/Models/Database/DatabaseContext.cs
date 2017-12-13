﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpacesForChildren.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
    }
}