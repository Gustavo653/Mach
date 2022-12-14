using Mach.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.DataAccess
{
    public abstract class BaseEntityConfig<TType> : IEntityTypeConfiguration<TType> where TType : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TType> builder)
        {
            builder.HasKey(obj => obj.Id);

            builder.HasOne(x => x.CreatedBy).WithMany();
            builder.HasOne(x => x.ChangedBy).WithMany();
        }
    }
}
