create table cidades(
	id int not null identity (1000, 1)primary key,
	cidade varchar(55) not null,
	estado_id int not null foreign key references estados(id)
	);