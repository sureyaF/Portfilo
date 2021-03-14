CREATE PROCEDURE dbo.ContactDeletion
@CustomerId int
AS
	DELETE tbl_Contact
	WHERE CustomerId= @CustomerId