
/****** Object:  Table [dbo].[TestSubjects]    Script Date: 04/04/2020 16:59:43 ******/
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

ALTER TABLE [dbo].[TestSubjects]  WITH CHECK ADD  CONSTRAINT [FK_TestSubjects_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([ID])
GO

ALTER TABLE [dbo].[TestSubjects] CHECK CONSTRAINT [FK_TestSubjects_Subject]
GO

ALTER TABLE [dbo].[TestSubjects]  WITH CHECK ADD  CONSTRAINT [FK_TestSubjects_Test] FOREIGN KEY([TestID])
REFERENCES [dbo].[Test] ([ID])
GO

ALTER TABLE [dbo].[TestSubjects] CHECK CONSTRAINT [FK_TestSubjects_Test]
GO


