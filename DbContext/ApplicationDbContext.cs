using Microsoft.EntityFrameworkCore;

namespace TesteInsereAutoConclusao
{
    public class ApplicationDbContext : DbContext
    {
        private string _conn;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AutoConcluEdificaMapping());
            builder.ApplyConfiguration(new AutoConcluHabitaMapping());
            builder.ApplyConfiguration(new AutoConcluInfraMapping());
            builder.ApplyConfiguration(new AutoConcluMensoesMapping());
            builder.ApplyConfiguration(new AutoConcluAssiFotoMapping());
            base.OnModelCreating(builder);
        }

    }
}