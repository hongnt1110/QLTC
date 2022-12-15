CREATE DATABASE QLTC

USE QLTC

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