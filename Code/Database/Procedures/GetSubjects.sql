
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Subjects
-- =============================================
CREATE PROCEDURE GetSubjects
	@ID int = null,
	@isAll bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select ID,Name from Subject 
	where (@isAll = 1) or (ID = @ID)
END
GO
