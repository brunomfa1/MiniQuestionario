using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteInsereAutoConclusao.Models;

namespace TesteInsereAutoConclusao
{
    public class AutoConcluMensoesMapping : IEntityTypeConfiguration<AutoConcluMensoes>
    {
        public AutoConcluMensoesMapping()
        {

        }

        public void Configure(EntityTypeBuilder<AutoConcluMensoes> builder)
        {
            builder.ToTable("AutoConcluMensoes");
            builder.HasKey(x =>x.Id);
            builder.Property(b => b.ProtocoloN).HasMaxLength(100);
            builder.Property(b => b.AreaTerreno).HasMaxLength(100);
            builder.Property(b => b.AreaConstruida).HasMaxLength(100);
            builder.Property(b => b.QtdPecasInternas).HasMaxLength(100);
            builder.Property(b => b.QtdPecasExternas).HasMaxLength(100);
            builder.Property(b => b.NPavimentos).HasMaxLength(100);
            builder.Property(b => b.NUnidadeComerciais).HasMaxLength(100);
            builder.Property(b => b.AreaTotalEdificacao).HasMaxLength(100);
            builder.Property(b => b.RecuoFrontal).HasMaxLength(100);
            builder.Property(b => b.TaxaOcupacao).HasMaxLength(100);

        }
    }
}
