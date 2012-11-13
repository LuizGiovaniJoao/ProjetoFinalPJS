CREATE DATABASE BD_AcervoMusical

USE BD_AcervoMusical
GO

create table Midia
(	
	Id int not null primary key,
	Interprete varchar(50),
	Autor varchar(50)not null,
	Album varchar(50),
	Musica varchar(70),
	DataAlbum datetime,
	DataAqusicao datetime,
	OrigemCompra varchar(100),
	Tipo varchar(20) not null,
	Observacoes varchar (200),
	Nota smallint 

);

create table Amigo
(
	Apelido varchar(50) primary key,
	Nome varchar(50) not null,
	Endereco varchar(70) ,
	Bairro varchar(50),
	Cidade varchar(50)not null,
	UF varchar(2)not null,
	Telefone varchar(15),
	Celular varchar(15),
	email varchar(50),
);

create table Emprestimo
(
	Id int not null primary key,
	Nome_Amigo varchar(50) not null,
	Endereco_Amigo varchar(70) not null,
	DataEmprestimo datetime not null,
	
);

create table ItemEmprestimo
(
	Id int not null primary key,
        FOREIGN KEY (Id) REFERENCES Emprestimo(Id),
	FOREIGN KEY (Id) REFERENCES Midia(Id),
	Album varchar(50),
	TipoMidia varchar(20),
	DataDevolucao datetime
	
);