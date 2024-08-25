﻿using Microsoft.EntityFrameworkCore;
using OrdersService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext2 : DbContext
    {
        public ApplicationDbContext2(DbContextOptions<ApplicationDbContext2> options)
            : base(options)
        {
        }

        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configuration for DB2
        }
    }
}