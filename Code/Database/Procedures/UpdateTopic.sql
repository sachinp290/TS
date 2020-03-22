
/****** Object:  StoredProcedure [dbo].[UpdateTopic]    Script Date: 03/22/2020 15:22:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTopic]
GO


/****** Object:  StoredProcedure [dbo].[UpdateTopic]    Script Date: 03/22/2020 15:22:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Topics
-- =============================================
Create PROCEDURE [dbo].[UpdateTopic]
@id int = 0,
@name nvarchar(50) = null,
@subjectid int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		Insert into Topic (Name, SubjectID) values(@name, @subjectid);
	END
	ELSE
	BEGIN
		Update Topic
		set Name = @name, SubjectID = @subjectid
		where ID = @id
	END

END

GO


