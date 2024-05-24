USE [Remax]
GO

/****** Object:  Table [dbo].[Transactions]    Script Date: 5/12/2024 11:04:55 AM ******/


CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[SellerName] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ContractPath] [nvarchar](255) NULL,
	[PaymentDate] [date] NULL,
	[Amount] [decimal](18, 2) NULL,
	[PropertyID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO

ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Clients]
GO

