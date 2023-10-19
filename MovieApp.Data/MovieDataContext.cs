using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    internal class MovieDataContext : DbContext
    {
        public  DbSet<Movie> Movies { get; set;}
        public  DbSet<Actor> Actors { get; set;}

        public MovieDataContext(DbContextOptions<MovieDataContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
    }
}
