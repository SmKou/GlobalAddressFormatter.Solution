﻿// <auto-generated />
using FormatterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormatterApi.Migrations
{
    [DbContext(typeof(FormatterApiContext))]
    [Migration("20230822205509_AddFieldSeedData")]
    partial class AddFieldSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FormatterApi.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .HasColumnType("longtext");

                    b.Property<string>("CountryName")
                        .HasColumnType("longtext");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryCode = "AUS",
                            CountryName = "Australia"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryCode = "BDG",
                            CountryName = "Bangladesh"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryCode = "CHL",
                            CountryName = "Chile"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryCode = "GRC",
                            CountryName = "Greece"
                        },
                        new
                        {
                            CountryId = 5,
                            CountryCode = "IND",
                            CountryName = "India"
                        },
                        new
                        {
                            CountryId = 6,
                            CountryCode = "USA",
                            CountryName = "United States"
                        });
                });

            modelBuilder.Entity("FormatterApi.Models.Field", b =>
                {
                    b.Property<int>("FieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FieldName")
                        .HasColumnType("longtext");

                    b.HasKey("FieldId");

                    b.ToTable("Fields");

                    b.HasData(
                        new
                        {
                            FieldId = 1,
                            FieldName = "business"
                        },
                        new
                        {
                            FieldId = 2,
                            FieldName = "addressee"
                        },
                        new
                        {
                            FieldId = 3,
                            FieldName = "street-number"
                        },
                        new
                        {
                            FieldId = 4,
                            FieldName = "street-name"
                        },
                        new
                        {
                            FieldId = 5,
                            FieldName = "locality"
                        },
                        new
                        {
                            FieldId = 6,
                            FieldName = "state"
                        },
                        new
                        {
                            FieldId = 7,
                            FieldName = "postal-code"
                        },
                        new
                        {
                            FieldId = 8,
                            FieldName = "po-box"
                        },
                        new
                        {
                            FieldId = 9,
                            FieldName = "locked-bag-number"
                        },
                        new
                        {
                            FieldId = 10,
                            FieldName = "additional-details"
                        },
                        new
                        {
                            FieldId = 11,
                            FieldName = "unit"
                        },
                        new
                        {
                            FieldId = 12,
                            FieldName = "building"
                        },
                        new
                        {
                            FieldId = 13,
                            FieldName = "town"
                        },
                        new
                        {
                            FieldId = 14,
                            FieldName = "country"
                        },
                        new
                        {
                            FieldId = 15,
                            FieldName = "village"
                        },
                        new
                        {
                            FieldId = 16,
                            FieldName = "post-office"
                        },
                        new
                        {
                            FieldId = 17,
                            FieldName = "thana-name"
                        },
                        new
                        {
                            FieldId = 18,
                            FieldName = "number"
                        },
                        new
                        {
                            FieldId = 19,
                            FieldName = "municipality"
                        },
                        new
                        {
                            FieldId = 20,
                            FieldName = "region"
                        },
                        new
                        {
                            FieldId = 21,
                            FieldName = "neighborhood"
                        },
                        new
                        {
                            FieldId = 22,
                            FieldName = "additional-information"
                        },
                        new
                        {
                            FieldId = 23,
                            FieldName = "countrycode"
                        },
                        new
                        {
                            FieldId = 24,
                            FieldName = "relation"
                        },
                        new
                        {
                            FieldId = 25,
                            FieldName = "relation-name"
                        },
                        new
                        {
                            FieldId = 26,
                            FieldName = "door-number"
                        },
                        new
                        {
                            FieldId = 27,
                            FieldName = "via-name"
                        },
                        new
                        {
                            FieldId = 28,
                            FieldName = "post-name"
                        },
                        new
                        {
                            FieldId = 29,
                            FieldName = "taluk-name"
                        },
                        new
                        {
                            FieldId = 30,
                            FieldName = "city"
                        },
                        new
                        {
                            FieldId = 31,
                            FieldName = "district"
                        },
                        new
                        {
                            FieldId = 32,
                            FieldName = "state"
                        },
                        new
                        {
                            FieldId = 33,
                            FieldName = "occupation"
                        },
                        new
                        {
                            FieldId = 34,
                            FieldName = "house-number"
                        },
                        new
                        {
                            FieldId = 35,
                            FieldName = "zipcode"
                        });
                });

            modelBuilder.Entity("FormatterApi.Models.Format", b =>
                {
                    b.Property<int>("FormatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FormatName")
                        .HasColumnType("longtext");

                    b.Property<string>("FormatPattern")
                        .HasColumnType("longtext");

                    b.HasKey("FormatId");

                    b.HasIndex("CountryId");

                    b.ToTable("Formats");

                    b.HasData(
                        new
                        {
                            FormatId = 1,
                            CountryId = 1,
                            FormatName = "Australia (general, to street address)",
                            FormatPattern = "{business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}"
                        },
                        new
                        {
                            FormatId = 2,
                            CountryId = 1,
                            FormatName = "Australia (general, to PO Box)",
                            FormatPattern = "{business}\n{addressee}\n{po-box}\n{locality}, {state}, {postal-code}"
                        },
                        new
                        {
                            FormatId = 3,
                            CountryId = 1,
                            FormatName = "Australia (general, to Locked Bag)",
                            FormatPattern = "{business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}"
                        },
                        new
                        {
                            FormatId = 4,
                            CountryId = 2,
                            FormatName = "Bangladesh (urban)",
                            FormatPattern = "{addressee}\n{additional-details}\n{unit}, {building}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}"
                        },
                        new
                        {
                            FormatId = 5,
                            CountryId = 2,
                            FormatName = "Bangladesh (rural)",
                            FormatPattern = "{addressee}\n{additional-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}"
                        },
                        new
                        {
                            FormatId = 6,
                            CountryId = 3,
                            FormatName = "Chile (multiple municipality city, with unit/apartment number)",
                            FormatPattern = "{addressee}\n{street-name} {number}, {unit}\n{postal-code} {municipality}\n{region}"
                        },
                        new
                        {
                            FormatId = 7,
                            CountryId = 3,
                            FormatName = "Chile (multiple municipality city, no unit/apartment number)",
                            FormatPattern = "{addressee}\n{street-name} {number}\n{postal-code} {municipality}\n{region}"
                        },
                        new
                        {
                            FormatId = 8,
                            CountryId = 3,
                            FormatName = "Chile (single municipality city, with unit/apartment number)",
                            FormatPattern = "{addressee}\n{street-name} {number}, {unit}\n{neighborhood}\n{region}"
                        },
                        new
                        {
                            FormatId = 9,
                            CountryId = 3,
                            FormatName = "Chile (single municipality city, no unit/apartment number)",
                            FormatPattern = "{addressee}\n{street-name} {number}\n{neighborhood}\n{region}"
                        },
                        new
                        {
                            FormatId = 10,
                            CountryId = 3,
                            FormatName = "Chile (rural, with unit/apartment number)",
                            FormatPattern = "{addressee}\n{street-name} {number}, {unit}\n{postal-code} {town}\n{region}"
                        },
                        new
                        {
                            FormatId = 11,
                            CountryId = 3,
                            FormatName = "Chile (rural, no unit/apartment number)",
                            FormatPattern = "{addressee}\n{street-name} {number}\n{postal-code} {town}\n{region}"
                        },
                        new
                        {
                            FormatId = 12,
                            CountryId = 3,
                            FormatName = "Chile (rural, no individual house numbers)",
                            FormatPattern = "{addressee}\n{street-name}, {additional-information}\n{postal-code} {town}\n{region}"
                        },
                        new
                        {
                            FormatId = 13,
                            CountryId = 4,
                            FormatName = "Greece (non-international mail)",
                            FormatPattern = "{addressee}\n{street-address}\n{postal-code}, {town}"
                        },
                        new
                        {
                            FormatId = 14,
                            CountryId = 4,
                            FormatName = "Greece (international mail)",
                            FormatPattern = "{addressee}\n{street-address}\n{countrycode} {postal-code}, {town}"
                        },
                        new
                        {
                            FormatId = 15,
                            CountryId = 5,
                            FormatName = "India (general, international)",
                            FormatPattern = "{addressee} {relation} of {relation-name}\n{door-number} {street-number}, {street-name}\nvia {via-name}\n{post-name}\n{taluk-name}\n{locality}\n{city} - {postal-code}\n{district}\n{state}\n{country}"
                        },
                        new
                        {
                            FormatId = 16,
                            CountryId = 5,
                            FormatName = "India (rural)",
                            FormatPattern = "{addressee}\n{street-number}, {street-name}\n{village}\n{district}\n{postal-code}\n{state}"
                        },
                        new
                        {
                            FormatId = 17,
                            CountryId = 5,
                            FormatName = "India (urban)",
                            FormatPattern = "{addressee}\n{occupation}\n{unit}, {building}\n{street-number}, {street-name}\n{locality}\n{postal-code}\n{state}"
                        },
                        new
                        {
                            FormatId = 18,
                            CountryId = 6,
                            FormatName = "USA (general)",
                            FormatPattern = "{addressee}\n{house-number}, {street-name}, {unit}\n{city}, {state} {zipcode}"
                        });
                });

            modelBuilder.Entity("FormatterApi.Models.FormatField", b =>
                {
                    b.Property<int>("FormatFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.HasKey("FormatFieldId");

                    b.HasIndex("FieldId");

                    b.HasIndex("FormatId");

                    b.ToTable("FormatFields");
                });

            modelBuilder.Entity("FormatterApi.Models.Format", b =>
                {
                    b.HasOne("FormatterApi.Models.Country", "Country")
                        .WithMany("Formats")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FormatterApi.Models.FormatField", b =>
                {
                    b.HasOne("FormatterApi.Models.Field", "Field")
                        .WithMany("FormatFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormatterApi.Models.Format", "Format")
                        .WithMany("FormatFields")
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Format");
                });

            modelBuilder.Entity("FormatterApi.Models.Country", b =>
                {
                    b.Navigation("Formats");
                });

            modelBuilder.Entity("FormatterApi.Models.Field", b =>
                {
                    b.Navigation("FormatFields");
                });

            modelBuilder.Entity("FormatterApi.Models.Format", b =>
                {
                    b.Navigation("FormatFields");
                });
#pragma warning restore 612, 618
        }
    }
}
