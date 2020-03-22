
/****** Object:  StoredProcedure [dbo].[GetSubjects]    Script Date: 03/22/2020 15:21:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSubjects]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetSubjects]
GO



/****** Object:  StoredProcedure [dbo].[GetSubjects]    Script Date: 03/22/2020 15:21:36 ******/
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


