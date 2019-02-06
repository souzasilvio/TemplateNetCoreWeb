CREATE TABLE [dbo].[Cliente] (
    [Codigo] INT            IDENTITY (1, 1) NOT NULL,
    [Nome]   NVARCHAR (100) NULL,
    [Email]  NVARCHAR (50)  NULL,
    [Telefone] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

