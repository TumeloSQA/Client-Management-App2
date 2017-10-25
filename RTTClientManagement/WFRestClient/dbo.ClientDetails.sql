CREATE TABLE [dbo].[ClientDetails] (
    [clientId]   INT          IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (50) NOT NULL,
    [gender]     VARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_ClientDetails] PRIMARY KEY ([clientId]) 
    
);

