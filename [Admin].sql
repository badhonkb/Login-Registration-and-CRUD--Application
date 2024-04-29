create database Book_Store
use Book_Store
create table [Admin]
( 
	Name VARCHAR(50),
    Gender varchar (50),
	DOB  varchar (50),
	Gmail Varchar(50),
	Mobile_Number varchar (50),
	Division varchar (50),
	District  varchar (50),
	User_Id VARCHAR(50) PRIMARY KEY,
	Password VARCHAR(50)
);



insert into [Admin] values('Badhon','Male' ,'Thursday, May 18, 2001' ,'bbadhon733@gmail.com ','01886111081','Chattogram','Feni','Admin1','admin1' );





select * from [Admin]
