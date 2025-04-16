﻿// <auto-generated />
using System;
using Domain.Models;
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

                    b.Property<Guid?>("JobApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobId")
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

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.AuthUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuthUsers");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.CompanyUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Company")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyNavigationId");

                    b.ToTable("CompanyUsers");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Industry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Industries");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Category")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Company")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Industry")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobLocation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobLocationNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JobSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PostedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostedByNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("JobLocationNavigationId");

                    b.HasIndex("PostedByNavigationId");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobProviderCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Industry")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LegalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Location")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationNavigationId");

                    b.ToTable("JobProviderCompanies");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobResponsibility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("JobPost")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobPostNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostNavigationId");

                    b.ToTable("JobResponsibilities");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeeker", b =>
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

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobSeekers");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobSeekerProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProfileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ResumeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("JobSeekerProfiles");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Qualification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobseekerProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Resume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("JobPost")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobPostNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobSeekerProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostNavigationId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.SystemUser", b =>
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

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemUsers");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.WorkExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.HasKey("Id");

                    b.HasIndex("JobSeekerProfileId");

                    b.ToTable("WorkExperiences");
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
                        .HasForeignKey("JobApplicationId");

                    b.HasOne("HireHorizonAPI.Models.JobPost", "Job")
                        .WithMany()
                        .HasForeignKey("JobId");

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
                    b.HasOne("HireHorizonAPI.Models.SystemUser", "SystemUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SystemUser");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.CompanyUser", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobProviderCompany", "CompanyNavigation")
                        .WithMany("CompanyUsers")
                        .HasForeignKey("CompanyNavigationId");

                    b.Navigation("CompanyNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobPost", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.Location", "JobLocationNavigation")
                        .WithMany("JobPosts")
                        .HasForeignKey("JobLocationNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireHorizonAPI.Models.CompanyUser", "PostedByNavigation")
                        .WithMany("JobPosts")
                        .HasForeignKey("PostedByNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobLocationNavigation");

                    b.Navigation("PostedByNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobProviderCompany", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.Location", "LocationNavigation")
                        .WithMany("JobProviderCompanies")
                        .HasForeignKey("LocationNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.JobResponsibility", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPostNavigation")
                        .WithMany("JobResponsibilities")
                        .HasForeignKey("JobPostNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobPostNavigation");
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
                        .HasForeignKey("JobPostId");

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.Skill", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobPost", "JobPostNavigation")
                        .WithMany("Skills")
                        .HasForeignKey("JobPostNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobPostNavigation");
                });

            modelBuilder.Entity("HireHorizonAPI.Models.WorkExperience", b =>
                {
                    b.HasOne("HireHorizonAPI.Models.JobSeekerProfile", "JobSeekerProfile")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("JobSeekerProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
#pragma warning restore 612, 618
        }
    }
}
