CREATE PROCEDURE dbo.EventDeletion
@EventId int
AS
	DELETE tbl_Event
	WHERE EventId= @EventId