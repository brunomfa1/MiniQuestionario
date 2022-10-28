using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteInsereAutoConclusao.Models;

namespace TesteInsereAutoConclusao
{
    public class AutoConcluEdificaMapping: IEntityTypeConfiguration<AutoConcluEdifica>
    {

        public void Configure(EntityTypeBuilder<AutoConcluEdifica> builder)
        {
            builder.ToTable("AutoConcluEdifica");
            builder.HasKey(x => x.Id);
            builder.Property(b => b.ProtocoloN).HasMaxLength(100);
            builder.Property(b => b.TipoUnidade).HasMaxLength(100);
            builder.Property(b => b.Material).HasMaxLength(100);
            builder.Property(b => b.RevestimentoExterno).HasMaxLength(100);
            builder.Property(b => b.RevestimentoInterno).HasMaxLength(100);
            builder.Property(b => b.Esquadria).HasMaxLength(100);
            builder.Property(b => b.Estrutura).HasMaxLength(100);
            builder.Property(b => b.Cobertura).HasMaxLength(100);
            builder.Property(b => b.InstalacaoSanitaria).HasMaxLength(100);
            builder.Property(b => b.Forro).HasMaxLength(100);
            builder.Property(b => b.InstalacaoEletrica).HasMaxLength(100);
            builder.Property(b => b.Piso).HasMaxLength(100);
            builder.Property(b => b.Limitacao).HasMaxLength(100);



        }
    }
}
