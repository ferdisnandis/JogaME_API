IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Jogador] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Senha] nvarchar(max) NULL,
    [DataNasc] datetime2 NOT NULL,
    CONSTRAINT [PK_Jogador] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Jogo] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    [DataLancamento] datetime2 NOT NULL,
    CONSTRAINT [PK_Jogo] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [JogosJogadores] (
    [Id] uniqueidentifier NOT NULL,
    [IdJogosJogadores] uniqueidentifier NOT NULL,
    [IdJogador] uniqueidentifier NOT NULL,
    [IdJogo] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_JogosJogadores] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_JogosJogadores_Jogador_IdJogador] FOREIGN KEY ([IdJogador]) REFERENCES [Jogador] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_JogosJogadores_Jogo_IdJogo] FOREIGN KEY ([IdJogo]) REFERENCES [Jogo] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_JogosJogadores_IdJogador] ON [JogosJogadores] ([IdJogador]);

GO

CREATE INDEX [IX_JogosJogadores_IdJogo] ON [JogosJogadores] ([IdJogo]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201101205020_InitialCreate', N'3.1.9');

GO

