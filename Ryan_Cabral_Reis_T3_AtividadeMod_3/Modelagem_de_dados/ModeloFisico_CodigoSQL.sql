create database AgenciaViagens;

use AgenciaViagens;

create table Cliente(
id_cliente int identity (1,1) primary key not null,
nome_cliente varchar(50) not null,
email varchar(50) not null,
data_Nasc date not null,
data_Ida date not null,
data_Volta date not null
);

insert into Cliente (nome_cliente,email,data_Nasc,data_Ida,data_Volta) values
('Lorem Ipsum', 'mamsamsa', '25/12/2022', '30/12/2021', '10/01/2022');

select * from Cliente;

create table destino(
id_destino int identity (1,1) primary key not null,
estado_Destino varchar(60) not null,
cidade_Destino varchar(60) not null,
pais_Destino varchar(60) not null,
preco decimal not null,

foreign key (id_cliente) references destinos(id_cliente)
);
