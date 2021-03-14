CREATE PROCEDURE dbo.ContactViewOrSearch
@ContactName nvarchar(50)
	
AS
	SELECT *
	FROM tbl_Contact
	WHERE FirstName LIKE @ContactName+ '%'