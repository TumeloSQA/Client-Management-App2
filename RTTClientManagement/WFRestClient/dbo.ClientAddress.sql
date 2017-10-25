CREATE TABLE [dbo].[ClientAddress] (
    [addressId]   INT          IDENTITY (1, 1) NOT NULL,
    [resAddress]  VARCHAR (50) NOT NULL,
    [workAddress] VARCHAR (50) NOT NULL,
    [posAddress]  VARCHAR (50) NOT NULL,
    [clientId]    INT          NOT NULL,
    CONSTRAINT [fk_category] FOREIGN KEY ([clientId]) REFERENCES [dbo].[ClientDetails] ([clientId]) ON DELETE CASCADE, 
    CONSTRAINT [PK_ClientAddress] PRIMARY KEY ([addressId])
);

