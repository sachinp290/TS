
/****** Object:  StoredProcedure [dbo].[AddTestSubject]    Script Date: 03/22/2020 15:22:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddTestSubject]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AddTestSubject]
GO


/****** Object:  StoredProcedure [dbo].[AddTestSubject]    Script Date: 03/22/2020 15:22:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Topics
-- =============================================
Create PROCEDURE [dbo].[AddTestSubject]
@id int = 0,
@testid nvarchar(50) = null,
@subjectid int = null,
@weightage int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TestSubjects]
           ([TestID]
           ,[SubjectID]
           ,[Weightage])
     VALUES
           (@testid
           ,@subjectid
           ,@weightage)

END

GO


