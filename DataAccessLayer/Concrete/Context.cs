﻿using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("server=localhost;database=TraversalDB;Integrated Security=true");
			optionsBuilder.UseSqlServer("Server=localhost;Database=TraversalDB;User=sa;Password=reallyStrongPwd123;Trusted_Connection=false;TrustServerCertificate=true;");
        }

		public DbSet<About> Abouts { get; set; }
		public DbSet<About2> Abouts2 { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Feature2> Features2 { get; set; }
		public DbSet<Guide> Guides { get; set; }
		public DbSet<Newsletter> Newsletters { get; set; }
		public DbSet<SubAbout> SubAbouts { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
    }
}

