﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lmsbackend.DAL;

#nullable disable

namespace lmsbackend.Migrations
{
    [DbContext(typeof(CoursesDbContext))]
    [Migration("20240424033048_Initial1")]
    partial class Initial1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lmsbackend.Models.DBEntities.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courseId"));

                    b.Property<string>("courseDescription")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("courseId");

                    b.ToTable("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}