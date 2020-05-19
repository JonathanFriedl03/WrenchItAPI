﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WrenchItWebAPI.Data;

namespace WrenchItWebAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200519021721_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WrenchItWebAPI.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("EstimatedTimeToComplete")
                        .HasColumnType("float");

                    b.Property<double>("Labor")
                        .HasColumnType("float");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceId = 1,
                            EstimatedTimeToComplete = 0.5,
                            Labor = 30.0,
                            ServiceName = "Oil Change"
                        },
                        new
                        {
                            ServiceId = 2,
                            EstimatedTimeToComplete = 1.5,
                            Labor = 30.0,
                            ServiceName = "Head Gasket"
                        },
                        new
                        {
                            ServiceId = 3,
                            EstimatedTimeToComplete = 1.0,
                            Labor = 30.0,
                            ServiceName = "Brake Pads"
                        },
                        new
                        {
                            ServiceId = 4,
                            EstimatedTimeToComplete = 2.5,
                            Labor = 30.0,
                            ServiceName = "Exhaust"
                        },
                        new
                        {
                            ServiceId = 5,
                            EstimatedTimeToComplete = 2.0,
                            Labor = 30.0,
                            ServiceName = "Struts"
                        },
                        new
                        {
                            ServiceId = 6,
                            EstimatedTimeToComplete = 1.0,
                            Labor = 30.0,
                            ServiceName = "Spark Plugs"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
