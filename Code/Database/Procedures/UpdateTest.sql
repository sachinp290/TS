
/****** Object:  StoredProcedure [dbo].[UpdateTest]    Script Date: 03/22/2020 15:22:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTest]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTest]
GO


/****** Object:  StoredProcedure [dbo].[UpdateTest]    Script Date: 03/22/2020 15:22:13 ******/
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


