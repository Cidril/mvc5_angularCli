using System.Data.Entity;
using Pv_Inf.Common.Migrations;

namespace Pv_Inf.Common.DAL
{
    public class PvContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }

        public PvContext() : base("pv-inf-connection")
        {

        }

        public static void Init()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PvContext, Configuration>());
        }
    }
}
