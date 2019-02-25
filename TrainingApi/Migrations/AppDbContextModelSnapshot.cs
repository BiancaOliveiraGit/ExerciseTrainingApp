﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingApi.Data;

namespace TrainingApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrainingApi.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, Name = "Shoulders" },
                        new { CategoryId = 2, Name = "Back" },
                        new { CategoryId = 3, Name = "Legs" }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("HomeAddress");

                    b.Property<string>("LastName");

                    b.Property<int>("Mobile");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new { ClientId = 1, Email = "buzz@gmail.com", FirstName = "Buzz", HomeAddress = "2 Galaxy Way Milkyway", LastName = "Lightyear", Mobile = 421055555 },
                        new { ClientId = 2, Email = "woody@gmail.com", FirstName = "Woody", HomeAddress = "5 Ranch Road Earth", LastName = "Cowboy", Mobile = 421054444 }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.ClientExercise", b =>
                {
                    b.Property<int>("ClientExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientWorkoutId");

                    b.Property<int>("ExerciseId");

                    b.Property<bool>("IsActive");

                    b.HasKey("ClientExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ClientExercises");

                    b.HasData(
                        new { ClientExerciseId = 1, ClientWorkoutId = 1, ExerciseId = 1, IsActive = true },
                        new { ClientExerciseId = 2, ClientWorkoutId = 1, ExerciseId = 2, IsActive = true },
                        new { ClientExerciseId = 3, ClientWorkoutId = 1, ExerciseId = 3, IsActive = true },
                        new { ClientExerciseId = 4, ClientWorkoutId = 2, ExerciseId = 2, IsActive = true },
                        new { ClientExerciseId = 5, ClientWorkoutId = 2, ExerciseId = 3, IsActive = true },
                        new { ClientExerciseId = 6, ClientWorkoutId = 2, ExerciseId = 1, IsActive = false }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.ClientWorkout", b =>
                {
                    b.Property<int>("ClientWorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientExerciseId");

                    b.Property<int>("ClientId");

                    b.Property<int>("Frequency");

                    b.Property<int>("WorkoutPlanId");

                    b.HasKey("ClientWorkoutId");

                    b.HasIndex("WorkoutPlanId");

                    b.ToTable("ClientWorkouts");

                    b.HasData(
                        new { ClientWorkoutId = 1, ClientExerciseId = 1, ClientId = 1, Frequency = 2, WorkoutPlanId = 4 },
                        new { ClientWorkoutId = 2, ClientExerciseId = 1, ClientId = 2, Frequency = 3, WorkoutPlanId = 4 }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("DoNotUse");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("VideoLibraryId");

                    b.HasKey("ExerciseId");

                    b.HasIndex("VideoLibraryId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new { ExerciseId = 1, CategoryId = 1, DoNotUse = false, Name = "Lateral Raise", VideoLibraryId = 1 },
                        new { ExerciseId = 2, CategoryId = 1, DoNotUse = false, Name = "Incline Front Raise", VideoLibraryId = 2 },
                        new { ExerciseId = 3, CategoryId = 1, DoNotUse = false, Name = "Band Overhead Press", VideoLibraryId = 3 }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.VideoLibrary", b =>
                {
                    b.Property<int>("VideoLibraryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltTag");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("DoNotUse");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("VideoUrl");

                    b.HasKey("VideoLibraryId");

                    b.ToTable("VideoLibraries");

                    b.HasData(
                        new { VideoLibraryId = 1, AltTag = "Lateral Raise", CreateDate = new DateTime(2019, 2, 11, 19, 25, 30, 750, DateTimeKind.Local), DoNotUse = false, ModifiedDate = new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), VideoUrl = "https://www.youtube.com/embed/0z-QQPzQHRE" },
                        new { VideoLibraryId = 2, AltTag = "Incline front Raise", CreateDate = new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), DoNotUse = false, ModifiedDate = new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), VideoUrl = "https://www.youtube.com/embed/2hLRHXZs15Y" },
                        new { VideoLibraryId = 3, AltTag = "Band Overhead Press", CreateDate = new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), DoNotUse = false, ModifiedDate = new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), VideoUrl = "https://www.youtube.com/embed/Zli1UXH9ZeE" }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.WorkoutExercise", b =>
                {
                    b.Property<int>("WorkoutExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DoNotUse");

                    b.Property<int>("ExerciseId");

                    b.Property<int>("WorkoutPlanId");

                    b.HasKey("WorkoutExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("WorkoutExercises");

                    b.HasData(
                        new { WorkoutExerciseId = 1, DoNotUse = false, ExerciseId = 1, WorkoutPlanId = 4 },
                        new { WorkoutExerciseId = 2, DoNotUse = false, ExerciseId = 2, WorkoutPlanId = 4 },
                        new { WorkoutExerciseId = 3, DoNotUse = false, ExerciseId = 3, WorkoutPlanId = 4 }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.WorkoutPlan", b =>
                {
                    b.Property<int>("WorkoutPlanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DoNotUse");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("WorkoutPlanId");

                    b.ToTable("WorkoutPlans");

                    b.HasData(
                        new { WorkoutPlanId = 4, DoNotUse = false, ImageUrl = "./images/Shoulders.jpg", Name = "Low Impact Shoulders" },
                        new { WorkoutPlanId = 5, DoNotUse = false, ImageUrl = "./images/legs.jpg", Name = "High Impact Legs" }
                    );
                });

            modelBuilder.Entity("TrainingApi.Data.ClientExercise", b =>
                {
                    b.HasOne("TrainingApi.Data.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingApi.Data.ClientWorkout", b =>
                {
                    b.HasOne("TrainingApi.Data.WorkoutPlan", "WorkoutPlan")
                        .WithMany()
                        .HasForeignKey("WorkoutPlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingApi.Data.Exercise", b =>
                {
                    b.HasOne("TrainingApi.Data.VideoLibrary", "VideoLibrary")
                        .WithMany()
                        .HasForeignKey("VideoLibraryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingApi.Data.WorkoutExercise", b =>
                {
                    b.HasOne("TrainingApi.Data.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
