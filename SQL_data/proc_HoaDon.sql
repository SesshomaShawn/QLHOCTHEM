use QLHOCTHEM
go

create proc sp_HoaDon_HS (@thang varchar(5), @nam varchar(5))
as
begin
	declare @MaHS char(10), @HocPhi bigint, @NgayXuat date, @STT int, @NgayNop date, @TinhTrang nvarchar(10), @day int, @ngay varchar(2)
	set @TinhTrang = N'Đã nộp'
	set @NgayXuat=convert(date, @nam+'-'+@thang+'-25')
	--set @NgayNop = convert(date, @nam+'-'+@thang+'-'+@ngay)
	select @STT= count(*) from HOADON

	declare con_tro cursor for
	select BangHocPhi.MaHS, BangHocPhi.HocPhi
	from
	(
		select TK.MaHS, TK.HoTenHS, sum(sotien) as HocPhi
		from 
		(
			select HS.MaHS, HoTenHS, Sum(LH.Sotiet * DML.SoTien) as sotien
			from HOCSINH HS,LICHHOC LH,LOPHOC LOP, DIEMDANH DD, DINHMUCLOP DML
			where HS.MaHS = DD.MaHS and LH.MaLichHoc = DD.MaLichHoc 
			and DD.DiemDanh = N'Có' and LH.MaLMH = LOP.MaLMH 
			and year(LH.NgayHoc) = @nam and month(LH.NgayHoc) = @thang and LOP.MaDML = DML.MaDML
			group by HS.MaHS, HoTenHS, LOP.TenLMH
		) as TK
		group by TK.MaHS, TK.HoTenHS
	) as BangHocPhi
	open con_tro
	fetch next from con_tro into @MaHS, @HocPhi
	while @@FETCH_STATUS=0
		begin 
			set @STT=@STT+1
			set @day = FLOOR(RAND()*(28-25+1)+25)
			set @ngay = cast(@day as varchar(2))
			set @NgayNop = convert(date, @nam+'-'+@thang+'-'+@ngay)
			insert into HOADON (MaHD,NgayNop, NgayXuat, SoTienNop,TinhTrang, MaHS)
			values ('HD'+RIGHT('000'+cast(@STT as varchar(3)),3),@NgayNop, @NgayXuat, @HocPhi,@TinhTrang, @MaHS)
			fetch next from con_tro into @MaHS, @HocPhi
		end 

	close con_tro
	deallocate con_tro
end

go
delete from HOADON
exec sp_HoaDon_HS '02','2021'
exec sp_HoaDon_HS '03','2021'
exec sp_HoaDon_HS '04','2021'
exec sp_HoaDon_HS '05','2021'

SELECT * FROM dbo.HOADON

update HOADON
set NgayNop = null , TinhTrang = N'Chưa nộp'
where MaHD in ('HD002','HD189','HD150', 'HD400','HD483','HD510', 'HD660', 'HD743','HD288')

/*
go
create proc set_data_HD
as
begin
	declare  @day int, @ngay varchar
	set @day = FLOOR(RAND()*(28-25+1)+25)
	set @ngay = cast(@day as varchar(2))
	
	declare cur_tro cursor for
	open cur_tro
	fetch next from cur_tro into @ngay
	while @@FETCH_STATUS=0
		begin 
			insert into HOADON(
			fetch next from con_tro into @MaHS, @HocPhi
		end 

	close cur_tro
	deallocate cur_tro
end
go
create proc sp_HoaDon_HS1 (@thang varchar(5), @nam varchar(5))
as
begin
	declare @MaHS char(10), @HocPhi bigint, @NgayXuat date, @STT int, @NgayNop date, @TinhTrang nvarchar(10), @day int, @ngay varchar(2)
	set @NgayXuat=convert(date, @nam+'-'+@thang+'-25')
	--set @NgayNop = convert(date, @nam+'-'+@thang+'-'+@ngay)
	select @STT= count(*) from HOADON

	declare con_tro cursor for
	select BangHocPhi.MaHS, BangHocPhi.HocPhi
	from
	(
		select TK.MaHS, TK.HoTenHS, sum(sotien) as HocPhi
		from 
		(
			select HS.MaHS, HoTenHS, Sum(LH.Sotiet * DML.SoTien) as sotien
			from HOCSINH HS,LICHHOC LH,LOPHOC LOP, DIEMDANH DD, DINHMUCLOP DML
			where HS.MaHS = DD.MaHS and LH.MaLichHoc = DD.MaLichHoc 
			and DD.DiemDanh = N'Có' and LH.MaLMH = LOP.MaLMH 
			and year(LH.NgayHoc) = @nam and month(LH.NgayHoc) = @thang and LOP.MaDML = DML.MaDML
			group by HS.MaHS, HoTenHS, LOP.TenLMH
		) as TK
		group by TK.MaHS, TK.HoTenHS
	) as BangHocPhi
	open con_tro
	fetch next from con_tro into @MaHS, @HocPhi
	while @@FETCH_STATUS=0
		begin 
			
			set @STT=@STT+1
			set @day = FLOOR(RAND()*(29-25+1)+25)
			/*set @ngay = cast(@day as varchar(2))
			set @NgayNop = convert(date, @nam+'-'+@thang+'-'+@ngay)
			set @TinhTrang = N'Đã nộp'*/
			if (@day = 29)
				insert into HOADON (MaHD,NgayXuat, SoTienNop,TinhTrang, MaHS)
				values ('HD'+RIGHT('000'+cast(@STT as varchar(3)),3),@NgayXuat, @HocPhi,N'Chưa nộp', @MaHS)
			else
				set @ngay = cast(@day as varchar(2))
				set @NgayNop = convert(date, @nam+'-'+@thang+'-'+@ngay)
				set @TinhTrang = N'Đã nộp'
				insert into HOADON (MaHD,NgayNop, NgayXuat, SoTienNop,TinhTrang, MaHS)
				values ('HD'+RIGHT('000'+cast(@STT as varchar(3)),3),@NgayNop, @NgayXuat, @HocPhi,@TinhTrang, @MaHS)
			fetch next from con_tro into @MaHS, @HocPhi
		end 

	close con_tro
	deallocate con_tro
end

go
delete from HOADON
exec sp_HoaDon_HS1 '02','2021'
exec sp_HoaDon_HS1 '03','2021'
exec sp_HoaDon_HS1 '04','2021'
exec sp_HoaDon_HS1 '05','2021'

drop proc sp_HoaDon_HS1


go 
update HOADON
set NgayNop = null , TinhTrang = N'Chưa nộp'
where MaHD in ('HD002','HD188','HD150', 'HD400','HD483','HD510', 'HD660', 'HD743')

select * from HOADON
where TinhTrang = N'Chưa nộp'
*/