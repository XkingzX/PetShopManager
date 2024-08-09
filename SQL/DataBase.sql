Create Database DB_CuaHangThuCung
go
Use DB_CuaHangThuCung
go

CREATE TABLE KHACHHANG(
	MAKH	char(4) not null,	
	HOTEN	varchar(40),
	DCHI	varchar(50),
	SODT	varchar(20),
	NGSINH	smalldatetime,
	NGDK	smalldatetime,
	DIACHI	varchar (200),
	TINH	varchar (100),
	HUYEN	varchar (100),
	XA		varchar(100),
	LOAIKH	varchar(40),
	EMAIL	varchar(100),
	
	constraint pk_kh primary key(MAKH)
)
go
---------------------------------------------
-- NHANVIEN
CREATE TABLE NHANVIEN(
	MANV	char(4) not null primary key,	
	HOTEN	varchar(40),
	SODT	varchar(20),
	NGVL	datetime
)
go
---------------------------------------------
-- SANPHAM
CREATE TABLE SANPHAM(
	MASP	char(4) not null primary key,
	TENSP	varchar(40),
	GIA		money,
	LOAI	varchar(20),
	HINH	VARBINARY(MAX),
	MOTA	nvarchar(250),
)
go

CREATE TABLE KHO(
	MAPK	char(4) not null primary key,
	MASP	char(4) not null foreign key references SANPHAM(MASP),
	NGAYNHAP datetime,
	SLHETHONG int,
	SLTHUCTE int,
	GHICHU nvarchar(50),
	TRANGTHAI nvarchar(30),
	MANV	char(4) not null foreign key references NHANVIEN(MANV),
)
go
CREATE TABLE HOADON(
	SOHD	int not null,
	NGHD 	smalldatetime,
	MAKH 	char(4) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MASP CHAR(4),
	SL int,
	TONGTIEN	money,
	constraint pk_hd primary key(SOHD)
)
go
-- CTHD
   CREATE TABLE CTHD(
	SOHD	int FOREIGN KEY REFERENCES HOADON(SOHD),
	MASP	char(4) FOREIGN KEY REFERENCES SANPHAM(MASP),
	SL	int,
	GIAMGIA DECIMAL,
	TONGTIEN MONEY,
	THOIGIAN DATETIME,
	MAKH CHAR(4) NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MANV CHAR(4) FOREIGN KEY REFERENCES NHANVIEN(MANV),
	CHINHANH VARCHAR(40),
	constraint pk_cthd primary key(SOHD,MASP)
)
go
set dateformat dmy
go
CREATE TABLE LoaiKhachHang (
    MaLoaiKH INT PRIMARY KEY,
    TenLoaiKH NVARCHAR(100)
)
go
--SANPHAM
insert into SANPHAM values
('SP01','Hat Catsrang','90000','Hat',null, null),
('SP02','Can cau meo','15000','Do Choi',null, null),
('SP03','Vien bi','90000','Do Choi',null, null),
('SP04','Cat dau nanh','120000','Cat',null, null)
go

--KHO
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLHETHONG, SLTHUCTE, GHICHU, TRANGTHAI, MANV) VALUES
('PK01', 'SP01', GETDATE(), 10, 9, N'Nhập kho lần đầu', N'Lệch kho', 'NV01'),
('PK02', 'SP02', GETDATE(), 10, 10, N'Nhập kho lần đầu', N'Đủ', 'NV02');
go
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, TRANGTHAI, MANV) VALUES
('PK03', 'SP03', GETDATE(), 9, N'Nhập kho lần đầu', N'Lệch kho', 'NV03')

-- NHANVIEN
insert into nhanvien values('NV01','Nguyen Hoang Minh','','16/04/2004')
insert into nhanvien values('NV02','Ngo Tien Toi','','21/04/2004')
insert into nhanvien values('NV03','Chu The Truong','','27/04/2004')
insert into nhanvien values('NV04','Do Trung Tin','','24/06/2004')
go

-- LoaiKhachHang
INSERT INTO LoaiKhachHang (MaLoaiKH, TenLoaiKH) VALUES (1, N'Khách hàng mới');
INSERT INTO LoaiKhachHang (MaLoaiKH, TenLoaiKH) VALUES (2, N'Khách hàng thân thiết');
INSERT INTO LoaiKhachHang (MaLoaiKH, TenLoaiKH) VALUES (3, N'Khách hàng VIP')
go

