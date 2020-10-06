IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Fornecedor] (
    [IdFornecedor] int NOT NULL IDENTITY,
    [Nome] nvarchar(150) NOT NULL,
    [Cnpj] nvarchar(25) NOT NULL,
    CONSTRAINT [PK_Fornecedor] PRIMARY KEY ([IdFornecedor])
);

GO

CREATE TABLE [Produto] (
    [IdProduto] int NOT NULL IDENTITY,
    [Nome] nvarchar(150) NOT NULL,
    [Preco] decimal(18,2) NOT NULL,
    [Quantidade] int NOT NULL,
    [IdFornecedor] int NOT NULL,
    CONSTRAINT [PK_Produto] PRIMARY KEY ([IdProduto]),
    CONSTRAINT [FK_Produto_Fornecedor_IdFornecedor] FOREIGN KEY ([IdFornecedor]) REFERENCES [Fornecedor] ([IdFornecedor]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Produto_IdFornecedor] ON [Produto] ([IdFornecedor]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201005145153_Initial', N'3.1.8');

GO

