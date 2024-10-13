﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RafahiaBlazorApp.Models;

#nullable disable

namespace RafahiaBlazorApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240129202111_TokenState")]
    partial class TokenState
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.ActivityContent", b =>
                {
                    b.Property<int>("IDContent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDContent"), 1L, 1);

                    b.Property<string>("DescriptionContent")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("IDActivity")
                        .HasColumnType("int");

                    b.Property<string>("Internet")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("NumberBathRoom")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("NumberContent")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("NumberRoom")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PriceContent")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("StateContent")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("TV")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("IDContent");

                    b.HasIndex("IDActivity");

                    b.HasIndex("TypeId");

                    b.ToTable("ActivityContent", "RH");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.ActivityRegister", b =>
                {
                    b.Property<int>("IDActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDActivity"), 1L, 1);

                    b.Property<string>("AddressIctivity")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("ContryIctivity")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("DescriptionIctivity")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("ImageActivity")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("NameIctivity")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PhoneIctivity")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("StarsIctivity")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("parking")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("restaurant")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("swimmingpool")
                        .HasColumnType("varchar(250)");

                    b.HasKey("IDActivity");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserID");

                    b.ToTable("ActivityRegister", "RH");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.TPBooking", b =>
                {
                    b.Property<int>("IDBooking")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDBooking"), 1L, 1);

                    b.Property<int>("IDContent")
                        .HasColumnType("int");

                    b.Property<string>("PriceBooking")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("StateBooking")
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime?>("TimeIN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TimeOUT")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDBooking");

                    b.HasIndex("IDContent");

                    b.HasIndex("UserID");

                    b.ToTable("Booking", "RH");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.TPImage", b =>
                {
                    b.Property<int>("IDImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDImage"), 1L, 1);

                    b.Property<string>("Extention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDContent")
                        .HasColumnType("int");

                    b.Property<string>("NameImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SizeImage")
                        .HasColumnType("bigint");

                    b.Property<string>("Typeiamge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URLImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDImage");

                    b.HasIndex("IDContent");

                    b.ToTable("Image", "RH");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.TypeContent", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("TypeId");

                    b.ToTable("TypeContent", "RH");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.TypeIctivity", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("TypeId");

                    b.ToTable("TypeActivity", "RH");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RafahiaBlazorApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.ActivityContent", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.ActivityRegister", "activityRegister")
                        .WithMany()
                        .HasForeignKey("IDActivity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RafahiaBlazorApp.Models.TypeContent", "type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("activityRegister");

                    b.Navigation("type");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.ActivityRegister", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.TypeIctivity", "type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RafahiaBlazorApp.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");

                    b.Navigation("type");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.ApplicationUser", b =>
                {
                    b.OwnsMany("RafahiaBlazorApp.Models.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<string>("ApplicationUserId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<DateTime>("CreatedOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("ExpiresOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("RevokedOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Token")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ApplicationUserId", "Id");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.TPBooking", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.ActivityContent", "activityContent")
                        .WithMany()
                        .HasForeignKey("IDContent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RafahiaBlazorApp.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");

                    b.Navigation("activityContent");
                });

            modelBuilder.Entity("RafahiaBlazorApp.Models.TPImage", b =>
                {
                    b.HasOne("RafahiaBlazorApp.Models.ActivityContent", "activityContent")
                        .WithMany()
                        .HasForeignKey("IDContent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("activityContent");
                });
#pragma warning restore 612, 618
        }
    }
}
