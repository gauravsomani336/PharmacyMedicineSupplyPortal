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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210812165751_init')
BEGIN
    CREATE TABLE [Stocks] (
        [name] nvarchar(450) NOT NULL,
        [ChemicalComposition] nvarchar(max) NULL,
        [TargetAilment] nvarchar(max) NULL,
        [DateOfExpiry] datetime2 NOT NULL,
        [NumberOfTabletsInStock] int NOT NULL,
        CONSTRAINT [PK_Stocks] PRIMARY KEY ([name])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210812165751_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210812165751_init', N'5.0.9');
END;
GO

COMMIT;
GO

