use Demo;
create table Users
(
UserId int  primary key identity(1,1),
Email varchar(30),
UserName varchar(30),
Password varchar(30),
MobileNumber varchar(30),
UserRole varchar(30),
ProfileImage varchar(30)

);

insert into Users values(),

drop table Users;
drop table Courses;
create table Courses
(
CourseId int primary key identity(1,1),
Title varchar(30),
Description varchar(30),
CourseStartDate datetime2(7),
CourseEndDate datetime2(7),
UserId int,
foreign key(UserId) references Users(UserId),
Category varchar(30),
Level varchar(30)
);

insert into Courses(Title,Description,CourseStartDate,CourseEndDate,Category,Level) values('Java','For Develope the Application','2020-11-20','2023-2-01','Programming language','Begineers'),('Python','For Develope the Application','2020-01-20','2023-4-01','Programming language','Advance');
drop table Enrollment;
select * from Users;

select * from Courses;

select * from Enrollment;
create table Enrollment(
	EnrollmentId int primary key identity(100,1),
	UserId int,
	CourseId int,
	Title varchar(30),
	
	EnrollmentDate datetime,
	Status varchar(20)
);
select * from Enrollment;

select * from Material;
 
create table Material(
	MaterialId int primary key identity(1,1) ,
	CourseId int,
	Title varchar(30),
	Description varchar(100),
	URL varchar(100),
	UploadDate datetime,
	ContentType varchar(30)
);
 select * from Enquiry;
create table Enquiry(
	EnquiryId int primary key identity(1,1),
	UserId int,
	CourseId int,
	Subject varchar(100),
	Message varchar(300),
	EnquiryDate datetime,
	Status varchar(20),
	Response varchar(300)
);

drop table Enquiry;


 select * from Feedback;
 drop table Feedback;
create table Feedback(
	FeedbackId int primary key identity(1,1),	
	UserId int,
	Feedback varchar(300),
	Date datetime,
	courseId int,
	username varchar(30)
);

select * from Feedback;