USE [master]
GO
/****** Object:  Database [Stok_Takip]    Script Date: 24/08/2019 09:46:32 ******/
CREATE DATABASE [Stok_Takip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stok_Takip', FILENAME = N'C:\Users\Ozan\Desktop\ozancod-master\WindowsFormsApp1' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stok_Takip_log', FILENAME = N'C:\Users\Ozan\Desktop\ozancod-master\WindowsFormsApp1' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Stok_Takip] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stok_Takip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stok_Takip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stok_Takip] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stok_Takip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stok_Takip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stok_Takip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stok_Takip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stok_Takip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stok_Takip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stok_Takip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stok_Takip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stok_Takip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stok_Takip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stok_Takip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stok_Takip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stok_Takip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stok_Takip] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stok_Takip] SET  MULTI_USER 
GO
ALTER DATABASE [Stok_Takip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stok_Takip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stok_Takip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stok_Takip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Stok_Takip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Stok_Takip] SET QUERY_STORE = OFF
GO
USE [Stok_Takip]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Stok_Takip]
GO
/****** Object:  Table [dbo].[MUSTERI]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUSTERI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [nvarchar](250) NOT NULL,
	[UNVAN] [nvarchar](250) NOT NULL,
	[VKN_TC] [nvarchar](250) NULL,
	[ADRES] [nvarchar](1000) NULL,
	[SORUMLUADSOYAD] [nvarchar](250) NULL,
	[SORUMLUTEL] [nchar](50) NULL,
	[FIRMATEL] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[URUN]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[URUN](
	[KATEGORIID] [int] NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_markabilgileri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ANADEPO]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANADEPO](
	[SIPARISNO] [nvarchar](50) NOT NULL,
	[URUNID] [int] NOT NULL,
	[MIKTAR] [int] NOT NULL,
	[TARIH] [datetime] NOT NULL,
	[MUSTERIID] [int] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TOPLAMSATIS] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AnaDepoView]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AnaDepoView]
AS
SELECT        SIPARISNO, URUNID, MIKTAR, TARIH, MUSTERIID, ID, TOPLAMSATIS,
                             (SELECT        AD
                               FROM            dbo.MUSTERI AS m
                               WHERE        (ID = ad.MUSTERIID)) AS MUSTERIAD,
                             (SELECT        VKN_TC
                               FROM            dbo.MUSTERI AS m
                               WHERE        (ID = ad.MUSTERIID)) AS VKN_TC,
                             (SELECT        SORUMLUADSOYAD
                               FROM            dbo.MUSTERI AS m
                               WHERE        (ID = ad.MUSTERIID)) AS SORUMLUADSOYAD,
                             (SELECT        NAME
                               FROM            dbo.URUN AS u
                               WHERE        (ID = ad.URUNID)) AS URUNAD
FROM            dbo.ANADEPO AS ad
GO
/****** Object:  Table [dbo].[ARADEPO]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARADEPO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MALZEMEID] [int] NOT NULL,
	[MIKTARI] [bigint] NOT NULL,
	[ALISFIYATI] [decimal](18, 2) NOT NULL,
	[SATISFIYATI] [decimal](18, 2) NOT NULL,
	[TARIH] [date] NOT NULL,
	[MALZEMEADI] [nvarchar](250) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KATEGORI]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KATEGORI](
	[AD] [nvarchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_kategoribilgileri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MALZEME]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MALZEME](
	[BARKODNO] [nvarchar](50) NOT NULL,
	[MALZEMEADI] [nvarchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[URUNMALZEME]    Script Date: 24/08/2019 09:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[URUNMALZEME](
	[URUNID] [int] NOT NULL,
	[MALZEMEID] [int] NOT NULL,
	[MIKTARI] [int] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MALZEMEADI] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ANADEPO] ON 
GO
INSERT [dbo].[ANADEPO] ([SIPARISNO], [URUNID], [MIKTAR], [TARIH], [MUSTERIID], [ID], [TOPLAMSATIS]) VALUES (N'4', 12, 1, CAST(N'2019-08-24T08:57:43.547' AS DateTime), 1, 1, CAST(112.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[ANADEPO] OFF
GO
SET IDENTITY_INSERT [dbo].[ARADEPO] ON 
GO
INSERT [dbo].[ARADEPO] ([ID], [MALZEMEID], [MIKTARI], [ALISFIYATI], [SATISFIYATI], [TARIH], [MALZEMEADI]) VALUES (3, 2, 940, CAST(11.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(N'2019-12-12' AS Date), N'süt')
GO
SET IDENTITY_INSERT [dbo].[ARADEPO] OFF
GO
SET IDENTITY_INSERT [dbo].[KATEGORI] ON 
GO
INSERT [dbo].[KATEGORI] ([AD], [ID]) VALUES (N'Pasta', 1)
GO
INSERT [dbo].[KATEGORI] ([AD], [ID]) VALUES (N'kek', 7)
GO
INSERT [dbo].[KATEGORI] ([AD], [ID]) VALUES (N'Dondurma', 8)
GO
INSERT [dbo].[KATEGORI] ([AD], [ID]) VALUES (N'Milkshake', 9)
GO
SET IDENTITY_INSERT [dbo].[KATEGORI] OFF
GO
SET IDENTITY_INSERT [dbo].[MALZEME] ON 
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'100', N'süt', 2)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'101', N'sıvı şanti', 3)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'102', N'toz şeker', 4)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'103', N'veyaz yumurta', 5)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'104', N'beyaz pul çikolata', 6)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'105', N'beyaz konfiserie', 7)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'106', N'un', 8)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'107', N'jelatin', 9)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'108', N'tirisodyum fosfat', 10)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'103', N'bütün yumurta3', 13)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'22', N'süt', 14)
GO
INSERT [dbo].[MALZEME] ([BARKODNO], [MALZEMEADI], [ID]) VALUES (N'1020', N'toz şeker0', 17)
GO
SET IDENTITY_INSERT [dbo].[MALZEME] OFF
GO
SET IDENTITY_INSERT [dbo].[MUSTERI] ON 
GO
INSERT [dbo].[MUSTERI] ([ID], [AD], [UNVAN], [VKN_TC], [ADRES], [SORUMLUADSOYAD], [SORUMLUTEL], [FIRMATEL]) VALUES (1, N'I0net', N'lte', N'15635383442', N'esenkent', N'maltepe', N'05313531355                                       ', N'02163531355                                       ')
GO
INSERT [dbo].[MUSTERI] ([ID], [AD], [UNVAN], [VKN_TC], [ADRES], [SORUMLUADSOYAD], [SORUMLUTEL], [FIRMATEL]) VALUES (8, N'anıl', N'stl', N'125123123', N'ıstanbul', N'maltepe', N'0531                                              ', N'123                                               ')
GO
SET IDENTITY_INSERT [dbo].[MUSTERI] OFF
GO
SET IDENTITY_INSERT [dbo].[URUN] ON 
GO
INSERT [dbo].[URUN] ([KATEGORIID], [NAME], [ID]) VALUES (1, N'crazy beyaz krema', 4)
GO
INSERT [dbo].[URUN] ([KATEGORIID], [NAME], [ID]) VALUES (7, N'yumurta', 10)
GO
INSERT [dbo].[URUN] ([KATEGORIID], [NAME], [ID]) VALUES (9, N'Süt', 11)
GO
INSERT [dbo].[URUN] ([KATEGORIID], [NAME], [ID]) VALUES (1, N'çikolatalı pasta1', 12)
GO
SET IDENTITY_INSERT [dbo].[URUN] OFF
GO
SET IDENTITY_INSERT [dbo].[URUNMALZEME] ON 
GO
INSERT [dbo].[URUNMALZEME] ([URUNID], [MALZEMEID], [MIKTARI], [ID], [MALZEMEADI]) VALUES (4, 2, 90, 4, N'süt')
GO
INSERT [dbo].[URUNMALZEME] ([URUNID], [MALZEMEID], [MIKTARI], [ID], [MALZEMEADI]) VALUES (12, 2, 60, 9, N'süt')
GO
INSERT [dbo].[URUNMALZEME] ([URUNID], [MALZEMEID], [MIKTARI], [ID], [MALZEMEADI]) VALUES (4, 10, 90, 7, N'tirisodyum fosfat')
GO
INSERT [dbo].[URUNMALZEME] ([URUNID], [MALZEMEID], [MIKTARI], [ID], [MALZEMEADI]) VALUES (4, 5, 9870, 6, N'veyaz yumurta')
GO
INSERT [dbo].[URUNMALZEME] ([URUNID], [MALZEMEID], [MIKTARI], [ID], [MALZEMEADI]) VALUES (10, 2, 80, 8, N'süt')
GO
SET IDENTITY_INSERT [dbo].[URUNMALZEME] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ad"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AnaDepoView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AnaDepoView'
GO
USE [master]
GO
ALTER DATABASE [Stok_Takip] SET  READ_WRITE 
GO
