create table fornecedores(
	id int not null identity (100000, 1) primary key,
	cpnj varchar(14) not null,
	razao_social varchar(100) not null,
	);