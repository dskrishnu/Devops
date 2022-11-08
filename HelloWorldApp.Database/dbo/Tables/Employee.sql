CREATE TABLE [dbo].[Employee] (
    [Id]     INT           NOT NULL,
    [Name]   NVARCHAR (50) NULL,
    [Salary] MONEY         NULL,
    [Experience] NCHAR(10) NULL, 
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([Id] ASC)
);

