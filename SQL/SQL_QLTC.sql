CREATE DATABASE QLTC

USE QLTC

CREATE TABLE TAIKHOAN(
	TenTaiKhoan varchar(50) not null,
	MatKhau varchar(50) not null,
	Email varchar(50) not null,
	CONSTRAINT PK_TAIKHOAN PRIMARY KEY (TenTaiKhoan)
)
CREATE TABLE LOAISANH(
	MaLoaiSanh int identity(1,1) not null,
	LoaiSanh nvarchar(100) not null,
	DonGia money not null,
	CONSTRAINT PK_LOAISANH PRIMARY KEY (MaLoaiSanh)
) 
CREATE TABLE SANH(
	MaSanh int identity(1,1) not null,
	TenSanh nvarchar(100) not null,
	MaLoaiSanh int not null,
	SoLuongBanToiDa int not null,
	DonGiaBanToiThieu money not null,
	Ghichu nvarchar(100) default N'Trống',
	CONSTRAINT PK_SANH PRIMARY KEY (MaSanh),
	CONSTRAINT FK_SANH_LOAI FOREIGN KEY (MaLoaiSanh) REFERENCES LOAISANH(MaLoaiSanh)
)
CREATE TABLE MONAN(
	MaMonAn int identity(1,1) not null,
	TenMonAn nvarchar(100) not null,
	DonGia money not null,
	CONSTRAINT PK_MONAN PRIMARY KEY (MaMonAn)
) 
CREATE TABLE DICHVU(
	MaDichVu int identity(1,1) not null,
	TenDichVu nvarchar(100) not null,
	DonGia money not null,
	CONSTRAINT PK_DICHVU PRIMARY KEY (MaDichVu)
) 
CREATE TABLE CA(
	MaCa	int identity(1,1) not null,
	LoaiCa	nvarchar (50) not null,
	ThoiGian	nvarchar (50) not null,
	CONSTRAINT PK_Ca PRIMARY KEY (MaCa)
)
CREATE TABLE KHACHHANG(
	MaKH	int identity(1,1) not null,
	TenKH	nvarchar(50) not null,
	DiaChi	nvarchar(300) not null,
	SoDienThoai	varchar(11) not null,
	CONSTRAINT PK_KHACHHANG PRIMARY KEY (MaKH)
)
CREATE TABLE PHIEUDATTIEC(
	MaPhieuDT	int identity(1,1) not null,
	MaKH	int not null,
	NgayDaiTiec	date not null,
	TenChuRe nvarchar (50) not null,
	TenCoDau nvarchar (50) not null,
	MaSanh	int not null,
	TienCoc	money not null,
	SoLuongBan	int not null,
	MaCa	int not null,
	CONSTRAINT PK_PHIEUDT PRIMARY KEY (MaPhieuDT),
	CONSTRAINT FK_PHIEU_KH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	CONSTRAINT FK_PHIEU_CA FOREIGN KEY (MaCa) REFERENCES CA(MaCa)
)
CREATE TABLE CT_DICHVU(
	MaCT_DichVu	int identity(1,1) not null,
	MaDichVu	int not null,
	MaPhieuDT	int not null,
	DonGia	money not null,
	CONSTRAINT PK_CTDV PRIMARY KEY (MaCT_DichVu),
	CONSTRAINT FK_CTDV_DV FOREIGN KEY (MaDichVu) REFERENCES DICHVU(MaDichVu),
	CONSTRAINT FK_CTDV_PHIEU FOREIGN KEY (MaPhieuDT) REFERENCES PHIEUDATTIEC(MaPhieuDT)
)
CREATE TABLE CT_MONAN(
	MaCT_MonAn	int identity(1,1) not null,
	MaMonAn	int not null,
	MaPhieuDT	int not null,
	DonGia	money not null,
	CONSTRAINT PK_CTMA PRIMARY KEY (MaCT_MonAn),
	CONSTRAINT FK_CTMA_MA FOREIGN KEY (MaMonAn) REFERENCES MONAN(MaMonAn),
	CONSTRAINT FK_CTMA_PHIEU FOREIGN KEY (MaPhieuDT) REFERENCES PHIEUDATTIEC(MaPhieuDT)
)
CREATE TABLE HOADON(
	MaHoaDon	int identity(1,1) not null,
	NgayThanhToan	date not null,
	TongTienHD	money not null,
	TienConLai	money not null,
	CONSTRAINT PK_HOADON PRIMARY KEY (MaHoaDon),
)
CREATE TABLE CT_HOADON(
	MaCT_HoaDon	int identity(1,1) not null,
	MaHoaDon	int not null,
	MaPhieuDT	int not null,
	CONSTRAINT PK_CTHD PRIMARY KEY (MaCT_HoaDon),
	CONSTRAINT FK_CTHD_HD FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
	CONSTRAINT FK_CTHD_PHIEU FOREIGN KEY (MaPhieuDT) REFERENCES PHIEUDATTIEC(MaPhieuDT)
)
CREATE TABLE DOANHSO(
	MaDoanhSo int identity(1,1) not null,
	NgayLap	date not null,
	Thang int not null,
	TongDoanhThu money not null,
	CONSTRAINT PK_DOANHSO PRIMARY KEY (MaDoanhSo)
)
CREATE TABLE CT_DOANHSO(
	MaCT_DoanhSo int identity(1,1) not null,
	MaDoanhSo int not null,
	MaHoaDon int not null,
	SoLuongTiecCuoi	int not null,
	TiLe float,
	CONSTRAINT PK_CTDS PRIMARY KEY (MaCT_DoanhSo),
	CONSTRAINT FK_CTDS_DS FOREIGN KEY (MaDoanhSo) REFERENCES DOANHSO(MaDoanhSo),
	CONSTRAINT FK_CTDS_HOADON FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon)
)
CREATE TABLE THAMSO(
	TenThamSo	nvarchar(100),
	GiaTri	int,
	CONSTRAINT PK_THAMSO PRIMARY KEY (TenThamSo)
)
Insert into THAMSO VALUES('ApDungQuyDinhPhat',1);
Insert into THAMSO VALUES('TiLePhat',0.01);
