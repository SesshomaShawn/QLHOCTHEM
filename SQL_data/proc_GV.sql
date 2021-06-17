use QLHOCTHEM
go
CREATE PROC [dbo].[XemLuong](@MaGV nchar(10), @thang int, @nam int)
AS
BEGIN
	SELECT MaPL, NgayTra, TenLMH, SoTien, SUM(SoTiet) AS SoTietDay, (SoTien*SUM(SoTiet)) AS TongTien
	FROM dbo.LOPHOC, dbo.LICHHOC, dbo.DINHMUCLUONG, dbo.GIAOVIEN, dbo.PHIEULUONG
	WHERE DINHMUCLUONG.MaDM = GIAOVIEN.MaDM AND GIAOVIEN.MaGV = LICHHOC.MaGV AND GIAOVIEN.MaGV = LOPHOC.MaGV AND LICHHOC.MaGV = LOPHOC.MaGV AND LICHHOC.MaLMH = LOPHOC.MaLMH AND GIAOVIEN.MaGV = PHIEULUONG.MaGV
		  AND MONTH(NgayHoc) = @thang AND YEAR(NgayHoc) = @nam AND GIAOVIEN.MaGV = @MaGV AND MONTH(NgayTra) = @thang AND YEAR(NgayTra) = @nam
GROUP BY MaPL, NgayTra, TenLMH, SoTien
END

GO
CREATE PROC [dbo].[CHANGE_PASSGV](
    @New_pass varchar(50),
	@Mail nvarchar(150)
	)
as
begin

UPDATE GIAOVIEN SET MatKhau = @New_pass WHERE Email = @Mail
END

GO
CREATE PROC [dbo].[XemLichDay](@MaGV nchar(10), @TenMH nchar(30))
AS
BEGIN
	SELECT MaLichHoc, LICHHOC.MaLMH, NgayHoc, KipHoc, SoTiet, HoTenGV
	FROM dbo.LICHHOC, dbo.LOPHOC, dbo.GIAOVIEN
	WHERE GIAOVIEN.MaGV = LOPHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = LOPHOC.MaLMH AND LICHHOC.MaGV = LOPHOC.MaGV
	      AND LICHHOC.MaGV = @MaGV AND dbo.LOPHOC.TenLMH LIKE '%'+RTRIM(@TenMH)+'%'
END
GO

GO
CREATE PROC [dbo].[XemLopDayCuaGV](@MaGV nchar(10))
AS
BEGIN
	SELECT TenLMH FROM dbo.LOPHOC 
	WHERE MaGV = @MaGV
END

CREATE PROCEDURE cbb (@MaGV NCHAR(10)) AS
BEGIN
    SELECT dbo.LOPHOC.TenLMH FROM dbo.GIAOVIEN, dbo.LOPHOC
	WHERE dbo.GIAOVIEN.MaGV = dbo.LOPHOC.MaGV 
	AND dbo.LOPHOC.MaGV = @MaGV
END
GO

CREATE PROC XemLichDay (@MaGV CHAR(10), @TenMH NvarCHAR(50)) AS
BEGIN
    SELECT MaLichHoc, LICHHOC.MaLMH, NgayHoc, KipHoc, SoTiet, HoTenGV
	FROM dbo.LICHHOC, dbo.LOPHOC, dbo.GIAOVIEN
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = dbo.LOPHOC.MaLMH AND LICHHOC.MaGV = dbo.LOPHOC.MaGV
	      AND LICHHOC.MaGV = @MaGV AND dbo.LOPHOC.TenLMH LIKE '%'+RTRIM(@TenMH)+'%'
END
go
--- tìm kiếm lịch dạy trong 1 ngày cụ thể
create proc Search_lichday_theoNgay (@MaGV char(10),@day date)
as 
begin
	SELECT MaLichHoc, TenLMH, NgayHoc, KipHoc, SoTiet, HoTenGV, LOPHOC.MALMH
	FROM LICHHOC, LOPHOC, GIAOVIEN
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = dbo.LOPHOC.MaLMH AND LICHHOC.MaGV = dbo.LOPHOC.MaGV
	      AND LICHHOC.MaGV = @MaGV 
		  and NgayHoc = @day 
end

drop proc Search_lichday_theoNgay

exec Search_lichday_theoNgay 'GV016','2021-02-04'

--- Tìm kiếm lịch dạy trong 1 khoảng thời gian
go
create proc Search_lichday (@MaGV char(10),@day1 date, @day2 date)
as 
begin
	SELECT MaLichHoc, TenLMH, NgayHoc, KipHoc, SoTiet, HoTenGV
	FROM LICHHOC, LOPHOC, GIAOVIEN
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = dbo.LOPHOC.MaLMH AND LICHHOC.MaGV = dbo.LOPHOC.MaGV
	      AND LICHHOC.MaGV = @MaGV 
		  and NgayHoc between @day1 and @day2
end

drop proc Search_lichday
exec Search_lichday 'GV016','2021-02-04', '2021-02-11'