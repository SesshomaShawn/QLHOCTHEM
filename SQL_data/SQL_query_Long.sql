--Form ThemGV
-- Them Giao Vien
CREATE PROC sp_ThemGiaoVien (@MaGV CHAR(10), @HoTenGV NVARCHAR(100), @NgaySinh DATE, @DiaChi NVARCHAR(50),
							@SDT CHAR(10), @GioiTinh NVARCHAR(10), @Email VARCHAR(50), @MatKhau VARCHAR(30),
							@MaMH CHAR(10), @MaDM CHAR(10))
AS
BEGIN
	INSERT dbo.GIAOVIEN (MaGV, HoTenGV, NgaySinh, DiaChi, GioiTinh, MaMH, MaDM, MatKhau, Email, SDT)
	VALUES (@MaGV, @HoTenGV, @NgaySinh, @DiaChi, @GioiTinh, @MaMH, @MaDM, @MatKhau, @Email, @SDT)
END
-- Xoa Giao Vien
CREATE PROC sp_XoaGiaoVien (@MaGV CHAR(10))
AS
BEGIN
	--Xóa ở các bảng có liên quan trước
	DELETE dbo.PHIEULUONG WHERE MaGV = @MaGV
	DELETE dbo.LOPHOC WHERE MaGV = @MaGV
	DELETE dbo.LICHHOC WHERE MaGV = @MaGV
	--Xóa ở bảng GV
	DELETE dbo.GIAOVIEN WHERE MaGV = @MaGV 
END
--Tim kiem theo ten GV
CREATE PROC sp_TimKiemTenGV (@TenGV NVARCHAR(100))
AS
BEGIN
	SELECT * FROM dbo.GIAOVIEN WHERE HoTenGV LIKE '%'+TRIM(@TenGV)+'%'
END
--Tim Kiem theo Ma GV
CREATE PROC sp_TimKiemMaGV (@MaGV CHAR(10))
AS
BEGIN
	SELECT * FROM dbo.GIAOVIEN WHERE MaGV LIKE '%'+TRIM(@MaGV)+'%'
END
--Tim kiem bat ki
CREATE PROC sp_TimKiemBatki (@text NVARCHAR(100))
AS
BEGIN
	DECLARE @pattern NVARCHAR(100)
	SET @pattern = '%'+TRIM(@text)+'%'

	SELECT * FROM dbo.GIAOVIEN 
	WHERE HoTenGV LIKE @pattern OR MaGV LIKE @pattern OR DiaChi LIKE @pattern OR SDT LIKE @pattern OR 
			GioiTinh LIKE @pattern OR Email LIKE @pattern OR MaMH LIKE @pattern OR MaDM LIKE @pattern OR NgaySinh LIKE @pattern
END
--Them Hoc sinh
CREATE PROC sp_ThemHocSinh (@MaHS CHAR(10), @HoTenHS NVARCHAR(100), @NgaySinh DATE, @DiaChi NVARCHAR(50),
							@SDT CHAR(10), @GioiTinh NVARCHAR(10), @Email VARCHAR(50), @MatKhau VARCHAR(30))
AS
BEGIN
	INSERT dbo.HOCSINH (MaHS, HoTenHS, NgaySinh, DiaChi, GioiTinh, MatKhau, Email, SDT)
	VALUES (@MaHS, @HoTenHS, @NgaySinh, @DiaChi, @GioiTinh, @MatKhau, @Email, @SDT)
END

-- Xoa Hoc Sinh
CREATE PROC sp_XoaHocSinh (@MaHS CHAR(10))
AS
BEGIN
	--Xóa ở các bảng có liên quan trước
	DELETE dbo.DIEMDANH WHERE MaHS = @MaHS
	DELETE dbo.HOADON WHERE MaHS = @MaHS
	--Xóa ở bảng GV
	DELETE dbo.HOCSINH WHERE MaHS = @MaHS
END

--Tim kiem theo ten HS
CREATE PROC sp_TimKiemTenHS (@TenHS NVARCHAR(100))
AS
BEGIN
	SELECT * FROM dbo.HOCSINH WHERE HoTenHS LIKE '%'+TRIM(@TenHS)+'%'
END
--Tim Kiem theo Ma HS
CREATE PROC sp_TimKiemMaHS (@MaHS CHAR(10))
AS
BEGIN
	SELECT * FROM dbo.HOCSINH WHERE MaHS LIKE '%'+TRIM(@MaHS)+'%'
END
--Tim kiem bat ki
CREATE PROC sp_TimKiemBatkiHS (@text NVARCHAR(100))
AS
BEGIN
	DECLARE @pattern NVARCHAR(100)
	SET @pattern = '%'+TRIM(@text)+'%'

	SELECT * FROM dbo.HOCSINH 
	WHERE HoTenHS LIKE @pattern OR MaHS LIKE @pattern OR DiaChi LIKE @pattern OR SDT LIKE @pattern OR 
			GioiTinh LIKE @pattern OR Email LIKE @pattern OR NgaySinh LIKE @pattern
END

--Thu tuc in ra Giao vien, luong nhan duoc trong thang
DROP PROC sp_TinhLuongGV_AD
GO
CREATE PROC sp_TinhLuongGV_AD (@thang VARCHAR(5), @nam VARCHAR(5)) AS
BEGIN
	DECLARE @MaGV CHAR(10), @Luong BIGINT, @NgayTra DATE, @STT INT
	SET @NgayTra=CONVERT(DATE, @nam+'-'+@thang+'-28')
	SELECT @STT= COUNT(*) FROM dbo.PHIEULUONG

	DECLARE ptr CURSOR FOR 
	SELECT BangLuong.MaGV, BangLuong.Luong
	FROM (
		SELECT GIAOVIEN.MaGV MaGV, HoTenGV, SUM(SoTiet) * DINHMUCLUONG.SoTien AS Luong
		FROM dbo.DINHMUCLOP, dbo.LOPHOC, dbo.LICHHOC, dbo.GIAOVIEN, dbo.DINHMUCLUONG
		WHERE dbo.DINHMUCLOP.MaDML=dbo.LOPHOC.MaDML 
			AND dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH 
			AND dbo.LICHHOC.MaGV=dbo.GIAOVIEN.MaGV 
			AND dbo.GIAOVIEN.MaDM=dbo.DINHMUCLUONG.MaDM
			AND NgayHoc LIKE '%-'+@thang+'-%' AND NgayHoc LIKE @nam+'-%'
		GROUP BY GIAOVIEN.MaGV, HoTenGV, DINHMUCLUONG.SoTien
	) BangLuong
	OPEN ptr
	
	FETCH NEXT FROM ptr INTO @MaGV, @Luong
	WHILE @@FETCH_STATUS=0
		BEGIN 
			SET @STT=@STT+1
			INSERT INTO dbo.PHIEULUONG (MaPL, NgayTra, TongSoTien, MaGV)
			VALUES ('PL'+RIGHT('000'+CAST(@STT AS VARCHAR(3)),3), @NgayTra, @Luong, @MaGV)
			FETCH NEXT FROM ptr INTO @MaGV, @Luong
		END 

	CLOSE ptr
	DEALLOCATE ptr
END

DELETE FROM dbo.PHIEULUONG
sp_TinhLuongGV_AD @thang='05', @nam='2021'
sp_TinhLuongGV_AD @thang='04', @nam='2021'
sp_TinhLuongGV_AD @thang='03', @nam='2021'
sp_TinhLuongGV_AD @thang='02', @nam='2021'
SELECT * FROM dbo.PHIEULUONG
ORDER BY MaGV
--Hien thi danh sach phieu luong cho form admin
DROP PROC sp_TimLuongGV_AD
CREATE PROC sp_TimLuongGV_AD (@tukhoa NVARCHAR(30), @thang VARCHAR(5), @nam VARCHAR(5)) AS
BEGIN
	(SELECT GV.MaGV, GV.HoTenGV, GV.Email, GV.SDT, CASE WHEN 1=1 THEN N'Đã trả' END TT, PL.NgayTra
	FROM  dbo.GIAOVIEN GV, dbo.PHIEULUONG PL
	WHERE GV.HoTenGV LIKE '%'+@tukhoa+'%' AND GV.MaGV=pl.MaGV AND PL.NgayTra LIKE @nam+'-'+@thang+'%')
	UNION
    (SELECT GV.MaGV, GV.HoTenGV, GV.Email, GV.SDT, CASE WHEN 1=1 THEN N'Chưa trả' END TT, NULL AS NgayTra
	FROM dbo.GIAOVIEN GV
	WHERE GV.HoTenGV LIKE '%'+@tukhoa+'%' 
	AND NOT EXISTS (SELECT * FROM dbo.PHIEULUONG PL WHERE PL.MaGV=GV.MaGV AND PL.NgayTra LIKE @nam+'-'+@thang+'%')
	)
END
sp_TimLuongGV_AD '', '05', '2021'
-- Hien thi thông tin chung phieu luong cho giao vien form admin
DROP PROC sp_ChungPLGV_AD
CREATE PROC sp_ChungPLGV_AD (@MaGV NCHAR(10), @thang VARCHAR(5), @nam varchar(5)) AS
BEGIN
	SELECT PL.MaPL, GV.MaGV, HoTenGV HoTenGV, NgayTra, GV.Email, GV.SDT
	FROM dbo.GIAOVIEN GV, dbo.PHIEULUONG PL
	WHERE GV.MaGV=@MaGV AND PL.MaGV = GV.MaGV and PL.NgayTra LIKE @nam+'-'+@thang+'%'
END
sp_ChungPLGV_AD 'GV001', '04', '2021'

-- Hien thi chi tiet phieu luong cho giao vien form admin
DROP PROC sp_ChiTietPLGV_AD
CREATE PROC sp_ChiTietPLGV_AD (@MaGV NCHAR(10), @thang VARCHAR(5), @nam varchar(5)) AS
BEGIN
	SELECT LH.MaLMH, dbo.LOPHOC.TenLMH, SUM(LH.SoTiet) TongSoTiet, LoaiDM, DML.SoTien
	FROM dbo.GIAOVIEN GV, dbo.LICHHOC LH, dbo.LOPHOC, dbo.DINHMUCLUONG DML
	WHERE DML.MaDM=GV.MaDM AND LH.MaGV=GV.MaGV AND dbo.LOPHOC.MALMH=LH.MaLMH 
		AND GV.MaGV=@MaGV AND LH.NgayHoc LIKE @nam+'-'+@thang+'%'
	GROUP BY LH.MaLMH, TenLMH, DML.LoaiDM, DML.SoTien
END
sp_ChiTietPLGV_AD 'GV001', '03', '2021'

--Hien thi danh sach hoc phi cho form admin
DROP PROC sp_TimHocPhiHS_AD
CREATE PROC sp_TimHocPhiHS_AD (@tukhoa NVARCHAR(30), @thang VARCHAR(5), @nam VARCHAR(5)) AS 
BEGIN 
	SELECT HOCSINH.MaHS, HoTenHS, Email, TinhTrang, NgayNop, NgayXuat
	FROM dbo.HOCSINH, dbo.HOADON
	WHERE HoTenHS LIKE '%'+@tukhoa+'%' AND HOADON.MaHS=HOCSINH.MaHS AND NgayXuat LIKE @nam+'-'+@thang+'%'
	ORDER BY HOCSINH.MaHS
END 
sp_TimHocPhiHS_AD '', '02', '2021'
-- Hien thi thông tin chung hoc phi cho hoc sinh form admin
DROP PROC sp_ChungHDHS_AD
CREATE PROC sp_ChungHDHS_AD(@MaHS NCHAR(10), @thang VARCHAR(5), @nam varchar(5)) AS 
BEGIN 
	SELECT  HD.MaHD, HS.MaHS, HS.HoTenHS, HD.NgayXuat, HD.NgayNop, HS.SDT
	FROM dbo.HOCSINH HS, dbo.HOADON HD
	WHERE HS.MaHS=@MaHS AND HD.NgayXuat LIKE @nam+'-'+@thang+'%' AND HD.MaHS=HS.MaHS
END 
sp_ChungHDHS_AD 'HS001', '04', '2021'

-- Hien thi thong tin chi tiet hoc phi cho hoc sinh form admin
DROP PROC sp_ChiTietHDHS_AD
CREATE PROC sp_ChiTietHDHS_AD(@MaHS NCHAR(10), @thang VARCHAR(5), @nam varchar(5)) AS 
BEGIN 
	SELECT LOPHOC.MALMH, TenLMH, DML.TrinhDoLop, SUM(LH.SoTiet) AS TongSoTiet, DML.SoTien
	FROM dbo.DINHMUCLOP DML, dbo.LOPHOC, dbo.LICHHOC LH, dbo.DIEMDANH DD, dbo.HOCSINH HS
	WHERE DML.MaDML=dbo.LOPHOC.MaDML AND dbo.LOPHOC.MaLMH=LH.MaLMH AND LH.MaLichHoc=DD.MaLichHoc AND DD.MaHS=HS.MaHS
		AND LH.NgayHoc LIKE @nam+'-'+@thang+'%' AND HS.MaHS=@MaHS
	GROUP BY LOPHOC.MaLMH, TenLMH, DML.TrinhDoLop, DML.SoTien
END 
sp_ChiTietHDHS_AD 'HS006', '04', '2021'

-- Hien thi thông tin chi tiet hoc phi cho hoc sinh form admin



--thong ke so luong giao vien theo mon hoc
DROP PROC sp_TK_GV_MH_AD
CREATE PROC sp_TK_GV_MH_AD AS 
BEGIN 
	SELECT MH.MaMH, MH.TenMH AS Loai, COUNT(GV.MaGV) AS SoLuong
	FROM dbo.GIAOVIEN AS GV, dbo.MONHOC AS MH
	WHERE MH.MaMH = GV.MaMH
	GROUP BY MH.MaMH, mh.TenMH
END 
sp_TK_GV_MH_AD

DROP PROC sp_TK_GV_DM_AD
CREATE PROC sp_TK_GV_DM_AD AS 
BEGIN 
	SELECT DML.MaDM, DML.TrinhDoGV AS Loai, COUNT(GV.MaGV) AS SoLuong
	FROM dbo.GIAOVIEN AS GV, dbo.DINHMUCLUONG AS DML
	WHERE GV.MaDM = DML.MaDM
	GROUP BY DML.MaDM, DML.TrinhDoGV
END 
sp_TK_GV_DM_AD

DROP PROC sp_TK_GV_KH_AD
CREATE PROC sp_TK_GV_KH_AD AS 
BEGIN 
	SELECT KH.MaKhoi, KH.TenKhoi AS Loai, COUNT(GV.MaGV) AS SoLuong
	FROM dbo.GIAOVIEN AS GV, dbo.LOPHOC AS LH, dbo.KHOI AS KH
	WHERE GV.MaGV=LH.MaGV AND LH.MaKhoi=KH.MaKhoi
	GROUP BY KH.MaKhoi, KH.TenKhoi
END 
sp_TK_GV_KH_AD

--thong ke hoc sinh theo cac mon hoc theo khoi nhap vao
DROP PROC sp_TK_HS_MH_TheoKhoi_AD
CREATE PROC sp_TK_HS_MH_TheoKhoi_AD (@MaKhoi CHAR(10))
AS
BEGIN
	SELECT LOPHOC.MaLMH, TenLMH, COUNT(DISTINCT(HS.MaHS)) AS SoLuongHS
	FROM dbo.HOCSINH HS, dbo.DIEMDANH DD, dbo.LICHHOC LH, dbo.LOPHOC
	WHERE HS.MaHS=DD.MaHS AND DD.MaLichHoc=LH.MaLichHoc AND LH.MaLMH=dbo.LOPHOC.MaLMH
		AND dbo.LOPHOC.MaKhoi=@MaKhoi 
	GROUP BY LOPHOC.MaLMH, TenLMH
END
sp_TK_HS_MH_TheoKhoi_AD 'KH01'

-- chi thu trong thang
DROP PROC sp_ChiThuThang_AD
CREATE PROC sp_ChiThuThang_AD (@thang VARCHAR(5), @nam VARCHAR(5)) AS 
BEGIN
	SELECT CASE WHEN 1 = 1 then N'Thu học phí'  END AS ThongKe, SUM(Thu.HocPhi) AS TongTien 
	FROM 
		(SELECT HS.MaHS, LOPHOC.MaLMH, SUM(LH.SoTiet) * DML.SoTien AS HocPhi
		FROM dbo.DINHMUCLOP DML, dbo.LOPHOC, dbo.LICHHOC LH, dbo.DIEMDANH DD, dbo.HOCSINH HS
		WHERE DML.MaDML=dbo.LOPHOC.MaDML AND dbo.LOPHOC.MALMH=LH.MaLMH AND LH.MaLichHoc=DD.MaLichHoc AND DD.MaHS=HS.MaHS
			AND LH.NgayHoc LIKE @nam+'-'+@thang+'-%' AND DD.DiemDanh=N'Có'
		GROUP BY HS.MaHS, LOPHOC.MaLMH, DML.SoTien
		) Thu
	UNION
	SELECT CASE WHEN 1 = 1 then N'Trả lương'  END AS ThongKe, SUM(Tra.Luong) AS TongTien 
	FROM 
		(SELECT GIAOVIEN.MaGV MaGV, HoTenGV, SUM(SoTiet) * DINHMUCLUONG.SoTien AS Luong
		FROM dbo.DINHMUCLOP, dbo.LOPHOC, dbo.LICHHOC, dbo.GIAOVIEN, dbo.DINHMUCLUONG
		WHERE dbo.DINHMUCLOP.MaDML=dbo.LOPHOC.MaDML 
			AND dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH 
			AND dbo.LICHHOC.MaGV=dbo.GIAOVIEN.MaGV 
			AND dbo.GIAOVIEN.MaDM=dbo.DINHMUCLUONG.MaDM
			AND NgayHoc LIKE @nam+'-'+@thang+'-%'
		GROUP BY GIAOVIEN.MaGV, HoTenGV, DINHMUCLUONG.SoTien) Tra
END 

sp_ChiThuThang_AD '02', '2021'


--
DROP PROC sp_LopHoc_HS_AD
CREATE PROC sp_LopHoc_HS_AD (@MaHS CHAR(10)) AS 
BEGIN
	SELECT DISTINCT(LICHHOC.MaLMH), TenLMH, TongSoTiet, NgayBatDau, TrinhDoLop
	FROM dbo.DINHMUCLOP, dbo.LOPHOC, dbo.LICHHOC, dbo.DIEMDANH, dbo.HOCSINH
	WHERE dbo.DINHMUCLOP.MaDML=dbo.LOPHOC.MaDML AND dbo.LOPHOC.MaLMH=dbo.LICHHOC.MaLMH
		AND dbo.LICHHOC.MaLichHoc=dbo.DIEMDANH.MaLichHoc AND dbo.DIEMDANH.MaHS=dbo.HOCSINH.MaHS
		AND dbo.HOCSINH.MaHS=@MaHS
END 
sp_LopHoc_HS_AD 'HS099'

DROP PROC sp_LopHoc_GV_AD
CREATE PROC sp_LopHoc_GV_AD (@MaGV CHAR(10)) AS 
BEGIN
	SELECT DISTINCT(dbo.LOPHOC.MaLMH), TenLMH, TongSoTiet, NgayBatDau, TrinhDoLop
	FROM dbo.DINHMUCLOP, dbo.LOPHOC, dbo.GIAOVIEN
	WHERE dbo.DINHMUCLOP.MaDML=dbo.LOPHOC.MaDML AND dbo.LOPHOC.MaGV=dbo.GIAOVIEN.MaGV
		AND dbo.GIAOVIEN.MaGV=@MaGV
END 
sp_LopHoc_GV_AD 'GV010'
------------------------------------------------------END-------------------------------------------------
-----------------------------------------------------------------------------------------------------------
--1
SELECT NgayTra FROM dbo.PHIEULUONG WHERE MaGV = N'GV010'
--2
SELECT * FROM dbo.HOCSINH WHERE GioiTinh = N'Nữ'
--3
SELECT MaGV, HoTenGV, NgaySinh
FROM dbo.GIAOVIEN GV, dbo.DINHMUCLUONG DM 
WHERE GV.MaDM = DM.MaDM AND GV.DiaChi = N'TP HCM' AND dm.LoaiDM = N'Định mức 2'
--4
SELECT HoTenHS, DiaChi FROM dbo.HOCSINH
--5
SELECT * FROM dbo.HocSinh WHERE MaHS='HS010'
--6
SELECT MaLichHoc, NgayHoc FROM dbo.LICHHOC WHERE KipHoc=4
--7
SELECT GV.MaGV, HoTenGV, TongSoTien 
FROM GIAOVIEN GV, PHIEULUONG PL
WHERE TongSoTien > 1000000 AND GV.MaGV = PL.MaGV
--8
SELECT * FROM dbo.PHIEULUONG WHERE TongSoTien > 1000000 
--9
SELECT * FROM dbo.GIAOVIEN WHERE MaGV='GV015'
--10
SELECT GV.MaGV, GV.HoTenGV, GV.NgaySinh, DM.LoaiDM, DM.SoTien 
FROM dbo.GIAOVIEN AS GV JOIN dbo.DINHMUCLUONG AS DM ON DM.MaDM = GV.MaDM
WHERE GV.MaGV = 'GV007'
--11
SELECT * FROM dbo.GIAOVIEN WHERE NgaySinh BETWEEN '1970-01-01' AND '1980-12-31'
--12
SELECT MaGV, HoTenGV
FROM dbo.GIAOVIEN, dbo.MONHOC
WHERE dbo.GIAOVIEN.MaMH = dbo.MONHOC.MaMH AND TenMH=N'Vật Lý'
--13
SELECT MALMH, TenLMH
FROM dbo.GIAOVIEN, dbo.LOPHOC
WHERE dbo.GIAOVIEN.MaGV=dbo.LOPHOC.MaGV AND dbo.GIAOVIEN.HoTenGV=N'Nguyễn Thị Lan'
--14
SELECT * FROM dbo.LOPHOC WHERE NgayBatDau <= '2021-02-02'
--15
SELECT GV.MaGV, GV.HoTenGV
FROM dbo.PHIEULUONG as PL, dbo.GIAOVIEN as GV 
WHERE PL.NgayTra LIKE '2021-01-%' and GV.MaGV=PL.MaGV
--16
SELECT MALMH, TenLMH
FROM dbo.LOPHOC, dbo.KHOI
WHERE dbo.LOPHOC.MaKhoi=dbo.KHOI.MaKhoi AND KHOI.TenKhoi=N'Lớp 11'
--17
SELECT dbo.LOPHOC.MaLMH, TenLMH
FROM dbo.LOPHOC, dbo.LICHHOC
WHERE dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH AND dbo.LICHHOC.NgayHoc='2021-02-03'
--18
SELECT GV.MaGV, GV.HoTenGV 
FROM dbo.GIAOVIEN AS GV, dbo.PHIEULUONG AS PL 
WHERE GV.MaGV=PL.MaGV AND GV.MaDM='DM01' AND PL.TongSoTien > 5000000
--19
SELECT MALMH, TenLMH, MaKhoi
FROM dbo.LOPHOC, dbo.DINHMUCLOP
WHERE dbo.LOPHOC.MaDML=dbo.DINHMUCLOP.MaDML AND TrinhDoLop=N'Nâng cao'
--20
SELECT GIAOVIEN.MaGV, HoTenGV, Email
FROM dbo.GIAOVIEN, dbo.LOPHOC
WHERE dbo.LOPHOC.MaGV=dbo.GIAOVIEN.MaGV AND dbo.LOPHOC.TenLMH=N'Văn 11'
-------------------------------------------------------------------------------------------
--1
SELECT LOPHOC.MALMH, TenLMH, TrinhDoLop, COUNT(DISTINCT(HOCSINH.MaHS)) SoLuongHS
FROM dbo.LOPHOC, dbo.LICHHOC, dbo.DIEMDANH, dbo.HOCSINH, dbo.DINHMUCLOP
WHERE dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH AND dbo.LICHHOC.MaLichHoc=dbo.DIEMDANH.MaLichHoc
	AND dbo.DIEMDANH.MaHS=dbo.HOCSINH.MaHS AND dbo.LOPHOC.MaDML=dbo.DINHMUCLOP.MaDML
GROUP BY LOPHOC.MALMH, TenLMH, TrinhDoLop

--2
SELECT NgayHoc, SUM(SoTiet) AS TongSoTiet
FROM dbo.LICHHOC
GROUP BY NgayHoc
HAVING SUM(SoTiet)>=14
--3
SELECT COUNT(*) AS SoLuongPL 
FROM dbo.PHIEULUONG 
WHERE NgayTra BETWEEN '2021-01-01'AND N'2021-12-31'
--4
SELECT dbo.HOCSINH.MaHS, dbo.HOCSINH.HoTenHS, SUM(dbo.DINHMUCLOP.SoTien*SoTiet) SoTien
FROM dbo.HOCSINH, dbo.DIEMDANH, dbo.LICHHOC, dbo.LOPHOC, dbo.DINHMUCLOP
WHERE	dbo.HOCSINH.MaHS=DiemDanh.MaHS AND DiemDanh.MaLichHoc=dbo.LICHHOC.MaLichHoc 
	AND dbo.LICHHOC.MaLMH=dbo.LOPHOC.MALMH AND dbo.LOPHOC.MaDML=dbo.DINHMUCLOP.MaDML
	AND DiemDanh.DiemDanh=N'Có' AND NgayHoc LIKE '2021-03-%'
GROUP BY dbo.HOCSINH.MaHS, dbo.HOCSINH.HoTenHS
--5
SELECT MaPL, NgayTra, TongSoTien
FROM dbo.PHIEULUONG
ORDER BY TongSoTien DESC 
--6
CREATE VIEW TEMPO AS
SELECT GIAOVIEN.MaGV, COUNT(MALMH) SoLuong
FROM dbo.GIAOVIEN, dbo.LOPHOC
WHERE dbo.GIAOVIEN.MaGV=dbo.LOPHOC.MaGV
GROUP BY dbo.GIAOVIEN.MaGV
GO

SELECT GIAOVIEN.MaGV, HoTenGV, COUNT(MALMH) SoLuongLop
FROM dbo.GIAOVIEN, dbo.LOPHOC
WHERE dbo.GIAOVIEN.MaGV=dbo.LOPHOC.MaGV
GROUP BY dbo.GIAOVIEN.MaGV, HoTenGV
HAVING COUNT(MALMH)=(SELECT MAX(SoLuong) FROM TEMPO)
--7
SELECT dbo.GIAOVIEN.MaGV, HoTenGV, SUM(TongSoTiet) AS Tong_Tiet
FROM GIAOVIEN, dbo.LOPHOC
WHERE dbo.GIAOVIEN.MaGV=dbo.LOPHOC.MaGV
GROUP BY dbo.GIAOVIEN.MaGV, HoTenGV
ORDER BY Tong_Tiet
--8
SELECT DISTINCT(dbo.HOCSINH.MaHS), HoTenHS, SDT
FROM dbo.HOCSINH, dbo.DIEMDANH
WHERE dbo.HOCSINH.MaHS=dbo.DIEMDANH.MaHS AND dbo.DIEMDANH.DiemDanh=N'Vắng'
--9
SELECT NgayHoc, SUM(SoTiet)
FROM dbo.HOCSINH, dbo.LICHHOC, dbo.DIEMDANH
WHERE dbo.HOCSINH.MaHS=DiemDanh.MaHS AND DiemDanh.MaLichHoc=dbo.LICHHOC.MaLichHoc AND dbo.HOCSINH.HoTenHS=N'Đỗ Thành Long'
GROUP BY NgayHoc
ORDER BY NgayHoc
--10
SELECT DiaChi, COUNT(MaGV) SoLuong 
FROM dbo.GIAOVIEN
GROUP BY DiaChi
ORDER BY SoLuong DESC
-------------------------------------------------------------------------------------------
--1
CREATE TRIGGER SuaHS ON HOCSINH FOR UPDATE
AS 
DECLARE @HoTenHS_cu NVARCHAR(100),
		@HoTenHS_moi NVARCHAR(100)
BEGIN
	SELECT @HoTenHS_cu=HoTenHS FROM deleted
	PRINT N'Họ và tên trước khi sửa: ' + @HoTenHS_cu
	SELECT @HoTenHS_moi=HoTenHS FROM inserted 
	PRINT N'Họ và tên sau khi sửa: ' + @HoTenHS_moi
END

DROP TRIGGER SuaHS

UPDATE dbo.HOCSINH
SET HoTenHS=N'Long Đỗ Thành'
WHERE MaHS='HS009'
--2
CREATE PROC TimLOPHOC (@MaLMH CHAR(10)) 
AS 
BEGIN
	SELECT MALMH, TenLMH, NgayBatDau, TrinhDoLop
	FROM dbo.LOPHOC, dbo.DINHMUCLOP
	WHERE dbo.LOPHOC.MaDML=dbo.DINHMUCLOP.MaDML AND MALMH=@MaLMH
END

TimLOPHOC 'LMH010'
--3
--4
--5
CREATE TRIGGER tg_XoaHS ON dbo.HOCSINH INSTEAD OF DELETE 
AS 
BEGIN
	DECLARE @MaHS CHAR(10)
	SELECT @MaHS=MaHS FROM deleted 
	--Xóa bảng con có liên quan trước
	DELETE dbo.DIEMDANH WHERE MaHS=@MaHS
	PRINT N'Mã HS vừa xóa trong bảng DiemDanh: '+@MaHS
	DELETE dbo.HOADON WHERE MaHS=@MaHS
	PRINT N'Mã HS vừa xóa trong bảng HoaDon: '+@MaHS
	--Tiến hành xóa bảng Học Sinh
	DELETE dbo.HOCSINH WHERE MaHS = @MaHS
	PRINT N'Đã xóa HS có mã '+@MaHS+N' trong bảng HOCSINH'
END
--6
--7
ALTER TABLE dbo.DINHMUCLUONG DROP COLUMN TongSoGV
DROP PROC sp_CapNhatTSGV

ALTER TABLE dbo.DINHMUCLUONG ADD TongSoGV INT

CREATE PROC sp_CapNhatTSGV AS 
BEGIN 
	DECLARE ptr_tsgv CURSOR FOR 
	SELECT DM.MaDM, COUNT(MaGV) AS TongSoGV 
	FROM dbo.GIAOVIEN AS GV JOIN dbo.DINHMUCLUONG AS DM 
	ON DM.MaDM = GV.MaDM
	GROUP BY DM.MaDM
	
	OPEN ptr_tsgv
	DECLARE @MaDM CHAR(10), @TongSoGV INT
	FETCH NEXT FROM ptr_tsgv INTO @MaDM, @TongSoGV
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.DINHMUCLUONG SET TongSoGV = @TongSoGV WHERE MaDM = @MaDM
		FETCH NEXT FROM ptr_tsgv INTO @MaDM, @TongSoGV
	END
	CLOSE ptr_tsgv
	DEALLOCATE ptr_tsgv
END

sp_CapNhatTSGV
SELECT * FROM dbo.DINHMUCLUONG

--6
--7
--8
CREATE PROC sp_HoaDonThang (@thang CHAR(5), @nam CHAR(5)) AS
BEGIN
	SELECT HOADON.MaHS, HoTenHS, SoTienNop
	FROM dbo.HOCSINH, dbo.HOADON
	WHERE dbo.HOCSINH.MaHS=dbo.HOADON.MaHS
		AND NgayXuat LIKE @nam+'-'+@thang+'-%' 
END
GO
--9
CREATE VIEW VIEW_SoTietDiHoc AS
SELECT MaHS, COUNT(MaHS) AS SoTIetHoc 
FROM dbo.DIEMDANH
WHERE DiemDanh = N'Có'
GROUP BY MaHS

DROP PROC sp_TK_TietHoc
CREATE PROC sp_TK_TietHoc (@thang VARCHAR(5), @nam VARCHAR(5)) AS
BEGIN
	SELECT HOCSINH.MaHS, COUNT(HOCSINH.MaHS) AS SoTietHoc 
	FROM dbo.HOCSINH, dbo.DIEMDANH, dbo.LICHHOC
	WHERE dbo.HOCSINH.MaHS=dbo.DIEMDANH.MaHS 
		AND DiemDanh=N'Có'
		AND dbo.DIEMDANH.MaLichHoc=dbo.LICHHOC.MaLichHoc
		AND NgayHoc LIKE @nam+'-'+@thang+'-%' 
	GROUP BY HOCSINH.MaHS
	ORDER BY SoTietHoc
END

sp_TK_TietHoc '05', '2021'



DROP PROC sp_DSLopDDDu
GO
CREATE PROC sp_DSLopDDDu AS 
BEGIN
	DECLARE @MaLMH CHAR(10), @TenLMH NVARCHAR(50)
	DECLARE ptr_dslop CURSOR FOR
	SELECT dbo.LOPHOC.MALMH, dbo.LOPHOC.TenLMH 
	FROM dbo.LOPHOC
	EXCEPT
	SELECT DISTINCT(dbo.LOPHOC.MALMH), dbo.LOPHOC.TenLMH
	FROM dbo.LOPHOC, dbo.LICHHOC, dbo.DIEMDANH, dbo.HOCSINH
	WHERE dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH 
		AND dbo.LICHHOC.MaLichHoc=dbo.DIEMDANH.MaLichHoc
		AND dbo.DIEMDANH.MaHS=dbo.HOCSINH.MaHS 
		AND dbo.DIEMDANH.DiemDanh=N'Vắng'	
	
	OPEN ptr_dslop
	FETCH NEXT FROM ptr_dslop INTO @MaLMH, @TenLMH
	PRINT N'Danh sách lớp có học sinh đi học đầy đủ: '
	WHILE @@FETCH_STATUS =0
	BEGIN
		PRINT @MaLMH + ', ' + @TenLMH
		FETCH NEXT FROM ptr_dslop INTO @MaLMH, @TenLMH
	END

	CLOSE ptr_dslop
	DEALLOCATE ptr_dslop
END
GO

sp_DSLopDDDu
--9
--10




----------------------------------------------------------------------------------------------------------------------
-- VO VAN: tần số đi học của học sinh của 1 lớp trong 1 tháng, so buoi di hoc, so buoi nghi
SELECT dbo.HOCSINH.MaHS, dbo.HOCSINH.HoTenHS, COUNT(DiemDanh.MaLichHoc) SoBuoiHoc
FROM dbo.LOPHOC, dbo.LICHHOC, dbo.DIEMDANH, dbo.HOCSINH
WHERE dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH AND dbo.LICHHOC.MaLichHoc=dbo.DIEMDANH.MaLichHoc 
		AND dbo.DIEMDANH.MaHS=dbo.HOCSINH.MaHS AND dbo.LOPHOC.MALMH='LMH011'
		AND NgayHoc LIKE '%-02-%'
		AND dbo.DIEMDANH.DiemDanh=N'Có'
GROUP BY HOCSINH.MaHS, HOCSINH.HoTenHS

CREATE PROC sp_ThongKeBuoiHoc (@MaLMH CHAR(10), @thang CHAR(5), @nam CHAR(5))
BEGIN
	SELECT dbo.HOCSINH.MaHS, dbo.HOCSINH.HoTenHS, COUNT(DiemDanh.MaLichHoc) SoBuoiHoc
	FROM dbo.LOPHOC, dbo.LICHHOC, dbo.DIEMDANH, dbo.HOCSINH
	WHERE dbo.LOPHOC.MALMH=dbo.LICHHOC.MaLMH AND dbo.LICHHOC.MaLichHoc=dbo.DIEMDANH.MaLichHoc 
			AND dbo.DIEMDANH.MaHS=dbo.HOCSINH.MaHS AND dbo.LOPHOC.MALMH=@MaLMH
			AND NgayHoc LIKE @nam+'-'+@thang+'-%'
			AND dbo.DIEMDANH.DiemDanh=N'Có'
	GROUP BY HOCSINH.MaHS, HOCSINH.HoTenHS
END
-----Nhap-------------
SELECT COUNT(*) 
FROM dbo.HOCSINH
WHERE MaHS NOT IN (
	SELECT HOCSINH.MaHS
	FROM dbo.DIEMDANH, dbo.HOCSINH
	WHERE dbo.DIEMDANH.MaHS=dbo.HOCSINH.MaHS
)


ALTER DATABASE QLHOCTHEM SET EMERGENCY;
GO
ALTER DATABASE QLHOCTHEM set single_user
GO
DBCC CHECKDB (QLHOCTHEM, REPAIR_ALLOW_DATA_LOSS) WITH ALL_ERRORMSGS;
GO
ALTER DATABASE QLHOCTHEM set multi_user
GO