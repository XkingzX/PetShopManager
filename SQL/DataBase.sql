﻿Create Database DB_CuaHangThuCung
go
Use DB_CuaHangThuCung
go
CREATE TABLE TINH (
    MATINH INT PRIMARY KEY,
    TENTINH NVARCHAR(100) NOT NULL
);
GO
CREATE TABLE HUYEN (
    MAHUYEN INT PRIMARY KEY IDENTITY,
    TENHUYEN NVARCHAR(100) NOT NULL,
    MATINH INT FOREIGN KEY REFERENCES TINH(MATINH)
);
GO
CREATE TABLE XA (
    MAXA INT PRIMARY KEY IDENTITY,
    TENXA NVARCHAR(100) NOT NULL,
    MAHUYEN INT FOREIGN KEY REFERENCES HUYEN(MAHUYEN)
);
go
CREATE TABLE KHACHHANG(
	MAKH	char(6) not null,	
	HOTEN	nvarchar(40),
	DCHI	nvarchar(50),
	SODT	varchar(20),
	NGSINH	smalldatetime,
	NGDK	smalldatetime,
	MATINH INT,             
    MAHUYEN INT,            
    MAXA INT,   
	LOAIKH	varchar(40),
	EMAIL	varchar(100),
	DIEMTHUONG int default 0,
	constraint pk_kh primary key(MAKH),
	FOREIGN KEY (MATINH) REFERENCES TINH(MATINH),     
    FOREIGN KEY (MAHUYEN) REFERENCES HUYEN(MAHUYEN), 
    FOREIGN KEY (MAXA) REFERENCES XA(MAXA)  
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
	LOAI	nvarchar(20),
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
	SOHD	char(6) not null,
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
--TINH/HUYEN/XA
INSERT INTO TINH (MATINH, TENTINH) VALUES
(61, N'Bình Dường'),
(59, N'Hồ Chí Minh'),
(72, N'Bà Rịa Vũng Tàu');
GO

-- Chèn dữ liệu vào bảng Huyện
INSERT INTO HUYEN (TENHUYEN, MATINH) VALUES
-- Binh Duong
(N'Thành phố Thủ Dầu Một', 61),
(N'Thành phố Thuận An', 61),
-- TPHCM
(N'Quận 1', 59),
(N'Quận 2', 59),
-- Bà Rịa Vũng Tàu
(N'Thành phố Bà Rịa', 72),
(N'Thành phố Vũng Tàu', 72);
GO

-- Chèn dữ liệu vào bảng XA
INSERT INTO XA (TENXA, MAHUYEN) VALUES
-- TP Thủ Dầu Một (Bình Dương)
(N'Phường An Phú', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thủ Dầu Một')),
(N'Phường An Thạnh', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thủ Dầu Một')),
(N'Phường Bình Chuẩn', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thủ Dầu Một')),
(N'Phường Bình Hòa', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thủ Dầu Một')),
(N'Phường Bình Nhâm', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thủ Dầu Một')),

-- TP Thuận An (Bình Dương)
(N'Phường Phú Cường', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thuận An')),
(N'Phường Hiệp Thành', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thuận An')),
(N'Phường Chánh Nghĩa', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thuận An')),
(N'Phường Phú Thọ', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thuận An')),
(N'Phường Phú Hòa', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Thuận An')),

-- Quận 1 (TPHCM)
(N'Phường Bến Nghé', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 1')),
(N'Phường Bến Thành', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 1')),
(N'Phường Cô Giang', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 1')),
(N'Phường Ong Lãnh', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 1')),
(N'Phường Cầu Kho', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 1')),

-- Quận 2 (TPHCM)
(N'Phường Bến Nghé', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 2')),
(N'Phường An Khánh', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 2')),
(N'Phường An Lợi Đông', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 2')),
(N'Phường An Phú', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 2')),
(N'Phường Bình An', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Quận 2')),

-- TP Bà Rịa (BR-VT)
(N'Phường Phước Hưng', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Bà Rịa')),
(N'Phường Phước Hiệp', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Bà Rịa')),
(N'Phường Phước Nguyên', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Bà Rịa')),
(N'Phường Long Toàn', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Bà Rịa')),
(N'Phường Long Hương', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Bà Rịa')),

-- TP Vũng Tàu (BR-VT)
(N'Phường 1', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Vũng Tàu')),
(N'Phường 2', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Vũng Tàu')),
(N'Phường 3', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Vũng Tàu')),
(N'Phường 4', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Vũng Tàu')),
(N'Phường 5', (SELECT MAHUYEN FROM HUYEN WHERE TENHUYEN = N'Thành phố Vũng Tàu'));
go
--SANPHAM
insert into SANPHAM values
('H01', N'Hạt Cát Trang', '90000', 10, N'Hạt', NULL, NULL),
('DC02', N'Can Cầu Mèo', '15000', 9, N'Đồ Chơi', NULL, NULL),
('DC03', N'Viên Bi', '90000', 8, N'Đồ Chơi', NULL, NULL),
('C04', N'Cát Đầu Nanh', '120000', 7, N'Cát', NULL, NULL);

-- NHANVIEN
insert into NHANVIEN values('QL01',N'ADMIN','' ,'' , '000', N'Quản lý','','','','','',null)
insert into NHANVIEN values('NV01',N'Nguyễn Hoàng Minh','' ,'16/04/2004', '123', N'Nhân viên','','','','','',null)
insert into NHANVIEN values('NV02',N'Ngô Tiến Tới','' ,'21/04/2004', '456', N'Nhân viên','','','','','',null)
insert into NHANVIEN values('NV03',N'Chu Thế Trường','' ,'27/04/2004', '789', N'Nhân viên','','','','','',null)
insert into NHANVIEN values('NV04',N'Đỗ Trung Tín','' ,'24/06/2004' ,'234' , N'Nhân viên','','','','','',null)
go
--KHO
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, TRANGTHAI, MANV) VALUES
('PK05', 'DC03', GETDATE(), 9, N'Nhập kho lần đầu', null, 'NV03'),
('PK02', 'H01', GETDATE(), 9, N'Nhập kho lần đầu', null, 'NV03'),
('PK01', 'DC02', GETDATE(), 9, N'Nhập kho lần đầu', null, 'NV03');
go
--KHACHHANG
INSERT INTO KHACHHANG (MAKH, HOTEN,NGDK,LOAIKH) VALUES
('KH01',N'Lê Vi',GETDATE(),N'Khách quen'),
('KH02',N'Đỗ Chung Tình',GETDATE(),N'Khách quen'),
('KH03',N'Phan Nguyễn Đức Trọng',GETDATE(),N'Khách quen'),
('KH04',N'Nguyễn Hoàng Minh',GETDATE(),N'Nhân viên'),
('KH05',N'Đỗ Trung Tín',GETDATE(),N'Nhân viên'),
('KH06',N'Chu Thế Trường',GETDATE(),N'Nhân viên'),
('KH07',N'Ngô Tiến Tới',GETDATE(),N'Nhân viên')
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


