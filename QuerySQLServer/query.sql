create database IncomeExpense
--use Test
--drop database IncomeExpense
go
use IncomeExpense
go

create table UserInfo(
	userId int IDENTITY(1,1) primary key not null,
	userName varchar(50) not null,
	userPassword varchar(50) not null,
	userEmail varchar(50) not null
);

create table Income(
	incId int IDENTITY(1,1) primary key not null,
	incName nvarchar(50) not null,
	incCategory nvarchar(50) not null,
	incAmount int not null,
	incDate date,
	incDesciption nvarchar(100) not null,
	userId int not null,
	foreign key (userId) references UserInfo(userId)
);

create table Expense(
	exId int IDENTITY(1,1) primary key not null,
	exName nvarchar(50) not null,
	exCategory nvarchar(50) not null,
	exAmount int not null,
	exDate date,
	exDesciption nvarchar(100) not null,
	userId int not null,
	foreign key (userId) references UserInfo(userId)
);


create table ExpensePlan(
	epId int identity(1,1) primary key not null,
	epName nvarchar(50) not null,
	epCategory nvarchar(50) not null,
	epAmount int not null,
	epDate date not null, 
	userId int not null,
	foreign key (userId) references UserInfo(userId)
);

insert into UserInfo values ('a', 'a', 'incomeexpenseapp123@gmail.com');

INSERT INTO Income (incName, incCategory, incAmount, incDate, incDesciption, userId) VALUES
(N'Lương', N'Thu nhập thường xuyên', 5000000, '2024-03-01', N'Lương hàng tháng', 1),
(N'Thưởng', N'Thu nhập bổ sung', 1000000, '2024-03-05', N'Thưởng hiệu suất làm việc', 1),
(N'Freelance', N'Thu nhập phụ', 700000, '2024-03-10', N'Thu nhập từ dự án Freelance', 1),
(N'Đầu tư', N'Đầu tư', 200000, '2024-03-15', N'Tiền lãi', 1),
(N'Thuê nhà', N'Thu nhập không làm việc', 1000000, '2024-03-20', N'Thu nhập từ cho thuê nhà', 1);

INSERT INTO Expense (exName, exCategory, exAmount, exDate, exDesciption, userId) VALUES
(N'Mua sắm', N'Thực phẩm', 200000, '2024-03-02', N'Mua sắm hàng tuần', 1),
(N'Hóa đơn', N'Hóa đơn', 150000, '2024-03-07', N'Tiền điện, nước, v.v.', 1),
(N'Giải trí', N'Giải trí', 100000, '2024-03-12', N'Xem phim', 1),
(N'Di chuyển', N'Du lịch', 50000, '2024-03-17', N'Di chuyển công cộng', 1),
(N'Chăm sóc sức khỏe', N'Y tế', 300000, '2024-03-22', N'Đi khám bác sĩ', 1);

INSERT INTO Income (incName, incCategory, incAmount, incDate, incDesciption, userId) VALUES
(N'Lương tháng 2', N'Thu nhập thường xuyên', 5000000, '2024-02-01', N'Lương hàng tháng', 1),
(N'Thưởng tháng 2', N'Thu nhập bổ sung', 1000000, '2024-02-05', N'Thưởng hiệu suất làm việc', 1),
(N'Lương tháng 1', N'Thu nhập thường xuyên', 5000000, '2024-01-01', N'Lương hàng tháng', 1),
(N'Thưởng tháng 1', N'Thu nhập bổ sung', 1000000, '2024-01-05', N'Thưởng hiệu suất làm việc', 1),
(N'Lương tháng 12', N'Thu nhập thường xuyên', 5000000, '2023-12-01', N'Lương hàng tháng', 1),
(N'Thưởng tháng 12', N'Thu nhập bổ sung', 1000000, '2023-12-05', N'Thưởng hiệu suất làm việc', 1),
(N'Freelance tháng 2', N'Thu nhập phụ', 700000, '2024-02-10', N'Thu nhập từ dự án Freelance', 1),
(N'Freelance tháng 1', N'Thu nhập phụ', 700000, '2024-01-10', N'Thu nhập từ dự án Freelance', 1),
(N'Freelance tháng 12', N'Thu nhập phụ', 700000, '2023-12-10', N'Thu nhập từ dự án Freelance', 1),
(N'Đầu tư tháng 2', N'Đầu tư', 200000, '2024-02-15', N'Tiền lãi', 1),
(N'Đầu tư tháng 1', N'Đầu tư', 200000, '2024-01-15', N'Tiền lãi', 1),
(N'Đầu tư tháng 12', N'Đầu tư', 200000, '2023-12-15', N'Tiền lãi', 1);

INSERT INTO Expense (exName, exCategory, exAmount, exDate, exDesciption, userId) VALUES
(N'Mua sắm tháng 2', N'Thực phẩm', 200000, '2024-02-02', N'Mua sắm hàng tuần', 1),
(N'Hóa đơn tháng 2', N'Hóa đơn', 150000, '2024-02-07', N'Tiền điện, nước, v.v.', 1),
(N'Giải trí tháng 2', N'Giải trí', 100000, '2024-02-12', N'Xem phim', 1),
(N'Di chuyển tháng 2', N'Du lịch', 50000, '2024-02-17', N'Di chuyển công cộng', 1),
(N'Chăm sóc sức khỏe tháng 2', N'Y tế', 300000, '2024-02-22', N'Đi khám bác sĩ', 1),
(N'Mua sắm tháng 1', N'Thực phẩm', 200000, '2024-01-02', N'Mua sắm hàng tuần', 1),
(N'Hóa đơn tháng 1', N'Hóa đơn', 150000, '2024-01-07', N'Tiền điện, nước, v.v.', 1),
(N'Giải trí tháng 1', N'Giải trí', 100000, '2024-01-12', N'Xem phim', 1),
(N'Di chuyển tháng 1', N'Du lịch', 50000, '2024-01-17', N'Di chuyển công cộng', 1),
(N'Chăm sóc sức khỏe tháng 1', N'Y tế', 300000, '2024-01-22', N'Đi khám bác sĩ', 1),
(N'Mua sắm tháng 12', N'Thực phẩm', 200000, '2023-12-02', N'Mua sắm hàng tuần', 1),
(N'Hóa đơn tháng 12', N'Hóa đơn', 150000, '2023-12-07', N'Tiền điện, nước, v.v.', 1),
(N'Giải trí tháng 12', N'Giải trí', 100000, '2023-12-12', N'Xem phim', 1),
(N'Di chuyển tháng 12', N'Du lịch', 50000, '2023-12-17', N'Di chuyển công cộng', 1),
(N'Chăm sóc sức khỏe tháng 12', N'Y tế', 300000, '2023-12-22', N'Đi khám bác sĩ', 1);

select * from Income

select * from Expense

select * from UserInfo