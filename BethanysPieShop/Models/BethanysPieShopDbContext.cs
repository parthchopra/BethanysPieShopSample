using System;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
	public class BethanysPieShopDbContext : DbContext
	{
		public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options)
		{

		}

		public DbSet<Pie> Pies { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}

