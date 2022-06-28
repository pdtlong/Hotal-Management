create database QLKH
use QLKH

create table Customer(
idCus int IDENTITY(1,1)  primary key, -- ma khach hang tự sinh theo thứ tự
nameCus nvarchar(30) not null, -- ten kh
Passport varchar(10) not null unique, -- CMND hoac ho chieu --
phoneCus nvarchar(11) null, --sdt kh
sexCus nvarchar(5) null, -- nam - nu
locationCus nvarchar(100) null, -- dia chi --
email nvarchar (50) null, -- mail
note nvarchar (200) null, -- ghi chu thong tin --
)
go
DBCC CHECKIDENT ('Customer', RESEED, 0);
GO

create table Staff( -- Nhan Vien
idStaff varchar(5) primary key, -- mã nhan vien NV là Nhân viên, AD là quả lí
nameStaff nvarchar(30) not null,
birthday date null,
sexStaff nvarchar(5), --nam - nu
locationStaff nvarchar(100) null, 
phoneStaff nvarchar(11) null,
email nvarchar (50) null, -- mail
salary int null,
position varchar(2)  -- admin 1, staff 0
)

create table TypeRoom(
idTR int IDENTITY(1,1) primary key,
NameTR nvarchar(20) not null, -- Tên phòng
priceR int, -- gia loai phong/ ngay
capacity int -- suc chua toi da ( ko anh huong gia phong)
)

Create table Room(
idR varchar(3) primary key, -- ma phong(ten phong)
idTR int not null,  -- ma loai phong
checkin bit null, -- Da nhan phong
constraint FK_Room_TypeRoom foreign key(idTR) references TypeRoom(idTR)
-- book bit null, -- trang thai phong hien tại ( 1 da dat , 0 chua dat)
)

create table ExtraService(
idSv int IDENTITY(1,1) primary key, -- ma dich vu
nameSv nvarchar(40), -- ten dich vu
priceSv nvarchar(10), -- gia dich vu
unitSv varchar(10),-- don vi
)


create table Account(
idStaff varchar(5) not null, -- ma nhan vien
userID varchar (20)  not null primary key, --ten tai khoan
pword varchar(20) not null, -- Mat Khau
constraint FK_Account_Staff foreign key(idStaff) references Staff(idStaff)
)

create table FormRent(
idRent int IDENTITY(1,1) not null primary key, -- ma thue phong auto
idCus int not null,
idR varchar(3),
startDate date, -- ngay bat dau o
endDate date, -- ngay ket thuc
stt nvarchar(10) not null, -- tinh trang: da nhan phong  
people int, -- so nguoi den o
userIDNhan varchar(20) not null, -- ma user cua account nhận đặt phòng
userIDTT varchar(20) null, -- ma user cua account thanh toán tiền phòng
constraint FK_FormRent_Customer foreign key(idCus) references Customer(idCus),
constraint FK_FormRent_Room foreign key(idR) references Room(idR),
constraint FK_FormRent_Account1 foreign key(userIDNhan) references Account(userID),
constraint FK_FormRent_Account2 foreign key(userIDTT) references Account(userID)
)

create table ServiceDetail(
idSv int , -- ma dich vu
idRent int not null,
quantity int not null -- so luong
primary key (idSV,idRent),
constraint FK_ServiceDetail_FormRent foreign key(idRent) references FormRent(idRent),
constraint FK_ServiceDetail_ExtraService foreign key(idSv) references ExtraService(idSv)
)


create table RoomState(
idR varchar(3) not null,
stt nvarchar(10) not null,
primary key(idR,stt),
constraint FK_RoomState_Room foreign key(idR) references Room(idR)
)

create table Item(
idIt int IDENTITY(1,1) not null primary key,
nameIt nvarchar(40) not null,
PriceIt int
)

create table ItemDetail(
idIt int not null,
idTR int not null,
quantity int not null,
primary key (idIt,idTR),
constraint FK_ItemDetail_TypeRoom foreign key(idTR) references TypeRoom(idTR),
constraint FK_ItemDetail_Item foreign key(idIt) references Item(idIt)
)



---tạo khóa tự động Nhân viên----
go
CREATE PROC InputStaff(@nameStaff nvarchar(30), @birthday date, @sexStaff nvarchar(5), @locationStaff nvarchar(100), @phoneStaff nvarchar(11),@email nvarchar (50),@salary int,@position varchar(2))
AS
BEGIN
	DECLARE @idStaff varchar(5)
	SELECT @idStaff = (MAX(RIGHT(idStaff, 3))) FROM Staff
	DECLARE @COUNT int
	SET @COUNT = CAST(@idStaff as int) + 1
		SELECT @idStaff = CASE
			WHEN @COUNT >= 0 and @COUNT < 10 THEN  @position + '00' + CAST(@COUNT as varchar(1))
			WHEN @COUNT >= 10 and @COUNT <=99 THEN @position + '0' + CAST(@COUNT as varchar(2))
			WHEN @COUNT > 99 and @COUNT  <=999 THEN @position + CAST(@COUNT as varchar(3))
		END
	Insert into Staff values (@idStaff, @nameStaff, @birthday, @sexStaff, @locationStaff, @phoneStaff, @email, @salary, @position)
END

insert into Customer values(N'Trần Xuân Vũ', '238246454', '0937540287',N'Nam', N'716 Linh Đàm, Quận Hoàng Mai, Hà Nội','txvu@gmail.com', N'Đã thanh toán tiền đặt phòng')
						  ,(N'Phạm Trường Vũ','906267705','0839432742', N'Nam', N' 93 đường 45 quận 4 tp. HCM','VuPham@gmail.com',N' Đã thanh toán tiền đặt phòng')
						  ,(N'Trần Thị Kim Chi','435788346','0929854176', N'Nữ', N' 22, Hồ Đắc Dĩ, Quận Đống Đa,Hà Nội','trthkchi@gmail.com',N' Đã Đặt phòng nhưng chưa thanh toán')
						  ,(N'Lại Thị Nga','4556692862','0945118163', N'Nữ', N'232 Bằng Đằng, Hải châu, Đằ nẵng',null,N'Chưa thanh toán tiền đặt phòng')
						  ,(N'Đào Quang Huy','232979261','0378440313', N'Nam', N'27 Nguyễn Trãi, Quận Thanh Xuân, Hà nội','QuangHuy12@gmail.com',N'Chưa thanh toán tiền đặt phòng')
						  ,(N'Trương Bảo Hoàng','490884925','098753159',N'Nam',N'72 Võ Thị Sáu quận 1 Tp.HCM',null,N'Đã thanh toán tiền đặt phòng')
						  ,('David Beckham','994766753','0937539512',N'Nam',N'England', null,N'Đã toán tiền đặt phòng nhưng chưa đến')
						  ,(N'Nguyễn Khoa Điền','911035797','0953571591',N'Nam',N'Long Biên Hà Nội',N'KhDien@gmail.com','Nchưa thanh toán tiền đặt phòng và chưa nhận phòng')
						  ,(N'Nguyễn Toàn Thiện','334933574','0767476678',N'Nam',N'Dương Bá Trạc Quận 5 tp.HCM',N'Thienchodien@gmail.com','Vẫn chưa than toán tiền phòng')

insert into TypeRoom values(N'Ngủ lều',50000,4)
						  ,(N'Phòng 2 pax', 130000, 2)
						  ,(N'Phòng 4 pax', 220000, 4)
						  ,(N'Phòng 8 pax', 400000, 8)

insert into Staff values('AD001',N'Phạm Dương Thành Long','01/09/1998',N'Nam',N'Lê văn Lương, Nhà Bè Tp. HCM','0928747589','longpham@gmail.com',10000000,'AD')
       execute InputStaff N'Nguyễn Đình Khải','02/08/1998',N'Nam',N'Gò vấp, Tp.HCM','0924567889','khuikhui@gmail.com',8000000,'NV'
       execute InputStaff N'Trần Thị Lan Anh','07/19/1998',N'Nữ',N'Quận 2 tp.HCM','0937564231','LanAnh@gmail.com',8000000,'NV'
       execute InputStaff N'Nguyễn Hoàng Huy','01/09/1998',N'Nam',N'Hóc môn, Tp. HCM','0902753951','HoangHuy@gmai.com',10000000,'AD'


insert into Room values('101',2,1) -- tầng 1
					  ,('102',2,0)
					  ,('103',3,0)
					  ,('104',3,0)
					  ,('105',4,0)
					  ,('201',2,0)  -- tầng 2
					  ,('202',2,0)
					  ,('203',3,0)
					  ,('204',4,0)
					  ,('301',4,0)  -- tầng 3
					  ,('302',1,0)
					  ,('303',1,0)
					  ,('304',1,0)
					  ,('305',1,0)
					  ,('306',1,0)
select * from Room
								---Thức ăn---
insert into ExtraService values(N'Sò Điệp Nướng Mỡ Hành',120000,N'Dĩa')
							  ,(N'Gỏi cá Mai',120000,N'Dĩa')
							  ,(N'Ốc Móng Tay xào rau Muống',70000,N'Dĩa')
							  ,(N'Ốc Mè/ ốc giấy nướngn mở Hành',100000,N'Dĩa')
							  ,(N'Mực nhồi thịt',100000,N'Dĩa')
							  ,(N'Hến xúc bánh tráng',100000,N'Dĩa')
							  ,(N'Cá Bóp Nướng',175000,N'Dĩa')
							  ,(N'Hào nướng phô mai',100000,N'Dĩa')
							  ,(N'Bách tuột nướng phô mai',100000,N'Dĩa')
							  ,(N'Nghiêu hấp xả ớt',100000,N'Dĩa')
							  ,(N'Bánh Crep chuối',20000,N'Dĩa')
							  ,(N'Mì gói mực',30000,N'Dĩa')
							  ,(N'Cá bò hấp/nướng',350000,N'Dĩa')
								--- Nước uống ---
							  ,(N'Coca',10000,N'Chai')
							  ,(N'Pepsi',10000,N'Chai')
							  ,(N'Sting',10000,N'Chai')
							  ,(N'Không độ',10000,N'Chai')
							  ,(N'7up',10000,N'Chai')
							  ,(N'Nước suối',7000,N'Chai')
								--- Dịch vụ ---
							  ,(N'Jeep Tour Ngắm Hoàng Hôn/Bình Minh',110000,'Lần')
							  ,(N'Bike Tour Hoàng Hôn/Bình Minh Mũi Né',350000,'Lần')
							  ,(N'Thuê xe số',12000,'Lần')
							  ,(N'Thuê xe Tay ga',15000,'Lần')
							  ,(N'Cho thuê Camera/ Go Pro',15000,'Lần')
							  ,(N'Giặt quần áo (5kg)',50000,'Lần')

insert into Account values('AD001','Manager1','123456')
						 ,('NV002','Staff1','123456')
						 ,('NV003','Staff2','123456')
						 ,('AD004','Manager2','123456')

insert into RoomState values('101','Busy')
							,('102','Waitting')
							,('103','Waitting')
							,('104','Waitting')
							,('105','Clean')
							,('201','Available')
							,('202','Available')
							,('203','Available')
							,('204','Available')
							,('301','Available')
							,('302','Available')
							,('303','Available')
							,('304','Available')
							,('305','Available')
							,('306','Available')

insert into Item values(N'Máy Lạnh Sharp AH-A25UEW',4790000)
					  ,(N'Tủ Lạnh Digital Inverter Samsung',4890000)
					  ,(N'Internet Tivi Sharp 40 inch ',5890000)

insert into ItemDetail values  (1,2,1) -- máy lạnh của từng loại phòng
							  ,(1,3,1)
							  ,(1,4,1)
							  ,(2,3,1) -- Tủ lạnh cho từng phòng
							  ,(2,4,1)
							  ,(3,2,1) -- Tivi cho từng phòng
							  ,(3,3,1)
							  ,(3,4,1)

insert into FormRent values (1,'101','9/11/2018','9/12/2018','Busy',2,'Staff1',null)
insert into ServiceDetail values(1,1,3),(7,1,2)

