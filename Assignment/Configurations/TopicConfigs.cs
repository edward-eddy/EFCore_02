using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configurations
{
    internal class TopicConfigs : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> topic)
        {
            topic.HasMany(T => T.Courses)
                 .WithOne(C => C.Topic)
                 .HasForeignKey(C => C.Top_ID);
        }
    }
}
