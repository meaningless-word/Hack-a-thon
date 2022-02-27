using Entities;
using Microsoft.EntityFrameworkCore;
using System;

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
				entity.Property<int>(e => e.Id).HasColumnName("id");
				entity.Property<DateTime>(e => e.DateAdded).HasColumnName("date_added");
				entity.Property<string>(e => e.RawData).HasColumnName("raw_data");
				entity.Property<string>(e => e.Images).HasColumnName("images");
				entity.Property<string>(e => e.Status).HasColumnName("status").HasMaxLength(20);
				entity.HasKey(e => e.Id).HasName("untitled_table_195_pkey");
				entity.ToTable("pereval_added");
			});

			modelBuilder.Entity<PerevalImagesEntity>(entity =>
			{
				entity.Property<int>(e => e.Id).HasColumnName("id");
				entity.Property<DateTime>(e => e.DateAdded).HasColumnName("date_added");
				entity.Property<byte[]>(e => e.Image).HasColumnName("img");
				entity.HasKey(e => e.Id).HasName("pereval_added_pkey");
				entity.ToTable("pereval_images");
			});
		}
	}
}
