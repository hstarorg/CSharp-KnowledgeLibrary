using System.Data.Entity;
using Hstar.KnowledgeLibrary.Model;

namespace Hstar.KnowledgeLibrary.DataAccess
{
    public class KnowledgeDbContext:DbContext
    {
        public KnowledgeDbContext() : base("DefaultConnection")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new CreateDatabaseIfNotExists<KnowledgeDbContext>());
        }

        public DbSet<KnowledgeEntity> Knowledge { get; set; } 
    }
}
