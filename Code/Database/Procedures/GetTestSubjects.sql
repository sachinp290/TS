
/****** Object:  StoredProcedure [dbo].[GetTestSubjects]    Script Date: 03/22/2020 15:21:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTestSubjects]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetTestSubjects]
GO



/****** Object:  StoredProcedure [dbo].[GetTestSubjects]    Script Date: 03/22/2020 15:21:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Subjects
-- =============================================
CREATE PROCEDURE [dbo].[GetTestSubjects]
@testID int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select a.*, b.Name SubjectName  from TestSubjects a Join Subject b on a.SubjectID = b.ID where TestID = @testID

END

GO


