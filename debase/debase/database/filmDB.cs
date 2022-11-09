using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debase
{
    public class filmDB : DbContext
    {
        /*   de connectie met de database   */

        public DbSet<defilms> defilms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=localhost;initial Catalog=filmreview;Integrated Security=False;User ID=moviereviews;Password=FilmReviews12");
        }
    }
}
