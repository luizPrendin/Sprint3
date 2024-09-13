using Sprint3.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Sprint3.Models.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    { 
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnName("nome_usuario") .IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).HasColumnName("decimal(18,2)");
    }
}
}
