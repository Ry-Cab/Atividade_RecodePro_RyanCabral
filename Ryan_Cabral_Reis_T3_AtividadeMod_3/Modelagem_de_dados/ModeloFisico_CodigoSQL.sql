create database AgenciaViagens;

use AgenciaViagens;

create table Cliente(
id_cliente int primary key not null,
nome_cliente char(50) not null,
email char(50) not null,
senha char(8) not null,
dataNasc char(12) not null,
estadoOrigem char(60) not null,
dataIda char(12) not null,
dataVolta char(12) not null
);