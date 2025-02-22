﻿using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class NorthwindContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=localhost;Database=CarRentalProjectDb;User=sa;Password=12345OHdf%e");
		}

		public DbSet<Car> Cars{ get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}

