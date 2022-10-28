using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteInsereAutoConclusao.Models;

namespace TesteInsereAutoConclusao
{
    public class AutoConcluInfraMapping : IEntityTypeConfiguration<AutoConcluInfra>
    {
        public AutoConcluInfraMapping()
        {

        }
        public void Configure(EntityTypeBuilder<AutoConcluInfra> builder)
        {
            builder.ToTable("AutoConcluInfra");
            builder.HasKey(x => x.Id);
            builder.Property(b => b.ProtocoloN).HasMaxLength(100);
            builder.Property(b => b.Esgoto).HasMaxLength(100);
            builder.Property(b => b.AguaRede).HasMaxLength(100);
            builder.Property(b => b.FossaSepticaSumidouro).HasMaxLength(100);
            builder.Property(b => b.EnergiaEletrica).HasMaxLength(100);
            builder.Property(b => b.Iluminacao).HasMaxLength(100);
            builder.Property(b => b.Telefone).HasMaxLength(100);
            builder.Property(b => b.GuiasSarjetas).HasMaxLength(100);
            builder.Property(b => b.GaleriaPluvial).HasMaxLength(100);
            builder.Property(b => b.Pavimentacao).HasMaxLength(100);
            builder.Property(b => b.Calcamento).HasMaxLength(100);
            builder.Property(b => b.Arborizacao).HasMaxLength(100);
            builder.Property(b => b.LimpezaPublica).HasMaxLength(100);
            builder.Property(b => b.ColetaLixo).HasMaxLength(100);
            builder.Property(b => b.TransporteColetivo).HasMaxLength(100);


        }
    }
}
