IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Movies] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [ReleaseDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Movies] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Actors] (
    [Id] int NOT NULL IDENTITY,
    [Name] int NOT NULL,
    [MovieId] int NOT NULL,
    CONSTRAINT [PK_Actors] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Actors_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Events] (
    [Id] int NOT NULL IDENTITY,
    [Text] nvarchar(max) NULL,
    [ActorId] int NOT NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Events_Actors_ActorId] FOREIGN KEY ([ActorId]) REFERENCES [Actors] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Actors_MovieId] ON [Actors] ([MovieId]);

GO

CREATE INDEX [IX_Events_ActorId] ON [Events] ([ActorId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190912175357_initial', N'2.2.6-servicing-10079');

GO

