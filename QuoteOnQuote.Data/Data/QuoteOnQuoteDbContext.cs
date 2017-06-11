using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteOnQuote.Models;
using QuoteOnQuote.Data;
using Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data.Data
{
    class QuoteOnQuoteDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Votes> Votes { get; set; }

        public QuoteOnQuoteDbContext()
            : base("DefaultConnection")
        {
        }

        public QuoteOnQuoteDbContext Create()
        {
            return new QuoteOnQuoteDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().HasRequired(u => u.User).WithMany().HasForeignKey(u => u.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
