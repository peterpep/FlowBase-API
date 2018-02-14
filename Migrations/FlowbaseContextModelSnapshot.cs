﻿// <auto-generated />
using FlowBaseAPI.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FlowBaseAPI.Migrations
{
    [DbContext(typeof(FlowbaseContext))]
    partial class FlowbaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("FlowBaseAPI.Models.Chemical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Barcode");

                    b.Property<string>("ChemicalName")
                        .IsRequired();

                    b.Property<string>("CommonName")
                        .IsRequired();

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("LotNumber")
                        .IsRequired();

                    b.Property<string>("ProjectCode")
                        .IsRequired();

                    b.Property<DateTime>("ReceiveDate");

                    b.Property<string>("SiemensMaterialNumber")
                        .IsRequired();

                    b.Property<string>("StorageTemperature")
                        .IsRequired();

                    b.Property<string>("VendorName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Chemicals");
                });

            modelBuilder.Entity("FlowBaseAPI.Models.DisposedChemical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Barcode");

                    b.Property<string>("ChemicalName")
                        .IsRequired();

                    b.Property<string>("CommonName")
                        .IsRequired();

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("LotNumber")
                        .IsRequired();

                    b.Property<string>("ProjectCode")
                        .IsRequired();

                    b.Property<DateTime>("ReceiveDate");

                    b.Property<string>("SiemensMaterialNumber")
                        .IsRequired();

                    b.Property<string>("StorageTemperature")
                        .IsRequired();

                    b.Property<string>("VendorName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("DisposedChemicals");
                });

            modelBuilder.Entity("FlowBaseAPI.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("FlowBaseAPI.Models.MetaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("MaxBarcode");

                    b.HasKey("Id");

                    b.ToTable("MetaData");
                });

            modelBuilder.Entity("FlowBaseAPI.Models.TempZone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StorageTemperature")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StorageTemperature")
                        .IsUnique();

                    b.ToTable("TempZones");
                });

            modelBuilder.Entity("FlowBaseAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("Notifications");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
