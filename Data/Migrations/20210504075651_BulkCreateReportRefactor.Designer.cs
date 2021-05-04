﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.QendraFolApi.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210504075651_BulkCreateReportRefactor")]
    partial class BulkCreateReportRefactor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Entities.ApiRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Pershkrim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("BackEnd.Entities.ApiUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DiteLindja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Emer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gjinia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Mbiemer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NrTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BackEnd.Entities.ApiUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("BackEnd.Entities.BulkCreateReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfImport")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImportFailedIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrImportFailure")
                        .HasColumnType("int");

                    b.Property<int>("NrImportSuccess")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BulkCreateReport");
                });

            modelBuilder.Entity("BackEnd.Entities.Fotografia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiUserId");

                    b.ToTable("Fotografia");
                });

            modelBuilder.Entity("BackEnd.Entities.OldCeshtja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data_Gjygjtari_pr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_Gjykata_Larte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_Vedim_Gjk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_Vendim_Apeli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_Vendimit_GJ_SH1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_Vendimit_Pr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_e_ngjarjes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_mas_sig_Apeli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_mas_sig_Gj_Larte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_mases_Gjykates_Shk1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gjygjtari_paraprak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gjykata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hetimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masa_e_sigurise_Gjykata_Shk1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masa_e_sigurisë_kërkuar_nga_Prokurori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masa_e_sigurisë_në_Gjykatën_e_Apelit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masa_e_sigurisë_në_Gjykatën_e_Larte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neni_Apeli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neni_GJL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neni_GJP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neni_GJSH1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OldId")
                        .HasColumnType("int");

                    b.Property<string>("Policia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prokuroria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sipas_Nenit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sipas_Nenit_P")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendim_Gjykata_Larte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendimi_Apelit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendimi_Gjykates_Shk1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OldCeshtja");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BackEnd.Entities.ApiUserRole", b =>
                {
                    b.HasOne("BackEnd.Entities.ApiRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Entities.ApiUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackEnd.Entities.Fotografia", b =>
                {
                    b.HasOne("BackEnd.Entities.ApiUser", "ApiUser")
                        .WithMany("Fotografite")
                        .HasForeignKey("ApiUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BackEnd.Entities.ApiRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BackEnd.Entities.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BackEnd.Entities.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BackEnd.Entities.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Entities.ApiRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BackEnd.Entities.ApiUser", b =>
                {
                    b.Navigation("Fotografite");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
