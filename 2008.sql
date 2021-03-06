USE [master]
GO
/****** Object:  Database [QuanLyMoiGiang]    Script Date: 12/12/2016 8:05:03 PM ******/
CREATE DATABASE [QuanLyMoiGiang] ON  PRIMARY 
( NAME = N'QuanLyMoiGiang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyMoiGiang.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyMoiGiang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyMoiGiang_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyMoiGiang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyMoiGiang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyMoiGiang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyMoiGiang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyMoiGiang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyMoiGiang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyMoiGiang] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyMoiGiang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyMoiGiang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyMoiGiang] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyMoiGiang', N'ON'
GO
USE [QuanLyMoiGiang]
GO
/****** Object:  Table [dbo].[ChiTietMoiGiang]    Script Date: 12/12/2016 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietMoiGiang](
	[MaMoiGiang] [varchar](10) NOT NULL,
	[MaGiaoVien] [varchar](10) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
 CONSTRAINT [PK_ChiTietMoiGiang] PRIMARY KEY CLUSTERED 
(
	[MaMoiGiang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinDangNhap]    Script Date: 12/12/2016 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinDangNhap](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](10) NOT NULL,
	[MaGiaoVien] [varchar](10) NOT NULL,
	[Quyen] [varchar](5) NOT NULL,
 CONSTRAINT [PK_ThongTinDangNhap_1] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinGiangVien]    Script Date: 12/12/2016 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinGiangVien](
	[TenGiaoVien] [nvarchar](50) NOT NULL,
	[MaGiaoVien] [varchar](10) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[DienThoai] [varchar](11) NULL,
 CONSTRAINT [PK_ThongTinGiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinLop]    Script Date: 12/12/2016 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinLop](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ThongTinLop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinMonHoc]    Script Date: 12/12/2016 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinMonHoc](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_ThongTinMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[tim]    Script Date: 12/12/2016 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tim] as
select d.MaGiaoVien, g.TenGiaoVien, TenDangNhap , d.MatKhau , d.Quyen
                            from dbo.ThongTinDangNhap as d, dbo.ThongTinGiangVien as g
                            where d.MaGiaoVien = g.MaGiaoVien and d.MaGiaoVien like '%GV0002%' 
GO
INSERT [dbo].[ThongTinGiangVien] ([TenGiaoVien], [MaGiaoVien], [GioiTinh], [NgaySinh], [DiaChi], [Email], [DienThoai]) VALUES (N'Tô Thị Bích Loan', N'GV0002', N'Nữ        ', CAST(N'2016-12-07' AS Date), N'Phan Rang Ninh Thuận', N'loanto@gmail.com', N'0988903219')
INSERT [dbo].[ThongTinGiangVien] ([TenGiaoVien], [MaGiaoVien], [GioiTinh], [NgaySinh], [DiaChi], [Email], [DienThoai]) VALUES (N'Tô Hoàng Phụng', N'GV0003', N'Nam       ', CAST(N'1996-07-27' AS Date), N'Phan Rang Ninh Thuận', N'Phungpro0127@gmail.com', N'01659858520')
INSERT [dbo].[ThongTinGiangVien] ([TenGiaoVien], [MaGiaoVien], [GioiTinh], [NgaySinh], [DiaChi], [Email], [DienThoai]) VALUES (N'Lưu Hoàng Phúc', N'GV0004', N'Nữ        ', CAST(N'1996-02-12' AS Date), N'232 Nguyễn Tất Thành Quận 4 TP Hồ Chí Minh', N'Phucluu@gmail.com', N'123456789')
INSERT [dbo].[ThongTinGiangVien] ([TenGiaoVien], [MaGiaoVien], [GioiTinh], [NgaySinh], [DiaChi], [Email], [DienThoai]) VALUES (N'Trần Minh Chiến', N'GV0005', N'Nam       ', CAST(N'2016-12-07' AS Date), N'Đại Học Quốc Gia Hồ Chí Minh', N'chientran@gmail.com', N'0125896324')
INSERT [dbo].[ThongTinGiangVien] ([TenGiaoVien], [MaGiaoVien], [GioiTinh], [NgaySinh], [DiaChi], [Email], [DienThoai]) VALUES (N'Tô Minh Nhựt', N'GV0006', N'Nữ        ', CAST(N'1996-08-01' AS Date), N'123 Nguyễn Trãi Quận 10 TP Hồ Chí Minh', N'tominhnhut@gmail.com', N'01293779590')
INSERT [dbo].[ThongTinLop] ([MaLop], [TenLop]) VALUES (N'ML001', N'14DTH02')
INSERT [dbo].[ThongTinLop] ([MaLop], [TenLop]) VALUES (N'ML002', N'14DTH03')
INSERT [dbo].[ThongTinLop] ([MaLop], [TenLop]) VALUES (N'ML003', N'14DTH04')
INSERT [dbo].[ThongTinLop] ([MaLop], [TenLop]) VALUES (N'ML004', N'14DTH05')
INSERT [dbo].[ThongTinLop] ([MaLop], [TenLop]) VALUES (N'ML005', N'14DTH06')
INSERT [dbo].[ThongTinMonHoc] ([MaMon], [TenMon], [SoTiet]) VALUES (N'MH001', N'Lập trình C++', 30)
INSERT [dbo].[ThongTinMonHoc] ([MaMon], [TenMon], [SoTiet]) VALUES (N'MH002', N'Lập trình C#', 30)
INSERT [dbo].[ThongTinMonHoc] ([MaMon], [TenMon], [SoTiet]) VALUES (N'MH003', N'Lập trình Java', 40)
INSERT [dbo].[ThongTinMonHoc] ([MaMon], [TenMon], [SoTiet]) VALUES (N'MH004', N'Lập trình Php', 50)
INSERT [dbo].[ThongTinMonHoc] ([MaMon], [TenMon], [SoTiet]) VALUES (N'MH005', N'Lập Trình Web', 45)
ALTER TABLE [dbo].[ChiTietMoiGiang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMoiGiang_ThongTinGiangVien] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[ThongTinGiangVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[ChiTietMoiGiang] CHECK CONSTRAINT [FK_ChiTietMoiGiang_ThongTinGiangVien]
GO
ALTER TABLE [dbo].[ChiTietMoiGiang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMoiGiang_ThongTinLop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[ThongTinLop] ([MaLop])
GO
ALTER TABLE [dbo].[ChiTietMoiGiang] CHECK CONSTRAINT [FK_ChiTietMoiGiang_ThongTinLop]
GO
ALTER TABLE [dbo].[ChiTietMoiGiang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMoiGiang_ThongTinMonHoc1] FOREIGN KEY([MaMon])
REFERENCES [dbo].[ThongTinMonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietMoiGiang] CHECK CONSTRAINT [FK_ChiTietMoiGiang_ThongTinMonHoc1]
GO
ALTER TABLE [dbo].[ThongTinDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinDangNhap_ThongTinGiangVien] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[ThongTinGiangVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[ThongTinDangNhap] CHECK CONSTRAINT [FK_ThongTinDangNhap_ThongTinGiangVien]
GO
ALTER TABLE [dbo].[ChiTietMoiGiang]  WITH CHECK ADD  CONSTRAINT [ktr] CHECK  (([NgayKetThuc]>[NgayBatDau]))
GO
ALTER TABLE [dbo].[ChiTietMoiGiang] CHECK CONSTRAINT [ktr]
GO
ALTER TABLE [dbo].[ThongTinDangNhap]  WITH CHECK ADD  CONSTRAINT [CK_ThongTinDangNhap] CHECK  (([Quyen]='Admin' OR [Quyen]='User'))
GO
ALTER TABLE [dbo].[ThongTinDangNhap] CHECK CONSTRAINT [CK_ThongTinDangNhap]
GO
ALTER TABLE [dbo].[ThongTinGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_ThongTinGiangVien] CHECK  (([GioiTinh]=N'Nam' OR [GioiTinh]=N'Nữ'))
GO
ALTER TABLE [dbo].[ThongTinGiangVien] CHECK CONSTRAINT [CK_ThongTinGiangVien]
GO
ALTER TABLE [dbo].[ThongTinGiangVien]  WITH CHECK ADD  CONSTRAINT [CK_ThongTinGiangVien_email] CHECK  (([Email] like '%@gmail.com%' OR [Email] like '%@yahoo.com%' OR [Email] like '%@outlook.com%' OR [Email] like '%@%'))
GO
ALTER TABLE [dbo].[ThongTinGiangVien] CHECK CONSTRAINT [CK_ThongTinGiangVien_email]
GO
ALTER TABLE [dbo].[ThongTinMonHoc]  WITH CHECK ADD  CONSTRAINT [CK_ThongTinMonHoc] CHECK  (([SoTiet]>(0)))
GO
ALTER TABLE [dbo].[ThongTinMonHoc] CHECK CONSTRAINT [CK_ThongTinMonHoc]
GO
USE [master]
GO
ALTER DATABASE [QuanLyMoiGiang] SET  READ_WRITE 
GO
