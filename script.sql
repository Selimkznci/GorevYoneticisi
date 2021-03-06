USE [ButceHesapla]
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 26.03.2021 03:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borclar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kredikarti] [float] NULL,
	[Taksit] [float] NULL,
 CONSTRAINT [PK_Borclar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eglenceler]    Script Date: 26.03.2021 03:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eglenceler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sinema] [float] NULL,
	[Tatil] [float] NULL,
	[Spor] [float] NULL,
	[Hobi] [float] NULL,
 CONSTRAINT [PK_Eglenceler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 26.03.2021 03:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Su] [float] NULL,
	[Elektrik] [float] NULL,
	[DogalGaz] [float] NULL,
	[Telefon] [float] NULL,
 CONSTRAINT [PK_Faturalar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gelir]    Script Date: 26.03.2021 03:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gelir](
	[GelirId] [int] IDENTITY(1,1) NOT NULL,
	[Maas] [float] NULL,
	[KiraGeliri] [float] NULL,
	[Harclik] [float] NULL,
	[Burs] [float] NULL,
	[StajGeliri] [float] NULL,
	[EkGelirler] [float] NULL,
 CONSTRAINT [PK_Gelir] PRIMARY KEY CLUSTERED 
(
	[GelirId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gider]    Script Date: 26.03.2021 03:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gider](
	[Id] [int] NOT NULL,
	[FaturaId] [int] NULL,
	[EglenceId] [int] NULL,
	[BorcId] [int] NULL,
	[Kira] [float] NULL,
	[Aidat] [float] NULL,
	[YiyecekMarket] [float] NULL,
	[EvEsyasi] [float] NULL,
 CONSTRAINT [PK_Gider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Borclar] ON 

INSERT [dbo].[Borclar] ([Id], [Kredikarti], [Taksit]) VALUES (1, 480, 801)
INSERT [dbo].[Borclar] ([Id], [Kredikarti], [Taksit]) VALUES (2, 120, 400)
INSERT [dbo].[Borclar] ([Id], [Kredikarti], [Taksit]) VALUES (1002, 500, 400)
INSERT [dbo].[Borclar] ([Id], [Kredikarti], [Taksit]) VALUES (1003, 500, 400)
SET IDENTITY_INSERT [dbo].[Borclar] OFF
GO
SET IDENTITY_INSERT [dbo].[Eglenceler] ON 

INSERT [dbo].[Eglenceler] ([Id], [Sinema], [Tatil], [Spor], [Hobi]) VALUES (1, 38, 1350, 200, 20)
INSERT [dbo].[Eglenceler] ([Id], [Sinema], [Tatil], [Spor], [Hobi]) VALUES (2, 69, 0, 150, 230)
INSERT [dbo].[Eglenceler] ([Id], [Sinema], [Tatil], [Spor], [Hobi]) VALUES (1002, 0, 0, 120, 0)
INSERT [dbo].[Eglenceler] ([Id], [Sinema], [Tatil], [Spor], [Hobi]) VALUES (1003, 0, 0, 120, 0)
SET IDENTITY_INSERT [dbo].[Eglenceler] OFF
GO
SET IDENTITY_INSERT [dbo].[Faturalar] ON 

INSERT [dbo].[Faturalar] ([Id], [Su], [Elektrik], [DogalGaz], [Telefon]) VALUES (1, 53, 75, 380, 83)
INSERT [dbo].[Faturalar] ([Id], [Su], [Elektrik], [DogalGaz], [Telefon]) VALUES (2, 70, 90, 420.1, 105)
INSERT [dbo].[Faturalar] ([Id], [Su], [Elektrik], [DogalGaz], [Telefon]) VALUES (1002, 20, 40, 50, 35)
INSERT [dbo].[Faturalar] ([Id], [Su], [Elektrik], [DogalGaz], [Telefon]) VALUES (1003, 20, 40, 50, 35)
SET IDENTITY_INSERT [dbo].[Faturalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Gelir] ON 

INSERT [dbo].[Gelir] ([GelirId], [Maas], [KiraGeliri], [Harclik], [Burs], [StajGeliri], [EkGelirler]) VALUES (1, 3500, 0, 0, 0, 0, 1500)
INSERT [dbo].[Gelir] ([GelirId], [Maas], [KiraGeliri], [Harclik], [Burs], [StajGeliri], [EkGelirler]) VALUES (2, 2100, 0, 500, 670, 0, 0)
SET IDENTITY_INSERT [dbo].[Gelir] OFF
GO
INSERT [dbo].[Gider] ([Id], [FaturaId], [EglenceId], [BorcId], [Kira], [Aidat], [YiyecekMarket], [EvEsyasi]) VALUES (1, 1, 1, 1, 1200, 100, 400, 300)
INSERT [dbo].[Gider] ([Id], [FaturaId], [EglenceId], [BorcId], [Kira], [Aidat], [YiyecekMarket], [EvEsyasi]) VALUES (2, 2, 2, 2, 800, 35, 250, 150)
GO
ALTER TABLE [dbo].[Gider]  WITH CHECK ADD  CONSTRAINT [FK_Gider_Borclar] FOREIGN KEY([BorcId])
REFERENCES [dbo].[Borclar] ([Id])
GO
ALTER TABLE [dbo].[Gider] CHECK CONSTRAINT [FK_Gider_Borclar]
GO
ALTER TABLE [dbo].[Gider]  WITH CHECK ADD  CONSTRAINT [FK_Gider_Eglenceler] FOREIGN KEY([EglenceId])
REFERENCES [dbo].[Eglenceler] ([Id])
GO
ALTER TABLE [dbo].[Gider] CHECK CONSTRAINT [FK_Gider_Eglenceler]
GO
ALTER TABLE [dbo].[Gider]  WITH CHECK ADD  CONSTRAINT [FK_Gider_Faturalar] FOREIGN KEY([FaturaId])
REFERENCES [dbo].[Faturalar] ([Id])
GO
ALTER TABLE [dbo].[Gider] CHECK CONSTRAINT [FK_Gider_Faturalar]
GO
