﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apiLeviathansChilds.infra.persistence;

namespace apiLeviathansChilds.infra.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("apiLeviathansChilds.domain.entities.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nick")
                        .IsRequired()
                        .HasColumnName("nick")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("status")
                        .HasColumnName("status");

                    b.HasKey("id");

                    b.HasIndex("nick")
                        .IsUnique()
                        .HasName("UK_USER_NICK");

                    b.ToTable("user");
                });

            modelBuilder.Entity("apiLeviathansChilds.domain.entities.User", b =>
                {
                    b.OwnsOne("apiLeviathansChilds.domain.valueObjects.Email", "email", b1 =>
                        {
                            b1.Property<Guid>("Userid");

                            b1.Property<string>("adress")
                                .IsRequired()
                                .HasColumnName("email")
                                .HasColumnType("varchar(50)");

                            b1.HasKey("Userid");

                            b1.HasIndex("adress")
                                .IsUnique()
                                .HasName("UK_USER_EMAIL");

                            b1.ToTable("user");

                            b1.HasOne("apiLeviathansChilds.domain.entities.User")
                                .WithOne("email")
                                .HasForeignKey("apiLeviathansChilds.domain.valueObjects.Email", "Userid")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("apiLeviathansChilds.domain.valueObjects.RealName", "name", b1 =>
                        {
                            b1.Property<Guid>("Userid");

                            b1.Property<string>("firstName")
                                .IsRequired()
                                .HasColumnName("firstName")
                                .HasColumnType("varchar(50)");

                            b1.Property<string>("lastName")
                                .IsRequired()
                                .HasColumnName("lastName")
                                .HasColumnType("varchar(50)");

                            b1.HasKey("Userid");

                            b1.ToTable("user");

                            b1.HasOne("apiLeviathansChilds.domain.entities.User")
                                .WithOne("name")
                                .HasForeignKey("apiLeviathansChilds.domain.valueObjects.RealName", "Userid")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
