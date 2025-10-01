create table paises(
	id int not null identity (10, 1)primary key,
	pais varchar(55) not null,
	sigla varchar(3) not null,
	ddi varchar(4) not null,
	moeda varchar(3) not null
	);
