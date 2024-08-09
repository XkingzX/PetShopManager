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