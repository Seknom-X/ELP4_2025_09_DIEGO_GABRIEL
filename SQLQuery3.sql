create table produtos(
    id int not null identity (1000000, 1) primary key,
	codigo_barras varchar(13) not null,
	produto varchar(100) not null,
	grupo varchar(50) not null,
	referencia varchar(20) not null,
	unidade varchar(5) not null
	);