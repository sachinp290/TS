
/****** Object:  Table [dbo].[TestSeries]    Script Date: 04/04/2020 16:59:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestSeries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] varchar(100) Not Null,
	[TestConfigurationId] [int] NOT NULL,
	[GeneratedDate] [datetime]  NULL,
	[StartDate] [datetime]  NULL,
	[IsReady] [bit] NOT NULL,
	
 CONSTRAINT [PK_TestSeries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[TestSeries]  WITH CHECK ADD  CONSTRAINT [FK_TestSeries_TestConfiguration] FOREIGN KEY([TestConfigurationId])
REFERENCES [dbo].[TestConfiguration] ([ID])
GO

ALTER TABLE [dbo].[TestSeries] CHECK CONSTRAINT [FK_TestSeries_TestConfiguration]
GO

ALTER TABLE [dbo].[TestSeries] ADD  CONSTRAINT [DF_TestSeries_IsReady]  DEFAULT ((0)) FOR [IsReady]
GO
