using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("INT").ValueGeneratedNever().UseIdentityColumn();
            builder.Property(p => p.DataCriacao).HasColumnName("DataCriacao").HasColumnType("DATETIME").IsRequired();
            builder.Property(p => p.Nome).HasColumnName("Nome").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(p => p.DataDeNascimento).HasColumnType("DATETIME");
        }
    }
}
