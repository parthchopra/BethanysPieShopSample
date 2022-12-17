using System;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
	public class PieRepository : IPieRepository
	{
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;
        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies => _bethanysPieShopDbContext.Pies.Include(c => c.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _bethanysPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);

        public Pie? GetPieById(int pieId) => _bethanysPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}

