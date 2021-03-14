CREATE TABLE [dbo].[Table] (
    [CustomerId]  INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (50)  NULL,
    [LastName]    VARCHAR (50)  NULL,
    [PhoneNumber] NVARCHAR (50) NULL,
    [BookingId]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

