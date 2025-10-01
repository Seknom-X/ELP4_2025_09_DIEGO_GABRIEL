create table fornecedores(
	id int not null identity (100000, 1) primary key,
	cnpj varchar(14) not null,
	razaoSocial varchar(100) not null,
	contato varchar(100) not null,
	telefone varchar(15) not null,
	email varchar(100) not null,
	endereco varchar(100) not null
	);