CREATE TABLE [dbo].[AnEvents] (
    [Id]                     INT            IDENTITY (1, 1) NOT NULL,
    [EventDateTime]          DATETIME       NOT NULL,
    [DepartmentId]           INT            NOT NULL,
    [EventCategoryId]        INT            NOT NULL,
    [Description]            NVARCHAR (MAX) NULL,
    [ReliableEnergySystemId] INT            NULL,
    [CorrectiveMeasureId]    INT            NULL,
    [OutfitId]               INT            NULL,
    [Report]                 NVARCHAR (255) NULL,
    [RegisteredBy]           INT            NOT NULL,
    [ClassifiedBy]           INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Categories] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Departments] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Login]    NVARCHAR (100) NULL,
    [Password] NVARCHAR (100) NULL,
    [Address]  NVARCHAR (255) NULL,
    [Phone]    NVARCHAR (50)  NULL,
    [Fax]      NVARCHAR (50)  NULL,
    [Place]    NVARCHAR (100) NULL,
    [Guest]    INT            DEFAULT ((1)) NOT NULL,
    [Name]     NVARCHAR (255) NULL,
    [IsPerson] INT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[CorrectiveMeasure]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Name] NCHAR(10) NOT NULL, 
    [ExecutorId] INT NOT NULL, 
    [DepartmentId] INT NOT NULL, 
    [CuratorId] INT NOT NULL, 
    [DateEnd] DATETIME NOT NULL, 
    [Content] TEXT NOT NULL, 
    [Compliance] NVARCHAR(255) NOT NULL , 
    [FailReason] NVARCHAR(255) NOT NULL, 
    [ExecutionStatus] NVARCHAR(255) NOT NULL, 
	[EventId] INT NOT NULL,
	[Finished] INT NOT NULL DEFAULT 0,
    [MemoNumber] NVARCHAR(50) NOT NULL, 
    [MemoDate] DATETIME NOT NULL
)
