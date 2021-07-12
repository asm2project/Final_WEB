using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Framework
{
    public partial class FPTDBContext : DbContext
    {
        public FPTDBContext()
            : base("name=FPTDBConnectionString")
        {
        }

        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Couse_Cat> Couse_Cat { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cours>()
                .Property(e => e.Couse_ID)
                .IsFixedLength();

            modelBuilder.Entity<Couse_Cat>()
                .Property(e => e.Couse_ID)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.ID_Role);
        }
    }
}
