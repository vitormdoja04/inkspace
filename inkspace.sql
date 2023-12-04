create database inkspace;
use inkspace;
create table adm(
cod_adm int primary key auto_increment,
login_adm varchar(50) not null,
senha_adm varchar(50) not null
);

create table pedidos(
cod_pedido int primary key auto_increment,
nome_pedido varchar(50) not null,
cpf_pedido varchar(20) not null,
telefone_pedido varchar(20) not null,
data_pedido varchar(50) not null,
horario_pedido varchar(5) not null,
disponibilidade_pedido char(3) not null,
tipo_pedido varchar(14) not null,
preco_pedido varchar(20) not null,
imagem_ref_pedido mediumblob,
desc_pedido varchar(300)
);
select * from adm;
select * from pedidos;
insert into adm (login_adm, senha_adm) values ("vitor.doja", "123");
insert into adm (login_adm, senha_adm) values ("gustavo.torres", "321");
drop database inkspace;