
/****** Object:  StoredProcedure [dbo].[DeleteTestSubject]    Script Date: 03/22/2020 15:20:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteTestSubject]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteTestSubject]
GO



/****** Object:  StoredProcedure [dbo].[DeleteTestSubject]    Script Date: 03/22/2020 15:20:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Subject
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTestSubject]
	@id int 
AS
BEGIN
	Delete from TestSubjects where ID = @id
END

GO


