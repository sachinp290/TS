/****** Object:  Database [TS]    Script Date: 04/12/2020 17:11:07 ******/
CREATE DATABASE [TS] ON  PRIMARY 
( NAME = N'TS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\TS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\TS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TS] SET ARITHABORT OFF
GO
ALTER DATABASE [TS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [TS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TS] SET  DISABLE_BROKER
GO
ALTER DATABASE [TS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TS] SET  READ_WRITE
GO
ALTER DATABASE [TS] SET RECOVERY SIMPLE
GO
ALTER DATABASE [TS] SET  MULTI_USER
GO
ALTER DATABASE [TS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TS] SET DB_CHAINING OFF
GO
/****** Object:  ForeignKey [FK_Topic_Subject]    Script Date: 04/12/2020 17:11:14 ******/
ALTER TABLE [dbo].[Topic] DROP CONSTRAINT [FK_Topic_Subject]
GO
/****** Object:  ForeignKey [FK_TestConfiguration_Complexity]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[TestConfiguration] DROP CONSTRAINT [FK_TestConfiguration_Complexity]
GO
/****** Object:  ForeignKey [FK_TestConfiguration_TestType]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[TestConfiguration] DROP CONSTRAINT [FK_TestConfiguration_TestType]
GO
/****** Object:  ForeignKey [FK_Test_TestConfiguration]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[Test] DROP CONSTRAINT [FK_Test_TestConfiguration]
GO
/****** Object:  ForeignKey [FK_Question_Complexity]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Complexity]
GO
/****** Object:  ForeignKey [FK_Question_Topic]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Topic]
GO
/****** Object:  ForeignKey [FK_TestSeries_TestConfiguration]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSeries] DROP CONSTRAINT [FK_TestSeries_TestConfiguration]
GO
/****** Object:  ForeignKey [FK_TestSubjects_Subject]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSubjects] DROP CONSTRAINT [FK_TestSubjects_Subject]
GO
/****** Object:  ForeignKey [FK_TestSubjects_Test]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSubjects] DROP CONSTRAINT [FK_TestSubjects_Test]
GO
/****** Object:  StoredProcedure [dbo].[AddTestSubject]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[AddTestSubject]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTestSubject]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[DeleteTestSubject]
GO
/****** Object:  StoredProcedure [dbo].[GetTestSubjects]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[GetTestSubjects]
GO
/****** Object:  StoredProcedure [dbo].[GetQuestions]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[GetQuestions]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTestSeries]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[DeleteTestSeries]
GO
/****** Object:  StoredProcedure [dbo].[GetTests]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[GetTests]
GO
/****** Object:  StoredProcedure [dbo].[GetTestSerieses]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[GetTestSerieses]
GO
/****** Object:  StoredProcedure [dbo].[DeleteQuestion]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[DeleteQuestion]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTest]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[DeleteTest]
GO
/****** Object:  Table [dbo].[TestSubjects]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSubjects] DROP CONSTRAINT [FK_TestSubjects_Subject]
GO
ALTER TABLE [dbo].[TestSubjects] DROP CONSTRAINT [FK_TestSubjects_Test]
GO
DROP TABLE [dbo].[TestSubjects]
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuestion]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[UpdateQuestion]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTest]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[UpdateTest]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTestSeries]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[UpdateTestSeries]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTopic]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[UpdateTopic]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTestConfiguration]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[UpdateTestConfiguration]
GO
/****** Object:  Table [dbo].[TestSeries]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSeries] DROP CONSTRAINT [FK_TestSeries_TestConfiguration]
GO
ALTER TABLE [dbo].[TestSeries] DROP CONSTRAINT [DF_TestSeries_IsReady]
GO
DROP TABLE [dbo].[TestSeries]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTestConfiguration]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[DeleteTestConfiguration]
GO
/****** Object:  StoredProcedure [dbo].[GetTestConfigurations]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[GetTestConfigurations]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTopic]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[DeleteTopic]
GO
/****** Object:  StoredProcedure [dbo].[GetTopics]    Script Date: 04/12/2020 17:11:27 ******/
DROP PROCEDURE [dbo].[GetTopics]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Complexity]
GO
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Topic]
GO
DROP TABLE [dbo].[Question]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[Test] DROP CONSTRAINT [FK_Test_TestConfiguration]
GO
ALTER TABLE [dbo].[Test] DROP CONSTRAINT [DF_Test_IsReady]
GO
DROP TABLE [dbo].[Test]
GO
/****** Object:  Table [dbo].[TestConfiguration]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[TestConfiguration] DROP CONSTRAINT [FK_TestConfiguration_Complexity]
GO
ALTER TABLE [dbo].[TestConfiguration] DROP CONSTRAINT [FK_TestConfiguration_TestType]
GO
DROP TABLE [dbo].[TestConfiguration]
GO
/****** Object:  StoredProcedure [dbo].[GetSubjects]    Script Date: 04/12/2020 17:11:26 ******/
DROP PROCEDURE [dbo].[GetSubjects]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSubject]    Script Date: 04/12/2020 17:11:26 ******/
DROP PROCEDURE [dbo].[DeleteSubject]
GO
/****** Object:  StoredProcedure [dbo].[UpdateSubject]    Script Date: 04/12/2020 17:11:26 ******/
DROP PROCEDURE [dbo].[UpdateSubject]
GO
/****** Object:  Table [dbo].[Topic]    Script Date: 04/12/2020 17:11:14 ******/
ALTER TABLE [dbo].[Topic] DROP CONSTRAINT [FK_Topic_Subject]
GO
DROP TABLE [dbo].[Topic]
GO
/****** Object:  Table [dbo].[TestType]    Script Date: 04/12/2020 17:11:14 ******/
DROP TABLE [dbo].[TestType]
GO
/****** Object:  Table [dbo].[Complexity]    Script Date: 04/12/2020 17:11:14 ******/
DROP TABLE [dbo].[Complexity]
GO
/****** Object:  Table [dbo].[TestQuestions]    Script Date: 04/12/2020 17:11:13 ******/
DROP TABLE [dbo].[TestQuestions]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 04/12/2020 17:11:13 ******/
DROP TABLE [dbo].[Subject]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 04/12/2020 17:11:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Subject] ON
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (1, N'Test changed')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (2, N'Test 2')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (3, N'This was Test 4')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (15, N'new')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (16, N'29 March')
SET IDENTITY_INSERT [dbo].[Subject] OFF
/****** Object:  Table [dbo].[TestQuestions]    Script Date: 04/12/2020 17:11:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestQuestions](
	[TestID] [int] NOT NULL,
	[QuestionID] [int] NOT NULL,
 CONSTRAINT [PK_TestQuestions] PRIMARY KEY CLUSTERED 
(
	[TestID] ASC,
	[QuestionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Complexity]    Script Date: 04/12/2020 17:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Complexity](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Complexity] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Complexity] ON
INSERT [dbo].[Complexity] ([ID], [Name]) VALUES (1, N'Super Easy')
INSERT [dbo].[Complexity] ([ID], [Name]) VALUES (2, N'Easy')
INSERT [dbo].[Complexity] ([ID], [Name]) VALUES (3, N'Medium')
INSERT [dbo].[Complexity] ([ID], [Name]) VALUES (4, N'Hard')
INSERT [dbo].[Complexity] ([ID], [Name]) VALUES (5, N'Super Hard')
SET IDENTITY_INSERT [dbo].[Complexity] OFF
/****** Object:  Table [dbo].[TestType]    Script Date: 04/12/2020 17:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TestType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TestType] ON
INSERT [dbo].[TestType] ([ID], [Name]) VALUES (1, N'Type 1')
INSERT [dbo].[TestType] ([ID], [Name]) VALUES (2, N'Type 2')
INSERT [dbo].[TestType] ([ID], [Name]) VALUES (3, N'Type 3')
INSERT [dbo].[TestType] ([ID], [Name]) VALUES (4, N'Type 4')
INSERT [dbo].[TestType] ([ID], [Name]) VALUES (5, N'Type 5')
SET IDENTITY_INSERT [dbo].[TestType] OFF
/****** Object:  Table [dbo].[Topic]    Script Date: 04/12/2020 17:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Topic] ON
INSERT [dbo].[Topic] ([ID], [Name], [SubjectID]) VALUES (2, N'Test Topic 2', 1)
INSERT [dbo].[Topic] ([ID], [Name], [SubjectID]) VALUES (5, N'Test Topic 5', 3)
INSERT [dbo].[Topic] ([ID], [Name], [SubjectID]) VALUES (8, N'latest 1', 2)
INSERT [dbo].[Topic] ([ID], [Name], [SubjectID]) VALUES (10, N'.Net', 15)
INSERT [dbo].[Topic] ([ID], [Name], [SubjectID]) VALUES (12, N'dd', 2)
SET IDENTITY_INSERT [dbo].[Topic] OFF
/****** Object:  StoredProcedure [dbo].[UpdateSubject]    Script Date: 04/12/2020 17:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Subjects
-- =============================================
Create PROCEDURE [dbo].[UpdateSubject]
@id int = 0,
@name nvarchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		Insert into Subject (Name) values(@name);
	END
	ELSE
	BEGIN
		Update Subject
		set Name = @name
		where ID = @id
	END

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteSubject]    Script Date: 04/12/2020 17:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Subject
-- =============================================
CREATE PROCEDURE [dbo].[DeleteSubject]
	@id int 
AS
BEGIN
	Delete from Subject where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetSubjects]    Script Date: 04/12/2020 17:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Subjects
-- =============================================
CREATE PROCEDURE [dbo].[GetSubjects]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select ID,Name from Subject where @id is null or ID=@id

END
GO
/****** Object:  Table [dbo].[TestConfiguration]    Script Date: 04/12/2020 17:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestConfiguration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TestTypeId] [int] NOT NULL,
	[ComplexityId] [int] NOT NULL,
	[NoOfTotalQuestions] [int] NOT NULL,
	[NoOfQuestions] [int] NOT NULL,
	[CorrectAnswersToPass] [int] NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalTime] [int] NOT NULL,
 CONSTRAINT [PK_TestConfiguration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TestConfiguration] ON
INSERT [dbo].[TestConfiguration] ([ID], [Name], [TestTypeId], [ComplexityId], [NoOfTotalQuestions], [NoOfQuestions], [CorrectAnswersToPass], [TotalMarks], [TotalTime]) VALUES (1, N'Test Configuration 1', 2, 3, 5, 3, 1, 30, 5)
INSERT [dbo].[TestConfiguration] ([ID], [Name], [TestTypeId], [ComplexityId], [NoOfTotalQuestions], [NoOfQuestions], [CorrectAnswersToPass], [TotalMarks], [TotalTime]) VALUES (2, N'Test Configuration 2', 5, 4, 10, 5, 5, 50, 10)
SET IDENTITY_INSERT [dbo].[TestConfiguration] OFF
/****** Object:  Table [dbo].[Test]    Script Date: 04/12/2020 17:11:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TestConfigurationId] [int] NOT NULL,
	[GeneratedDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[IsReady] [bit] NULL CONSTRAINT [DF_Test_IsReady]  DEFAULT ((0)),
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Test] ON
INSERT [dbo].[Test] ([ID], [TestConfigurationId], [GeneratedDate], [StartDate], [EndDate], [IsReady]) VALUES (1, 2, NULL, NULL, NULL, 1)
INSERT [dbo].[Test] ([ID], [TestConfigurationId], [GeneratedDate], [StartDate], [EndDate], [IsReady]) VALUES (3, 2, NULL, NULL, NULL, 0)
INSERT [dbo].[Test] ([ID], [TestConfigurationId], [GeneratedDate], [StartDate], [EndDate], [IsReady]) VALUES (6, 1, NULL, CAST(0x00009D7400000000 AS DateTime), CAST(0x0000A17F00000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Test] OFF
/****** Object:  Table [dbo].[Question]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TopicID] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[Option1] [nvarchar](max) NOT NULL,
	[Option2] [nvarchar](max) NOT NULL,
	[Option3] [nvarchar](max) NOT NULL,
	[Option4] [nvarchar](max) NOT NULL,
	[CorrectAnswer] [nvarchar](10) NOT NULL,
	[Reason] [nvarchar](max) NULL,
	[ComplexityID] [int] NULL,
	[Language] [nvarchar](10) NULL,
	[IsReady] [bit] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Question] ON
INSERT [dbo].[Question] ([ID], [TopicID], [Text], [Option1], [Option2], [Option3], [Option4], [CorrectAnswer], [Reason], [ComplexityID], [Language], [IsReady]) VALUES (4, 8, N'Test', N'Test', N'Test', N'Test', N'Test', N'Option4', N'Not the actual rason', 2, N'ENGLISH', 0)
INSERT [dbo].[Question] ([ID], [TopicID], [Text], [Option1], [Option2], [Option3], [Option4], [CorrectAnswer], [Reason], [ComplexityID], [Language], [IsReady]) VALUES (5, 10, N'a', N'Test', N'Test', N'correct answer', N'a', N'Option3', N'because answer is correct', 2, N'ENGLISH', 1)
INSERT [dbo].[Question] ([ID], [TopicID], [Text], [Option1], [Option2], [Option3], [Option4], [CorrectAnswer], [Reason], [ComplexityID], [Language], [IsReady]) VALUES (6, 10, N'<p><b>Place the below Alphabets in Order.</b></p>
<ol>
<li><b>A</b></li>
<li><b>C</b></li>
<li><b>D</b></li>
<li><b>B</b></li>
</ol>', N'ABCD', N'ACBD', N'ABDC', N'DCBA', N'Option1', N'that is correct', 2, N'ENGLISH', 1)
SET IDENTITY_INSERT [dbo].[Question] OFF
/****** Object:  StoredProcedure [dbo].[GetTopics]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Topics
-- =============================================
CREATE PROCEDURE [dbo].[GetTopics]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.ID,a.Name, SubjectID, b.Name SubjectName from Topic a join Subject b on a.SubjectID = b.ID 
	where @id is null or a.ID=@id

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTopic]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Topic
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTopic]
	@id int 
AS
BEGIN
	Delete from Topic where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetTestConfigurations]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the TestConfigurations
-- =============================================
CREATE PROCEDURE [dbo].[GetTestConfigurations]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.*,b.Name TestTypeName, c.Name ComplexityName from TestConfiguration a join TestType b on a.TestTypeId = b.ID 
	Join Complexity c on a.ComplexityID = c.ID
	where @id is null or a.ID=@id

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTestConfiguration]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete TestConfiguration
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTestConfiguration]
	@id int 
AS
BEGIN
	Delete from TestConfiguration where ID = @id
END
GO
/****** Object:  Table [dbo].[TestSeries]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TestSeries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[TestConfigurationId] [int] NOT NULL,
	[GeneratedDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[IsReady] [bit] NOT NULL CONSTRAINT [DF_TestSeries_IsReady]  DEFAULT ((0)),
 CONSTRAINT [PK_TestSeries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TestSeries] ON
INSERT [dbo].[TestSeries] ([ID], [Name], [TestConfigurationId], [GeneratedDate], [StartDate], [IsReady]) VALUES (6, N'.Net 2', 2, CAST(0x0000AB9A00FC74FD AS DateTime), CAST(0x0000A2EC00C5C100 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[TestSeries] OFF
/****** Object:  StoredProcedure [dbo].[UpdateTestConfiguration]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update TestConfigurations
-- =============================================
Create PROCEDURE [dbo].[UpdateTestConfiguration]
@id int = 0,
@name nvarchar(50),
@testtypeid int,
@complexityid int,
@nooftotalquestions int,
@noofquestions int,
@correctanswerstopass int,
@totalmarks int,
@totaltime int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		INSERT INTO [dbo].[TestConfiguration]
           ([Name]
           ,[TestTypeId]
           ,[ComplexityId]
           ,[NoOfTotalQuestions]
           ,[NoOfQuestions]
           ,[CorrectAnswersToPass]
           ,[TotalMarks]
           ,[TotalTime])
     VALUES
           (@name, @testtypeid, @complexityid, @nooftotalquestions, @noofquestions, @correctanswerstopass, @totalmarks, @totaltime
			)
	END
	ELSE
	BEGIN
		Update TestConfiguration
		SET [Name] = @name
      ,[TestTypeId] = @testtypeid
      ,[ComplexityId] = @complexityid
      ,[NoOfTotalQuestions] = @nooftotalquestions
      ,[NoOfQuestions] = @noofquestions
      ,[CorrectAnswersToPass] = @correctanswerstopass
      ,[TotalMarks] = @totalmarks
      ,[TotalTime] = @totaltime
		where ID = @id
	END

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTopic]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Topics
-- =============================================
Create PROCEDURE [dbo].[UpdateTopic]
@id int = 0,
@name nvarchar(50) = null,
@subjectid int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		Insert into Topic (Name, SubjectID) values(@name, @subjectid);
	END
	ELSE
	BEGIN
		Update Topic
		set Name = @name, SubjectID = @subjectid
		where ID = @id
	END

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTestSeries]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update TestSeriess
-- =============================================
Create PROCEDURE [dbo].[UpdateTestSeries]
@id int = 0,
@name nvarchar(100),
@testconfigurationid int,
@generateddate  datetime =null,
@startdate datetime =null,
@isready bit 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		Insert into TestSeries (Name, [TestConfigurationId]
           ,[GeneratedDate]
           ,[StartDate]
           ,[IsReady]) values(@name, @testconfigurationid, GETDATE(), @startdate, @isready);
	END
	ELSE
	BEGIN
		Update TestSeries
		set Name =@name, 
		[TestConfigurationId] = @testconfigurationid
			  ,[StartDate] = @startdate
			  ,[IsReady] = @isready
		where ID = @id
	END

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTest]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Tests
-- =============================================
Create PROCEDURE [dbo].[UpdateTest]
@id int = 0,
@testconfigurationid int,
@generateddate  datetime =null,
@startdate datetime =null,
@enddate datetime =null,
@isready bit 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		Insert into Test ([TestConfigurationId]
           ,[GeneratedDate]
           ,[StartDate]
           ,[EndDate]
           ,[IsReady]) values(@testconfigurationid, @generateddate, @startdate, @enddate, @isready);
	END
	ELSE
	BEGIN
		Update Test
		set [TestConfigurationId] = @testconfigurationid
			  ,[GeneratedDate] = @generateddate
			  ,[StartDate] = @startdate
			  ,[EndDate] = @enddate
			  ,[IsReady] = @isready
		where ID = @id
	END

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuestion]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Questions
-- =============================================
Create PROCEDURE [dbo].[UpdateQuestion]
@id int = 0,
@topicid int,
@text nvarchar(max),
@option1 nvarchar(max),
@option2 nvarchar(max),
@option3 nvarchar(max),
@option4 nvarchar(max),
@correctanswer nvarchar(10),
@reason nvarchar(max) = null,
@complexityid int,
@language nvarchar(10),
@isready bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		INSERT INTO [TS].[dbo].[Question]
           ([TopicID]
           ,[Text]
           ,[Option1]
           ,[Option2]
           ,[Option3]
           ,[Option4]
           ,[CorrectAnswer]
           ,[Reason]
           ,[ComplexityID]
           ,[Language]
           ,[IsReady])
     VALUES
           (@topicid,
			@text ,
			@option1 ,
			@option2 ,
			@option3 ,
			@option4 ,
			@correctanswer ,
			@reason ,
			@complexityid ,
			@language ,
			@isready 
			)
	END
	ELSE
	BEGIN
		Update Question
		set Text = @text, ComplexityID = @complexityid,
			CorrectAnswer = @correctanswer, IsReady = @isready, Language =@language,
			Option1 = @option1, Option2 = @option2,Option3 = @option3,Option4 = @option4,
			Reason = @reason
		where ID = @id
	END

END
GO
/****** Object:  Table [dbo].[TestSubjects]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestSubjects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TestID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Weightage] [int] NOT NULL,
 CONSTRAINT [PK_TestSubjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TestSubjects] ON
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (3, 3, 3, 10)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (4, 3, 2, 20)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (5, 3, 16, 30)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (11, 6, 1, 20)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (12, 6, 2, 20)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (13, 6, 3, 30)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (15, 6, 16, 20)
INSERT [dbo].[TestSubjects] ([ID], [TestID], [SubjectID], [Weightage]) VALUES (16, 6, 15, 10)
SET IDENTITY_INSERT [dbo].[TestSubjects] OFF
/****** Object:  StoredProcedure [dbo].[DeleteTest]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Test
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTest]
	@id int 
AS
BEGIN
	Delete from Test where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteQuestion]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Question
-- =============================================
CREATE PROCEDURE [dbo].[DeleteQuestion]
	@id int 
AS
BEGIN
	Delete from Question where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetTestSerieses]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the TestSerieses
-- =============================================
CREATE PROCEDURE [dbo].[GetTestSerieses]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.*,b.Name TestConfigurationName from TestSeries a join TestConfiguration b on a.TestConfigurationID = b.ID 
	where @id is null or a.ID=@id

END
GO
/****** Object:  StoredProcedure [dbo].[GetTests]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Tests
-- =============================================
CREATE PROCEDURE [dbo].[GetTests]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.*,b.Name TestConfigurationName from Test a join TestConfiguration b on a.TestConfigurationID = b.ID 
	where @id is null or a.ID=@id

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTestSeries]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete TestSeries
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTestSeries]
	@id int 
AS
BEGIN
	Delete from TestSeries where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetQuestions]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Questions
-- =============================================
CREATE PROCEDURE [dbo].[GetQuestions]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.*,b.Name TopicName, c.Name ComplexityName from Question a join Topic b on a.TopicID = b.ID 
	Join Complexity c on a.ComplexityID = c.ID
	where @id is null or a.ID=@id

END
GO
/****** Object:  StoredProcedure [dbo].[GetTestSubjects]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Subjects
-- =============================================
CREATE PROCEDURE [dbo].[GetTestSubjects]
@testID int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select a.*, b.Name SubjectName  from TestSubjects a Join Subject b on a.SubjectID = b.ID where TestID = @testID

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTestSubject]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Subject
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTestSubject]
	@id int 
AS
BEGIN
	Delete from TestSubjects where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[AddTestSubject]    Script Date: 04/12/2020 17:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Topics
-- =============================================
Create PROCEDURE [dbo].[AddTestSubject]
@id int = 0,
@testid nvarchar(50) = null,
@subjectid int = null,
@weightage int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TestSubjects]
           ([TestID]
           ,[SubjectID]
           ,[Weightage])
     VALUES
           (@testid
           ,@subjectid
           ,@weightage)

END
GO
/****** Object:  ForeignKey [FK_Topic_Subject]    Script Date: 04/12/2020 17:11:14 ******/
ALTER TABLE [dbo].[Topic]  WITH CHECK ADD  CONSTRAINT [FK_Topic_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[Topic] CHECK CONSTRAINT [FK_Topic_Subject]
GO
/****** Object:  ForeignKey [FK_TestConfiguration_Complexity]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[TestConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_TestConfiguration_Complexity] FOREIGN KEY([ComplexityId])
REFERENCES [dbo].[Complexity] ([ID])
GO
ALTER TABLE [dbo].[TestConfiguration] CHECK CONSTRAINT [FK_TestConfiguration_Complexity]
GO
/****** Object:  ForeignKey [FK_TestConfiguration_TestType]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[TestConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_TestConfiguration_TestType] FOREIGN KEY([TestTypeId])
REFERENCES [dbo].[TestType] ([ID])
GO
ALTER TABLE [dbo].[TestConfiguration] CHECK CONSTRAINT [FK_TestConfiguration_TestType]
GO
/****** Object:  ForeignKey [FK_Test_TestConfiguration]    Script Date: 04/12/2020 17:11:26 ******/
ALTER TABLE [dbo].[Test]  WITH CHECK ADD  CONSTRAINT [FK_Test_TestConfiguration] FOREIGN KEY([TestConfigurationId])
REFERENCES [dbo].[TestConfiguration] ([ID])
GO
ALTER TABLE [dbo].[Test] CHECK CONSTRAINT [FK_Test_TestConfiguration]
GO
/****** Object:  ForeignKey [FK_Question_Complexity]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Complexity] FOREIGN KEY([ComplexityID])
REFERENCES [dbo].[Complexity] ([ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Complexity]
GO
/****** Object:  ForeignKey [FK_Question_Topic]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Topic] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topic] ([ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Topic]
GO
/****** Object:  ForeignKey [FK_TestSeries_TestConfiguration]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSeries]  WITH CHECK ADD  CONSTRAINT [FK_TestSeries_TestConfiguration] FOREIGN KEY([TestConfigurationId])
REFERENCES [dbo].[TestConfiguration] ([ID])
GO
ALTER TABLE [dbo].[TestSeries] CHECK CONSTRAINT [FK_TestSeries_TestConfiguration]
GO
/****** Object:  ForeignKey [FK_TestSubjects_Subject]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSubjects]  WITH CHECK ADD  CONSTRAINT [FK_TestSubjects_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[TestSubjects] CHECK CONSTRAINT [FK_TestSubjects_Subject]
GO
/****** Object:  ForeignKey [FK_TestSubjects_Test]    Script Date: 04/12/2020 17:11:27 ******/
ALTER TABLE [dbo].[TestSubjects]  WITH CHECK ADD  CONSTRAINT [FK_TestSubjects_Test] FOREIGN KEY([TestID])
REFERENCES [dbo].[Test] ([ID])
GO
ALTER TABLE [dbo].[TestSubjects] CHECK CONSTRAINT [FK_TestSubjects_Test]
GO
