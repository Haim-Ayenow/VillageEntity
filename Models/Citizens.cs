using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Village.Models
{
    public partial class Citizens : DbContext
    {
        public Citizens()
            : base("name=Citizens")
        {
        }

        public virtual DbSet<Citizen> Citizens1 { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
