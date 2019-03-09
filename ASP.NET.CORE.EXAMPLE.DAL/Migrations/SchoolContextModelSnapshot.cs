﻿// <auto-generated />
using System;
using ASP.NET.CORE.EXAMPLE.DAL.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET.CORE.EXAMPLE.DAL.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NET.CORE.EXAMPLE.DAL.EntityFramework.Tables.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedTime");

                    b.Property<string>("NameSurname");

                    b.Property<string>("ProfileAvatar");

                    b.Property<byte>("Sex");

                    b.HasKey("Id");

                    b.ToTable("TABLE.STUDENTS");
                });
#pragma warning restore 612, 618
        }
    }
}
