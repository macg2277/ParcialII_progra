create database BDParcial2ManuelYLuis

use BDParcial2ManuelYLuis

Create Table Departamento (
	IdDepartamento Int Not Null Primary Key Identity(1,1),
	N_departamento Char(25));

	Create Table Municipio  (
	IdMunicipio Int Not Null Primary Key Identity(1,1),
	Municipio Varchar(15) Not Null,
	Departamento int  not null foreign Key References Departamento(IdDepartamento)
	);
Create table Cliente (
IdCliente int primary key identity (1,1), 
Nombre varchar(20) not null ,
Apellido varchar (20) not null ,
Departamento int  not null foreign Key References departamento(IdDepartamento),
Municipio int  not null foreign Key References municipio(IdMunicipio)
);
	Insert Into departamento Values('San Salvador');
	Insert Into departamento Values('La Paz');
	Insert Into departamento Values('La libertad');
	Insert Into departamento Values('Cuscatlan');

	insert Into Municipio Values('Ilopango',1);
	insert Into Municipio Values('Apopa',1);
	insert Into Municipio Values('San Salvador',1);
	Insert Into Municipio Values('La Paz',2);
	
	Insert Into Municipio Values('san luis talpa',2)
	Insert Into Municipio Values('Olocuilta',2)

	insert Into Municipio Values('Tepecoyo',3);
	insert Into Municipio Values('Teotepeque',3);
	insert Into Municipio Values('Jicalapa',3);

	insert Into Municipio Values('Cojutepeque',4);
	insert Into Municipio Values('Tenancingo',4);
	insert Into Municipio Values('Suchitoto',4);

	select *from Municipio
	select *from Departamento

	Insert Into Cliente values ('Jorge','Martinez',1,3);

	select *from Cliente