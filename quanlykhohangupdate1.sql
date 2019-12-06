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
----------------------------------
create table account
	(
		idtk  int not null,
		taikhoan  varchar(8) not null,
		matkhau varchar(8) not null,
		type int not null ,
		constraint pk_idtk primary key(idtk)
	);

--------------------------------
--Nhóm hàng hóa
create table loaisach
	(
		tenloaisach  varchar(8) not null,
		constraint pk_loaisach primary key (tenloaisach)
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


	--Kệ
	create table ke
	(
		make   varchar(8) not null,
		tenke  varchar(20),
		constraint pk_ke primary key (make),
	);

	--Thủ kho
	create table nhanvien
	(
		manhanvien  varchar(8) not null,
		tennhanvien varchar(20) not null,
		diachi  varchar(20) ,
        sex  varchar(10),
		mabophan  varchar(8) not null,
		constraint pk_nhanvien primary key (manhanvien),
		constraint ck_nhanvien foreign key (mabophan) references bophannv(mabophan)
	);


	--Khach hang
	create table khachhang
	(
		makhachhang varchar(8) not null,
		tenkhachhang   varchar(20) not null,
        sex varchar(10),
        diachi  varchar(20),
		constraint pk_khachhang primary key (makhachhang),
	);


	--Hàng hóa 
	create table sach
	(
		masach	   varchar(8) not null, 
		tensach   varchar(40) ,    
		tenloaisach	varchar(8) not null,
		soluong     int,
		make  varchar (8) not null
		constraint pk_sach primary key (masach),
		constraint ck_sach_loaisach foreign key (tenloaisach) references loaisach(tenloaisach),
		constraint ck_sach_ke foreign key (make) references ke(make)
	);


	--Phiếu nhập
	create table phieunhap
	(
		maphieunhap  varchar(8) not null,
		ngaynhap     date not null,
		manhanvien  varchar(8)not null ,
		mancc  varchar(8) not null,
        soluong   int,
		masach	   varchar(8) not null,
		constraint pk_phieunhap primary key (maphieunhap),
		constraint ck_phieunhap_nv foreign key (manhanvien) references nhanvien(manhanvien),
		constraint ck_phieunhap_ncc foreign key (mancc) references nhacungcap(mancc),
		constraint ck_phieunhap_s foreign key (masach) references sach(masach)
	);


	
	--Phiếu xuất
	create table phieuxuat
	(
		maphieuxuat  varchar(8) not null,
		ngayxuat     date not null,
		manhanvien  varchar(8) not null,
		masach	   varchar(8) not null,
        soluong   int,
		makhachhang   varchar(8) not null,
		trangthai   varchar(20) not null,
		constraint pk_phieuxuat primary key (maphieuxuat),
		constraint ck_phieuxuat_nv foreign key (manhanvien) references nhanvien(manhanvien),
		constraint ck_phieuxuat_s foreign key (masach) references sach(masach),
		constraint ck_phieuxuat_kh foreign key (makhachhang) references khachhang(makhachhang)
	);
go
---------------------------


---------------------------Tao Check------------------------------
----------------------tao khoa ngoai SACH-------------------------
alter table sach
	with nocheck add constraint fk_sach_loaisach
	foreign key (tenloaisach) references loaisach(tenloaisach);

go
alter table sach
	with nocheck add constraint fk_sach_ke
	foreign key (make) references ke(make);

go
alter table sach
	check constraint fk_sach_loaisach;

go
alter table sach
	check constraint fk_sach_ke;
go	
------------------------------------------------------------------



----------------------tao khoa ngoai NHANVIEN---------------------
alter table nhanvien
	with nocheck add constraint fk_nhanvien_bophannv
	foreign key (mabophan) references bophannv(mabophan);

go
alter table nhanvien
	check constraint fk_nhanvien_bophannv;
go

------------------------------------------------------------------



----------------------tao khoa ngoai PHIEUNHAP--------------------
alter table phieunhap
	with nocheck add constraint fk_phieunhap_nhanvien
	foreign key (manhanvien) references nhanvien(manhanvien);

go
alter table phieunhap
	with nocheck add constraint fk_phieunhap_nhacungcap
	foreign key (mancc) references nhacungcap(mancc);

go
alter table phieunhap
	with nocheck add constraint fk_phieunhap_sach
	foreign key (masach) references sach(masach);

go
alter table phieunhap
	check constraint fk_phieunhap_nhanvien;

go
alter table phieunhap
	check constraint fk_phieunhap_nhacungcap;

go
alter table phieunhap
	check constraint fk_phieunhap_sach;

go	
	
------------------------------------------------------------------



----------------------tao khoa ngoai PHIEUXUAT--------------------


alter table phieuxuat
	with nocheck add constraint fk_phieuxuat_nhanvien
	foreign key (manhanvien) references nhanvien(manhanvien);

go

alter table phieuxuat
	with nocheck add constraint fk_phieuxuat_sach
	foreign key (masach) references sach(masach);

go
alter table phieuxuat
	with nocheck add constraint fk_phieuxuat_khachhang
	foreign key (makhachhang) references khachhang(makhachhang);

go
alter table phieuxuat
	check constraint fk_phieuxuat_nhanvien;

go
alter table phieuxuat
	check constraint fk_phieuxuat_sach;

go
alter table phieuxuat
	check constraint fk_phieuxuat_khachhang;

go

--------------------------------------------------



----------------------nhap gia tri------------------------------
insert into nhacungcap values
('NCC111','Quoc Dat','Binh Thuan','7456345758'),
('NCC112','Tien Hoa','Binh Thuan','7456345743'),
('NCC113','Binh Tuy','Dong Nai','7456345111'),
('NCC114','Nem Hoa','Ho Chi Minh','9766345111');

insert into khachhang values
('KH111','Vo Quoc Tuan','nam','Duc Linh'),
('KH112','Tien Hoa','nam','Ham Tan'),
('KH113','Quan AP','nam','Ha Noi'),
('KH114','Jack','nu','Long An');

insert into account values
(1,'Hoadt','1234',1),
(2,'DatG','4444',1),
(3,'HaiTac','6665',0);

insert into ke values
('KE001','Ke01'),
('KE002','Ke02'),
('KE003','Ke03');

insert into loaisach values
('ThamKhao'),
('GiaDinh'),
('ThienVan');

insert into bophannv values
('BP01','Thu Kho'),
('BP02','Xu ly');

insert into nhanvien values

('NV01','Son Tung MTP','Ben Tre','Nam','BP02'),
('NV02','Ly Hai','Tien Giang','Nu','BP01'),
('NV03','Chau Khai Phong','Ben Tre','Nam','BP02'),
('NV04','Pham Quynh Anh','Tien Giang','Nu','BP01');


insert into sach values
('S0001','Toi Thay Hoa Vang tren Co Xanh','ThienVan','105','KE001'),
('S0002','Bai Tap Vat Ly 2','ThamKhao','87','KE002'),
('S0003','Bai Tap Toan 1','ThamKhao','34','KE002'),
('S0004','Huong Dan nau an','GiaDinh','55','KE003');

insert into phieunhap values
('PN001','2019-10-24','NV01','NCC111','2','S0003'),
('PN002','2019-12-06','NV04','NCC112','3','S0001'),
('PN003','2019-07-10','NV04','NCC114','1','S0002'),
('PN004','2019-06-11','NV01','NCC113','2','S0003');

insert into phieuxuat values
('PX001','2019-11-24','NV01','S0003','2','KH113','Đã xử lý'),
('PX002','2019-12-10','NV04','S0001','3','KH112','Chưa xử lý'),
('PX003','2019-08-10','NV04','S0002','1','KH114','Đã xử lý'),
('PX004','2019-07-11','NV01','S0003','2','KH113','Chưa xử lý');






-----------------------------------------

-- tạo proc ,funtion ,trigger

-----------------ACCOUNT-----------------------------
Go
-- xác nhận đúng mật khẩu để đăng nhập :)) ;
create function laymk(@tendangnhap varchar(8))
		Returns varchar(8)
	Begin
		return(Select matkhau from account
		Where account.taikhoan=@tendangnhap);
	End;
go

--xác nhận loại mật khẩu
create proc laymk2 @tendangnhap varchar(8),@matkhau varchar(8), @type int
as 
	select * from account where taikhoan=@tendangnhap and matkhau=@matkhau and type = @type
go



create proc laymk1 @tendangnhap varchar(8),@matkhau varchar(8)
as 
	select * from account where taikhoan=@tendangnhap and matkhau=@matkhau
go


 -- kiểm tra trước khi thêm tài khoản nếu có tài khoản đó rôi thì thêm bị lỗi :)))
create proc kiemtrataikhoan @taikhoan varchar(8)
as
	select * from account where taikhoan=@taikhoan
go

--exec kiemtrataikhoan 'Hoadt'; ----test


go
-- neu  có giá trị thì them ko dc ,tài khoản đã tồn tại ,còn ko , thì insert

--thực thi để thêm tài khoản sau khi đã xác nhận xong
create proc themtaikhoan(@idtk int,@taikhoan varchar(8),@matkhau varchar(8),@type int)
as
	insert into account values(@idtk,@taikhoan,@matkhau,@type)
go


--------------------------------------------------------------------------

---------------------------------PHIEUNHAP--------------------------------
-- xem tất cả  thông tin của nhiều phiếu nhập
 create proc  infophieunhap
as
	select *from phieunhap
go


--exec infophieunhap; -----test
go


--kiểm tra xem có giá trị trả về không nếu có thì đã tồn tại chưa trước khi lập phiếu nhập
create proc kiemtraphieunhap(@maphieunhap varchar(8))
as
	select *from phieunhap where maphieunhap=@maphieunhap
go


-----thêm phiếu nhập
create proc themphieunhap(@maphieunhap varchar(8),@ngaynhap date,@mathukho varchar(8),@mancc varchar(8),
	@soluong int,@mahang varchar(8),@trangthai varchar(20))
	as
		begin
			IF	@maphieunhap = '' THROW 50001, 'Mã phiếu nhập không được để trống!', 1;
			IF	@mahang = '' THROW 50001, 'Mã  sách không được để trống!', 1;
			IF	@mathukho='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
			IF	@ngaynhap ='' THROW 50001, 'Ngày không được để trống!', 1;
			insert into phieunhap values(@maphieunhap,@ngaynhap,@mathukho,@mancc,@soluong,@mahang)
		end
	go
	--sửa phiếu nhập
create proc suaphieunhap(@maphieunhap varchar(8),@ngaynhap date,@mathukho varchar(8),@mancc varchar(8),
	@soluong int,@mahang varchar(8))
	as
		begin
			IF	@maphieunhap = '' THROW 50001, 'Mã phiếu nhập không được để trống!', 1;
			IF	@mahang = '' THROW 50001, 'Mã  sách không được để trống!', 1;
			IF	@mathukho='' THROW 50001, 'Mã nhân viên không được để trống!', 1;
			IF	@ngaynhap ='' THROW 50001, 'Ngày không được để trống!', 1;
			update phieunhap set maphieunhap =@maphieunhap,ngaynhap= @ngaynhap,
			manhanvien=@mathukho,mancc= @mancc,soluong= @soluong,masach= @mahang
		end
	go


-----------------------------------------------------------------------------
---------------------------------PHIEUXUAT-----------------------------------
-- lấy thông tin từ phiếu xuất
create proc  infophieuxuat
as
	select *from phieuxuat
go


--exec infophieuxuat; ----test
go


-- kiểm tra trước khi lập phiếu xuất
create proc kiemtraphieuxuat(@maphieuxuat varchar(8))
as
	select *from phieuxuat where maphieuxuat=@maphieuxuat
go


-- thêm phiếu xuất 
create proc themphieuxuat(@maphieuxuat varchar(8),@ngayxuat date,@mathukho varchar(8),@mahang varchar(8),
	@soluong int,@makhachhang varchar(8),@trangthai varchar(20))
	as
		begin
			IF	@soluong>(SELECT soluong FROM sach WHERE masach=@mahang) THROW 50001,'Số lượng hàng trong kho không đủ!',1;
			IF	@maphieuxuat = '' THROW 50001, 'Mã phiếu xuất không được để trống!', 1;
			IF	@makhachhang = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
			IF	@mathukho='' THROW 50001, 'Mã thủ kho không được để trống!', 1;
			IF	@ngayxuat ='' THROW 50001, 'Ngày không được để trống!', 1;
			IF	@trangthai ='' THROW 50001, 'Trạng thái không được để trống!', 1;
			insert into phieuxuat values(@maphieuxuat,@ngayxuat,@mathukho,@mahang,@soluong,@makhachhang,@trangthai)
		end
	go

--sửa phiếu xuất
create proc suaphieuxuat(@maphieuxuat varchar(8),@ngayxuat date,@mathukho varchar(8),@mahang varchar(8),
	@soluong int,@makhachhang varchar(8),@trangthai varchar(20))
	as
		begin
			IF	@soluong>(SELECT soluong FROM sach WHERE masach=@mahang) THROW 50001,'Số lượng hàng trong kho không đủ!',1;
			IF	@maphieuxuat = '' THROW 50001, 'Mã phiếu xuất không được để trống!', 1;
			IF	@makhachhang = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
			IF	@mathukho='' THROW 50001, 'Mã thủ kho không được để trống!', 1;
			IF	@ngayxuat ='' THROW 50001, 'Ngày không được để trống!', 1;
			IF	@trangthai ='' THROW 50001, 'Trạng thái không được để trống!', 1;
			update phieuxuat set maphieuxuat=@maphieuxuat,ngayxuat= @ngayxuat,
			manhanvien=@mathukho,soluong=@soluong,makhachhang=@makhachhang,trangthai=@trangthai
		end
	go


------------------------------------------------------------------------------------

--------------------------------SOLUONG---------------------------------------------
	
-- cập nhập số lượng khi thêm sản phẩm 
create trigger trinphieunhap on phieunhap after insert as
	begin 
		update sach 
		set soluong= sach.soluong+(
		select soluong from inserted
		where inserted.masach=sach.masach)
		from sach join inserted on
		sach.masach=inserted.masach
	end 
go

-- cập nhập số lượng khi xuất sản phẩm
create trigger trinphieuxuat on phieuxuat after insert as
	begin 
		update sach 
		set soluong= sach.soluong-(
		select soluong from inserted
		where inserted.masach=sach.masach)
		from sach join inserted on
		sach.masach=inserted.masach
	end 
go

--cap nhap so luong sau khi xoa phieu nhap 
create trigger trdephieunhap on phieunhap for delete as
	begin
		update sach
		set soluong=sach.soluong-(
		select soluong from deleted
		where masach=sach.masach)
		from sach join deleted on sach.masach=deleted.masach
	end;
go

--cap nhap so luong sau khi xoa phieu xuat 
create trigger trdephieuxuat on phieuxuat for delete as
	begin
		update sach
		set soluong=sach.soluong+(
		select soluong from deleted
		where masach=sach.masach)
		from sach join deleted on sach.masach=deleted.masach
	end;
go


---------------------------------------------------------------------------
-----------------------------NHÀ CUNG CẤP----------------------------------

-- tra cứu thông tin nha cung cấp
create proc thongtinncc
as
	select * from  nhacungcap
go

--kiem tra truoc khi them vao
create proc kiemtrancc(@mancc varchar(8))
as
	select * from nhacungcap where mancc=@mancc
go

-- thêm nhà cung cấp
create proc themncc(@mancc varchar(8),@tenncc varchar(20),@diachincc varchar(20),@sotk varchar(12))
as
	insert into nhacungcap values(@mancc,@tenncc,@diachincc,@sotk)
go

--sửa nhà cung cấp
create proc suancc @mancc varchar(8),@tenncc varchar(20),@diachincc varchar(20),@sotk varchar(12)
as
	begin
		update nhacungcap set tenncc= @tenncc,
		diachincc= @diachincc,sotk= @sotk where mancc=@mancc
	end
go

create proc xoancc @mancc varchar(8)
as
	begin
		delete  from nhacungcap where mancc=@mancc
	end
go 

create proc searchncc @id varchar(8)
as
	select * from nhacungcap where mancc=@id
go


-----------------------------------------------------------------
--------------------------KỆ SÁCH--------------------------------
	
--thông tin kệ
create proc thongtinke
as
	select * from  ke
go

--kiem tra truoc khi them vao
create proc kiemtrake(@make varchar(8))
as
	select * from ke where make =@make
go

-- thêm vào 
create proc themke(@make varchar(8),@tenke varchar(20))
as
	insert into ke values(@make,@tenke)
go
 
-- chinh sua ke
create proc suake @make varchar(8),@tenke varchar(20)
as
	begin
		update ke set
		tenke= @tenke where make=@make
	end
go

-- xoa ke
create proc xoake @make varchar(8)
as
	begin
		delete  from ke where make=@make
	end
go
                   
create proc searchke @id varchar(8)
as
	select * from ke where make=@id
go


-------------------------------------------------------
-------------------KHÁCH HÀNG--------------------------

--thông tin khachhang
create proc thongtinkhachhang
as
	select * from  khachhang
go

--kiem tra truoc khi them vao
create proc kiemtrakhachhang(@makhachhang varchar(8))
as
	select * from khachhang where  makhachhang=@makhachhang
go

-- thêm vào 
create proc themkhachang(@makhachhang varchar(8),@tenkhachhang varchar(20),@sex varchar(10), @diachi  varchar(20))
as
	insert into khachhang values(@makhachhang,@tenkhachhang,@sex,@diachi)
go 

-- chinh sua khachhang
create proc suakhachhang @makhachhang varchar(8),@tenkhachhang varchar(20),@sex varchar(10), @diachi  varchar(20)
as
	begin
		update khachhang set
		tenkhachhang= @tenkhachhang,sex=@sex,diachi=@diachi where makhachhang=@makhachhang
	end
go
  
-- xoa khachhang
create proc xoakkhachhang @makhachhang varchar(8)
as
	begin
		delete  from khachhang where makhachhang=@makhachhang
	end
go
                   
create proc searchkhachhang @id varchar(8)
as
	select * from khachhang where makhachhang=@id
go

------------------------------------------------------------------------
-------------------------Bộ Phận Nhân Viên------------------------------
	
--thông tin bộ phận
create proc thongtinbophan
as
	select * from  bophannv
go

--kiem tra truoc khi them vao
create proc kiembophan(@mabophan varchar(8))
as
	select * from bophannv where mabophan=@mabophan
go
  
-- thêm vào 
create proc thembophan(@mabophan varchar(8),@tenbophan varchar(20))
as
	insert into bophannv values(@mabophan,@tenbophan)
go

-- chinh sua bo phận
create proc suabophan @mabophan varchar(8),@tenbophan varchar(20)
as
	begin
		update bophannv set
		tenbophan= @tenbophan where mabophan=@mabophan
	end
go
  
-- xoa bo phan
create proc xoabophan @mabophan varchar(8)
as
	begin
		delete  from bophannv where mabophan=@mabophan
	end
go                   
create proc searchbophannv @id varchar(8)
as
	select * from bophannv where mabophan=@id
go

-------------------------------------------------------------
--------------------LOẠI SÁCH--------------------------------
	
--thông tin 
create proc thongtinloaisach
as
	select * from  loaisach
go

--kiem tra truoc khi them vao
 create proc kiemnhomhang(@tennhomhang varchar(8))
as
	select * from loaisach where tenloaisach = @tennhomhang
go
  
-- thêm vào 
create proc themnhomhang(@tennhomhang varchar(8))
as
	insert into loaisach values(@tennhomhang)
go
 
-- chinh sua
create proc suanhomhang @tennhomhang varchar(8)
as
	begin
		update loaisach set
		tenloaisach= @tennhomhang
	end
go
  
-- xoa 
create proc xoanhomhang @tennhomhang varchar(8)
as
	begin
		delete  from loaisach where tenloaisach=@tennhomhang
	end
go                   
create proc searchloaisach @id varchar(8)
as
	select * from loaisach where tenloaisach=@id
go


-------------------------------------------------------------
---------------------------SÁCH------------------------------

--lays thong tin
create proc thongtinsach
as
	select * from  sach
go

--kiem tra truoc khi them
create proc kiemtrasach(@idsach varchar(8))
as
	select * from sach where masach= @idsach
go  

--sửa sách
create proc suasach         
    @idsach varchar(8),
	@tensach nvarchar(20),
	@loaisach nvarchar(8),
	@make nvarchar(8)
as
	begin
		begin try
			begin tran
				update sach
				set 
				tensach= @tensach,
				tenloaisach= @loaisach,
				make=@make
				where masach=@idsach
			commit tran
			print 'Sửa thành công';
		end try
		begin catch
			rollback tran
			print 'lỗi rồi';
		end catch
	end
go


--thêm sách
create proc themsach
	@idsach nvarchar(8),
	@tensach nvarchar(20),
	@loaisach nvarchar(8),
	@make nvarchar(8)
as
	begin
	declare @soluong int
	set @soluong= 0;
		begin try
			begin tran
				insert into sach
				values(	@tensach,@idsach,
						@loaisach,@soluong,
						@make)
			commit tran
			print 'Thêm thành công';
		end try
		begin catch
			rollback tran
			print 'lỗi rồi';
		end catch
	end
go