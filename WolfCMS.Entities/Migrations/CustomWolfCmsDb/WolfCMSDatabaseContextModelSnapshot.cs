﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WolfCMS.Entities.Concrete.EntityFramework;

#nullable disable

namespace WolfCMS.Entities.Migrations.CustomWolfCmsDb
{
    [DbContext(typeof(WolfCMSDatabaseContext))]
    partial class WolfCMSDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPermanentlyDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("IconId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPermanentlyDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("LogoId")
                        .HasColumnType("int");

                    b.Property<int>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPermanentlyDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantiityPerUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPermanentlyDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPermanentlyDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Product", b =>
                {
                    b.HasOne("WolfCMS.Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.User", b =>
                {
                    b.HasOne("WolfCMS.Entities.Concrete.Customer", "Customer")
                        .WithMany("Users")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.UserRole", b =>
                {
                    b.HasOne("WolfCMS.Entities.Concrete.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WolfCMS.Entities.Concrete.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Customer", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("WolfCMS.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}