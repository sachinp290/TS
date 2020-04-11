
/****** Object:  StoredProcedure [dbo].[GetTestSerieses]    Script Date: 03/29/2020 23:45:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTestSerieses]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetTestSerieses]
GO


/****** Object:  StoredProcedure [dbo].[GetTestSerieses]    Script Date: 03/29/2020 23:45:24 ******/
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


