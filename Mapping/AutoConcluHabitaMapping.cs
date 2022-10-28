
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteInsereAutoConclusao.Models;

namespace TesteInsereAutoConclusao
{
    public class AutoConcluHabitaMapping : IEntityTypeConfiguration<AutoConcluHabita>
    {
        public AutoConcluHabitaMapping()
        {

        }

        public void Configure(EntityTypeBuilder<AutoConcluHabita> builder)
        {
            builder.ToTable("AutoConcluHabita");
            builder.HasKey(x => x.Id);
            builder.Property(b => b.ProjetoN).HasMaxLength(100);
            builder.Property(b => b.AutoConclu).HasMaxLength(100);
            builder.Property(b => b.ProjetoN).HasMaxLength(100);
            builder.Property(b => b.Requerente).HasMaxLength(100);
            builder.Property(b => b.Quadra).HasMaxLength(100);
            builder.Property(b => b.Lote).HasMaxLength(100);
            builder.Property(b => b.Endereco).HasMaxLength(100);
            builder.Property(b => b.DataLicenca).HasMaxLength(100);
            builder.Property(b => b.ConclusaoObra).HasMaxLength(100);



        }
    }
}
