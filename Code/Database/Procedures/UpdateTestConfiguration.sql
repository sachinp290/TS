
/****** Object:  StoredProcedure [dbo].[UpdateTestConfiguration]    Script Date: 03/29/2020 23:46:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTestConfiguration]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTestConfiguration]
GO


/****** Object:  StoredProcedure [dbo].[UpdateTestConfiguration]    Script Date: 03/29/2020 23:46:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update TestConfigurations
-- =============================================
Create PROCEDURE [dbo].[UpdateTestConfiguration]
@id int = 0,
@name nvarchar(50),
@testtypeid int,
@complexityid int,
@nooftotalquestions int,
@noofquestions int,
@correctanswerstopass int,
@totalmarks int,
@totaltime int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		INSERT INTO [dbo].[TestConfiguration]
           ([Name]
           ,[TestTypeId]
           ,[ComplexityId]
           ,[NoOfTotalQuestions]
           ,[NoOfQuestions]
           ,[CorrectAnswersToPass]
           ,[TotalMarks]
           ,[TotalTime])
     VALUES
           (@name, @testtypeid, @complexityid, @nooftotalquestions, @noofquestions, @correctanswerstopass, @totalmarks, @totaltime
			)
	END
	ELSE
	BEGIN
		Update TestConfiguration
		SET [Name] = @name
      ,[TestTypeId] = @testtypeid
      ,[ComplexityId] = @complexityid
      ,[NoOfTotalQuestions] = @nooftotalquestions
      ,[NoOfQuestions] = @noofquestions
      ,[CorrectAnswersToPass] = @correctanswerstopass
      ,[TotalMarks] = @totalmarks
      ,[TotalTime] = @totaltime
		where ID = @id
	END

END

GO


