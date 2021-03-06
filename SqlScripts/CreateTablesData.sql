USE [TrainingApiDB]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClientExercises]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientExercises](
	[ClientExerciseId] [int] IDENTITY(1,1) NOT NULL,
	[ClientWorkoutId] [int] NOT NULL,
	[ExerciseId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_ClientExercises] PRIMARY KEY CLUSTERED 
(
	[ClientExerciseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[HomeAddress] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Mobile] [int] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClientWorkouts]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientWorkouts](
	[ClientWorkoutId] [int] IDENTITY(1,1) NOT NULL,
	[WorkoutPlanId] [int] NOT NULL,
	[Frequency] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
 CONSTRAINT [PK_ClientWorkouts] PRIMARY KEY CLUSTERED 
(
	[ClientWorkoutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exercises]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exercises](
	[ExerciseId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[CategoryId] [int] NOT NULL,
	[VideoLibraryId] [int] NOT NULL,
	[DoNotUse] [bit] NOT NULL,
 CONSTRAINT [PK_Exercises] PRIMARY KEY CLUSTERED 
(
	[ExerciseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VideoLibraries]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoLibraries](
	[VideoLibraryId] [int] IDENTITY(1,1) NOT NULL,
	[VideoUrl] [nvarchar](max) NULL,
	[AltTag] [nvarchar](max) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[DoNotUse] [bit] NOT NULL,
 CONSTRAINT [PK_VideoLibraries] PRIMARY KEY CLUSTERED 
(
	[VideoLibraryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkoutExercises]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkoutExercises](
	[WorkoutExerciseId] [int] IDENTITY(1,1) NOT NULL,
	[WorkoutPlanId] [int] NOT NULL,
	[ExerciseId] [int] NOT NULL,
	[DoNotUse] [bit] NOT NULL,
 CONSTRAINT [PK_WorkoutExercises] PRIMARY KEY CLUSTERED 
(
	[WorkoutExerciseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkoutPlans]    Script Date: 22/11/2018 9:01:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkoutPlans](
	[WorkoutPlanId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DoNotUse] [bit] NOT NULL,
 CONSTRAINT [PK_WorkoutPlans] PRIMARY KEY CLUSTERED 
(
	[WorkoutPlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

GO
INSERT [dbo].[Categories] ([CategoryId], [Name]) VALUES (1, N'Shoulders')
GO
INSERT [dbo].[Categories] ([CategoryId], [Name]) VALUES (2, N'Back')
GO
INSERT [dbo].[Categories] ([CategoryId], [Name]) VALUES (3, N'Legs')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientExercises] ON 

GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (2, 1, 2, 1)
GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (3, 1, 3, 1)
GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (4, 2, 2, 1)
GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (5, 2, 3, 1)
GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (6, 2, 1, 0)
GO
INSERT [dbo].[ClientExercises] ([ClientExerciseId], [ClientWorkoutId], [ExerciseId], [IsActive]) VALUES (7, 3, 3, 1)
GO
SET IDENTITY_INSERT [dbo].[ClientExercises] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

GO
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [HomeAddress], [Email], [Mobile]) VALUES (1, N'Buzz', N'Lightyear', N'2 Galaxy Way Milkyway', N'1', 421055555)
GO
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [HomeAddress], [Email], [Mobile]) VALUES (2, N'Woody', N'Cowboy', N'5 Ranch Road Earth', N'2', 421054444)
GO
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientWorkouts] ON 

GO
INSERT [dbo].[ClientWorkouts] ([ClientWorkoutId], [WorkoutPlanId], [Frequency], [ClientId]) VALUES (1, 4, 2, 1)
GO
INSERT [dbo].[ClientWorkouts] ([ClientWorkoutId], [WorkoutPlanId], [Frequency], [ClientId]) VALUES (2, 4, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[ClientWorkouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Exercises] ON 

GO
INSERT [dbo].[Exercises] ([ExerciseId], [Name], [CategoryId], [VideoLibraryId], [DoNotUse]) VALUES (1, N'Lateral Raise', 1, 1, 0)
GO
INSERT [dbo].[Exercises] ([ExerciseId], [Name], [CategoryId], [VideoLibraryId], [DoNotUse]) VALUES (2, N'Incline Front Raise', 1, 2, 0)
GO
INSERT [dbo].[Exercises] ([ExerciseId], [Name], [CategoryId], [VideoLibraryId], [DoNotUse]) VALUES (3, N'Band Overhead Press', 1, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[Exercises] OFF
GO
SET IDENTITY_INSERT [dbo].[VideoLibraries] ON 

GO
INSERT [dbo].[VideoLibraries] ([VideoLibraryId], [VideoUrl], [AltTag], [CreateDate], [ModifiedDate], [DoNotUse]) VALUES (1, N'C:\Users\biancav\Pictures\Exercises\LaterialRaise', N'Lateral Raise', CAST(N'2018-11-22T00:00:00.0000000' AS DateTime2), CAST(N'2018-11-22T00:00:00.0000000' AS DateTime2), 0)
GO
INSERT [dbo].[VideoLibraries] ([VideoLibraryId], [VideoUrl], [AltTag], [CreateDate], [ModifiedDate], [DoNotUse]) VALUES (3, N'C:\Users\biancav\Pictures\Exercises\InclineFrontRaise', N'Incline front Raise', CAST(N'2018-11-22T00:00:00.0000000' AS DateTime2), CAST(N'2018-11-22T00:00:00.0000000' AS DateTime2), 0)
GO
INSERT [dbo].[VideoLibraries] ([VideoLibraryId], [VideoUrl], [AltTag], [CreateDate], [ModifiedDate], [DoNotUse]) VALUES (4, N'C:\Users\biancav\Pictures\Exercises\BandOverheadPress', N'Band Overhead Press', CAST(N'2018-11-22T00:00:00.0000000' AS DateTime2), CAST(N'2018-11-22T00:00:00.0000000' AS DateTime2), 0)
GO
SET IDENTITY_INSERT [dbo].[VideoLibraries] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkoutExercises] ON 

GO
INSERT [dbo].[WorkoutExercises] ([WorkoutExerciseId], [WorkoutPlanId], [ExerciseId], [DoNotUse]) VALUES (1, 4, 1, 0)
GO
INSERT [dbo].[WorkoutExercises] ([WorkoutExerciseId], [WorkoutPlanId], [ExerciseId], [DoNotUse]) VALUES (2, 4, 2, 0)
GO
INSERT [dbo].[WorkoutExercises] ([WorkoutExerciseId], [WorkoutPlanId], [ExerciseId], [DoNotUse]) VALUES (3, 4, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[WorkoutExercises] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkoutPlans] ON 

GO
INSERT [dbo].[WorkoutPlans] ([WorkoutPlanId], [Name], [DoNotUse]) VALUES (4, N'Low Impact Shoulders', 0)
GO
SET IDENTITY_INSERT [dbo].[WorkoutPlans] OFF
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [Mobile]
GO
ALTER TABLE [dbo].[ClientWorkouts] ADD  DEFAULT ((0)) FOR [ClientId]
GO
