﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20220824170433_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("ProjectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Budget")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "12 Valley of Kings, Geneva",
                            Budget = 900000,
                            Country = "Switzerland",
                            Description = "A superb detached Victorian property on one of the town's finest roads, within easy reach of Barnes Village. The property has in excess of 6000 sq/ft of accommodation, a driveway and landscaped garden."
                        },
                        new
                        {
                            Id = 2,
                            Address = "89 Road of Forks, Bern",
                            Budget = 500000,
                            Country = "Switzerland",
                            Description = "This impressive family home, which dates back to approximately 1840, offers original period features throughout and is set back from the road with off street parking for up to six cars and an original Coach Project, which has been incorporated into the main Project to provide further accommodation. "
                        },
                        new
                        {
                            Id = 3,
                            Address = "Grote Hof 12, Amsterdam",
                            Budget = 200500,
                            Country = "The Netherlands",
                            Description = "This Project has been designed and built to an impeccable standard offering luxurious and elegant living. The accommodation is arranged over four floors comprising a large entrance hall, living room with tall sash windows, dining room, study and WC on the ground floor."
                        },
                        new
                        {
                            Id = 4,
                            Address = "Meel Kade 321, The Hague",
                            Budget = 259500,
                            Country = "The Netherlands",
                            Description = "Discreetly situated a unique two storey period home enviably located on the corner of Krom Road and Recht Road offering seclusion and privacy. The Project features a magnificent double height reception room with doors leading directly out onto a charming courtyard garden."
                        },
                        new
                        {
                            Id = 5,
                            Address = "Oude Gracht 32, Utrecht",
                            Budget = 400500,
                            Country = "The Netherlands",
                            Description = "This luxurious three bedroom flat is contemporary in style and benefits from the use of a gymnasium and a reserved underground parking space."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}