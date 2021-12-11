create database AgenciaViagens;

use AgenciaViagens;

create table Cliente(
id_cliente int identity (1,1) primary key not null,
nome_cliente char(50) not null,
email char(50) not null,
senha char(8) not null,
data_Nasc char(12) not null,
estado_Origem char(60) not null,
data_Ida char(12) not null,
data_Volta char(12) not null
);

create table Destino(
id_destino int identity (1,1) primary key not null,
estado_Destino char(60) not null,
cidade_Destino char(60) not null,
pais_Destino char(60) not null,
preco decimal not null
);