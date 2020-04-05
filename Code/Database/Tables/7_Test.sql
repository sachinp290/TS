
/****** Object:  Table [dbo].[Test]    Script Date: 04/04/2020 16:59:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TestConfigurationId] [int] NOT NULL,
	[GeneratedDate] [datetime]  NULL,
	[StartDate] [datetime]  NULL,
	[EndDate] [datetime]  NULL,
	[EndDate] [datetime] NULL,
	[IsReady] [bit] NOT NULL,
	
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Test]  WITH CHECK ADD  CONSTRAINT [FK_Test_TestConfiguration] FOREIGN KEY([TestConfigurationId])
REFERENCES [dbo].[TestConfiguration] ([ID])
GO

ALTER TABLE [dbo].[Test] CHECK CONSTRAINT [FK_Test_TestConfiguration]
GO

ALTER TABLE [dbo].[Test] ADD  CONSTRAINT [DF_Test_IsReady]  DEFAULT ((0)) FOR [IsReady]
GO
