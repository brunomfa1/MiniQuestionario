using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteInsereAutoConclusao.Models;

public class AutoConcluAssiFotoMapping : IEntityTypeConfiguration<AutoConcluAssiFoto>
{
    public AutoConcluAssiFotoMapping()
    {

    }
    public void Configure(EntityTypeBuilder<AutoConcluAssiFoto> builder)
    {
        builder.ToTable("AutoConcluAssiFoto");
        builder.HasKey(x => x.Id);
        builder.Property(b => b.ProtocoloN);
        builder.Property(b => b.Foto1);
        builder.Property(b => b.Foto2);
        builder.Property(b => b.Assinatura);
    }
}

