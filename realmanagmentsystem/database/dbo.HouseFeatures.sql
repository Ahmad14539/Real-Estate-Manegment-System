CREATE TABLE [dbo].[HouseFeatures] (
    [EstateID]      INT            NOT NULL,
    [Building Type] NVARCHAR (50)  NULL,
    [BedRooms]      INT            NULL,
    [Built in]      NVARCHAR (10)  NULL,
    [Neighbourhood] NVARCHAR (50)  NULL,
    [Address]       NVARCHAR (100) NULL,
    [Price]         MONEY          NULL,
    [Description]   NCHAR (255)    NULL,
    [Pool]          NVARCHAR (10)  NULL,
    [Elevator]      NVARCHAR (10)  NULL,
    [ImageUrl] IMAGE NULL, 
    CONSTRAINT [PK_HouseFeatures] PRIMARY KEY CLUSTERED ([EstateID] ASC)
);

