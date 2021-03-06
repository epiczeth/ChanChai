USE [master]
GO
/****** Object:  Database [chanchaikr]    Script Date: 12/11/2558 18:12:00 ******/
CREATE DATABASE [chanchaikr]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Community', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\chanchai kr.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Community_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\chanchai kr.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [chanchaikr] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [chanchaikr].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [chanchaikr] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [chanchaikr] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [chanchaikr] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [chanchaikr] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [chanchaikr] SET ARITHABORT OFF 
GO
ALTER DATABASE [chanchaikr] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [chanchaikr] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [chanchaikr] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [chanchaikr] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [chanchaikr] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [chanchaikr] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [chanchaikr] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [chanchaikr] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [chanchaikr] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [chanchaikr] SET  DISABLE_BROKER 
GO
ALTER DATABASE [chanchaikr] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [chanchaikr] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [chanchaikr] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [chanchaikr] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [chanchaikr] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [chanchaikr] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [chanchaikr] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [chanchaikr] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [chanchaikr] SET  MULTI_USER 
GO
ALTER DATABASE [chanchaikr] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [chanchaikr] SET DB_CHAINING OFF 
GO
ALTER DATABASE [chanchaikr] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [chanchaikr] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [chanchaikr] SET DELAYED_DURABILITY = DISABLED 
GO
USE [chanchaikr]
GO
/****** Object:  Table [dbo].[Circulation]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Circulation](
	[Years] [varchar](4) NOT NULL,
	[M_ID] [int] NOT NULL,
	[Sum] [float] NULL,
 CONSTRAINT [PK_Circulation] PRIMARY KEY CLUSTERED 
(
	[Years] ASC,
	[M_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dividend]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dividend](
	[Years] [varchar](4) NOT NULL,
	[M_ID] [int] NOT NULL,
	[P] [int] NULL,
	[D_P] [int] NULL,
	[Sum] [float] NULL,
	[D_Sum] [float] NULL,
	[SubTotal] [float] NULL,
 CONSTRAINT [PK_Dividend] PRIMARY KEY CLUSTERED 
(
	[Years] ASC,
	[M_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Member]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[M_ID] [int] NOT NULL,
	[Prefix] [varchar](50) NULL,
	[Name] [varchar](100) NULL,
	[Surname] [varchar](100) NULL,
	[P] [int] NULL,
	[Money] [int] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[M_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Member1]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member1](
	[M_ID] [varchar](13) NOT NULL,
	[Name] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[Phone] [int] NULL,
	[Mail] [varchar](100) NULL,
 CONSTRAINT [PK_Member1] PRIMARY KEY CLUSTERED 
(
	[M_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[O_ID] [int] NOT NULL,
	[Date] [date] NULL,
	[Net] [float] NULL,
	[Status] [varchar](1) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[O_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders_Detail]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders_Detail](
	[O_ID] [int] NOT NULL,
	[P_ID] [varchar](13) NOT NULL,
	[Base] [float] NULL,
	[Qty] [int] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Orders_Detail] PRIMARY KEY CLUSTERED 
(
	[O_ID] ASC,
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[P_ID] [varchar](13) NOT NULL,
	[Name] [varchar](100) NULL,
	[Base] [float] NULL,
	[Price] [float] NULL,
	[Low] [int] NULL,
	[Stock] [int] NULL,
	[T_ID] [varchar](10) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product1]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product1](
	[P_ID] [varchar](13) NOT NULL,
	[Date] [date] NULL,
	[Name] [varchar](100) NULL,
	[Base] [float] NULL,
	[Price] [float] NULL,
	[Low] [int] NULL,
	[Stock] [int] NULL,
	[NameT] [varchar](100) NULL,
 CONSTRAINT [PK_Product1] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product2]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product2](
	[P_ID] [varchar](13) NOT NULL,
	[Type] [varchar](100) NULL,
	[Name] [varchar](100) NULL,
	[Color] [varchar](50) NULL,
	[Size] [varchar](50) NULL,
	[unit] [varchar](50) NULL,
	[Base] [float] NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[Spe] [float] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_Product2] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product3]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product3](
	[P_ID] [varchar](13) NOT NULL,
	[Type] [varchar](100) NULL,
	[Name] [varchar](100) NULL,
	[Color] [varchar](100) NULL,
	[Size] [varchar](13) NULL,
	[unit] [varchar](13) NULL,
	[Base] [float] NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[Spe] [float] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_Product3] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[S_ID] [int] NOT NULL,
	[Date] [date] NULL,
	[Net] [float] NULL,
	[M_ID] [int] NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sale_Detail]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sale_Detail](
	[S_ID] [int] NOT NULL,
	[P_ID] [varchar](13) NOT NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[special] [float] NULL,
	[Qty] [int] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Sale_Detail] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC,
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sale_Detail1]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sale_Detail1](
	[S_ID] [int] NOT NULL,
	[P_ID] [varchar](13) NOT NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[special] [float] NULL,
	[Qty] [int] NULL,
	[QtyL] [int] NULL,
	[QtyS] [int] NULL,
	[Total] [int] NULL,
	[TotalL] [int] NULL,
	[TotalS] [int] NULL,
 CONSTRAINT [PK_Sale_Detail1] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC,
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sale_Detail2]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sale_Detail2](
	[S_ID] [int] NOT NULL,
	[P_ID] [varchar](13) NOT NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[Special] [float] NULL,
	[Qty] [int] NULL,
	[QtyL] [int] NULL,
	[QtyS] [int] NULL,
	[Total] [int] NULL,
	[TotalL] [int] NULL,
	[TotalS] [int] NULL,
 CONSTRAINT [PK_Sale_Detail2] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC,
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sale1]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sale1](
	[S_ID] [int] NOT NULL,
	[Date] [date] NULL,
	[Net] [float] NULL,
	[Name] [varchar](100) NULL,
 CONSTRAINT [PK_Sale1] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Screen]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Screen](
	[C_ID] [varchar](13) NOT NULL,
	[Name] [varchar](100) NULL,
	[Size] [varchar](50) NULL,
	[unit] [varchar](50) NULL,
	[Base] [float] NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_Screen] PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shirt]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shirt](
	[ID_S] [varchar](13) NOT NULL,
	[Type] [varchar](100) NULL,
	[Name] [varchar](100) NULL,
	[Color] [varchar](100) NULL,
	[Size] [varchar](13) NULL,
	[Base] [float] NULL,
	[Price] [float] NULL,
	[Low] [float] NULL,
	[Spe] [float] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_Shirt] PRIMARY KEY CLUSTERED 
(
	[ID_S] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Type]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Type](
	[T_ID] [varchar](10) NOT NULL,
	[Name] [varchar](100) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Type1]    Script Date: 12/11/2558 18:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Type1](
	[T_ID] [varchar](10) NOT NULL,
	[NameT] [varchar](100) NULL,
 CONSTRAINT [PK_Type1] PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [chanchaikr] SET  READ_WRITE 
GO
