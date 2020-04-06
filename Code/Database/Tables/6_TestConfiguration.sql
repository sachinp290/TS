
/****** Object:  Table [dbo].[TestConfiguration]    Script Date: 04/04/2020 16:19:44 ******/
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

ALTER TABLE [dbo].[TestConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_TestConfiguration_Complexity] FOREIGN KEY([ComplexityId])
REFERENCES [dbo].[Complexity] ([ID])
GO

ALTER TABLE [dbo].[TestConfiguration] CHECK CONSTRAINT [FK_TestConfiguration_Complexity]
GO

ALTER TABLE [dbo].[TestConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_TestConfiguration_TestType] FOREIGN KEY([TestTypeId])
REFERENCES [dbo].[TestType] ([ID])
GO

ALTER TABLE [dbo].[TestConfiguration] CHECK CONSTRAINT [FK_TestConfiguration_TestType]
GO


