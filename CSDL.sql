USE QLBH_Son;
GO

-- 1️⃣ XÓA DỮ LIỆU

DELETE FROM NhatKy_SanPham;
DELETE FROM NhatKy_HoaDon;
DELETE FROM ChiTietPhieuNhap;
DELETE FROM PhieuNhap;
DELETE FROM HoaDon_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM TonKho;
DELETE FROM SanPham;
DELETE FROM HangSanXuat;
DELETE FROM LoaiSanPham;
DELETE FROM TaiKhoan;
DELETE FROM NhanVien;
DELETE FROM KhachHang;
DELETE FROM ThongKe;
GO
--------------------------------------------------
-- 2️⃣ RESET IDENTITY (THEO MẪU)
--------------------------------------------------

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'HangSanXuat' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('HangSanXuat', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'LoaiSanPham' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('LoaiSanPham', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'SanPham' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('SanPham', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'NhanVien' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('NhanVien', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'KhachHang' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('KhachHang', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'HoaDon' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('HoaDon', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'HoaDon_ChiTiet' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('HoaDon_ChiTiet', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'PhieuNhap' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('PhieuNhap', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'ChiTietPhieuNhap' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('ChiTietPhieuNhap', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'TaiKhoan' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('TaiKhoan', RESEED, 0);

	IF EXISTS (SELECT * FROM sys.identity_columns 
           WHERE OBJECT_NAME(OBJECT_ID) = 'ThongKe' 
           AND last_value IS NOT NULL)
    DBCC CHECKIDENT('ThongKe', RESEED, 0);
GO
SET IDENTITY_INSERT HangSanXuat ON
INSERT INTO HangSanXuat(ID, TenHangSanXuat, SoDienThoai, DiaChi)
VALUES
(1,N'3CE', '0936272757',N'TP.HCM'),
(2,N'MAC', '0976231896',N'Vĩnh Long'),
(3,N'Dior', '0587325789',N'An Giang'),
(4,N'Black Rouge', '0547823790', N'Đồng Nai'),
(5,N'Romand', '0342146789', N'Đồng Tháp');
SET IDENTITY_INSERT HangSanXuat OFF
GO
SET IDENTITY_INSERT LoaiSanPham ON
INSERT INTO LoaiSanPham(ID, TenLoai)
VALUES
(1,N'Son lì'),
(2,N'Son kem'),
(3,N'Son tint'),
(4,N'Son bóng');
SET IDENTITY_INSERT LoaiSanPham OFF
GO
INSERT INTO NhanVien
(HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan, NgaySinh, HinhThucLamViec, GioiTinh)
VALUES
(N'Nguyễn Thị Lan', '0909123456', N'Long Xuyên', 'admin',
'$2a$11$XGOVk9m4HqzXBlwVvhKN/ur8FS/keV9QyuCwikTL67sL0gqNUupMa',
1, '1995-05-01', N'Full-time', N'Nữ'),

(N'Trần Mỹ Duyên', '0912345678', N'Châu Thành', 'nhanvien',
'$2a$11$c1syEtekaZ6OJrX77mGoJ.6mu4YuUjUHvKrliW8oOU3M3u7I6zyuy',
0, '1998-08-10', N'Part-time', N'Nữ');
GO

INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi)
VALUES
(N'Lê Thị Ngọc', '0933222111', N'Long Xuyên'),
(N'Phạm Thuỳ Trang', '0944555666', N'Châu Đốc');
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, NhanVienID)
VALUES
('admin',
'$2a$11$XGOVk9m4HqzXBlwVvhKN/ur8FS/keV9QyuCwikTL67sL0gqNUupMa',
'Admin', 1),

('nhanvien',
'$2a$11$c1syEtekaZ6OJrX77mGoJ.6mu4YuUjUHvKrliW8oOU3M3u7I6zyuy',
'NhanVien', 2);
GO

INSERT INTO SanPham
(HangSanXuatID, LoaiSanPhamID, TenSanPham, DonGia, SoLuong, HinhAnh, MoTa)
VALUES
(2, 1, N'MAC Ruby Woo', 550000, 50, 'mac.jpg', N'Son đỏ huyền thoại'),
(4, 2, N'Black Rouge A12', 180000, 100, 'br.jpg', N'Son kem bán chạy'),
(5, 3, N'Romand 06', 220000, 80, 'romand.jpg', N'Son tint cam đào');
GO
INSERT INTO PhieuNhap (NgayNhap, NhanVienID, GhiChu)
VALUES
(GETDATE(), 1, N'Nhập hàng đợt 1');
GO

INSERT INTO ChiTietPhieuNhap
(PhieuNhapID, SanPhamID, SoLuongNhap, DonGiaNhap)
VALUES
(1, 1, 20, 400000),
(1, 2, 30, 120000);
GO
-- CẬP NHẬT KHO SAU NHẬP

UPDATE SanPham SET SoLuong = SoLuong + 20 WHERE ID = 1;
UPDATE SanPham SET SoLuong = SoLuong + 30 WHERE ID = 2;
GO

INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap)
VALUES
(2, 1, GETDATE());
GO

INSERT INTO HoaDon_ChiTiet
(HoaDonID, SanPhamID, SoLuongBan, DonGiaBan)
VALUES
(1, 1, 1, 550000),
(1, 2, 2, 180000);
GO
-- CẬP NHẬT TỒN KHO SAU BÁN

UPDATE SanPham SET SoLuong = SoLuong - 1 WHERE ID = 1;
UPDATE SanPham SET SoLuong = SoLuong - 2 WHERE ID = 2;
GO

INSERT INTO ThongKe
(
    ThoiGian,
    TongSoHoaDon,
    TongSoSanPhamBan,
    TongDoanhThu,
    TongSoPhieuNhap,
    TongSoSanPhamNhap,
    TongTienNhap,
    TongSanPhamTon
)
VALUES
(
    GETDATE(),
    2,
    3,
    1500000,
    1,
    5,
    2000000,
    20
)
