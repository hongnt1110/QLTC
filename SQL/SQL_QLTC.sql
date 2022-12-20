CREATE DATABASE QLTC

USE QLTC

set dateformat dmy;
SELECT FORMAT (getdate(), 'dd-MM-yyyy') as date
GO

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
	GiaBan money not null
	CONSTRAINT PK_PHIEUDT PRIMARY KEY (MaPhieuDT),
	CONSTRAINT FK_PHIEU_KH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	CONSTRAINT FK_PHIEU_CA FOREIGN KEY (MaCa) REFERENCES CA(MaCa),
	CONSTRAINT FK_PHIEU_SANH FOREIGN KEY (MaSanh) REFERENCES SANH(MaSanh)
)

CREATE TABLE CT_DICHVU(
	MaCT_DichVu	int identity(1,1) not null,
	MaDichVu	int,
	SoLuong int,
	MaPhieuDT	int not null,
	CONSTRAINT PK_CTDV PRIMARY KEY (MaCT_DichVu),
	CONSTRAINT FK_CTDV_DV FOREIGN KEY (MaDichVu) REFERENCES DICHVU(MaDichVu),
	CONSTRAINT FK_CTDV_PHIEU FOREIGN KEY (MaPhieuDT) REFERENCES PHIEUDATTIEC(MaPhieuDT)
)
CREATE TABLE CT_MONAN(
	MaCT_MonAn	int identity(1,1) not null,
	MaMonAn int,
	MaPhieuDT	int not null,	

	CONSTRAINT PK_CTMA PRIMARY KEY (MaCT_MonAn),
	CONSTRAINT FK_CTMA_MA FOREIGN KEY (MaMonAn) REFERENCES MONAN(MaMonAn),
	CONSTRAINT FK_CTMA_PHIEU FOREIGN KEY (MaPhieuDT) REFERENCES PHIEUDATTIEC(MaPhieuDT)
)
CREATE TABLE HOADON(
	MaHoaDon	int identity(1,1) not null,
	NgayThanhToan	date,
	TongTienHD	money,
	TienConLai	money,
	MaPhieuDT	int,
	CONSTRAINT PK_HOADON PRIMARY KEY (MaHoaDon),
	CONSTRAINT FK_HD_PHIEU FOREIGN KEY (MaPhieuDT) REFERENCES PHIEUDATTIEC(MaPhieuDT)
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

/*thêm khách hàng*/
insert into KHACHHANG values ('Nam', 'TP HCM', '00000000')
insert into KHACHHANG values (N'Nữ', 'TP HCM', '023232100')
insert into KHACHHANG values (N'Hải', N'Thanh Hóa', '0123213423')
select*from KHACHHANG

/*thêm ca*/
insert into CA values ('Trưa', '12H00 - 15H00')
insert into CA values (N'Tối', '18H00 - 21H00')
select *from CA

/*Thêm loại sảnh*/
insert into LOAISANH values ('A', 10000000)
insert into LOAISANH values ('B', 20000000)
insert into LOAISANH values ('C', 30000000)
insert into LOAISANH values ('D', 40000000)
insert into LOAISANH values ('E', 40000000)
select *from LOAISANH
/*thêm sảnh */
insert into SANH values ('Rose',1,100, 1000000, N'Trống')
insert into SANH values ('Tulip',2,120, 1100000, N'Trống')
insert into SANH values ('Purple',3,150, 1200000, N'Trống')
insert into SANH values ('Pink',4,100, 1400000, N'Trống')
insert into SANH values ('Red',5,150, 1200000, N'Trống')
select *from SANH

/*Thêm món ăn*/
insert into MONAN values (N'Mì cay', 50000)
insert into MONAN values (N'Lẩu hải sản', 1000000)
insert into MONAN values (N'Lẩu chua cay', 1000000)
insert into MONAN values (N'Gà nướng', 1200000)
insert into MONAN values (N'Gà luộc', 1000000)
insert into MONAN values (N'Cua luộc', 1000000)
insert into MONAN values (N'Cua nướng', 1000000)

/*Thêm dịch vụ*/
insert into DICHVU values (N'Màn hoa tươi', 2000000)
insert into DICHVU values (N'Cổng hoa tươi', 5000000)
insert into DICHVU values (N'Backdrop và Background đặc biệt', 10000000)
insert into DICHVU values (N'Tranh cát', 1200000)
insert into DICHVU values (N'Bàn lễ tân đặc biệt', 10000000)
insert into DICHVU values (N'Quà đáp lễ', 5000000)
insert into DICHVU values (N'Thiệp cưới', 8000000)
insert into DICHVU values (N'Truyền hình trực tiếp', 20000000)
/*thêm phiếu đặt tiệc*/
insert into PHIEUDATTIEC values (2,'18/02/2002','4','4',2,45,23,3,3544)
select *from PHIEUDATTIEC


/*Trigger tự động thêm hóa đơn mỗi khi thêm phiếu đặt tiệc*/



/*Trigger tự động thêm chi tiết dịch vụ mỗi khi thêm phiếu đặt tiệc*/
/*create trigger CTDV_PHIEUDATTIEC_INSERT
on PHIEUDATTIEC
for insert
as
begin
	--Xác định biến
	declare @MaPhieuDatTiec int
	--Gán giá trị cho biến
	select @MaPhieuDatTiec = MaPhieuDT from inserted
	insert into CT_DICHVU (MaPhieuDT,MaDichVu) values (@MaPhieuDatTiec, null)
	print ('Da tu dong them vao CTDV')
end*/


/*Trigger tự động thêm chi tiết món ăn mỗi khi thêm phiếu đặt tiệc*/
/*create trigger CTMA_PHIEUDATTIEC_INSERTCTMA
on PHIEUDATTIEC
for insert
as
begin
	--Xác định biến
	declare @MaPhieuDatTiec int
	--Gán giá trị cho biến
	select @MaPhieuDatTiec = MaPhieuDT from inserted
	insert into CT_MONAN (MaPhieuDT,MaMonAn) values (@MaPhieuDatTiec, null)
	print ('Da tu dong them vao CTMA')
end*/


create trigger HD_PHIEUDATTIEC_INSERTHD
on PHIEUDATTIEC
for insert
as
begin
	--Xác định biến
	declare @MaPhieuDatTiec int,@TongTienHoaDon money, @TienConLai money
	--Gán giá trị cho biến
	select @TongTienHoaDon = inserted.GiaBan*inserted.SoLuongBan + LOAISANH.DonGia from inserted, SANH, LOAISANH,DICHVU,CT_DICHVU,MONAN,CT_MONAN where inserted.MaSanh = SANH.MaSanh 
	and SANH.MaLoaiSanh = LOAISANH.MaLoaiSanh 

	select @TienConLai = @TongTienHoaDon - inserted.TienCoc from inserted
	insert into HOADON values (null, @TongTienHoaDon,@TienConLai,@MaPhieuDatTiec)
	print ('Da tu dong them hoa don')
end

select * from HOADON
select *from CT_DICHVU
select *from HOADON
select *from DICHVU

insert into HOADON values ('16/12/2022',1000,500,1)
insert into HOADON values ('16/12/2022',1111,555,2)
insert into HOADON values ('17/12/2022',2000,500,1)
insert into HOADON values ('16/11/2022',2000,500,1)
insert into HOADON values ('16/11/2022',1511,555,2)
insert into HOADON values ('17/11/2022',4600,500,1)
insert into HOADON values ('16/10/2022',1000,500,1)
insert into HOADON values ('16/10/2022',6111,555,2)
insert into HOADON values ('17/10/2022',9000,500,1)

insert into HOADON values ('18/12/2022',1000,500,1)
insert into HOADON values ('14/12/2022',1111,555,2)
insert into HOADON values ('11/12/2022',2000,500,1)
insert into HOADON values ('9/12/2022',2000,500,1)
insert into HOADON values ('1/12/2022',1511,555,2)
insert into HOADON values ('17/12/2022',4600,500,1)
insert into HOADON values ('16/12/2022',1000,500,1)
insert into HOADON values ('19/12/2022',6111,555,2)
insert into HOADON values ('31/12/2022',9000,500,1)