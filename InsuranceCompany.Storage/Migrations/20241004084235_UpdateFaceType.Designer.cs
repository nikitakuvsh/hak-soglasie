﻿// <auto-generated />
using System;
using InsuranceCompany.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Storage.Migrations
{
    [DbContext(typeof(InsuranceCompanyDbContext))]
    [Migration("20241004084235_UpdateFaceType")]
    partial class UpdateFaceType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.AgentAgreementEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgentId")
                        .HasColumnType("integer");

                    b.Property<int>("LOBId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Rate")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("LOBId");

                    b.ToTable("AGENT_AGREEMENTS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.AgentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset?>("DateBegin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateCreate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FaceId")
                        .HasColumnType("integer");

                    b.Property<int>("IKPId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FaceId")
                        .IsUnique();

                    b.HasIndex("IKPId");

                    b.HasIndex("StatusId");

                    b.ToTable("AGENTS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ContractEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgentId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Commission")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateSign")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("InsuranceSum")
                        .HasColumnType("numeric");

                    b.Property<int?>("InsuredPersonId")
                        .HasColumnType("integer");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int?>("PolicyHolderId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Premium")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Rate")
                        .HasColumnType("numeric");

                    b.Property<int>("Status")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("InsuredPersonId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PolicyHolderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CONTRACTS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ContractRiskEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("InsuranceSum")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Premium")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("CONTRACT_RISKS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.FaceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int?>("INN")
                        .HasColumnType("integer");

                    b.Property<string>("Lastname")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("SecondName")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int>("Type")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("FACES", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.IKPEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("IKPS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.LOBEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("LOBS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Formula")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LOBId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("LOBId");

                    b.ToTable("PRODUCTS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductMetafieldEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("JsonData")
                        .IsRequired()
                        .HasColumnType("json");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("PRODUCT_METAFIELDS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductRiskEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("InsuranceSum")
                        .HasColumnType("numeric");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal?>("Premium")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("PRODUCT_RISKS", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.StatusAgentContractEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("STATUSES_AGENT_CONTRACT", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.AgentAgreementEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.AgentEntity", "Agent")
                        .WithMany("AgentAgreements")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Storage.Entities.LOBEntity", "LOB")
                        .WithMany("AgentAgreements")
                        .HasForeignKey("LOBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("LOB");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.AgentEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.FaceEntity", "Face")
                        .WithOne("AgentEntity")
                        .HasForeignKey("InsuranceCompany.Storage.Entities.AgentEntity", "FaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Storage.Entities.IKPEntity", "IKP")
                        .WithMany("Agents")
                        .HasForeignKey("IKPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Storage.Entities.StatusAgentContractEntity", "Status")
                        .WithMany("Agents")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Face");

                    b.Navigation("IKP");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ContractEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.AgentEntity", "Agent")
                        .WithMany("Contracts")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Storage.Entities.FaceEntity", "InsuredPerson")
                        .WithMany("InsuredPersonContracts")
                        .HasForeignKey("InsuredPersonId");

                    b.HasOne("InsuranceCompany.Storage.Entities.FaceEntity", "Owner")
                        .WithMany("OwnerContracts")
                        .HasForeignKey("OwnerId");

                    b.HasOne("InsuranceCompany.Storage.Entities.FaceEntity", "PolicyHolder")
                        .WithMany("PolicyHolderContracts")
                        .HasForeignKey("PolicyHolderId");

                    b.HasOne("InsuranceCompany.Storage.Entities.ProductEntity", "Product")
                        .WithMany("Contracts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("InsuredPerson");

                    b.Navigation("Owner");

                    b.Navigation("PolicyHolder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ContractRiskEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.ContractEntity", "Contract")
                        .WithMany("ContractRisks")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.LOBEntity", "LOB")
                        .WithMany("Products")
                        .HasForeignKey("LOBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LOB");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductMetafieldEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.ProductEntity", "Product")
                        .WithMany("ProductMetafield")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductRiskEntity", b =>
                {
                    b.HasOne("InsuranceCompany.Storage.Entities.ProductEntity", "Product")
                        .WithMany("ProductRisks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.AgentEntity", b =>
                {
                    b.Navigation("AgentAgreements");

                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ContractEntity", b =>
                {
                    b.Navigation("ContractRisks");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.FaceEntity", b =>
                {
                    b.Navigation("AgentEntity")
                        .IsRequired();

                    b.Navigation("InsuredPersonContracts");

                    b.Navigation("OwnerContracts");

                    b.Navigation("PolicyHolderContracts");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.IKPEntity", b =>
                {
                    b.Navigation("Agents");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.LOBEntity", b =>
                {
                    b.Navigation("AgentAgreements");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.ProductEntity", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("ProductMetafield");

                    b.Navigation("ProductRisks");
                });

            modelBuilder.Entity("InsuranceCompany.Storage.Entities.StatusAgentContractEntity", b =>
                {
                    b.Navigation("Agents");
                });
#pragma warning restore 612, 618
        }
    }
}
