using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationDemo
{
    class PlutoContext:DbContext
    {
        public PlutoContext():base("name=PlutoContext")
        {

        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Course>()
            //            .ToTable("course");          //change table name

            //modelBuilder.Entity<Course>()
            //            .HasKey(a => a.AuthorId);     //set primary key

            //modelBuilder.Entity<Course>()
            //            .HasKey(a => new { a.AuthorId, a.Author });     //set primary key as composite key

            //modelBuilder.Entity<Course>()
            //            .Property(a => a.FullPrice)
            //            .HasColumnName("Price");               //change column name fullprice to price

            //modelBuilder.Entity<Course>()
            //            .Property(a => a.FullPrice)
            //            .HasColumnType("varchar");             //change column data type to varchar

            //modelBuilder.Entity<Course>()
            //            .Property(a => a.FullPrice)
            //            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);   //set column number generation none

            //modelBuilder.Entity<Course>()
            //            .Property(a => a.FullPrice)
            //            .IsRequired();                       //making column not nullable

            //modelBuilder.Entity<Course>()
            //            .Property(a => a.Description) 
            //            .HasMaxLength(2000);              //setting column maximum length to 2000 characters

            //modelBuilder.Entity<Course>()
            //            .HasMany(a => a.Tags)
            //            .WithMany(a => a.Courses);         //Many to Many relationship course-tag

            //modelBuilder.Entity<Author>()
            //            .HasMany(a => a.Courses)
            //            .WithRequired(a => a.Author);        //one to many realtionship author-course

            
                         

        }
    }
}
