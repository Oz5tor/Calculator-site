use Skole
go
drop table Users 
--go
create table Users(
		UserID int primary key identity (1,1),
		Username varchar(30),
		Userpwd varchar(30),
		Adresse varchar(30),
		Email varchar(80),
		Usertype varchar(20),
		Userright int,
);

Insert into Users values ('Tor','123', 'Krudttårnsvænget', 'tec@mail.dk', 'Subcalc');
go


update Users set Usertype = 'Sub' Where Usertype = 'sub'

select * from Users