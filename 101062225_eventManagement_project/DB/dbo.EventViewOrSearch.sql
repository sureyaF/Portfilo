CREATE PROCEDURE dbo.EventViewOrSearch
@EventName nvarchar(50)
	
AS
	SELECT *
	FROM tbl_Event
	WHERE EventName LIKE @EventName+ '%'