USE master
go
DROP DATABASE IF EXISTS QLTV 
GO
CREATE DATABASE QLTV
GO
USE QLTV
GO
-----------TẠO CÁC BẢNG-------------

CREATE TABLE [dbo].[NGUOIDUNG](
	[TaiKhoan] [varchar](50) PRIMARY KEY NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[MaQuyen] [nvarchar](50) NOT NULL
)
GO

CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](50) PRIMARY KEY NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
	[TenTruongKhoa] [nvarchar](50) NULL,
	[SDTKhoa] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
)
GO

CREATE TABLE [dbo].[LoaiSach](
	[MaLoai] [varchar](50) NOT NULL PRIMARY KEY,
	[TenLoai] [nvarchar](50) NULL
)
GO

CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL PRIMARY KEY,
	[TenNCC] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL
)
GO

CREATE TABLE [dbo].[KESACH](
	[MaKe] [varchar](50) NOT NULL PRIMARY KEY,
	[ChatLieu] [nvarchar](50) NULL,
	[SucChua] [int] NULL,
	[LoaiSach] [varchar] (50) NULL
)
GO

CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](50) NOT NULL PRIMARY KEY,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaKe] [varchar](50) NOT NULL foreign key references KESACH(MaKe) ON DELETE CASCADE ON UPDATE CASCADE,
	[NhaXuatBan] [nvarchar](100) NULL,
	[NamXuatBan] [int] NULL,
	[TacGia] [nvarchar](100) NULL,
	[MaLoai] [varchar](50) NOT NULL foreign key references LoaiSach(MaLoai) ON DELETE CASCADE ON UPDATE CASCADE,
)
GO

CREATE TABLE [dbo].[DOCGIA](
	[MaDocGia] [varchar](50) NOT NULL PRIMARY KEY,
	[LoaiDocGia] [nvarchar](50) NOT NULL,
	[TenDocGia] [nvarchar](50) NOT NULL,
	[MaKhoa] [varchar](50) NOT NULL foreign key references Khoa(MaKhoa) ON DELETE CASCADE ON UPDATE CASCADE,
	[Lop] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](16) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL
)
GO

CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [varchar](50) NOT NULL PRIMARY KEY,
	[NgayLap] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[NguoiLap] [varchar](50) NOT NULL foreign key references NGUOIDUNG(TaiKhoan) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

CREATE TABLE [dbo].[CHITIETNHAP](
	[MaPN] [varchar](50) NOT NULL foreign key references PHIEUNHAP(MaPN) ON DELETE CASCADE ON UPDATE CASCADE,
	[MaSach] [varchar](50) NOT NULL foreign key references SACH(MaSach) ON DELETE CASCADE ON UPDATE CASCADE,
	[MaNCC] [varchar](50) NOT NULL foreign key references NhaCungCap(MaNCC) ON DELETE CASCADE ON UPDATE CASCADE,
	[SoLuong] [int] NOT NULL
)
GO
ALTER TABLE CHITIETNHAP ADD PRIMARY KEY(MaPN,MaSach)
GO

CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [varchar](50) NOT NULL PRIMARY KEY,
	[NgayMuon] [datetime] NULL,
	[NguoiLapPhieuMuon] [varchar](50) NOT NULL foreign key references NGUOIDUNG(TaiKhoan) ON DELETE CASCADE ON UPDATE CASCADE,
	[MaDocGia] [varchar](50) NOT NULL foreign key references DOCGIA(MaDocGia) ON DELETE CASCADE ON UPDATE CASCADE, 
	[GhiChu] [nvarchar](50) NULL
)
GO

CREATE TABLE [dbo].[CHITIETMUON](
	[MaPM] [varchar](50) NOT NULL foreign key references PHIEUMUON(MaPM) ON DELETE CASCADE ON UPDATE CASCADE,
	[MaSach] [varchar](50) NOT NULL foreign key references SACH(MaSach) ON DELETE CASCADE ON UPDATE CASCADE,
	[SoLuong] [int] NULL,
	[NgayTra] [datetime] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[NguoiLapPhieuTra] [varchar](50) NULL foreign key references NGUOIDUNG(TaiKhoan),
	TinhTrangSachKhiMuon NVARCHAR(50) NULL,
	TinhTrangSachKhiTra NVARCHAR(50) NULL
)
GO
ALTER TABLE CHITIETMUON ADD PRIMARY KEY(MaPM,MaSach)
GO

------------THÊM DỮ LIỆU CHO CÁC BẢNG-----------

INSERT INTO NGUOIDUNG (TaiKhoan,MatKhau,MaQuyen) VALUES
(N'ADMIN',N'123',N'Quản trị viên'),
(N'USER1',N'456',N'Nhân viên'),
(N'USER2',N'456',N'Nhân viên'),
(N'USER3',N'456',N'Nhân viên'),
(N'USER4',N'456',N'Nhân viên'),
(N'USER5',N'456',N'Nhân viên')
GO

INSERT INTO KESACH (MaKe,ChatLieu,SucChua,LoaiSach) VALUES
(N'KE01',N'a',1000,'KINHTE'),
(N'KE02',N'b',5000,'LAPTRINH'),
(N'KE03',N'a',1000,'NGOAINGU'),
(N'KE04',N'b',1000,'KIENTRUC'),
(N'KE05',N'a',1000,'LUAT'),
(N'KE06',N'b',1000,'KHOAHOC')
GO

SELECT * FROM KESACH

INSERT INTO LoaiSach(MaLoai,TenLoai) VALUES
('KHOAHOC',N'Khoa học'),
('KINHTE',N'Kinh tế'),
('LAPTRINH',N'Lập trình'),
('NGOAINGU',N'Ngoại ngữ'),
('KIENTRUC',N'Kiến trúc'),
('LUAT',N'Luật')
GO

INSERT INTO Khoa(MaKhoa,TenKhoa,TenTruongKhoa,SDTKhoa,Email) VALUES 
('KINHTE', N'Khoa Kinh tế', N'Phạm Văn Hùng', '0981234567', 'hungpv@ou.edu.vn'),
('XAYDUNG', N'Khoa Xây dựng', N'Nguyễn Thị Hòa', '0918777666', 'hoant@ou.edu.vn'),
('DIENTU', N'Khoa Điện tử', N'Trần Minh Khoa', '0909090909', 'khoatm@ou.edu.vn'),
('CNTT', N'Khoa Công Nghệ Thông Tin', N'Lê Viết Tuấn', '0977888999', 'tuanlv@ou.edu.vn'),
('LUAT', N'Khoa Luật', N'Hoàng Quốc Việt', '0922233445', 'viethq@ou.edu.vn')
GO

INSERT INTO NhaCungCap(MaNCC,TenNCC,SDT,DiaChi) VALUES
('NXB01', N'Nhà xuất bản Giáo dục', '0901123456', N'123 Trần Hưng Đạo, Q1, TP.HCM'),
('NXB02', N'Nhà xuất bản Trẻ', '0911223344', N'15B Nguyễn Đình Chiểu, Q3, TP.HCM'),
('NXB03', N'Nhà xuất bản Kim Đồng', '0988112233', N'62 Nguyễn Du, Hai Bà Trưng, Hà Nội')
GO

INSERT INTO DocGia (MaDocGia,LoaiDocGia,TenDocGia,MaKhoa,Lop,GioiTinh,NgaySinh,DiaChi,SDT) VALUES
('DG01', N'Sinh viên', N'Nguyễn Văn Anh', 'CNTT', 'IT01',N'Nam','Jul 15 2003 12:00:00:000AM',N'Đà Nẵng', '0911222000'),
('DG02', N'Sinh viên', N'Lê Thị Bích Ngọc', 'CNTT', 'IT02', N'Nữ', 'Nov 23 2004 12:00:00:000AM', N'Đà Nẵng', '0911222333'),
('DG03', N'Sinh viên', N'Phạm Minh Tuấn', 'CNTT', 'IT01', N'Nam', 'Oct 20 2002 12:00:00:000AM', N'TP.HCM', '0903344556'),
('DG04', N'Sinh viên', N'Trần Hoàng Nam', 'XAYDUNG', 'XD01', N'Nam', 'Mar 12 2001 12:00:00:000AM', N'Hà Nội', '0988665544'),
('DG05', N'Sinh viên', N'Nguyễn Thị Hoa', 'KINHTE', 'KT01', N'Nữ', 'Jan 04 2004 12:00:00:000AM', N'Cần Thơ', '0977554433'),
('DG06', N'Sinh viên', N'Doãn Quốc Huy', 'LUAT', 'L01', N'Nam', 'Feb 17 2003 12:00:00:000AM', N'Hải Phòng', '0933221100'),
('DG07', N'Sinh viên', N'Bùi Thảo Nhi', 'LUAT', 'L01', N'Nữ', 'Sep 10 2000 12:00:00:000AM', N'Quảng Ngãi', '0944223344'),
('DG08', N'Giảng viên', N'Tạ Quốc Việt', 'DIENTU', 'DT01', N'Nam', 'Aug 29 1982 12:00:00:000AM', N'TP.HCM', '0922110033'),
('DG09', N'Giảng viên', N'Hồ Đức Anh', 'KINHTE', 'KT01', N'Nam', 'May 01 1985 12:00:00:000AM', N'Vĩnh Long', '0911998877'),
('DG10', N'Giảng viên', N'Ngô Nhật Minh', 'CNTT', 'IT02', N'Nam', 'May 01 1990 12:00:00:000AM', N'Tây Ninh', '0901234321')
GO

INSERT INTO SACH (MaSach,TenSach,MaKe,NhaXuatBan,NamXuatBan,TacGia,MaLoai) VALUES
('SACH01', N'Kinh tế học', 'KE01', N'Nhà xuất bản Giáo dục', 2015, N'Lê Thị Thủy', 'KINHTE'),
('SACH02', N'Quản trị học', 'KE01', N'Nhà xuất bản Giáo dục', 2016, N'Nguyễn Tuấn', 'KINHTE'),
('SACH03', N'Quản trị cơ sở dữ liệu', 'KE02', N'Nhà xuất bản Giáo dục', 2017, N'Lev Tolstoy', 'LAPTRINH'),
('SACH04', N'Lập trình cơ sở dữ liệu', 'KE02', N'Nhà xuất bản Giáo dục', 2017, N'Keigo Higashino', 'LAPTRINH'),
('SACH05', N'Grammar Basic', 'KE03', N'Nhà xuất bản Giáo dục', 2020, N'Nguyễn Phương Trang', 'NGOAINGU'),
('SACH06', N'Kỹ thuật thi công công trình', 'KE04', N'Nhà xuất bản Trẻ', 2021, N'Stephen Hawking', 'KIENTRUC'),
('SACH07', N'Giáo trình Luật Dân sự', 'KE05', N'Nhà xuất bản Trẻ', 2022, N'Hayao Miyazaki', 'LUAT'),
('SACH08', N'Vật lý lượng tử nhập môn', 'KE06', N'Nhà xuất bản Kim Đồng', 2019, N'Gabriel García Márquez', 'KHOAHOC')
GO
