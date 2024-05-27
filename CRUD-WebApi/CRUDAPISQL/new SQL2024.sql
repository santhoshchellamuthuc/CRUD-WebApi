Create Table HospitalDetails(
Id  bigint identity(1,1) Primary key ,
Name nvarchar(100) Not null,
Email nvarchar(100) unique,
Address nvarchar(300) Not null,
Phonenumber bigint Not null,
Pincode bigint Not null)


--drop table HospitalDetails
create or alter procedure  HospitalLogin
 
 (@Name nvarchar(50), 
 @Email nvarchar(100),
 @Address nvarchar(100),
 @Phonenumber bigint,
 @Pincode bigint) 
 
 AS
 Begin
 Insert into[dbo] .[HospitalDetails]
 ([Name],[Email],[Address],[Phonenumber],[Pincode])
 values(
 @Name,
 @Email,
 @Address,
 @Phonenumber,
 @Pincode)
end

--exec HospitalLogin  'santhosh','santhosh12@gmail.com','wvfwfwqfwqff',909099090,624613
select *from [HospitalDetails]

 create or alter procedure HospitalEdit
(@Id Bigint,
 @Name nvarchar(100),
 @Email nvarchar(100),
 @Address nvarchar(100),
 @Phonenumber bigint,
 @Pincode bigint
 ) 
 As
 Begin
 update HospitalDetails set Name=@Name, Email=@Email,Address=@Address,Phonenumber=@Phonenumber,Pincode=@Pincode 
 where Id=@Id
 end

-- exec HospitalEdit 2, 'santoshkumar','madesh123@gmail.com','2/23,porulur,dindugul',9090909090,624616
 select *from HospitalDetails

 create or alter procedure HospitalDelete
 (@Id Bigint)
 As
 begin Delete  HospitalDetails where Id=@Id end

 --exec HospitalDelete 2
 select *from HospitalDetails

 create or alter procedure HospitalSearch
 (@Name nvarchar (100))
 As
 Begin select * from HospitalDetails 
 where
 Id like '%'+@Name+'%' or
 Name like'%'+@Name+'%'or
 Email like'%'+@Name+'%'or
 Address like '%'+@Name+'%' or
 Phonenumber like'%'+@Name+'%' or
 Pincode like'%'+@Name+'%' end

 -- exec HospitalSearch 909099090
 --  create or alter procedure HospitalSelect
 --(@Id Bigint,
 --@Name nvarchar(100),
 --@Email nvarchar(100),
 --@Address nvarchar(100),
 --@Phonenumber bigint,
 --@Pincode bigint)
   
 --As
 --Begin select *from HospitalDetails where Name=@Name,Email=@Email,Address=@Address,