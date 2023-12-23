using ExemploGtkNet8.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploGtkNet8.Configurations;

public class PessoaTypeConfiguration : IEntityTypeConfiguration<Pessoa>
{
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder.ToTable("pessoa");
        
        builder.Property(e => e.IdPessoa).HasColumnName("idpessoa");
        builder.Property(e => e.Nome).IsRequired().HasMaxLength(100).HasColumnName("nome");
        builder.Property(e => e.Email).IsRequired().HasMaxLength(150).HasColumnName("email");
    }
}