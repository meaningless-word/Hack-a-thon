﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PerevalAddedEntity>(entity =>
			{
				//entity.HasKey(e => e.Id).HasName("untitled_table_195_pkey");
				entity.Property(e => e.DateAdded).HasColumnName()
			});
		}
	}
}
