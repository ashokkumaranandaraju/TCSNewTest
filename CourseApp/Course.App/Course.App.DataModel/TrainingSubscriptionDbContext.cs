using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Course.App.DataModel
{
    public class TrainingSubscriptionDbContext : DbContext
    {
        public TrainingSubscriptionDbContext(DbContextOptions<TrainingSubscriptionDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //This will singularize all table names
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Use the entity name instead of the Context.DbSet<T> name
                // refs https://learn.microsoft.com/en-us/ef/core/modeling/entity-types?tabs=fluent-api#table-name
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Users");
                b.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(3850050, 1);
            });

            modelBuilder.Entity<Course>().HasData(new[]
            {
                new Course { Id = 1,CCode ="C101", Name = ".Net Web API", Title = "C# Net Web API & EF",Description = "C# Advanced programming",Status ="Active"},
                new Course { Id = 2,CCode ="C102", Name = "ASP.net core", Title = "Build an app with ASPNET MVC",Description = "ASP.net MVC from scratch",Status ="Active" },
                new Course { Id = 3,CCode ="C103", Name = "Angular 10", Title = "Angular Fundamental",Description = "Angular Fundamental step by step",Status ="Active" },
                new Course { Id = 4,CCode ="C104", Name = "PHP for beginner", Title = "PHP for beginner",Description = "PHP for beginner",Status ="Hold" }
            });
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User{Id=3850058,Name ="Rajan Adiga",Email="rajan_adiga@terry.test",Gender="female",Status="active"},
                new User{Id=3850059,Name ="Draupadi Khanna",Email="draupadi_khanna@torphy.test",Gender="male",Status="inactive"},
                new User{Id=3850060,Name ="Sen. Ganaka Mehrotra",Email="ganaka_sen_mehrotra@hodkiewicz.example",Gender="male",Status="inactive"},
                new User{Id=3850061,Name ="Harinarayan Trivedi",Email="trivedi_harinarayan@koss.example",Gender="male",Status="inactive"},
                new User{Id=3850062,Name ="Rahul Panicker DO",Email="panicker_rahul_do@emard.example",Gender="female",Status="active"},
                new User{Id=3850063,Name ="Ujjawal Dutta",Email="dutta_ujjawal@crooks.example",Gender="male",Status="inactive"},
                new User{Id=3850064,Name ="Himadri Sethi II",Email="sethi_himadri_ii@kihn-gusikowski.test",Gender="male",Status="active"},
                 new User{Id=3850065,Name ="Mrs. Vaishno Pillai",Email="vaishno_mrs_pillai@aufderhar.test",Gender="male",Status="inactive"},
                  new User{Id=3850066,Name ="Bhavani Gandhi",Email="gandhi_bhavani@hane.test",Gender="female",Status="inactive"},
                   new User{Id=3850068,Name ="Leela Embranthiri",Email="leela_embranthiri@feest.example",Gender="female",Status="active"}

            });

        }

        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Training> Trainings => Set<Training>();
        public DbSet<Subscription> Subscriptions => Set<Subscription>();
        public DbSet<User> Users => Set<User>();

    }
}
