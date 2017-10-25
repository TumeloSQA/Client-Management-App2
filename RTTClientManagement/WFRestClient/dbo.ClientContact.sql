CREATE TABLE [dbo].[ClientContact]
(
	[ContactId] INT  IDENTITY (1, 1) NOT NULL,
	[cellNumber] VARCHAR (50) NOT NULL,
    [workTel]    VARCHAR (50) NOT NULL,
	[clientId]    INT          NOT NULL, 
	CONSTRAINT [fk_client_contact] FOREIGN KEY ([clientId]) REFERENCES [dbo].[ClientDetails] ([clientId]) ON DELETE CASCADE, 
    CONSTRAINT [PK_ClientContact] PRIMARY KEY ([ContactId])
    
)
