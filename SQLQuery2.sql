create table estados(
	id int not null identity (100, 1)primary key,
	estado varchar(55) not null,
	sigla varchar(2) not null,
	pais_id int not null foreign key references paises(id)
	);