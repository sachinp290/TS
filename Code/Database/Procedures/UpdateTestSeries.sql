
/****** Object:  StoredProcedure [dbo].[UpdateTestSeries]    Script Date: 03/22/2020 15:22:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTestSeries]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTestSeries]
GO


/****** Object:  StoredProcedure [dbo].[UpdateTestSeries]    Script Date: 03/22/2020 15:22:13 ******/
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
		Insert into TestSeries ([TestConfigurationId]
           ,[GeneratedDate]
           ,[StartDate]
           ,[IsReady]) values(@testconfigurationid, @generateddate, @startdate, @isready);
	END
	ELSE
	BEGIN
		Update TestSeries
		set [TestConfigurationId] = @testconfigurationid
			  ,[GeneratedDate] = @generateddate
			  ,[StartDate] = @startdate
			  ,[IsReady] = @isready
		where ID = @id
	END

END

GO


