CREATE PROCEDURE dbo.RSVPViewOrSearch
@FirstName nvarchar(50)
	
AS
	SELECT *
	FROM tbl_RSVP
	WHERE FirstName LIKE @FirstName+ '%'