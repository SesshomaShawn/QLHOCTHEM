use QLHOCTHEM
go
CREATE PROC CHANGE_PASS
(  @NEW_PASS VARCHAR(30),
   @MAIL VARCHAR(50)
)
AS
BEGIN 
    UPDATE HOCSINH
	SET MatKhau = @NEW_PASS
	WHERE Email = @MAIL
END
GO

 -- Tạo procedures thông tin học phí của Học sinh
 CREATE PROC THONGTIN_HOCPHI
 (
    @MALMH CHAR(10),
	@MONTH INT,
	@YEAR INT
 )
 AS
 BEGIN
 SELECT TB1.MaHS, TB1.HoTenHS, SUM(SoTien) AS N'Tổng số tiền'
 FROM 
     ( SELECT HS.MaHS, HS.HoTenHS, SUM (LIH.SoTiet * DML.SoTien) AS SoTien
	 FROM HOCSINH AS HS, LICHHOC AS LIH, DIEMDANH AS DD, DINHMUCLOP AS DML, LOPHOC AS LOH
	 WHERE HS.MaHS = DD.MaHS
	    AND LIH.MaLMH = @MALMH
		AND DD.MaLichHoc = LIH.MaLichHoc
		AND DD.DiemDanh = N'Có'
		AND LIH.MaLMH = LOH.MALMH
		AND LOH.MaDML = DML.MaDML
		AND MONTH(LIH.NgayHoc) = @MONTH
		AND YEAR(LIH.NgayHoc) = @YEAR
	 GROUP BY HS.MaHS, HoTenHS ) AS TB1
	 GROUP BY TB1.MaHS, TB1.HoTenHS
 END
 GO

 -- Tạo procedures xem học phí của Học sinh 
 CREATE PROC XEM_HOCPHI
 (
    @TEN NVARCHAR(30), 
	@THANG VARCHAR(5), 
	@NAM VARCHAR(5))
 AS
 BEGIN
 DECLARE @DANOP NVARCHAR(10) = N'Đã nộp'
 DECLARE @CHUANOP NVARCHAR(10) = N'Chưa nộp'
 SELECT TB2.TenLMH, TB2.TinhTrang, TB2.SoTietDiHoc, TB2.MaLMH, TB2.HoTenGV, TB2.sotient, SUM(sotient) as TongTien 
 FROM (
 (SELECT LOH.MALMH, LOH.TenLMH, DML.SoTien, HS.Email, GV.HoTenGV,case when 1=1 then @DANOP end as TinhTrang, SUM(sotiet) as SoTietDiHoc, Sum(LIH.SoTiet * DML.SoTien) as sotient
  FROM HOCSINH AS HS, LICHHOC AS LIH, LOPHOC AS LOH, DIEMDANH AS DD, GIAOVIEN GV, DINHMUCLOP AS DML
  WHERE HS.MaHS = DD.MaHS 
  AND LIH.MaLichHoc = DD.MaLichHoc 
  AND DD.DiemDanh = N'Có'
  AND DML.MaDML = LOH.MaDML
  AND LIH.MaLMH = LOH.MALMH 
  AND GV.MaGV = LOH.MaGV 
  AND LIH.NgayHoc LIKE @NAM+'-0'+@THANG+'%'
  AND EXISTS 
     ( SELECT *
	   FROM HOADON AS HD, HOCSINH HS
	   WHERE  NgayNop LIKE @NAM + '-0' +@THANG+'%' 
	   AND Email = @TEN 
	   AND HD.MaHS = HS.MaHS)
       GROUP BY LOH.MALMH, DML.SoTien, LOH.TenLMH, HS.Email, GV.HoTenGV)
  
  UNION
 (SELECT LOH.MALMH, LOH.TenLMH, DML.SoTien, HS.Email, GV.HoTenGV,case when 1=1 then @CHUANOP end as TinhTrang, SUM(sotiet) as SoTietDiHoc, Sum(LIH.SoTiet * DML.SoTien) as sotient
  FROM HOCSINH AS HS, LICHHOC AS LIH, LOPHOC AS LOH, DIEMDANH AS DD, GIAOVIEN AS GV, DINHMUCLOP AS DML 
  WHERE HS.MaHS = DD.MaHS 
  AND LIH.MaLichHoc = DD.MaLichHoc 
  AND DD.DiemDanh = N'Có' 
  AND LIH.MaLMH = LOH.MALMH 
  AND DML.MaDML = LOH.MaDML
  AND GV.MaGV = LOH.MaGV 
  AND LIH.NgayHoc LIKE @NAM+'-0'+@THANG+'%'
  AND NOT EXISTS
    (SELECT *
	 FROM HOADON AS HD, HOCSINH AS HS 
	 WHERE  NgayNop LIKE @NAM + '-0' +@THANG+'%' 
	 AND Email = @TEN 
	 AND HD.MaHS = HD.MaHS)
  GROUP BY LOH.MALMH, DML.SoTien, LOH.TenLMH, HS.Email, GV.HoTenGV)
 ) AS TB2
  GROUP BY TB2.MaLMH,TB2.sotient, TB2.SoTietDiHoc, TB2.HoTenGV, TB2.TenLMH, TB2.Email, TB2.TinhTrang 
  HAVING TB2.Email = @TEN

 END
GO

XEM_HOCPHI 'DoThanhLong@gmail.com', '4', '2021'

  -- Tạo procedures xem buổi nghỉ học của Học sinh
 CREATE PROC NGHI_HOC
 (
   @EMAIL VARCHAR(35),
   @THANG VARCHAR(10),
@NAM VARCHAR (10)
 )
 AS 
 BEGIN
    SELECT LOH.MALMH, LOH.TenLMH, LIH.NgayHoc, SUM(LIH.SoTiet) AS sotietnghi
    FROM HOCSINH AS HS, LICHHOC AS LIH, LOPHOC AS LOH, DIEMDANH AS DD
	WHERE HS.MaHS = DD.MaHS
	   AND LIH.MaLichHoc = DD.MaLichHoc
	   AND DD.DiemDanh = N'Vắng'
	   AND LIH.MaLMH = LOH.MALMH
	   AND LIH.NgayHoc LIKE @NAM + '-0' + @THANG + '%'
	   AND HS.Email = @EMAIL
	GROUP BY LOH.MALMH, LOH.TenLMH, LIH.NgayHoc
  END
  GO

  -- Tạo porceduces xem lịch học
 CREATE PROC XEM_LICHHOC
 (
   @Ten NVARCHAR(15)) 
 AS
 BEGIN
   SELECT MaLichHoc, NgayHoc, KipHoc, SoTiet, LOH.MALMH, GV.HoTenGV 
   FROM LICHHOC AS LIH, LOPHOC AS LOH, GIAOVIEN AS GV
   WHERE LIH.MaLMH = LOH.MALMH 
   AND LIH.MaGV = GV.MaGV 
   AND LOH.TenLMH = @Ten
 END
 GO

 CREATE PROC XEM_HOCPHI
 (
    @TEN NVARCHAR(30), 
	@THANG VARCHAR(5), 
	@NAM VARCHAR(5))
 AS
 BEGIN
 DECLARE @DANOP NVARCHAR(10) = N'Đã nộp'
 DECLARE @CHUANOP NVARCHAR(10) = N'Chưa nộp'
 SELECT TB2.TenLMH, TB2.TinhTrang, TB2.SoTietDiHoc, TB2.MaLMH, TB2.HoTenGV, TB2.SoTien, SUM(Tongsotien) as TongTien 
 FROM (
 (SELECT LOH.MALMH, LOH.TenLMH, DML.SoTien, HS.Email, GV.HoTenGV,case when 1=1 then @DANOP end as TinhTrang, SUM(sotiet) as SoTietDiHoc, Sum(LIH.SoTiet * DML.SoTien) as Tongsotien
  FROM HOCSINH AS HS, LICHHOC AS LIH, LOPHOC AS LOH, DIEMDANH AS DD, GIAOVIEN GV, DINHMUCLOP AS DML
  WHERE HS.MaHS = DD.MaHS 
  AND LIH.MaLichHoc = DD.MaLichHoc 
  AND DD.DiemDanh = N'Có'
  AND DML.MaDML = LOH.MaDML
  AND LIH.MaLMH = LOH.MALMH 
  AND GV.MaGV = LOH.MaGV 
  AND LIH.NgayHoc LIKE @NAM+'-0'+@THANG+'%'
  AND EXISTS 
     ( SELECT *
	   FROM HOADON AS HD, HOCSINH HS
	   WHERE  NgayNop LIKE @NAM + '-0' +@THANG+'%' 
	   AND Email = @TEN 
	   AND HD.MaHS = HS.MaHS)
       GROUP BY LOH.MALMH, DML.SoTien, LOH.TenLMH, HS.Email, GV.HoTenGV)
  
  UNION
 (SELECT LOH.MALMH, LOH.TenLMH, DML.SoTien, HS.Email, GV.HoTenGV,case when 1=1 then @CHUANOP end as TinhTrang, SUM(sotiet) as SoTietDiHoc, Sum(LIH.SoTiet * DML.SoTien) as Tongsotien
  FROM HOCSINH AS HS, LICHHOC AS LIH, LOPHOC AS LOH, DIEMDANH AS DD, GIAOVIEN AS GV, DINHMUCLOP AS DML 
  WHERE HS.MaHS = DD.MaHS 
  AND LIH.MaLichHoc = DD.MaLichHoc 
  AND DD.DiemDanh = N'Có' 
  AND LIH.MaLMH = LOH.MALMH 
  AND DML.MaDML = LOH.MaDML
  AND GV.MaGV = LOH.MaGV 
  AND LIH.NgayHoc LIKE @NAM+'-0'+@THANG+'%'
  AND NOT EXISTS
    (SELECT *
	 FROM HOADON AS HD, HOCSINH AS HS 
	 WHERE  NgayNop LIKE @NAM + '-0' +@THANG+'%' 
	 AND Email = @TEN 
	 AND HD.MaHS = HD.MaHS)
  GROUP BY LOH.MALMH, DML.SoTien, LOH.TenLMH, HS.Email, GV.HoTenGV)
 ) AS TB2
  GROUP BY TB2.MaLMH, TB2.SoTien, TB2.SoTietDiHoc, TB2.HoTenGV, TB2.TenLMH, TB2.Email, TB2.TinhTrang 
  HAVING TB2.Email = @TEN

 END
GO

drop proc NGHI_HOC
go
create proc [dbo].[cbb_HS2] (@MaHS nchar(10))
as
begin
	select TenLMH from LOPHOC
	where TenLMH not in (select distinct LOPHOC.TenLMH from LOPHOC, LICHHOC, DIEMDANH
	where DIEMDANH.MaLichHoc = LICHHOC.MaLichHoc
	and LICHHOC.MaLMH = LOPHOC.MALMH
	and DIEMDANH.MaHS = @MaHS)
end
GO
CREATE PROCEDURE [dbo].[cbb_HS1] (@MaHS NCHAR(10)) AS
BEGIN
    select distinct LOPHOC.TenLMH from LOPHOC, LICHHOC, DIEMDANH
	where DIEMDANH.MaLichHoc = LICHHOC.MaLichHoc
	and LICHHOC.MaLMH = LOPHOC.MALMH
	and DIEMDANH.MaHS = @MaHS
end
GO

create proc [dbo].[XemLichHoc_HS1] (@MaHS char(10), @TenLMH nvarchar(30))
as
begin

select LICHHOC.MaLichHoc, LOPHOC.MALMH, NgayHoc, KipHoc, SoTiet, HoTenGV
from LICHHOC, GIAOVIEN, DIEMDANH, LOPHOC
where DIEMDANH.MaLichHoc = LICHHOC.MaLichHoc
and LOPHOC.MALMH = LICHHOC.MaLMH
and LOPHOC.MaGV = GIAOVIEN.MaGV
and DIEMDANH.MaHS = @MaHS
and LOPHOC.TenLMH = @TenLMH
end
GO

create proc [dbo].[XemLichHoc_HS2] ( @TenLMH nvarchar(30))
as
begin

select LICHHOC.MaLichHoc, LOPHOC.MALMH, NgayHoc, KipHoc, SoTiet, HoTenGV
from LICHHOC, GIAOVIEN, LOPHOC
where LOPHOC.MALMH = LICHHOC.MaLMH
and LOPHOC.MaGV = GIAOVIEN.MaGV
and LOPHOC.TenLMH = N'Hóa 12_1'--@TenLMH
end
GO

-------------------------------------------------------------------------------
create proc Search_lichhoc (@MaHS char(10),@day1 date, @day2 date)
as 
begin
	SELECT Lichhoc.MaLichHoc, TenLMH, NgayHoc, KipHoc, SoTiet, HoTenGV, LOPHOC.MALMH
	FROM LICHHOC, LOPHOC, GIAOVIEN, DIEMDANH
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = dbo.LOPHOC.MaLMH AND LICHHOC.MaGV = dbo.LOPHOC.MaGV
          and DiemDanh.MaLichHoc = LICHHOC.MaLichHoc
		  and DIEMDANH.MaHS = @MaHS --and DiemDanh.DiemDanh = 'Có'
		  and NgayHoc between @day1 and @day2
end
exec Search_lichhoc 'HS039','2021-02-04', '2021-05-11'
drop proc Search_lichhoc
drop proc NGHI_HOC

create proc Search_lichhoc_theoNgay (@MaHS char(10),@day date)
as 
begin
	SELECT Lichhoc.MaLichHoc, TenLMH, NgayHoc, KipHoc, SoTiet, HoTenGV, LOPHOC.MALMH
	FROM LICHHOC, LOPHOC, GIAOVIEN, DIEMDANH
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = dbo.LOPHOC.MaLMH AND LICHHOC.MaGV = dbo.LOPHOC.MaGV
          and DiemDanh.MaLichHoc = LICHHOC.MaLichHoc
		  and DIEMDANH.MaHS = @MaHS 
		  and NgayHoc = @day
end
exec Search_lichhoc_theoNgay 'HS039','2021-02-17'
drop proc Search_lichhoc_theoNgay
-- Xem lớp đã đăng ký
  CREATE PROC cbb_HS1 (@MaHS NCHAR(10)) AS
BEGIN
    SELECT DISTINCT dbo.LOPHOC.TenLMH FROM dbo.DIEMDANH, dbo.LOPHOC, LICHHOC
	WHERE LICHHOC.MaLichHoc = DIEMDANH.MaLichHoc
	AND LICHHOC.MaLMH = LOPHOC.MALMH
	AND dbo.DIEMDANH.MaHS = @MaHS
END
GO

  EXEC cbb_HS1 N'HS004'

----

---- Xem lịch học các lớp đã đăng ký
CREATE PROC XemLichHoc_HS1 (@MaHS CHAR(10), @TenLMH NvarCHAR(50)) AS
BEGIN
    SELECT LICHHOC.MaLichHoc, LOPHOC.TenLMH, NgayHoc, KipHoc, SoTiet, HoTenGV
	FROM dbo.LICHHOC, dbo.LOPHOC, DIEMDANH, GIAOVIEN
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV
	      AND LICHHOC.MaLMH = LOPHOC.MALMH
		  AND LICHHOC.MaLichHoc = dbo.DIEMDANH.MaLichHoc
	      AND DIEMDANH.MaHS = @MaHS
		  AND dbo.LOPHOC.TenLMH = @TenLMH
	
END
go

 EXEC XemLichHoc_HS1 N'HS006', N'Hóa 10'

 -- Xem các lớp chưa đăng ký 
 CREATE PROC cbb_HS2 (@MaHS NCHAR(10)) AS
BEGIN
    SELECT TenLMH  FROM LOPHOC
	WHERE TenLMH NOT IN ( SELECT DISTINCT dbo.LOPHOC.TenLMH FROM dbo.DIEMDANH, dbo.LOPHOC, LICHHOC
	WHERE LICHHOC.MaLichHoc = DIEMDANH.MaLichHoc
	AND LICHHOC.MaLMH = LOPHOC.MALMH
	AND dbo.DIEMDANH.MaHS = @MaHS )
END
GO
  
  EXEC cbb_HS2 N'HS004'

---- xem lich học của các lớp chưa đăng ký 
CREATE PROC XemLichHoc_HS2 (@TenLMH NvarCHAR(50)) AS
BEGIN
    SELECT LICHHOC.MaLichHoc, LOPHOC.TenLMH, NgayHoc, KipHoc, SoTiet, HoTenGV
	FROM dbo.LICHHOC, dbo.LOPHOC, GIAOVIEN
	WHERE GIAOVIEN.MaGV = dbo.LOPHOC.MaGV
	      AND LICHHOC.MaLMH = LOPHOC.MALMH    
		  AND dbo.LOPHOC.TenLMH = @TenLMH
	
END
go
  EXEC XemLichHoc_HS2 N'Hóa 10'