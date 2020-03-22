
/****** Object:  StoredProcedure [dbo].[GetTopics]    Script Date: 03/22/2020 15:21:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTopics]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetTopics]
GO


/****** Object:  StoredProcedure [dbo].[GetTopics]    Script Date: 03/22/2020 15:21:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 10 March 2020
-- Description:	To Get the Topics
-- =============================================
CREATE PROCEDURE [dbo].[GetTopics]
@id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.ID,b.Name, SubjectID, b.Name SubjectName from Topic a join Subject b on a.SubjectID = b.ID 
	where @id is null or a.ID=@id

END

GO


