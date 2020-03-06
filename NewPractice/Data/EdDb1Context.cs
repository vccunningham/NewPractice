using Microsoft.EntityFrameworkCore;
using NewPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPractice.Data {
    public class EdDb1Context : DbContext {

        public EdDb1Context(DbContextOptions<EdDb1Context> options)
            : base(options) {

        }
        public DbSet<Players> Players { get; set; }
        public DbSet<Coaches> Coaches { get; set; }
        public DbSet<Rosters> Rosters { get; set; }

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Players>(e => {
                e.ToTable("Players");
                e.HasKey(x => x.Id);
                e.Property(x => x.Firstname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Lastname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Position).HasMaxLength(3).IsRequired();
                e.Property(x => x.Age).HasMaxLength(2).IsRequired();
                e.Property(x => x.SchoolAttended).HasMaxLength(30);
                e.Property(x => x.IsVeteran);
            });
            model.Entity<Coaches>(e => {
                e.ToTable("Coaches");
                e.HasKey(x => x.Id);
                e.Property(x => x.Firstname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Lastname).HasMaxLength(30).IsRequired();
                e.Property(x => x.YearsExperienced).HasMaxLength(2).IsRequired();
                e.Property(x => x.IsTenured);
            });
            model.Entity<Rosters>(e => {
                e.ToTable("Rosters");
                e.HasKey(x => x.Id);
                e.Property(x => x.HeadCoach).HasMaxLength(30).IsRequired();
                e.Property(x => x.JerseyNbr).HasMaxLength(2).IsRequired();
                e.Property(x => x.PositionId).HasMaxLength(3).IsRequired();
                e.Property(x => x.IsStarter);
            });

        }
    }
}
