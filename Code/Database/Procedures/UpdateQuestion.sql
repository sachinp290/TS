
/****** Object:  StoredProcedure [dbo].[UpdateQuestion]    Script Date: 03/29/2020 23:46:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateQuestion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateQuestion]
GO


/****** Object:  StoredProcedure [dbo].[UpdateQuestion]    Script Date: 03/29/2020 23:46:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Add/Update Questions
-- =============================================
Create PROCEDURE [dbo].[UpdateQuestion]
@id int = 0,
@topicid int,
@text nvarchar(max),
@option1 nvarchar(max),
@option2 nvarchar(max),
@option3 nvarchar(max),
@option4 nvarchar(max),
@correctanswer nvarchar(10),
@reason nvarchar(max),
@complexityid int,
@language nvarchar(10),
@isready bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @id = 0
	BEGIN
		INSERT INTO [TS].[dbo].[Question]
           ([TopicID]
           ,[Text]
           ,[Option1]
           ,[Option2]
           ,[Option3]
           ,[Option4]
           ,[CorrectAnswer]
           ,[Reason]
           ,[ComplexityID]
           ,[Language]
           ,[IsReady])
     VALUES
           (@topicid,
			@text ,
			@option1 ,
			@option2 ,
			@option3 ,
			@option4 ,
			@correctanswer ,
			@reason ,
			@complexityid ,
			@language ,
			@isready 
			)
	END
	ELSE
	BEGIN
		Update Question
		set Text = @text, ComplexityID = @complexityid,
			CorrectAnswer = @correctanswer, IsReady = @isready, Language =@language,
			Option1 = @option1, Option2 = @option2,Option3 = @option3,Option4 = @option4,
			Reason = @reason
		where ID = @id
	END

END

GO


