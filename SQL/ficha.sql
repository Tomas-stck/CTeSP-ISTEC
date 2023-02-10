create database ficha_avaliacao;

create table alunos(
	num int unique primary key,
	nome nvarchar(50)not null,
	rua nvarchar(80)not null,
	cpostal nvarchar(4)not null,
	localidade nvarchar(25)not null
);

create table disciplina(
	coddisc int unique primary key,
	ano int default 1988,
	ndisc int unique,
	codlic int,
	constraint FK_codlic foreign key (codlic)
	references licenciatura(codlic)
);

create table licenciatura(
	codlic int unique primary key,
	nlic int unique
);

create table inscricao(
	codinsc int unique primary key,
	aluno int unique,
	disciplina int,
	ano int default 1988,
	data date default '20000101',
	datafim date default '20000101',
	constraint FK_discano foreign key (ano)
	references disciplina(ano),
	constraint FK_coddisc foreign key (disciplina)
	references disciplina(coddisc),
	constraint FK_aluno foreign key (aluno)
	references alunos(num)
);

create table avaliacao(
	idaval int unique primary key,
	aluno int unique,
	disciplina int,
	ano int default 1988,
	tipoaval int,
	nota int,
	constraint FK_idtipo foreign key (tipoaval)
	references tipoavaliacao(idtipo),	
	constraint FK_discano foreign key (ano)
	references disciplina(ano),
	constraint FK_coddisc foreign key (disciplina)
	references disciplina(coddisc),
	constraint FK_aluno foreign key (aluno)
	references alunos(num)
);

create table tipoavaliacao(
	idtipo int unique primary key,
	descritivo nvarchar(50)
);