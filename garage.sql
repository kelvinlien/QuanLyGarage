use Karaoke

CREATE PROCEDURE ThemKhachHang
	@TenKH varchar(30),
	@DienThoai varchar(10),
	@DiaChi varchar(100),
	@TienNo int
AS
BEGIN
	DECLARE @test int
	SELECT @test=COUNT(MaKH) FROM KHACHHANG WHERE (@TenKH = TenKH) and (@DienThoai = DienThoai) 
	if @test = 0
	BEGIN
		DECLARE @imakh int
		SELECT @imakh = MAX(MaKH) from KHACHHANG
		SET @imakh = @imakh + 1
		INSERT INTO KHACHHANG (MaKH, TenKH, DiaChi, DienThoai, TienNo) VALUES (@imakh, @TenKH, @DiaChi,@DienThoai, @TienNo)
	END
END;
drop procedure ThemXe
CREATE PROCEDURE ThemXe
	@BienSo varchar(10) ,
	@HieuXe int,
	@MaKH int,
	@NgaySuaChua datetime
AS
BEGIN
	INSERT INTO Xe (BienSo, MaHX, MaKH, NgaySuaChua, TrangThai) VALUES (@BienSo, @HieuXe, @MaKH,@NgaySuaChua, 1)
END;
select * from KhachHang
delete from KHACHHANG where MaKH = 6
create table TAIKHOAN
(
	TenDangNhap varchar(20) PRIMARY KEY,
	MatKhau varchar(20),
	QuyenHan varchar(20)
)
create table XE
(
	BienSo varchar(10) PRIMARY KEY,
	MaHX int FOREIGN KEY REFERENCES HIEUXE(MaHX),
	MaKH int FOREIGN KEY REFERENCES KHACHHANG(MaKH),
	NgaySuaChua datetime,
)

create table HIEUXE
(
	MaHX int PRIMARY KEY,
	TenHieuXe varchar(30)
)
insert into HIEUXE values('1','Dream')
insert into HIEUXE values('2','Innova')
insert into HIEUXE values('3','Honda')
delete from HIEUXE 
insert into XE values('8337','1','1','6/2/2019')
insert into XE values('8338','2','2','5/2/2019')
insert into XE values('8339','3','3','4/2/2019')
insert into XE values('8340','3','4','3/2/2019')
insert into KHACHHANG values('1','Tran Kim Trung','1','QN','1000')
insert into KHACHHANG values('2','Tran Thi Kim Dung','2','QN','2000')
insert into KHACHHANG values('3','Ta Thi Thu Lieu','3','QN','3000')
insert into KHACHHANG values('4','Tran Kim Ngoc','4','QN','0')
create table KHACHHANG
(
	MaKH int PRIMARY KEY,
	TenKH varchar(30),
	DienThoai varchar(10),
	DiaChi varchar(100),
	TienNo int
)
use garage
SELECT MaKH FROM KHACHHANG WHERE TenKH = 'Tran Kim Trung' and DienThoai = '1'
create table PHIEUSUACHUA
(
	MaPhieuSuaChua int PRIMARY KEY,
	BienSo varchar(10) FOREIGN KEY REFERENCES XE(BienSo),
	MaKH int FOREIGN KEY REFERENCES KHACHHANG(MaKH),
	TienCong int,
	TienPhuTung int,
	TongTien int,
)

create table TIENCONG
(
	MaTC int PRIMARY KEY,
	TenTienCong varchar(100),
	ChiPhi int,
)

create table CHITIETPHIEUSUACHUA
(
	MaPhieuSuaChua int FOREIGN KEY REFERENCES PHIEUSUACHUA(MaPhieuSuaChua),
	MaTC int FOREIGN KEY REFERENCES TIENCONG(MaTC),
	MaPhuTung int FOREIGN KEY REFERENCES KHO(MaPhuTung)
)

create table KHO
(
	MaPhuTung int PRIMARY KEY,
	TenVatTuPhuTung varchar(30),
	SoLuong int,
	DonGia int
)

create table PHIEUTHUTIEN
(
	MaPhieuThuTien int PRIMARY KEY,
	MaKH int FOREIGN KEY REFERENCES KHACHHANG(MaKH),
	TienThu int,
)

CREATE PROCEDURE ThemPhieuThuTien
	@BienSo varchar(10),
	@TienThu int,
	@NgayThuTien datetime
AS
BEGIN
		DECLARE @imaptt int
		DECLARE @MaKH int
		SELECT @imaptt = COUNT(MaPhieuThuTien) from PHIEUTHUTIEN
		SET @imaptt = @imaptt + 1
		SELECT @MaKH = MaKH FROM XE WHERE XE.BienSo = @BienSo
		INSERT INTO PHIEUTHUTIEN (MaPhieuThuTien, MaKH, TienThu, NgayThuTien) VALUES (@imaptt, @MaKH, @TienThu, @NgayThuTien)
		UPDATE KHACHHANG SET TienNo = TienNo - @TienThu WHERE MaKH = @MaKH
END


CREATE TABLE [dbo].[THAMSO] (
    [MaThamSo]  VARCHAR (5)  NOT NULL,
    [TenThamSo] VARCHAR (50) NULL,
    [GiaTri]    INT          NULL,
    PRIMARY KEY CLUSTERED ([MaThamSo] ASC)
);
INSERT INTO [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS1', N'So hieu xe', 10)
INSERT INTO [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS2', N'So xe sua chua toi da', 30)
INSERT INTO [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS3', N'So loai vat tu', 200)
INSERT INTO [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS4', N'So loai tien cong', 100)

select * from THAMSO
delete from khachhang where makh = 6

create procedure NhapVTPT
	@MaPhuTung int,
	@SoLuong int
AS
BEGIN
	UPDATE KHO SET SoLuong = SoLuong + @SoLuong WHERE MaPhuTung = @MaPhuTung
END
create procedure NhapMoiVTPT
	@TenPhuTung varchar(30),
	@SoLuong int,
	@DonGia int
AS
BEGIN
	DECLARE @iMVTPT int
	SELECT @iMVTPT = COUNT(MaPhuTung) FROM KHO
	SET @iMVTPT = @iMVTPT + 1
	INSERT INTO KHO (MaPhuTung, TenVatTuPhuTung, SoLuong, DonGia) VALUES (@iMVTPT, @TenPhuTung, @SoLuong, @DonGia)
END
create procedure TimKiemTuongDoi
	@DuLieu varchar(100)
AS
BEGIN
	SELECT BienSo, TenHieuXe, TenKH, DienThoai, DiaChi
	FROM XE, HIEUXE as HX, KHACHHANG as KH
	WHERE XE.MaHX = HX.MaHX and KH.MaKH = XE.MaKH and ((BienSo LIKE '%'+@DuLieu+'%') or (TenHieuXe LIKE '%'+@DuLieu+'%') or (TenKH LIKE '%'+@DuLieu+'%') or (DienThoai LIKE '%'+@DuLieu+'%') or (DiaChi LIKE '%'+@DuLieu+'%'))
END
TimKiemChinhXac 8338 , 'Innova'
create procedure TimKiemChinhXac
	@BienSo varchar(10),
	@HieuXe varchar(30)
AS
BEGIN
	SELECT BienSo, TenHieuXe, TenKH, DienThoai, DiaChi
	FROM XE, HIEUXE as HX, KHACHHANG as KH
	WHERE XE.MaHX = HX.MaHX and KH.MaKH = XE.MaKH and @BienSo = XE.BienSo and @HieuXe = HX.TenHieuXe 
END
drop procedure TimKiemChinhXac
create procedure BaoCaoDoanhThu
		@Thang int,
		@Nam int
AS
BEGIN
	select HX.TenHieuXe, COUNT(PSC.MaPhieuSuaChua) as 'Số Lượt Sửa', SUM(PTT.TienThu) as 'Chi Phí', (COUNT(PSC.MaPhieuSuaChua)*100/(SELECT Count(*) FROM  PHIEUTHUTIEN as PTT, PHIEUSUACHUA as PSC where  PTT.MaKH = PSC.MaKH and Month(PTT.NgayThuTien) = @Thang and YEAR(PTT.NgayThuTien) = @Nam) ) as 'Tỉ Lệ'
	FROM KHACHHANG as KH, XE, HIEUXE as HX, PHIEUTHUTIEN as PTT, PHIEUSUACHUA as PSC
	WHERE KH.MaKH = XE.MaKH and XE.MaHX = HX.MaHX and PTT.MaKH = KH.MaKH and PSC.BienSo = Xe.BienSo and Month(PTT.NgayThuTien) = @Thang and YEAR(PTT.NgayThuTien) = @Nam
	Group by HX.TenHieuXe
END
drop procedure BaoCaoDoanhThu

create procedure TongTienDoanhThu
		@Thang int,
		@Nam int
AS
BEGIN
	select sum(PTT.TienThu)
	from PHIEUTHUTIEN as PTT
	WHERE Month(PTT.NgayThuTien) = @Thang and YEAR(PTT.NgayThuTien) = @Nam
END
BaoCaoDoanhThu 6 ,2019
TongTienDoanhThu 6, 2019
select * from PHIEUTHUTIEN
select *from PHIEUSUACHUA

drop procedure NhapVTPT

create table PHIEUNHAPVTPT
(
	MaPNVTPT int PRIMARY KEY,
	MaPhuTung int,
	SoLuong int,
	ThoiDiem datetime
)
drop procedure NhapVTPT
create procedure NhapVTPT
	@MaPhuTung int,
	@SoLuong int,
	@ThoiDiem datetime
AS
BEGIN
	DECLARE @iMPNVTPT int
	SELECT @iMPNVTPT = COUNT(MaPNVTPT) FROM PHIEUNHAPVTPT
	SET @iMPNVTPT = @iMPNVTPT + 1
	INSERT INTO PHIEUNHAPVTPT (MaPNVTPT, MaPhuTung, SoLuong, ThoiDiem) VALUES (@iMPNVTPT, @MaPhuTung, @SoLuong, @ThoiDiem)
	UPDATE KHO SET SoLuong = SoLuong + @SoLuong WHERE MaPhuTung = @MaPhuTung
END

drop procedure NhapMoiVTPT
create procedure NhapMoiVTPT
	@TenPhuTung varchar(30),
	@SoLuong int,
	@DonGia int
AS
BEGIN
	DECLARE @iMVTPT int
	SELECT @iMVTPT = COUNT(MaPhuTung) FROM KHO
	SET @iMVTPT = @iMVTPT + 1
	INSERT INTO KHO (MaPhuTung, TenVatTuPhuTung, SoLuong, DonGia) VALUES (@iMVTPT, @TenPhuTung, @SoLuong, @DonGia)
END
drop procedure ThemPhieuThuTien
CREATE PROCEDURE ThemPhieuThuTien
	@BienSo varchar(10),
	@TienThu int,
	@NgayThuTien datetime
AS
BEGIN
		DECLARE @imaptt int
		DECLARE @MaKH int
		SELECT @imaptt = COUNT(MaPhieuThuTien) from PHIEUTHUTIEN
		SET @imaptt = @imaptt + 1
		SELECT @MaKH = MaKH FROM XE WHERE XE.BienSo = @BienSo
		INSERT INTO PHIEUTHUTIEN (MaPhieuThuTien, MaKH, TienThu, NgayThuTien) VALUES (@imaptt, @MaKH, @TienThu, @NgayThuTien)
		UPDATE KHACHHANG SET TienNo = TienNo - @TienThu WHERE MaKH = @MaKH
END
drop procedure ThemKhachHang
CREATE PROCEDURE ThemKhachHang
	@TenKH varchar(30),
	@DienThoai varchar(10),
	@DiaChi varchar(100),
	@TienNo int
AS
BEGIN
	DECLARE @test int
	SELECT @test=COUNT(MaKH) FROM KHACHHANG WHERE (@TenKH = TenKH) and (@DienThoai = DienThoai) 
	if @test = 0
	BEGIN
		DECLARE @imakh int
		SELECT @imakh = MAX(MaKH) from KHACHHANG
		SET @imakh = @imakh + 1
		INSERT INTO KHACHHANG (MaKH, TenKH, DiaChi, DienThoai, TienNo) VALUES (@imakh, @TenKH, @DiaChi,@DienThoai, @TienNo)
	END
END;

create table BAOCAOTON
(
	MaBCT int PRIMARY KEY,
	ThoiDiemBaoCao datetime
)

create table CT_BAOCAOTON
(
	MaBCT int not null,
	MaPhuTung int not null,
	TonDau int,
	PhatSinh int,
	TonCuoi int
)
drop table BAOCAOTON
drop table CT_BAOCAOTON
alter table CT_BAOCAOTON add constraint pk_ctBCT primary key (MaBCT, MaPhuTung)

insert into BAOCAOTON 

select * from (XE join KHACHHANG on XE.MaKH = KHACHHANG.MaKH) join HIEUXE on XE.MaHX = HIEUXE.MaHX

create procedure DoiMK
	@MaTK int,
	@MatKhauMoi varchar(20)
AS
BEGIN
	UPDATE TAIKHOAN
	SET MatKhau = @MatKhauMoi 
	WHERE MaTK = @MaTK
END

create table TAIKHOAN
(
	MaTK int PRIMARY KEY,
	TenChuTaiKhoan varchar(20),
	TenDangNhap varchar(20),
	MatKhau varchar(20),
	QuyenHan varchar(20)
)
drop table TAIKHOAN

CREATE PROCEDURE ThemXe
	@BienSo varchar(10) ,
	@HieuXe int,
	@MaKH int,
	@NgayTiepNhan datetime
AS
BEGIN
	INSERT INTO Xe (BienSo, MaHX, MaKH, NgayTiepNhan, TrangThai) VALUES (@BienSo, @HieuXe, @MaKH,@NgayTiepNhan, 1)
END;

drop procedure ThemXe
