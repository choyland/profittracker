using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProfitTracker.Models.Entities;

namespace ProfitTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public IDbSet<BackBet> BackBet { get; set; }
        public IDbSet<Bookmaker> Bookmaker { get; set; }
        public IDbSet<Exchange> Exchange { get; set; }
        public IDbSet<LayBet> LayBet { get; set; }
        public IDbSet<BetResult> BetResult { get; set; }
        public IDbSet<Bet> Bet { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}