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

CREATE TABLE [Cliente] (
    [Id] INT NOT NULL IDENTITY,
    [Nome] VARCHAR(100) NOT NULL,
    [DataDeNascimento] DATETIME NOT NULL,
    [DataCriacao] DATETIME NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Livro] (
    [Id] INT NOT NULL IDENTITY,
    [Nome] VARCHAR(100) NOT NULL,
    [Editora] VARCHAR(100) NOT NULL,
    [DataCriacao] DATETIME NOT NULL,
    CONSTRAINT [PK_Livro] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Pedido] (
    [Id] INT NOT NULL IDENTITY,
    [ClienteId] INT NOT NULL,
    [LivroId] INT NOT NULL,
    [DataCriacao] DATETIME NOT NULL,
    CONSTRAINT [PK_Pedido] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pedido_Cliente_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Pedido_Livro_LivroId] FOREIGN KEY ([LivroId]) REFERENCES [Livro] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Pedido_ClienteId] ON [Pedido] ([ClienteId]);
GO

CREATE INDEX [IX_Pedido_LivroId] ON [Pedido] ([LivroId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250726202530_primeira-migracao', N'8.0.0');
GO

COMMIT;
GO

