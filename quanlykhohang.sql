use master;
go

if DB_ID('QuanLyKho') is not null
	drop database QuanLyKho;
go

create database QuanLyKho;
go

use QuanLyKho;
go

--tạo bảng :

--Nhóm hàng hóa
create table nhomhanghoa
	(tennhomhang  varchar(8) not null,
	constraint pk_nhomhanghoa primary key (tennhomhang)

	);

-- NHà cung cấp
	create table nhacungcap
	(
	mancc  varchar(8) not null,
	tenncc  varchar(20) not null,
	diachincc varchar(20) not null,
	sotk   varchar(12),
	constraint pk_nhacungcap primary key (mancc)
	);

	--Bộ phận nhân viên
	create table bophannv
	(
	mabophan  varchar(8) not null,
	tenbophan  varchar(20),
	constraint pk_bophannv primary key (mabophan)
	);


	--Kho hàng
	create table kho
	(
	makho   varchar(8) not null,
	tenkho  varchar(20),
	constraint pk_kho primary key (makho),
	);

	--Thủ kho
	create table thukho
	(
	mathukho  varchar(8) not null,
	tenthukho varchar(20) not null,
	diachi  varchar(20) ,
        sex  varchar(10),
	mabophan  varchar(8) not null,
	constraint pk_thukho primary key (mathukho),
constraint ck_thukho unique (mabophan)
	);


		--Nhân viên
	create table nhanvien
	(
	manhanvien varchar(8) not null,
	tennv   varchar(20) not null,
	mabophan  varchar(8) not null,
        sex varchar(10),
        diachi  varchar(20),
constraint pk_nhanvien primary key (manhanvien),
constraint ck_nhanvien unique (mabophan)
	);


	--Hàng hóa 
create table hanghoa
	(tenhang   varchar(20) ,   
	 mahang	   varchar(8) not null,
	 tennhomhang		varchar(8),
	 makho  varchar (8)  not null,
	constraint pk_hanghoa primary key (mahang),
constraint ck_hanghoa unique (tennhomhang,makho)
	);



	--Phiếu nhập
	create table phieunhap
	(
	maphieunhap  varchar(8) not null,
	ngaynhap     date not null,
	mathukho  varchar(8) not null,
	mancc  varchar(8) not null,
        soluong   int,
	mahang	   varchar(8) not null,
	constraint pk_phieunhap primary key (maphieunhap),
constraint ck_phieunhap unique (mathukho,mancc,mahang)
	);


	--Phiếu xuất
	create table phieuxuat
	(
	maphieuxuat  varchar(8) not null,
	ngayxuat     date not null,
	mathukho  varchar(8) not null,
	mahang	   varchar(8) not null,
        soluong   int,
	manhanvien   varchar(8) not null,
	constraint pk_phieuxuat primary key (maphieuxuat),
constraint ck_phieuxuat unique (mathukho,mahang,manhanvien)
		);



go


		---------------------------
alter table hanghoa
 with nocheck add constraint fk_hoanghoa_nhomhang
foreign key (tennhomhang) references nhomhanghoa(tennhomhang);

go
alter table hanghoa
 with nocheck add constraint fk_hoanghoa_kho
foreign key (makho) references kho(makho);

go
alter table hanghoa
check constraint fk_hoanghoa_nhomhang;

go
alter table hanghoa
check constraint fk_hoanghoa_kho;
	go	
		
		---------------------------

alter table thukho
 with nocheck add constraint fk_thukho_bophannv
foreign key (mabophan) references bophannv(mabophan);
go

alter table thukho
check constraint fk_thukho_bophannv;
go
		---------------------------

	alter table phieunhap
 with nocheck add constraint fk_phieunhap_thukho
foreign key (mathukho) references thukho(mathukho);
go
alter table phieunhap
 with nocheck add constraint fk_phieunhap_nhacungcap
foreign key (mancc) references nhacungcap(mancc);
go
alter table phieunhap
 with nocheck add constraint fk_phieunhap_hanghoa
foreign key (mahang) references hanghoa(mahang);
go
alter table phieunhap
check constraint fk_phieunhap_thukho;
go
alter table phieunhap
check constraint fk_phieunhap_nhacungcap;
go
alter table phieunhap
check constraint fk_phieunhap_hanghoa;
go	
	
		---------------------------
alter table nhanvien
 with nocheck add constraint fk_nhanvien_bophannv
foreign key (mabophan) references bophannv(mabophan);
go
alter table nhanvien
check constraint fk_nhanvien_bophannv;
go
-------------------------------


alter table phieuxuat
 with nocheck add constraint fk_phieuxuat_thukho
foreign key (mathukho) references thukho(mathukho);
go

alter table phieuxuat
 with nocheck add constraint fk_phieuxuat_hanghoa
foreign key (mahang) references hanghoa(mahang);
go
alter table phieuxuat
 with nocheck add constraint fk_phieuxuat_yeucau
foreign key (manhanvien) references nhanvien(manhanvien);
go
alter table phieuxuat
check constraint fk_phieuxuat_thukho;
go
alter table phieuxuat
check constraint fk_phieuxuat_hanghoa;
go
alter table phieuxuat
check constraint fk_phieuxuat_nhanvien;
go

