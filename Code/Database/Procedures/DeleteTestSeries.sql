
/****** Object:  StoredProcedure [dbo].[DeleteTestSeries]    Script Date: 03/22/2020 15:20:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteTestSeries]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteTestSeries]
GO



/****** Object:  StoredProcedure [dbo].[DeleteTestSeries]    Script Date: 03/22/2020 15:20:38 ******/
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


