// <auto-generated />
using System;
using LevelApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LevelApp.DAL.Migrations
{
    [DbContext(typeof(LevelAppContext))]
    [Migration("20191019123702_InitialLevelAppMigration")]
    partial class InitialLevelAppMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LevelApp.DAL.Models.Core.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime?>("DateCreatedUtc");

                    b.Property<DateTime?>("DateDeletedUtc");

                    b.Property<DateTime?>("DateModifiedUtc");

                    b.Property<int?>("DeletedBy");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.Property<int?>("ModifiedBy");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CoreAppUser");
                });
#pragma warning restore 612, 618
        }
    }
}
