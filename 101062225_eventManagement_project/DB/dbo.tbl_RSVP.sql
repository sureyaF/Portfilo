CREATE TABLE [dbo].[tbl_RSVP] (
    [RSVPId]    INT           IDENTITY (1, 1) NOT NULL,
    [EventName] NVARCHAR (50) NULL,
    [FirstName] NVARCHAR (50) NULL,
    [BookingId] NVARCHAR (50) NULL,
    [LastName]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([RSVPId] ASC)
);

