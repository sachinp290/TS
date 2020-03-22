
/****** Object:  Table [dbo].[Question]    Script Date: 03/22/2020 16:06:45 ******/
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

ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Complexity] FOREIGN KEY([ComplexityID])
REFERENCES [dbo].[Complexity] ([ID])
GO

ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Complexity]
GO

ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Topic] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topic] ([ID])
GO

ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Topic]
GO


