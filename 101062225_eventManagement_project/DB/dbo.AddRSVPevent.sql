CREATE PROCEDURE dbo.AddRSVPevent
	@mode nvarchar(10),
	@RSVPId	int	,
	@EventName	nvarchar(50),		
	@FirstName	nvarchar(50),		
	@BookingId nvarchar(50),	
	@LastName nvarchar(50)
	

AS
	IF @mode='Add'
	BEGIN
	INSERT INTO tbl_RSVP
	(EventName,FirstName,BookingId,LastName)
	VALUES(
	@EventName,@FirstName,@BookingId,@LastName)
	END
	ELSE IF @mode= 'Edit'
	BEGIN
	UPDATE tbl_RSVP
	SET 
	EventName = @EventName,
	FirstName=@FirstName,
	BookingId=@BookingId,
	LastName=@LastName
	WHERE
	RSVPId= @RSVPId
	END