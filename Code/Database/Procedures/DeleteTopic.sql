
/****** Object:  StoredProcedure [dbo].[DeleteTopic]    Script Date: 03/22/2020 15:21:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteTopic]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteTopic]
GO



/****** Object:  StoredProcedure [dbo].[DeleteTopic]    Script Date: 03/22/2020 15:21:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Sachin Patil
-- Create date: 18 March 2020
-- Description:	To Delete Topic
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTopic]
	@id int 
AS
BEGIN
	Delete from Topic where ID = @id
END

GO


