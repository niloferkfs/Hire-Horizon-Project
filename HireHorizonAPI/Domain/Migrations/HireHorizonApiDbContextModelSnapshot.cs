﻿// <auto-generated />
using System;
using HireHorizonAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(HireHorizonApiDbContext))]
    partial class HireHorizonApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.JobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoverLetter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("JobPostId");

                    b.HasIndex("ResumeId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("Domain.Models.JobInterview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateScheduled")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IntervieweeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScheduledById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IntervieweeId");

                    b.HasIndex("JobApplicationId");

                    b.HasIndex("JobId");

                    b.HasIndex("ScheduledById");

                    b.ToTable("JobInterviews");
                });

            modelBuilder.Entity("Domain.Models.SavedJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateSaved")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SavedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.HasIndex("SavedById");

                    b.ToTable("SavedJobs");
                });

            modelBuilder.Entity("Domain.Models.SignUpRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SignUpRequests");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.AuthUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SystemUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SystemUserId");

                    b.ToTable("AuthUser", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.CompanyUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Company")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Company");

                    b.ToTable("CompanyUser", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Industry", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Industry", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobCategory", b =>
                {
                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.ToTable("JobCategory", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobPost", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Category")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Company")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Industry")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobLocation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JobSummary")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<Guid>("PostedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("JobLocation");

                    b.HasIndex("PostedBy");

                    b.ToTable("JobPost", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobProviderCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Industry")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LegalName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Location")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Location");

                    b.ToTable("JobProviderCompany", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobResponsibility", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<Guid>("JobPost")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("JobPost");

                    b.ToTable("JobResponsibility", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeeker", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobSeeker", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeekerProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProfileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("JobSeekerProfile", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Location", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Qualification", b =>
                {
                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobseekerProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasIndex("JobPostId");

                    b.ToTable("Qualification", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Resume", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resume", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Role", b =>
                {
                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("JobPost")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobSeekerProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("JobPost");

                    b.ToTable("Skill", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.SystemUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemUser", (string)null);
                });

            modelBuilder.Entity("HireHorizonAPI.Models.WorkExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("JobSeekerProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ServiceEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServiceStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Experiences");

                    b.HasIndex("JobSeekerProfileId");

                    b.ToTable("WorkExperience", (string)null);
                });

            modelBuilder.Entity("Domain.Models.JobApplication", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobSeeker", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPost")
                        .WithMany()
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.Resume", "Resume")
                        .WithMany()
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("JobPost");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("Domain.Models.JobInterview", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobSeeker", "Interviewee")
                        .WithMany()
                        .HasForeignKey("IntervieweeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.JobApplication", "JobApplication")
                        .WithMany()
                        .HasForeignKey("JobApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.JobPost", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.CompanyUser", "ScheduledBy")
                        .WithMany()
                        .HasForeignKey("ScheduledById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interviewee");

                    b.Navigation("Job");

                    b.Navigation("JobApplication");

                    b.Navigation("ScheduledBy");
                });

            modelBuilder.Entity("Domain.Models.SavedJob", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPost")
                        .WithMany()
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.JobSeeker", "SavedBy")
                        .WithMany()
                        .HasForeignKey("SavedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobPost");

                    b.Navigation("SavedBy");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.AuthUser", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.SystemUser", "IdNavigation")
                        .WithOne("AuthUserIdNavigation")
                        .HasForeignKey("HireHorizonAPI.Models.AuthUser", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.SystemUser", "SystemUser")
                        .WithMany("AuthUserSystemUsers")
                        .HasForeignKey("SystemUserId")
                        .IsRequired();

                    b.Navigation("IdNavigation");

                    b.Navigation("SystemUser");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.CompanyUser", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobProviderCompany", "CompanyNavigation")
                        .WithMany("CompanyUsers")
                        .HasForeignKey("Company")
                        .HasConstraintName("FK_CompanyUser_JobProviderCompany");

                    b.Navigation("CompanyNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobPost", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.Location", "JobLocationNavigation")
                        .WithMany("JobPosts")
                        .HasForeignKey("JobLocation")
                        .IsRequired()
                        .HasConstraintName("FK_JobPost_Location");

                    b.HasOne("HireHorizonAPI.Models.CompanyUser", "PostedByNavigation")
                        .WithMany("JobPosts")
                        .HasForeignKey("PostedBy")
                        .IsRequired()
                        .HasConstraintName("FK_JobPost_Industry");

                    b.Navigation("JobLocationNavigation");

                    b.Navigation("PostedByNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobProviderCompany", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.Location", "LocationNavigation")
                        .WithMany("JobProviderCompanies")
                        .HasForeignKey("Location")
                        .IsRequired()
                        .HasConstraintName("FK_JobProviderCompany_Location");

                    b.Navigation("LocationNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobResponsibility", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPostNavigation")
                        .WithMany("JobResponsibilities")
                        .HasForeignKey("JobPost")
                        .IsRequired()
                        .HasConstraintName("FK_JobResponsibility_JobPost");

                    b.Navigation("JobPostNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeeker", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.SystemUser", "IdNavigation")
                        .WithOne("JobSeeker")
                        .HasForeignKey("HireHorizonAPI.Models.JobSeeker", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeekerProfile", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.Resume", "Resume")
                        .WithMany("JobSeekerProfiles")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Qualification", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPost")
                        .WithMany()
                        .HasForeignKey("JobPostId")
                        .HasConstraintName("FK_Qualification_JobSeekerProfile");

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Skill", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPostNavigation")
                        .WithMany("Skills")
                        .HasForeignKey("JobPost")
                        .IsRequired()
                        .HasConstraintName("FK_Skill_JobSeekerProfile1");

                    b.Navigation("JobPostNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.WorkExperience", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobSeekerProfile", "JobSeekerProfile")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("JobSeekerProfileId")
                        .IsRequired()
                        .HasConstraintName("FK_WorkExperience_JobSeekerProfile");

                    b.Navigation("JobSeekerProfile");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.CompanyUser", b =>
                {
                    b.Navigation("JobPosts");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobPost", b =>
                {
                    b.Navigation("JobResponsibilities");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobProviderCompany", b =>
                {
                    b.Navigation("CompanyUsers");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeekerProfile", b =>
                {
                    b.Navigation("WorkExperiences");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Location", b =>
                {
                    b.Navigation("JobPosts");

                    b.Navigation("JobProviderCompanies");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Resume", b =>
                {
                    b.Navigation("JobSeekerProfiles");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.SystemUser", b =>
                {
                    b.Navigation("AuthUserIdNavigation");

                    b.Navigation("AuthUserSystemUsers");

                    b.Navigation("JobSeeker");
                });
#pragma warning restore 612, 618
        }
    }
}
