
/****** Object:  StoredProcedure [dbo].[UpdateSubject]    Script Date: 03/22/2020 15:22:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateSubject]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateSubject]
GO


/****** Object:  StoredProcedure [dbo].[UpdateSubject]    Script Date: 03/22/2020 15:22:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Subjects
-- =============================================
Create PROCEDURE [dbo].[UpdateSubject]
@id int = 0,
@name nvarchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		Insert into Subject (Name) values(@name);
	END
	ELSE
	BEGIN
		Update Subject
		set Name = @name
		where ID = @id
	END

END

GO


