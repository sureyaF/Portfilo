CREATE PROCEDURE dbo.ContactAddorEdit
	@mode nvarchar(10),
	@CustomerId	int	,
	@FirstName	nvarchar(50),		
	@LastName	nvarchar(50)	,	
	@PhoneNumber	nvarchar(50),	
	@BookingId	nvarchar(50)	
				

AS
	IF @mode='Add'
	BEGIN
	INSERT INTO tbl_Contact
	(FirstName,
	LastName,
	PhoneNumber,
	BookingId)
	VALUES(
	@FirstName,
	@LastName,
	@PhoneNumber,
	@BookingId)
	END
	ELSE IF @mode= 'Edit'
	BEGIN
	UPDATE tbl_Contact
	SET 
	FirstName = @FirstName,
	LastName=@LastName,
	PhoneNumber=@PhoneNumber,
	BookingId=@BookingId
	WHERE CustomerId = @CustomerId
	END