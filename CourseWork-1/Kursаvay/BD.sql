USE [SysAdmin]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 10.12.2019 22:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IdTypeName] [int] NOT NULL,
	[Quantity] [int] NULL,
	[IdStorage] [int] NOT NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Extradition]    Script Date: 10.12.2019 22:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Extradition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEquipment] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IdPersonnel] [int] NOT NULL,
	[IdUsers] [int] NOT NULL,
 CONSTRAINT [PK_Extradition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnel]    Script Date: 10.12.2019 22:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[Post] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Personnel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storages]    Script Date: 10.12.2019 22:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Storages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeEquipment]    Script Date: 10.12.2019 22:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeEquipment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_TypeName] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10.12.2019 22:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](30) NULL,
	[Password] [nvarchar](20) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Equipment] ON 

INSERT [dbo].[Equipment] ([Id], [Name], [IdTypeName], [Quantity], [IdStorage]) VALUES (1, N'Роутер', 2, 10, 1)
INSERT [dbo].[Equipment] ([Id], [Name], [IdTypeName], [Quantity], [IdStorage]) VALUES (2, N'Компьютер от Dexp', 3, 10, 1)
INSERT [dbo].[Equipment] ([Id], [Name], [IdTypeName], [Quantity], [IdStorage]) VALUES (4, N'Монитор от Asus', 7, 10, 1)
INSERT [dbo].[Equipment] ([Id], [Name], [IdTypeName], [Quantity], [IdStorage]) VALUES (5, N'Мышка офисная', 4, 10, 1)
INSERT [dbo].[Equipment] ([Id], [Name], [IdTypeName], [Quantity], [IdStorage]) VALUES (6, N'Патч-корд', 6, 10, 1)
INSERT [dbo].[Equipment] ([Id], [Name], [IdTypeName], [Quantity], [IdStorage]) VALUES (7, N'Клавиатура офисная', 5, 10, 1)
SET IDENTITY_INSERT [dbo].[Equipment] OFF
SET IDENTITY_INSERT [dbo].[Personnel] ON 

INSERT [dbo].[Personnel] ([Id], [LastName], [FirstName], [MiddleName], [Post]) VALUES (1, N'Болдарь', N'Никита', N'Сергеевич', N'Директор')
INSERT [dbo].[Personnel] ([Id], [LastName], [FirstName], [MiddleName], [Post]) VALUES (2, N'Помазной', N'Никита', N'Александрович', N'Аналитик')
INSERT [dbo].[Personnel] ([Id], [LastName], [FirstName], [MiddleName], [Post]) VALUES (4, N'Овчиникова', N'Яна', N'Андреевна', N'Бухгалтер')
SET IDENTITY_INSERT [dbo].[Personnel] OFF
SET IDENTITY_INSERT [dbo].[Storages] ON 

INSERT [dbo].[Storages] ([Id], [Name]) VALUES (1, N'Склад 1')
SET IDENTITY_INSERT [dbo].[Storages] OFF
SET IDENTITY_INSERT [dbo].[TypeEquipment] ON 

INSERT [dbo].[TypeEquipment] ([Id], [Name]) VALUES (2, N'Маршрутизаторы')
INSERT [dbo].[TypeEquipment] ([Id], [Name]) VALUES (3, N'ПК')
INSERT [dbo].[TypeEquipment] ([Id], [Name]) VALUES (4, N'Мышки')
INSERT [dbo].[TypeEquipment] ([Id], [Name]) VALUES (5, N'Клавиатуры')
INSERT [dbo].[TypeEquipment] ([Id], [Name]) VALUES (6, N'Провода')
INSERT [dbo].[TypeEquipment] ([Id], [Name]) VALUES (7, N'Мониторы')
SET IDENTITY_INSERT [dbo].[TypeEquipment] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password], [LastName], [FirstName], [MiddleName]) VALUES (2, N'admin', N'admin1', N'Торосян', N'Карен', N'Робертович')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK__Equipment__IdSto__37A5467C] FOREIGN KEY([IdStorage])
REFERENCES [dbo].[Storages] ([Id])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK__Equipment__IdSto__37A5467C]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK__Equipment__IdTyp__36B12243] FOREIGN KEY([IdTypeName])
REFERENCES [dbo].[TypeEquipment] ([Id])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK__Equipment__IdTyp__36B12243]
GO
ALTER TABLE [dbo].[Extradition]  WITH CHECK ADD  CONSTRAINT [FK__Extraditi__IdEqu__3F466844] FOREIGN KEY([IdEquipment])
REFERENCES [dbo].[Equipment] ([Id])
GO
ALTER TABLE [dbo].[Extradition] CHECK CONSTRAINT [FK__Extraditi__IdEqu__3F466844]
GO
ALTER TABLE [dbo].[Extradition]  WITH CHECK ADD  CONSTRAINT [FK__Extraditi__IdPer__403A8C7D] FOREIGN KEY([IdPersonnel])
REFERENCES [dbo].[Personnel] ([Id])
GO
ALTER TABLE [dbo].[Extradition] CHECK CONSTRAINT [FK__Extraditi__IdPer__403A8C7D]
GO
ALTER TABLE [dbo].[Extradition]  WITH CHECK ADD FOREIGN KEY([IdUsers])
REFERENCES [dbo].[Users] ([Id])
GO
