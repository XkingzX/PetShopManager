Create Database DB_CuaHangThuCung
go
Use DB_CuaHangThuCung
go

CREATE TABLE KHACHHANG(
	MAKH	char(10) not null,	
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
	MANV	char(4) not null,	
	HOTEN	varchar(40),
	SODT	varchar(20),
	NGVL	smalldatetime	
	constraint pk_nv primary key(MANV)
)
go
---------------------------------------------
-- SANPHAM
CREATE TABLE SANPHAM(
	MASP	char(4) not null,
	TENSP	varchar(40),
	GIA		money,
	LOAI	varchar(20),
	constraint pk_sp primary key(MASP)	
)
go
CREATE TABLE KHO(
	MAPK	char(4) not null primary key,
	MASP	char(4) not null foreign key references SANPHAM(MASP),
	NGAYNHAP smalldatetime,
	SLHETHONG int,
	SLTHUCTE int,
	GHICHU nvarchar(50)
)
go
CREATE TABLE HOADON(
	SOHD	int not null,
	NGHD 	smalldatetime,
	MAKH 	char(10),
	MANV 	char(4),
	TRIGIA	money,
	constraint pk_hd primary key(SOHD)
)
go
CREATE TABLE LoaiKhachHang (
    MaLoaiKH INT PRIMARY KEY,
    TenLoaiKH NVARCHAR(100)
)
go
---------------------------------------------
-- CTHD
   CREATE TABLE CTHD(
	SOHD	int,
	MASP	char(4),
	SL	int,
	constraint pk_cthd primary key(SOHD,MASP)
)
go
ALTER TABLE HOADON ADD CONSTRAINT fk01_HD FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
ALTER TABLE HOADON ADD CONSTRAINT fk02_HD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
-- Khoa ngoai cho bang CTHD
ALTER TABLE CTHD ADD CONSTRAINT fk01_CTHD FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD)
ALTER TABLE CTHD ADD CONSTRAINT fk02_CTHD FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
set dateformat dmy

--SANPHAM
insert into SANPHAM values
('SP01','Hat Catsrang','90000','Hat'),
('SP02','Can cau meo','15000','Do Choi'),
('SP03','Vien bi','90000','Do Choi'),
('SP04','Cat dau nanh','120000','Cat')
-- NHANVIEN
insert into nhanvien values('NV01','Nguyen Hoang Minh','','16/04/2004')
insert into nhanvien values('NV02','Ngo Tien Toi','','21/04/2004')
insert into nhanvien values('NV03','Chu The Truong','','27/04/2004')
insert into nhanvien values('NV04','Do Trung Tin','','24/06/2004')

-- Thêm các loại khách hàng vào bảng LoaiKhachHang
INSERT INTO LoaiKhachHang (MaLoaiKH, TenLoaiKH) VALUES (1, N'Khách hàng mới');
INSERT INTO LoaiKhachHang (MaLoaiKH, TenLoaiKH) VALUES (2, N'Khách hàng thân thiết');
INSERT INTO LoaiKhachHang (MaLoaiKH, TenLoaiKH) VALUES (3, N'Khách hàng VIP');