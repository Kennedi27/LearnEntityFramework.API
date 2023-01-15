using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEntityFramework.EFLibrary.Configurations
{
    internal sealed class UserLoginConfiguration : IEntityTypeConfiguration<UserLoginEntity>
    {
        public void Configure(EntityTypeBuilder<UserLoginEntity> builder)
        {
            builder.ToTable("user_login");

            builder.HasKey(user => user.UserName);
        }
    }
}
