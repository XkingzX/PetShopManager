Create Database DB_CuaHangThuCung
go
Use DB_CuaHangThuCung
go

CREATE TABLE KHACHHANG(
	MAKH	char(6) not null,	
	HOTEN	nvarchar(40),
	DCHI	nvarchar(50),
	SODT	varchar(10),
	NGSINH	smalldatetime,
	NGDK	smalldatetime,
	TINH	nvarchar (100),
	HUYEN	nvarchar (100),
	XA		nvarchar(100),
	LOAIKH	nvarchar(40),
	EMAIL	varchar(100),
	DIEMTHUONG int DEFAULT 0,
	constraint pk_kh primary key(MAKH)
)
go
---------------------------------------------
-- NHANVIEN
CREATE TABLE NHANVIEN(
	MANV	char(6) not null,	
	HOTEN	nvarchar(40),
	SODT	varchar(10),
	NGVL	smalldatetime,
	MATKHAU varchar(40),
	QUYEN nvarchar(40),
	DIACHI nvarchar(100),
	EMAIL varchar(100),
	NGSINH smalldatetime,
	GIOITINH nvarchar(3),
	GHICHU nvarchar(100),
	HINH VARBINARY(MAX)
	constraint pk_nv primary key(MANV)
)
go
---------------------------------------------
-- SANPHAM
CREATE TABLE SANPHAM(
	MASP	char(6) not null,
	TENSP	nvarchar(40),
	GIA		money,
	SLHETHONG int,
	LOAI	varchar(20),
	HINH	VARBINARY(MAX),
	MOTA	nvarchar(250),
	constraint pk_sp primary key(MASP)
)
go

CREATE TABLE KHO(
	MAPK	char(6) not null,
	MASP	char(6),
	NGAYNHAP datetime,
	SLTHUCTE int,
	GHICHU nvarchar(50),
	TRANGTHAI nvarchar(30),
	DaXoa bit default 0,
	MANV	char(6) not null 
	constraint fk_kho_nhanvien foreign key (MANV) references NHANVIEN(MANV),
	constraint pk_pk primary key(MAPK),
	constraint FK_KHO_SANPHAM foreign key (MASP) REFERENCES SANPHAM(MASP)
)
go
CREATE TABLE HOADON(
	SOHD	int not null,
	NGHD 	smalldatetime,
	MAKH 	char(6) ,
	MASP CHAR(6),
	SL int,
	TONGTIEN	money,
	constraint pk_hd primary key(SOHD,MASP)
)
GO
-- CTHD
CREATE TABLE CTHD(
	SOHD	char(6),
	MASP	char(6),
	SL	int,
	GIAMGIA DECIMAL,
	TONGTIEN MONEY,
	THOIGIAN DATETIME,
	MAKH CHAR(6) NOT NULL,
	MANV CHAR(6),
	CHINHANH NVARCHAR(40),
	TRANGTHAI NVARCHAR(40),
	PTTHANHTOAN NVARCHAR(20),
	KHACHTRA MONEY,
	TIENTHOI MONEY,
	constraint pk_cthd primary key(SOHD,MASP)
)
set dateformat dmy
go
--SANPHAM
insert into SANPHAM values
('SP01','Hat Catsrang','90000',10,'Hat',null, null),
('SP02','Can cau meo','15000',9,'Do Choi',null, null),
('SP03','Vien bi','90000',8,'Do Choi',null, null),
('SP04','Cat dau nanh','120000',7,'Cat',null, null)
go

-- NHANVIEN
insert into NHANVIEN values('QL01',N'ADMIN','' ,'' , '000', N'Quản lý','','','','','',null)
insert into NHANVIEN values('NV01',N'Nguyễn Hoàng Minh','' ,'16/04/2004', '123', N'Nhân viên','','','','','',null)
insert into NHANVIEN values('NV02',N'Ngô Tiến Tới','' ,'21/04/2004', '456', N'Nhân viên','','','','','',null)
insert into NHANVIEN values('NV03',N'Chu Thế Trường','' ,'27/04/2004', '789', N'Nhân viên','','','','','',null)
insert into NHANVIEN values('NV04',N'Đỗ Trung Tín','' ,'24/06/2004' ,'234' , N'Nhân viên','','','','','',null)
go
--KHO
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, TRANGTHAI, MANV) VALUES
('PK01', 'SP01', GETDATE(), 9, N'Nhập kho lần đầu', N'Lệch kho', 'NV01'),
('PK02', 'SP02', GETDATE(), 10, N'Nhập kho lần đầu', N'Đủ', 'NV02');
go
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, TRANGTHAI, MANV) VALUES
('PK03', 'SP03', GETDATE(), 9, N'Nhập kho lần đầu', N'Lệch kho', 'NV03');
go


--KHACHHANG
INSERT INTO KHACHHANG (MAKH, HOTEN,NGDK,LOAIKH) VALUES
('KH01',N'Lê Vi',GETDATE(),N'Vip'),
('KH02',N'Đỗ Chung Tình',GETDATE(),N'Vip'),
('KH03',N'Phan Nguyễn Đức Trọng',GETDATE(),N'Nhân viên'),
('KH04',N'Nguyễn Hoàng Minh',GETDATE(),N'Nhân viên')
go
CREATE TRIGGER trg_CapNhatKhoKhiXoa 
ON SANPHAM 
AFTER DELETE
AS
BEGIN
    -- Cập nhật cột DaXoa trong bảng KHO khi xóa bản ghi trong SANPHAM
    UPDATE KHO
    SET DaXoa = 1
    FROM KHO k
    INNER JOIN DELETED d ON k.MASP = d.MASP;
END;
go

--Xoa trigger
--IF OBJECT_ID('trg_CapNhatKhoKhiXoa', 'TR') IS NOT NULL
--BEGIN
--    DROP TRIGGER trg_CapNhatKhoKhiXoa;
--END;

--SELECT * 
--FROM sys.triggers 
--WHERE name = 'trg_CapNhatKhoKhiXoa';

--DELETE FROM SANPHAM 
--WHERE MASP = 'SP01';
--SELECT * 
--FROM KHO 
--WHERE MASP = 'SP01';
--ALTER TABLE KHO
--DROP CONSTRAINT FK__KHO__MASP;

ALTER TABLE KHO
ADD CONSTRAINT FK__KHO__MASP
FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)
ON DELETE SET NULL;


