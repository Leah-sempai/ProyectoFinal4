create database Final
use Final
go

create table Users(
UserID int identity (1,1) primary key not null,
LoginName nvarchar(90) unique not null,
Password nvarchar(45) not null,
Nombre nvarchar(50) not null,
Apellido nvarchar (45) not  null,
Posicion nvarchar (50) not null,
Email nvarchar (50) not null
)
go


insert into Users values('Admin','admin','Francisco','Berroa','Estudiante','20209462@itla.edu.do')
insert into Users values('General','gn23','Leandry','Belen','general','leandry368@gmail.com')
go

create proc SP_login
@LoginName nvarchar(90),
@Password nvarchar (45)
as
select * from Users where LoginName=@LoginName and Password=@Password

select * from Users where LoginName='admin' and Password = 'admin'
declare @user nvarchar(90) = 'admin'
declare @pass nvarchar (45) = 'admin'

create table Usuario(
IdUsuario int identity (1,1) primary key not null,
Nombre nvarchar(50) not null,
Apellido nvarchar (45) not  null,
Carrera nvarchar (40) not null,
Email nvarchar (50) not null,
Edificio nvarchar (50) not null,
Hora nvarchar(50) not null,
Aula nvarchar(10) not null,
Motivo nvarchar (99) not null
)
go

create proc SP_buscarvisitas
@buscar nvarchar(50)
as
select * from Usuario
where Nombre like @buscar + '%'
go

create proc SP_insertarusuario
@Nombre nvarchar(50),
@Apellido nvarchar (45),
@Carrera nvarchar (40),
@Email nvarchar (50),
@Edificio nvarchar (50),
@Hora nvarchar(50),
@Aula nvarchar(10),
@Motivo nvarchar (99)
as
begin 
insert into Usuario values(@Nombre,@Apellido,@Carrera,@Email,@Edificio,@Hora,@Aula,@Motivo)
end;
go

create proc SP_editarusuario
@IdUsuario int,
@Nombre nvarchar(50),
@Apellido nvarchar (45),
@Carrera nvarchar (40),
@Email nvarchar (50),
@Edificio nvarchar (50),
@Hora nvarchar(50),
@Aula nvarchar(10),
@Motivo nvarchar (99)
as
UPDATE [dbo].[Usuario]
   SET [Nombre]= @Nombre
	  ,[Apellido] = @Apellido
	  ,[Carrera] = @Carrera
	  ,[Email] = @Email
	  ,[Edificio] = @Edificio
	  ,[Hora] = @Hora
	  ,[Aula] = @Aula
	  ,[Motivo] = @Motivo
where Usuario.IdUsuario = @IdUsuario
go

create proc SP_eliminarusuario
@IdUsuario int 
as
delete Usuario
where IdUsuario = @IdUsuario

create table Edificio(
IdEdificio int identity (1,1) primary key not null,
)
go

create table General(
IdGeneral int identity (1,1) primary key not null,
Nombre nvarchar(50) not null,
Apellido nvarchar (45) not null,
Fecha nvarchar (100) not null
)
go

create proc SP_buscargeneral
@buscar nvarchar(50)
as 
select * from General
where Nombre like @buscar + '%'
go

create proc SP_insertargeneral
@Nombre nvarchar (50),
@Apellido nvarchar (45),
@Fecha nvarchar(100)
as
begin 
insert into General values(@Nombre,@Apellido,@Fecha)
end;
go

create proc SP_editargeneral
@IdGeneral int,
@Nombre nvarchar(50),
@Apellido nvarchar(45),
@Fecha nvarchar(100)
as

UPDATE [dbo].[General]
   SET [Nombre] = @Nombre
      ,[Apellido] = @Apellido
	  ,[Fecha] = @Fecha

WHERE General.IdGeneral = @IdGeneral
go

create proc SP_eliminargeneral
@IdGeneral int 
as
delete General
where IdGeneral=@IdGeneral

go

create proc SP_buscaredificio
@buscar nvarchar(50)
as
select * from Usuario
where Edificio like @buscar + '%'

create proc SP_buscaraula
@buscar nvarchar (50)
as
select * from Usuario
where Aula like @buscar + '%'




		




