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

CREATE TABLE [Orcamentos] (
    [Id] int NOT NULL IDENTITY,
    [NomeCliente] nvarchar(max) NULL,
    [Data] datetime2 NOT NULL,
    [TipoServico] int NOT NULL,
    [TipoMovel] nvarchar(max) NULL,
    [DescricaoMovel] nvarchar(max) NULL,
    [EstadoMovel] int NOT NULL,
    [ValorOrcamento] decimal(18,2) NOT NULL,
    [status] int NOT NULL,
    CONSTRAINT [PK_Orcamentos] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'DescricaoMovel', N'EstadoMovel', N'NomeCliente', N'TipoMovel', N'TipoServico', N'ValorOrcamento', N'status') AND [object_id] = OBJECT_ID(N'[Orcamentos]'))
    SET IDENTITY_INSERT [Orcamentos] ON;
INSERT INTO [Orcamentos] ([Id], [Data], [DescricaoMovel], [EstadoMovel], [NomeCliente], [TipoMovel], [TipoServico], [ValorOrcamento], [status])
VALUES (1, '2022-01-01T00:00:00.0000000', N'Guarda-roupa com 3 portas de espelho', 1, N'Barbara', N'Guarda-Roupa', 1, 200.0, 1),
(2, '2020-01-01T00:00:00.0000000', N'Cômoda de tres gavetas', 2, N'Sonia ', N'Cômoda', 2, 150.5, 1),
(3, '2021-01-01T00:00:00.0000000', N'Mesa gamer 60cm - 136cm ', 1, N'Gabriel ', N'Mesa ', 1, 300.0, 1),
(4, '2022-01-01T00:00:00.0000000', N'Mesa de 4 cadeiras', 2, N'Anahi ', N'Mesa', 2, 200.0, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'DescricaoMovel', N'EstadoMovel', N'NomeCliente', N'TipoMovel', N'TipoServico', N'ValorOrcamento', N'status') AND [object_id] = OBJECT_ID(N'[Orcamentos]'))
    SET IDENTITY_INSERT [Orcamentos] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220403215018_InitialCreate', N'5.0.15');
GO

COMMIT;
GO

