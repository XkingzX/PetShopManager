UPDATE SanPham
SET SoLuongTonKho = SoLuongTonKho - 1
WHERE MaSP = @maSP;

select *
from SANPHAM, KHO
where SANPHAM.MASP = KHO.MASP

select *
from KHO
select *
from SANPHAM
select *
from NHANVIEN
INSERT INTO NHANVIEN (MANV, HOTEN,MATKHAU, QUYEN)
Values ('NV01',N'Nguyễn Hoàng Minh','123',N'Nhân viên')
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLHETHONG, SLTHUCTE, GHICHU, TRANGTHAI, MANV)
VALUES ('PK01', 'SP01', GETDATE(), 10, 9, N'Nhập kho lần đầu', N'Lệch kho', 'NV01'),
('PK02', 'SP02', GETDATE(), 10, 10, N'Nhập kho lần đầu', N'Đủ', 'NV01')

update KHO
set SLHETHONG = 9
where MASP = 'SP01'
delete from KHO
where MAPK = 'PK01'

update SANPHAM 
set MOTA = N'Hạt catsrang sản phẩm được bán chạy'
where MASP = 'SP01'

select MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA as N'Giá', LOAI as N'Loại', HINH as N'Hình Sản Phẩm', MOTA from SANPHAM

select MOTA 
from SANPHAM
where MASP = 'SP01'

select MAPK
from KHO

select MAPK as N'Mã Phiếu Kho', MASP as N'Mã Phiếu Nhập', NGAYNHAP as N'Ngày Nhập', SLHETHONG as N'Số lượng hệ thống', SLTHUCTE as N'Số lượng thực tế',(SLTHUCTE - SLHETHONG) as N'Số lượng chênh lệch', GHICHU as N'Ghi chú',TRANGTHAI as N'Trạng thái', MANV as N'Người tạo'
from KHO


INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, MANV) VALUES ('PK03', 'SP03', GETDATE(), 20, 'ghichu', 'NV01')
INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, MANV) VALUES ('PK03', 'SP03', GETDATE(), 20, 'ghichu', 'NV01')

select MANV + ' - ' + HOTEN as N'Người tạo'
from NHANVIEN

set dateformat dmy
select *
from KHO,NHANVIEN

select MAPK, MASP, NGAYNHAP, SLHETHONG, SLTHUCTE, GHICHU, TRANGTHAI, KHO.MANV
FROM KHO,NHANVIEN
where KHO.MANV = NHANVIEN.MANV

select *
from KHO, NHANVIEN
where KHO.MANV = NHANVIEN.MANV

select * 
from SANPHAM
where MASP = 'SP01'

select MANV,QUYEN,HOTEN
from NHANVIEN
where MANV = 'QL01' AND QUYEN = N'Quản lý' AND HOTEN = N'ADMIN'

select *
from KHO,SANPHAM,NHANVIEN
where KHO.MANV = NHANVIEN.MANV AND KHO.MASP = SANPHAM.MASP


ALTER TABLE KHO
WITH CHECK CHECK CONSTRAINT FK_KHO_SANPHAM;
ALTER TABLE KHO
ADD CONSTRAINT FK_KHO_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP);

select * 
from SANPHAM
select *
from KHO
ALTER TABLE KHO
ADD DaXoa BIT DEFAULT 0;
DECLARE @MASP char(4) = 'SP01';
UPDATE KHO
SET DaXoa = NULL
WHERE MASP = 'SP01';
UPDATE KHO
SET MASP = NULL
WHERE MASP = 'SP01';
UPDATE KHO set MASP = 'concat' where MASP = 'SP01'
UPDATE KHO SET MASP = 'SP01' WHERE MAPK = 'PK01';
DELETE SANPHAM WHERE MASP = 'SP01';
select *
from KHO
where Daxoa = 1

SELECT COUNT(*) FROM SANPHAM WHERE MASP = 'SP01'
SELECT * FROM SANPHAM WHERE MASP = 'SP01';
SELECT * FROM KHO WHERE MASP = 'SP01'

select MAPK as N'Mã phiếu kho', MASP as N'Mã sản phẩm', NGAYNHAP as N'Ngày nhập', SLHETHONG as N'Số lượng hệ thống', SLTHUCTE as N'Số lượng thực tế', (SLTHUCTE - SLHETHONG) as N'Số lượng chênh lệch', GHICHU as N'Ghi chú',TRANGTHAI as N'Trạng thái', MANV as N'Người tạo', DAXOA as N'Đã xóa'
from KHO
select MAPK, MASP, NGAYNHAP, SLHETHONG, SLTHUCTE, (SLTHUCTE - SLHETHONG) as N'Số lượng chênh lệch'
from KHO

select K.MAPK as N'Mã phiếu kho', K.MASP as N'Mã sản phẩm', K.NGAYNHAP as N'Ngày nhập', 
                        S.SLHETHONG as N'Số lượng hệ thống', K.SLTHUCTE as N'Số lượng thực tế', 
                        (SLTHUCTE - SLHETHONG) as N'Số lượng chênh lệch', K.GHICHU as N'Ghi chú',
                        K.TRANGTHAI as N'Trạng thái', K.MANV as N'Người tạo', K.DAXOA as N'Đã xóa'
                        from KHO K
                        INNER JOIN SANPHAM S ON K.MASP = S.MASP

select *
from KHO,SANPHAM
where KHO.MASP = SANPHAM.MASP

SELECT SUM(SLHETHONG)
FROM SANPHAM;
SELECT SUM(SLHETHONG) FROM SANPHAM;select MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA as N'Giá', SLHETHONG, LOAI as N'Loại', HINH as N'Hình Sản Phẩm', MOTA from SANPHAM

SELECT K.MAPK AS N'Mã phiếu kho', 
       K.MASP AS N'Mã sản phẩm', 
       K.NGAYNHAP AS N'Ngày nhập', 
       ISNULL(S.SLHETHONG, 0) AS N'Số lượng hệ thống', 
       K.SLTHUCTE AS N'Số lượng thực tế', 
       CASE 
           WHEN ISNULL(S.SLHETHONG, 0) = 0 THEN 0
           ELSE (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0))
       END AS N'Số lượng chênh lệch', 
       CASE 
           WHEN ISNULL(S.SLHETHONG, 0) = 0 THEN N'Chưa có dữ liệu'
           WHEN (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0)) > 0 THEN N'Dư sản phẩm'
           WHEN (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0)) = 0 THEN N'Đủ'
           ELSE N'Thiếu'
       END AS N'Tình trạng', 
       K.GHICHU AS N'Ghi chú', 
       K.MANV AS N'Người tạo', 
       K.DAXOA AS N'Đã xóa'
FROM KHO K
LEFT JOIN SANPHAM S ON K.MASP = S.MASP;



			select *
			from KHO
INSERT INTO SANPHAM (MASP, TENSP, SLHETHONG, GIA, LOAI) VALUES ('SP01', 'san pham 1', 12, 12000, 'Do choi')
INSERT INTO SANPHAM (MASP, TENSP, SLHETHONG, GIA, LOAI, Hinh, MOTA) VALUES ('SP02', 'san pham 2', 1, 12000, 'Do choi',null,null)
select *
from SANPHAM
select *
from KHO


SELECT 
    CTHD.THOIGIAN AS N'Thời gian',
    SUM(CTHD.TONGTIEN) AS N'Doanh thu',
    SUM(CTHD.SL) AS N'Số lượng',
    SUM(CTHD.GIAMGIA) AS N'Giảm giá',
    SUM(CTHD.TONGTIEN - ISNULL(CTHD.GIAMGIA, 0)) AS N'Thực thu'
FROM 
    CTHD
WHERE 
    CTHD.TRANGTHAI = N'Đã thanh toán'
GROUP BY 
    CTHD.THOIGIAN
ORDER BY 
    CTHD.THOIGIAN;