CREATE PROCEDURE dbo.EventAddorEdit
	@mode nvarchar(10),
	@EventId	int	,
	@EventName	nvarchar(50),		
	@EventDate	date,
	@PeopleAttending int,
	@EventVenue nvarchar(50)
	

AS
	IF @mode='Add'
	BEGIN
	INSERT INTO tbl_Event
	(EventName,EventDate,PeopleAttending,EventVenue)
	VALUES(
	@EventName,@EventDate,@PeopleAttending,@EventVenue)
	END
	ELSE IF @mode= 'Edit'
	BEGIN
	UPDATE tbl_Event
	SET 
	EventName = @EventName,
	EventDate=@EventDate,
	PeopleAttending =@PeopleAttending, 
	EventVenue = @EventVenue
	WHERE EventId = @EventId
	END