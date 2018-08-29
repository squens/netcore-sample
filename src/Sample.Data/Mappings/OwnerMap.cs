﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Core.Domain;

namespace Sample.Data.Mappings
{
    public class OwnerMap : EntityMappingConfiguration<Owner>
    {
        public override void Map(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("Owner");
            builder.OwnsOne(x => x.Geometry);
        }
    }
}
