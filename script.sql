-- CRIANDO BANCO DE DADOS
CREATE DATABASE dbloja;
-- USANDO BANCO DE DADOS
USE dbloja;

-- CRIANDO AS TABELAS
CREATE TABLE Usuario(
	id int primary key auto_increment,
    nome varchar(40) not null,
    email varchar(40) not null,
    senha varchar(40) not null
);

CREATE TABLE Cliente(
	codCliente int primary key auto_increment,
    nomeCli varchar(40) not null,
    telCli varchar(40) not null,
    emailCli varchar(40) not null
);

-- CONSULTANDO AS TABELAS
SELECT * FROM Usuario;
SELECT * FROM Cliente;