IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Finanças] (
    [Id] int NOT NULL IDENTITY,
    [Tipo] VARCHAR(100) NOT NULL,
    [Categoria] VARCHAR(7) NOT NULL,
    [Valor] INT NOT NULL,
    [Descricao] VARCHAR(150) NOT NULL,
    [DataCriacao] DATETIME NOT NULL,
    CONSTRAINT [PK_Finanças] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250731001325_primeira-migracao', N'8.0.0');
GO

COMMIT;
GO

