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

CREATE PROCEDURE ThemXe
	@BienSo varchar(10) ,
	@HieuXe varchar(20),
	@MaKH int,
	@NgaySuaChua datetime
AS
BEGIN
	DECLARE @iMaHX int
	SELECT @iMaHX = MaHX from HIEUXE where @HieuXe = TenHieuXe
	INSERT INTO Xe (BienSo, MaHX, MaKH, NgaySuaChua) VALUES (@BienSo, @iMaHX, @MaKH,@NgaySuaChua)
END;

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

create table KHACHHANG
(
	MaKH int PRIMARY KEY,
	TenKH varchar(30),
	DienThoai varchar(10),
	DiaChi varchar(100),
	TienNo int
)

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














