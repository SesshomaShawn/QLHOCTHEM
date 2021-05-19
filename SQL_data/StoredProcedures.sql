USE [QLHOCTHEM]
GO
/****** Object:  StoredProcedure [dbo].[abx]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[abx]
as
begin
	(select * from GIAOVIEN)
	(Select * from HOCSINH)
end
GO
/****** Object:  StoredProcedure [dbo].[CHANGE_PASS]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CHANGE_PASS](
    @New_pass varchar(50),
	@Mail nvarchar(150)
	)
as
begin

UPDATE HOCSINH SET MatKhau = @New_pass WHERE Email = @Mail
END
GO
/****** Object:  StoredProcedure [dbo].[CHANGE_PASSGV]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[Chi_Thu_Thang]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Chi_Thu_Thang](
	@thang nvarchar(5),
	@nam nvarchar(5))
as
begin
 (select case when 1 = 1 then N'Thu học phí'  end as TT , Sum(TongTien) as Tong  from
   (    select 		
		lh.MaLMH    ,
		COUNT(MaHS) as TT,
	    lmh.SoTien_Tiet,
		lh.SoTiet,
		COUNT(MaHS)*lmh.SoTien_Tiet*lh.SoTiet as TongTien
	from dbo.DIEMDANH dd, dbo.LICHHOC lh, dbo.LOPMONHOC lmh 
	where  lh.NgayHoc like @nam+'-0'+@thang+'%'and dd.MaLichHoc = lh.MaLichHoc and lh.MaLMH = lmh.MaLMH
	group by lh.MaLMH , lmh.SoTien_Tiet, lh.SoTiet 	) as BB
	) union
	(select case when 1 = 1 then N'Trả lương'  end as TT, Sum(TongTien) as Tong  from
	(select 		
		lh.MaLMH    ,
		COUNT(MaLichHoc) as TT,
	    dm.SoTien,
		lh.SoTiet,
		COUNT(MaLichHoc)*dm.SoTien*lh.SoTiet as TongTien
	from  dbo.LICHHOC lh, dbo.LOPMONHOC lmh ,dbo.GIAOVIEN gv , dbo.DINHMUC dm
	where  lh.NgayHoc like @nam+'-0'+@thang+'%' and lh.MaLMH = lmh.MaLMH and lmh.MaGV = gv.MaGV and gv.MaDM = dm.MaDM
	group by lh.MaLMH , dm.SoTien, lh.SoTiet ) as BP)
	
end







GO
/****** Object:  StoredProcedure [dbo].[insertHD]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertHD]
	@mahd varchar(5),
	@ngaynop date,
	@tongtien float,
	@mahs varchar(5)
as
begin
	insert into HOADON(MaHD, NgayNop, SoTienNop, MaHS)
	values(@mahd,@ngaynop,@tongtien,@mahs)
end
GO
/****** Object:  StoredProcedure [dbo].[insertPLuong]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertPLuong]
	@mapl varchar(5),
	@ngaytra date,
	@tongtien float,
	@magv varchar(5)
as
begin
	insert into PHIEULUONG(MaPL, NgayTra, TongTien, MaGV)
	values(@mapl,@ngaytra,@tongtien,@magv)
end

GO
/****** Object:  StoredProcedure [dbo].[THEM_PHIEULUONG]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[THEM_PHIEULUONG] (
    @Ten nvarchar(20),
	@nam varchar(10),
	@thang varchar(10))
	as
	begin
select mh.TenLMH,mh.MaLMH,dm.LoaiDM,dm.SoTien, (COUNT(lh.MaGV)*lh.SoTiet) as Sotietday from GIAOVIEN gv, LOPMONHOC mh, DINHMUC dm,LICHHOC lh
where gv.MaDM = dm.MaDM and gv.MaGV = mh.MaGV and gv.MaGV = lh.MaGV and gv.HoTenGV = @Ten and lh.MaLMH = mh.MaLMH and lh.NgayHoc like @nam + '-0' +@thang+'%' 
group by mh.TenLMH,mh.MaLMH,dm.LoaiDM,dm.SoTien,lh.SoTiet
  end
GO
/****** Object:  StoredProcedure [dbo].[ThemGiaoVien]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[ThemGiaoVien](@MaGV nchar(5), @HoTenGV nchar(30), @NgaySinh date, @DiaChi nchar(30), @GioiTinh nchar(3), @MaMH nchar(5), @MaDM nchar(5), @MatKhau nchar(30), @Email nchar(30))
AS
BEGIN
	INSERT dbo.GIAOVIEN (MaGV, HoTenGV, NgaySinh, DiaChi, GioiTinh, MaMH, MaDM, MatKhau, Email)
	VALUES (@MaGV, @HoTenGV, @NgaySinh, @DiaChi, @GioiTinh, @MaMH, @MaDM, @MatKhau, @Email)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHocSinh]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHocSinh](@MaHS nchar(5), @HoTenHS nchar(30), @NgaySinh date, @DiaChi nchar(30), @GioiTinh nchar(3), @MatKhau nchar(30), @Email nchar(30))
AS
BEGIN
	INSERT dbo.HOCSINH (MaHS, HoTenHS, NgaySinh, DiaChi, GioiTinh, MatKhau, Email)
	VALUES (@MaHS, @HoTenHS, @NgaySinh, @DiaChi, @GioiTinh, @MatKhau, @Email)
END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSoLuongGiaoVien]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongKeSoLuongGiaoVien]
AS
BEGIN
	SELECT COUNT(GV.MaGV) AS SoLuong, MH.TenMH
	FROM dbo.GIAOVIEN AS GV, dbo.MONHOC AS MH
	WHERE MH.MaMH = GV.MaMH
	GROUP BY MH.TenMH
END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSoLuongHocSinh]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[ThongKeSoLuongHocSinh](@MaNhomLop NCHAR(20))
AS
BEGIN
	SELECT SUM(TB.SoLuongHocSinh) AS SoLuong, N'Toán' AS TenLMH
	FROM (SELECT LMH.TenLMH, COUNT(DISTINCT HS.MaHS) AS SoLuongHocSinh
		  FROM dbo.HOCSINH AS HS, dbo.LICHHOC AS LH, dbo.LOPMONHOC AS LMH, dbo.DIEMDANH AS DD
		  WHERE HS.MaHS = DD.MaHS AND DD.MaLichHoc = LH.MaLichHoc AND LH.MaLMH = LMH.MaLMH
			    AND LMH.MaNhomLop = @MaNhomLop 
		  GROUP BY LMH.TenLMH) AS TB
	WHERE TB.TenLMH LIKE N'Toán%'
	UNION
	SELECT SUM(TB.SoLuongHocSinh) AS SoLuong, N'Lý' AS TenLMH
	FROM (SELECT LMH.TenLMH, COUNT(DISTINCT HS.MaHS) AS SoLuongHocSinh
		  FROM dbo.HOCSINH AS HS, dbo.LICHHOC AS LH, dbo.LOPMONHOC AS LMH, dbo.DIEMDANH AS DD
		  WHERE HS.MaHS = DD.MaHS AND DD.MaLichHoc = LH.MaLichHoc AND LH.MaLMH = LMH.MaLMH
			    AND LMH.MaNhomLop = @MaNhomLop 
		  GROUP BY LMH.TenLMH) AS TB
	WHERE TB.TenLMH LIKE N'Lý%'
	UNION
	SELECT SUM(TB.SoLuongHocSinh) AS SoLuong, N'Hóa' AS TenLMH
	FROM (SELECT LMH.TenLMH, COUNT(DISTINCT HS.MaHS) AS SoLuongHocSinh
		  FROM dbo.HOCSINH AS HS, dbo.LICHHOC AS LH, dbo.LOPMONHOC AS LMH, dbo.DIEMDANH AS DD
	      WHERE HS.MaHS = DD.MaHS AND DD.MaLichHoc = LH.MaLichHoc AND LH.MaLMH = LMH.MaLMH
			    AND LMH.MaNhomLop = @MaNhomLop 
		  GROUP BY LMH.TenLMH) AS TB
	WHERE TB.TenLMH LIKE N'Hóa%'
	UNION	
	SELECT SUM(TB.SoLuongHocSinh) AS SoLuong, N'Văn' AS TenLMH
	FROM (SELECT LMH.TenLMH, COUNT(DISTINCT HS.MaHS) AS SoLuongHocSinh
		  FROM dbo.HOCSINH AS HS, dbo.LICHHOC AS LH, dbo.LOPMONHOC AS LMH, dbo.DIEMDANH AS DD
		  WHERE HS.MaHS = DD.MaHS AND DD.MaLichHoc = LH.MaLichHoc AND LH.MaLMH = LMH.MaLMH
			    AND LMH.MaNhomLop = @MaNhomLop 
		  GROUP BY LMH.TenLMH) AS TB
	WHERE TB.TenLMH LIKE N'Văn%'
	UNION
	SELECT SUM(TB.SoLuongHocSinh) AS SoLuong, N'Tiếng Anh' AS TenLMH
	FROM (SELECT LMH.TenLMH, COUNT(DISTINCT HS.MaHS) AS SoLuongHocSinh
		  FROM dbo.HOCSINH AS HS, dbo.LICHHOC AS LH, dbo.LOPMONHOC AS LMH, dbo.DIEMDANH AS DD
		  WHERE HS.MaHS = DD.MaHS AND DD.MaLichHoc = LH.MaLichHoc AND LH.MaLMH = LMH.MaLMH
				AND LMH.MaNhomLop = @MaNhomLop 
		  GROUP BY LMH.TenLMH) AS TB
	WHERE TB.TenLMH LIKE N'Tiếng Anh%'
END
GO
/****** Object:  StoredProcedure [dbo].[Tim_GV1]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Tim_GV1](
	@tukhoa nvarchar(30),
	@thang nvarchar(5),
	@nam nvarchar(5))
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	(select 
		gv.MaGV,
		gv.HoTenGV,
		gv.Email,
	    case when 1 = 1 then N'Đã trả'  end as TT,
		pl.NgayTra
	from dbo.GIAOVIEN gv,dbo.PHIEULUONG  pl 
	where lower(gv.HoTenGV) like '%'+@tukhoa+'%'and gv.MaGV=pl.MaGV and pl.NgayTra like @nam+'-0'+@thang+'%'
	)
	union 
	(select 
		gv.MaGV,
		gv.HoTenGV,
		gv.Email,
	    case when 1 = 1 then N'Chưa trả'  end as TT,
		null as NgayTra		

	from dbo.GIAOVIEN gv
	where lower(gv.HoTenGV) like '%'+@tukhoa+'%'
	and not exists ( select * from dbo.PHIEULUONG pl where pl.NgayTra like @nam+'-0'+@thang+'%'and pl.MaGV= gv.MaGV and gv.HoTenGV like '%'+@tukhoa+'%'))

end
GO
/****** Object:  StoredProcedure [dbo].[Tim_GVnew]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Tim_GVnew](
	@tukhoa nvarchar(30),
	@thang nvarchar(5),
	@nam nvarchar(5))
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	(select 
		gv.MaGV,
		gv.HoTenGV,
		gv.Email,
	    case when 1 = 1 then N'Đã trả'  end as TT

	from dbo.GIAOVIEN gv,dbo.PHIEULUONG  pl 
	where lower(gv.HoTenGV) like '%'+@tukhoa+'%'
	and exists ( select * from dbo.PHIEULUONG pl , dbo.GIAOVIEN gv where pl.NgayTra like @nam+'-0'+@thang+'%'and pl.MaGV= gv.MaGV and gv.HoTenGV like '%'+@tukhoa+'%'))
	union 
	(select 
		gv.MaGV,
		gv.HoTenGV,
		gv.Email,
	    case when 1 = 1 then N'Chưa trả'  end as TT

	from dbo.GIAOVIEN gv,dbo.PHIEULUONG  pl 
	where lower(gv.HoTenGV) like '%'+@tukhoa+'%'
	and not exists ( select * from dbo.PHIEULUONG pl , dbo.GIAOVIEN gv where pl.NgayTra like @nam+'-0'+@thang+'%'and pl.MaGV= gv.MaGV and gv.HoTenGV like '%'+@tukhoa+'%'))

end







GO
/****** Object:  StoredProcedure [dbo].[Tim_HS1]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Tim_HS1](
	@tukhoa nvarchar(30),
	@thang nvarchar(5),
	@nam nvarchar(5))
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	(select 
		hs.MaHS,
		hs.HoTenHS,
		hs.Email,
	    case when 1 = 1 then N'Đã nộp'  end as TrangThai,
		hd.NgayNop
	from dbo.HOCSINH hs,dbo.HOADON  hd 
	where lower(hs.HoTenHS) like '%'+@tukhoa+'%'and hs.MaHS= hd.MaHS and hd.NgayNop like @nam+'-0'+@thang+'%'
	)
	union 
	(select 
		hs.MaHS,
		hs.HoTenHS,
		hs.Email,
	    case when 1 = 1 then N'Chưa nộp'  end as TrangThai,
		null as NgayNop	
	from dbo.HOCSINH hs 
	where lower(hs.HoTenHS) like '%'+@tukhoa+'%'
	and not exists ( select * from dbo.HOADON hd  where hd.NgayNop like @nam+'-0'+@thang+'%' and hd.MaHS=hs.MaHS and hs.HoTenHS like '%'+@tukhoa+'%'  ))

end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTheoMaGV]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------Procedure Tìm kiếm theo mã GV------------
CREATE PROC [dbo].[TimKiemTheoMaGV](@MaGV nchar(5))
AS
BEGIN
	SELECT * FROM dbo.GIAOVIEN WHERE MaGV = @MaGV
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTheoMaHS]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimKiemTheoMaHS](@MaHS nchar(5))
AS
BEGIN
	SELECT * FROM dbo.HOCSINH WHERE MaHS = @MaHS
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTheoTenGV]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------Procedure Tìm kiếm theo tên GV------------
CREATE PROC [dbo].[TimKiemTheoTenGV](@TenGV nchar(30))
AS
BEGIN
	SELECT * FROM dbo.GIAOVIEN WHERE HoTenGV LIKE '%'+RTRIM(@TenGV)+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTheoTenHS]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------Procedure Tìm kiếm theo tên HS------------
CREATE PROC [dbo].[TimKiemTheoTenHS](@TenHS nchar(30))
AS
BEGIN
	SELECT * FROM dbo.HOCSINH WHERE HoTenHS LIKE '%'+RTRIM(@TenHS)+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[TinhHocPhi]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TinhHocPhi](@MaLMH nchar(5), @Month int, @Year int)
as begin
select TB.MaHS, TB.HoTenHS, sum(sotien) as N'Tổng số tiền'
from (select HS.MaHS, HS.HoTenHS, SUM (LH.SoTiet * LMH.SoTien_Tiet) as sotien 
FROM dbo.HOCSINH as HS, dbo.LICHHOC as LH, dbo.DIEMDANH as DD, dbo.LOPMONHOC as LMH
WHERE HS.MaHS= DD.MaHS AND LH.MaLMH = @MaLMH AND DD.MaLichHoc = LH.MaLichHoc AND DD.DiemDanh = N'Có'
AND LH.MaLMH = LMH.MaLMH AND MONTH(LH.NgayHoc) = @Month and YEAR(LH.NgayHoc)=@Year 
GROUP BY HS.MaHS, HoTenHS) as TB
group by TB.MaHS, TB.HoTenHS
end
GO
/****** Object:  StoredProcedure [dbo].[XEM_BUOINGHI]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XEM_BUOINGHI] 
(
   @EMAIL VARCHAR(35),
   @THANG VARCHAR(10),
   @NAM VARCHAR (10)
 )
 AS BEGIN
select mh.MaLMH, mh.TenLMH, lh.NgayHoc, Sum(lh.Sotiet) as sotietnghi from HOCSINH hs,LICHHOC lh,LOPMONHOC mh, DIEMDANH dd
where hs.MaHS = dd.MaHS and lh.MaLichHoc = dd.MaLichHoc and dd.DiemDanh = N'Vắng' and lh.MaLMH = mh.MaLMH and lh.NgayHoc like @NAM+ '-0'+@THANG +'%' and hs.Email =@EMAIL
group by mh.MaLMH, mh.TenLMH, lh.NgayHoc
END
GO
/****** Object:  StoredProcedure [dbo].[Xem_HoaDon]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Xem_HoaDon] (
    @Ten nvarchar(20),
	@nam varchar(10),
	@thang varchar(10))
	as
	begin
select hd.NgayNop , hd.MaHD , hs.DiaChi , hs.Email  from dbo.HOCSINH hs, dbo.HOADON hd
where hs.HoTenHS = @Ten and hd.MaHS = hs.MaHS and hd.NgayNop like @nam + '-0' +@thang+'%' 
end
GO
/****** Object:  StoredProcedure [dbo].[XEM_HOCPHI]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC XEM_HOCPHI

use ThucTapCSDL EXEC sp_changedbowner 'sa'

CREATE PROC [dbo].[XEM_HOCPHI](@TEN NVARCHAR(30), @THANG varchar(5), @NAM varchar(5))
 AS
 BEGIN
 declare @danop nvarchar(10) = N'Đã nộp'
 declare @chuanop nvarchar(10) = N'Chưa nộp'
 select tb.TenLMH,tb.TinhTrang,tb.SoTietDiHoc,tb.MaLMH,tb.HoTenGV,tb.SoTien_tiet,sum(sotien) as TongTien 
 from (
 (select mh.MaLMH, mh.TenLMH,mh.SoTien_tiet, hs.Email, gv.HoTenGV,case when 1=1 then @danop end as TinhTrang,sum(sotiet) as SoTietDiHoc, Sum(lh.Sotiet * mh.SoTien_tiet) as sotien
 from HOCSINH hs, LICHHOC lh, LOPMONHOC mh, DIEMDANH dd, GIAOVIEN gv 
 where hs.MaHS = dd.MaHS and lh.MaLichHoc = dd.MaLichHoc and dd.DiemDanh = N'Có' and lh.MaLMH = mh.MaLMH and gv.MaGV = mh.MaGV and lh.NgayHoc like @NAM+'-0'+@THANG+'%'
 and exists (select *from HOADON hd,HOCSINH hs where  NgayNop like @NAM + '-0' +@THANG+'%' and Email = @TEN and hd.MaHS = hs.MaHS)
 group by mh.MaLMH,mh.SoTien_tiet, mh.TenLMH, hs.Email, gv.HoTenGV)
  
 union
 (select mh.MaLMH, mh.TenLMH,mh.SoTien_tiet, hs.Email, gv.HoTenGV,case when 1=1 then @chuanop end as TinhTrang,sum(sotiet) as SoTietDiHoc, Sum(lh.Sotiet * mh.SoTien_tiet) as sotien
 from HOCSINH hs, LICHHOC lh, LOPMONHOC mh, DIEMDANH dd, GIAOVIEN gv 
 where hs.MaHS = dd.MaHS and lh.MaLichHoc = dd.MaLichHoc and dd.DiemDanh = N'Có' and lh.MaLMH = mh.MaLMH and gv.MaGV = mh.MaGV and lh.NgayHoc like @NAM+'-0'+@THANG+'%'
 and not exists (select *from HOADON hd,HOCSINH hs where  NgayNop like @NAM + '-0' +@THANG+'%' and Email = @TEN and hd.MaHS = hs.MaHS)
 group by mh.MaLMH,mh.SoTien_tiet, mh.TenLMH, hs.Email, gv.HoTenGV)
 ) as tb
 group by tb.MaLMH,tb.SoTien_tiet,tb.SoTietDiHoc,tb.HoTenGV,tb.TenLMH,tb.Email,tb.TinhTrang having tb.Email = @TEN

 END
GO
/****** Object:  StoredProcedure [dbo].[XEM_HOCPHIHS]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XEM_HOCPHIHS](@TEN NVARCHAR(30), @THANG varchar(5), @NAM varchar(5))
 AS
 BEGIN
 select tb.MaLMH,tb.TenLMH,tb.SoTietDiHoc,tb.SoTien_tiet,sum(sotien) as Tongtien 
 from (select mh.MaLMH, mh.TenLMH,mh.SoTien_tiet, hs.HoTenHS,sum(sotiet) as SoTietDiHoc, Sum(lh.Sotiet * mh.SoTien_tiet) as sotien
 from HOCSINH hs, LICHHOC lh, LOPMONHOC mh, DIEMDANH dd 
 where hs.MaHS = dd.MaHS and lh.MaLichHoc = dd.MaLichHoc and dd.DiemDanh = N'Có' and lh.MaLMH = mh.MaLMH  and lh.NgayHoc like @NAM+'-0'+@THANG+'%'  
 group by mh.MaLMH,mh.SoTien_tiet, mh.TenLMH, hs.HoTenHS) as tb 
 group by tb.MaLMH,tb.SoTien_tiet,tb.SoTietDiHoc,tb.TenLMH,tb.HoTenHS having tb.HoTenHS = @TEN
 END
GO
/****** Object:  StoredProcedure [dbo].[XEM_HOCPHInew]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[XEM_HOCPHInew](@TEN NVARCHAR(30), @THANG varchar(5), @NAM varchar(5))
 AS
 BEGIN
 declare @danop nvarchar(10) = N'Đã nộp'
 declare @chuanop nvarchar(10) = N'Chưa nộp'
 select tb.TenLMH,tb.TinhTrang,tb.SoTietDiHoc,tb.MaLMH,tb.HoTenGV,tb.SoTien_tiet,sum(sotien) as TongTien 
 from (
 (select mh.MaLMH, mh.TenLMH,mh.SoTien_tiet, hs.Email, gv.HoTenGV,case when 1=1 then @danop end as TinhTrang,sum(sotiet) as SoTietDiHoc, Sum(lh.Sotiet * mh.SoTien_tiet) as sotien
 from HOCSINH hs, LICHHOC lh, LOPMONHOC mh, DIEMDANH dd, GIAOVIEN gv 
 where hs.MaHS = dd.MaHS and lh.MaLichHoc = dd.MaLichHoc and dd.DiemDanh = N'Có' and lh.MaLMH = mh.MaLMH and gv.MaGV = mh.MaGV and lh.NgayHoc like @NAM+'-0'+@THANG+'%'
 and exists (select *from HOADON hd,HOCSINH hs where  NgayNop like @NAM + '-0' +@THANG+'%' and Email = @TEN and hd.MaHS = hs.MaHS)
 group by mh.MaLMH,mh.SoTien_tiet, mh.TenLMH, hs.Email, gv.HoTenGV)
  
 union
 (select mh.MaLMH, mh.TenLMH,mh.SoTien_tiet, hs.Email, gv.HoTenGV,case when 1=1 then @chuanop end as TinhTrang,sum(sotiet) as SoTietDiHoc, Sum(lh.Sotiet * mh.SoTien_tiet) as sotien
 from HOCSINH hs, LICHHOC lh, LOPMONHOC mh, DIEMDANH dd, GIAOVIEN gv 
 where hs.MaHS = dd.MaHS and lh.MaLichHoc = dd.MaLichHoc and dd.DiemDanh = N'Có' and lh.MaLMH = mh.MaLMH and gv.MaGV = mh.MaGV and lh.NgayHoc like @NAM+'-0'+@THANG+'%'
 and not exists (select *from HOADON hd,HOCSINH hs where  NgayNop like @NAM + '-0' +@THANG+'%' and Email = @TEN and hd.MaHS = hs.MaHS)
 group by mh.MaLMH,mh.SoTien_tiet, mh.TenLMH, hs.Email, gv.HoTenGV)
 ) as tb
 group by tb.MaLMH,tb.SoTien_tiet,tb.SoTietDiHoc,tb.HoTenGV,tb.TenLMH,tb.Email,tb.TinhTrang having tb.Email = @TEN

 END
GO
/****** Object:  StoredProcedure [dbo].[Xem_LichHoc]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Xem_LichHoc] (@Ten nvarchar(15)) as
begin
select MaLichHoc, NgayHoc, KipHoc, SoTiet, lh.MaLMH, gv.HoTenGV from LICHHOC lh, LOPMONHOC mh, GIAOVIEN gv
where lh.MaLMH = mh.MaLMH and lh.MaGV = gv.MaGV and mh.TenLMH = @Ten
end
GO
/****** Object:  StoredProcedure [dbo].[Xem_PHIEULUONG]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xem_PHIEULUONG] (
    @Ten nvarchar(20),
	@nam varchar(10),
	@thang varchar(10))
	as
	begin
select pl.NgayTra , pl.MaPL ,gv.DiaChi ,gv.Email  from dbo.GIAOVIEN gv, dbo.PHIEULUONG pl
where gv.HoTenGV = @Ten and pl.MaGV = gv.MaGV and pl.NgayTra like @nam + '-0' +@thang+'%' 
end
GO
/****** Object:  StoredProcedure [dbo].[XemLichDay]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemLichDay](@MaGV nchar(10), @TenMH nchar(30))
AS
BEGIN
	SELECT MaLichHoc, LICHHOC.MaLMH, NgayHoc, KipHoc, SoTiet, HoTenGV
	FROM dbo.LICHHOC, dbo.LOPMONHOC, dbo.GIAOVIEN
	WHERE GIAOVIEN.MaGV = LOPMONHOC.MaGV AND GIAOVIEN.MaGV = LICHHOC.MaGV AND LICHHOC.MaLMH = LOPMONHOC.MaLMH AND LICHHOC.MaGV = LOPMONHOC.MaGV
	      AND LICHHOC.MaGV = @MaGV AND dbo.LOPMONHOC.TenLMH LIKE '%'+RTRIM(@TenMH)+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[XemLopDayCuaGV]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemLopDayCuaGV](@MaGV nchar(10))
AS
BEGIN
	SELECT TenLMH FROM dbo.LOPMONHOC 
	WHERE MaGV = @MaGV
END
GO
/****** Object:  StoredProcedure [dbo].[XemLuong]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemLuong](@MaGV nchar(10), @thang int, @nam int)
AS
BEGIN
	SELECT MaPL, NgayTra, TenLMH, SoTien, SUM(SoTiet) AS SoTietDay, (SoTien*SUM(SoTiet)) AS TongTien
	FROM dbo.LOPMONHOC, dbo.LICHHOC, dbo.DINHMUC, dbo.GIAOVIEN, dbo.PHIEULUONG
	WHERE DINHMUC.MaDM = GIAOVIEN.MaDM AND GIAOVIEN.MaGV = LICHHOC.MaGV AND GIAOVIEN.MaGV = LOPMONHOC.MaGV AND LICHHOC.MaGV = LOPMONHOC.MaGV AND LICHHOC.MaLMH = LOPMONHOC.MaLMH AND GIAOVIEN.MaGV = PHIEULUONG.MaGV
		  AND MONTH(NgayHoc) = @thang AND YEAR(NgayHoc) = @nam AND GIAOVIEN.MaGV = @MaGV AND MONTH(NgayTra) = @thang AND YEAR(NgayTra) = @nam
GROUP BY MaPL, NgayTra, TenLMH, SoTien
END
GO
/****** Object:  StoredProcedure [dbo].[XoaGV]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaGV](@MaGV NCHAR(5))
AS
BEGIN
	--Xóa ở các bảng có liên quan trước
	DELETE dbo.PHIEULUONG WHERE MaGV = @MaGV
	DELETE dbo.LOPMONHOC WHERE MaGV = @MaGV
	DELETE dbo.LICHHOC WHERE MaGV = @MaGV
	--Xóa ở bảng GV
	DELETE dbo.GIAOVIEN WHERE MaGV = @MaGV 
END
GO
/****** Object:  StoredProcedure [dbo].[XoaHS]    Script Date: 5/8/2021 8:53:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------Procedure Xóa HS------------
CREATE PROC [dbo].[XoaHS](@MaHS NCHAR(5))
AS
BEGIN
	--Xóa ở các bảng có liên quan trước
	DELETE dbo.DIEMDANH WHERE MaHS = @MaHS
	DELETE dbo.HOADON WHERE MaHS = @MaHS
	--Xóa ở bảng GV
	DELETE dbo.HOCSINH WHERE MaHS = @MaHS
END
GO
