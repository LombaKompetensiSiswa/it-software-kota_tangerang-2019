USE [LKS Kota Tangerang 2019]
GO
/****** Object:  Table [dbo].[Detailorder]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detailorder](
	[Detailid] [int] NOT NULL,
	[Orderid] [nchar](10) NOT NULL,
	[Menuid] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Status] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Detailorder] PRIMARY KEY CLUSTERED 
(
	[Detailid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetailPackage]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPackage](
	[DetailPackageID] [int] IDENTITY(1,1) NOT NULL,
	[HeaderPackageID] [int] NOT NULL,
	[Menuid] [int] NOT NULL,
	[Qty] [int] NOT NULL,
 CONSTRAINT [PK_DetailPackage] PRIMARY KEY CLUSTERED 
(
	[DetailPackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Headerorder]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Headerorder](
	[OrderID] [nchar](10) NOT NULL,
	[Employeeid] [nchar](6) NOT NULL,
	[Memberid] [nchar](8) NOT NULL,
	[Date] [date] NOT NULL,
	[Payment] [nvarchar](50) NULL,
	[bank] [nvarchar](50) NULL,
	[CardNumber] [varchar](10) NULL,
 CONSTRAINT [PK_Headerorder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HeaderPackage]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HeaderPackage](
	[HeaderPackageID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[CountMeat] [int] NOT NULL,
	[CountVegetables] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[MinOrder] [int] NOT NULL,
 CONSTRAINT [PK_HeaderPackage] PRIMARY KEY CLUSTERED 
(
	[HeaderPackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Msemployee]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Msemployee](
	[EmployeeID] [nchar](6) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Handphone] [nvarchar](13) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Msemployee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Msmember]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Msmember](
	[MemberID] [nchar](8) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Handphone] [nvarchar](13) NOT NULL,
	[JoinDate] [date] NOT NULL,
 CONSTRAINT [PK_Msmember] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Msmenu]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Msmenu](
	[MenuID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Photo] [nvarchar](100) NOT NULL,
	[Category] [varchar](20) NULL,
 CONSTRAINT [PK_Msmenu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Review]    Script Date: 2/14/2019 2:32:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[Reviewid] [int] IDENTITY(1,1) NOT NULL,
	[Orderid] [nchar](10) NOT NULL,
	[Menuid] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Note] [text] NOT NULL,
	[Photo] [nvarchar](100) NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Reviewid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (1, N'2019020001', 5, 3, 12000, N'Cooking')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (2, N'2019020001', 6, 1, 30000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (3, N'2019020002', 2, 2, 20000, N'Cooking')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (4, N'2019020002', 4, 2, 130000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (5, N'2019020002', 6, 2, 30000, N'Cooking')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (6, N'2019020002', 1, 2, 100000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (7, N'2019020003', 1, 1, 50000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (8, N'2019020003', 2, 2, 20000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (9, N'2019020004', 3, 2, 20000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (10, N'2019020004', 2, 3, 30000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (11, N'2019020005', 3, 1, 10000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (12, N'2019020005', 4, 2, 130000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (13, N'2019020006', 4, 1, 65000, N'Cooking')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (14, N'2019020006', 3, 2, 20000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (15, N'2019020006', 1, 2, 100000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (16, N'2019020007', 7, 2, 20000, N'Preparing')
INSERT [dbo].[Detailorder] ([Detailid], [Orderid], [Menuid], [Qty], [Price], [Status]) VALUES (17, N'2019020007', 3, 2, 20000, N'Preparing')
SET IDENTITY_INSERT [dbo].[DetailPackage] ON 

INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (1, 1, 1, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (2, 1, 7, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (3, 2, 1, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (7, 2, 7, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (9, 2, 4, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (10, 2, 5, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (12, 3, 1, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (13, 3, 7, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (14, 3, 2, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (15, 3, 3, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (17, 3, 4, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (19, 4, 1, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (21, 4, 7, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (22, 4, 1, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (25, 4, 4, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (26, 4, 5, 100)
INSERT [dbo].[DetailPackage] ([DetailPackageID], [HeaderPackageID], [Menuid], [Qty]) VALUES (27, 4, 6, 100)
SET IDENTITY_INSERT [dbo].[DetailPackage] OFF
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020001', N'EM0002', N'2       ', CAST(N'2019-02-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020002', N'EM0002', N'2       ', CAST(N'2019-02-13' AS Date), N'Credit', N'CIMB NIAGA', N'124124')
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020003', N'EM0002', N'2       ', CAST(N'2019-02-14' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020004', N'EM0002', N'2       ', CAST(N'2019-02-14' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020005', N'EM0002', N'1       ', CAST(N'2019-02-14' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020006', N'EM0002', N'1       ', CAST(N'2019-02-14' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Headerorder] ([OrderID], [Employeeid], [Memberid], [Date], [Payment], [bank], [CardNumber]) VALUES (N'2019020007', N'EM0002', N'2       ', CAST(N'2019-02-14' AS Date), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[HeaderPackage] ON 

INSERT [dbo].[HeaderPackage] ([HeaderPackageID], [Name], [CountMeat], [CountVegetables], [Price], [MinOrder]) VALUES (1, N'Bronze', 1, 1, 50000, 100)
INSERT [dbo].[HeaderPackage] ([HeaderPackageID], [Name], [CountMeat], [CountVegetables], [Price], [MinOrder]) VALUES (2, N'Silver', 2, 2, 80000, 100)
INSERT [dbo].[HeaderPackage] ([HeaderPackageID], [Name], [CountMeat], [CountVegetables], [Price], [MinOrder]) VALUES (3, N'Gold', 2, 3, 120000, 100)
INSERT [dbo].[HeaderPackage] ([HeaderPackageID], [Name], [CountMeat], [CountVegetables], [Price], [MinOrder]) VALUES (4, N'Diamond', 3, 3, 150000, 100)
INSERT [dbo].[HeaderPackage] ([HeaderPackageID], [Name], [CountMeat], [CountVegetables], [Price], [MinOrder]) VALUES (5, N'Platinum', 3, 4, 200000, 100)
SET IDENTITY_INSERT [dbo].[HeaderPackage] OFF
INSERT [dbo].[Msemployee] ([EmployeeID], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0001', N'Ikhsan Maulana', N'admin@gmail.com', N'Admin1', N'081398461650', N'Admin')
INSERT [dbo].[Msemployee] ([EmployeeID], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0002', N'Robby', N'cashier@gmail.com', N'Cashier1', N'081231321535', N'Cashier')
INSERT [dbo].[Msemployee] ([EmployeeID], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0003', N'Hengky Sanjaya', N'chef@gmail.com', N'Chef1', N'081321531135', N'Chef')
INSERT [dbo].[Msemployee] ([EmployeeID], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0004', N'Edi Gunawan', N'edi@gmail.com', N'H4tZfjCY', N'083215125215', N'Chef')
INSERT [dbo].[Msmember] ([MemberID], [Name], [Email], [Handphone], [JoinDate]) VALUES (N'1       ', N'Rama', N'rama@gmail.com', N'081231321511', CAST(N'2019-02-13' AS Date))
INSERT [dbo].[Msmember] ([MemberID], [Name], [Email], [Handphone], [JoinDate]) VALUES (N'2       ', N'Budi', N'budi@gmail.com', N'082123215152', CAST(N'2019-02-13' AS Date))
INSERT [dbo].[Msmember] ([MemberID], [Name], [Email], [Handphone], [JoinDate]) VALUES (N'3       ', N'Ana', N'ana@gmail.com', N'081213151531', CAST(N'2019-02-13' AS Date))
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (1, N'Cumi Goreng Terasi', 50000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\cumi-goreng-terasi.jpg', N'Meat')
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (2, N'Gado-Gado', 10000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\Gado2.jpeg', N'Vegetables')
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (3, N'Lemon Tea', 10000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\lemontea.jpg', N'Drink')
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (4, N'Ikan bakar bali', 65000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\ikan-bakar-bali.jpg', N'Meat')
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (5, N'Mie Ayam', 12000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\MieAyam.jpg', N'Meat')
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (6, N'Sate Ayam', 15000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\sate-ayam.jpg', N'Meat')
INSERT [dbo].[Msmenu] ([MenuID], [Name], [Price], [Photo], [Category]) VALUES (7, N'Sayur Kol', 10000, N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\Sayur-Kol.jpg', N'Vegetables')
SET IDENTITY_INSERT [dbo].[Review] ON 

INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (1, N'2019020001', 5, 5, N'Sangat Lezat mie ayam yang saya pesan', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\MieAyam.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (3, N'2019020002', 1, 5, N'Cumi makanan kesukaan saya mantap', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\cumi-goreng-terasi.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (4, N'2019020003', 1, 5, N'Wow Gurih kerasa banget', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\cumi-goreng-terasi.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (6, N'2019020001', 6, 5, N'Sate Ayam Enak', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\sate-ayam.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (7, N'2019020002', 2, 5, N'Bikin ketahian makan gado-gado di restaurant ini', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\Gado2.jpeg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (9, N'2019020004', 3, 5, N'Manis dan murah harganya', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\lemontea.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (10, N'2019020002', 4, 5, N'Besar sekali daging ikannya', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\ikan-bakar-bali.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (12, N'2019020007', 7, 5, N'Sangat bergizi sayurannya', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\Sayur-Kol.jpg', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[Review] ([Reviewid], [Orderid], [Menuid], [Rating], [Note], [Photo], [Date]) VALUES (13, N'2019020006', 1, 5, N'Mantap lezat', N'C:\Users\ADMIN\source\repos\LKS Kota Tangerang 2019 Ikhsan Maulana\Resource\cumi-goreng-terasi.jpg', CAST(N'2019-02-14' AS Date))
SET IDENTITY_INSERT [dbo].[Review] OFF
ALTER TABLE [dbo].[Detailorder]  WITH CHECK ADD  CONSTRAINT [FK_Detailorder_Headerorder] FOREIGN KEY([Orderid])
REFERENCES [dbo].[Headerorder] ([OrderID])
GO
ALTER TABLE [dbo].[Detailorder] CHECK CONSTRAINT [FK_Detailorder_Headerorder]
GO
ALTER TABLE [dbo].[Detailorder]  WITH CHECK ADD  CONSTRAINT [FK_Detailorder_Msmenu] FOREIGN KEY([Menuid])
REFERENCES [dbo].[Msmenu] ([MenuID])
GO
ALTER TABLE [dbo].[Detailorder] CHECK CONSTRAINT [FK_Detailorder_Msmenu]
GO
ALTER TABLE [dbo].[DetailPackage]  WITH CHECK ADD  CONSTRAINT [FK_DetailPackage_HeaderPackage] FOREIGN KEY([HeaderPackageID])
REFERENCES [dbo].[HeaderPackage] ([HeaderPackageID])
GO
ALTER TABLE [dbo].[DetailPackage] CHECK CONSTRAINT [FK_DetailPackage_HeaderPackage]
GO
ALTER TABLE [dbo].[DetailPackage]  WITH CHECK ADD  CONSTRAINT [FK_DetailPackage_Msmenu] FOREIGN KEY([Menuid])
REFERENCES [dbo].[Msmenu] ([MenuID])
GO
ALTER TABLE [dbo].[DetailPackage] CHECK CONSTRAINT [FK_DetailPackage_Msmenu]
GO
ALTER TABLE [dbo].[Headerorder]  WITH CHECK ADD  CONSTRAINT [FK_Headerorder_Msemployee] FOREIGN KEY([Employeeid])
REFERENCES [dbo].[Msemployee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Headerorder] CHECK CONSTRAINT [FK_Headerorder_Msemployee]
GO
ALTER TABLE [dbo].[Headerorder]  WITH CHECK ADD  CONSTRAINT [FK_Headerorder_Msmember] FOREIGN KEY([Memberid])
REFERENCES [dbo].[Msmember] ([MemberID])
GO
ALTER TABLE [dbo].[Headerorder] CHECK CONSTRAINT [FK_Headerorder_Msmember]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Headerorder] FOREIGN KEY([Orderid])
REFERENCES [dbo].[Headerorder] ([OrderID])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Headerorder]
GO
