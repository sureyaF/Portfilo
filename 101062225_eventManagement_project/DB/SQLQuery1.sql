USE [C:\USERS\REYAF\SOURCE\REPOS\101062225_EVENTMANAGEMENT_PROJECT\DB\CONTACTDB.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[RSVPViewOrSearch]
		@FirstName = N'',
		@EventName = N'',
		@BookingId = NULL

SELECT	@return_value as 'Return Value'

GO
