CREATE DATABASE BD_SGHP

USE BD_SGHP

--Cria tabela usuario
CREATE TABLE usuario (
 id_usuario int identity(1, 1) NOT NULL,
 des_login varchar(20) UNIQUE,
 des_senha varchar(32),
 sts_usuario varchar(1),
 PRIMARY KEY (id_usuario)
);

--insere primeiro usuario
INSERT INTO usuario (des_login, des_senha, sts_usuario)
	VALUES ('adm', '1234', 'A');


--cria tabela pessoa
CREATE TABLE pessoa (
 id_pessoa int identity(1, 1) NOT NULL,
 des_nome varchar(50),
 des_cpf varchar(15) UNIQUE NOT NULL,
 des_rg varchar(15),
 dat_nasc DATE,
 des_endereco varchar(100),
 des_cidade varchar(30),
 des_estado varchar(2),
 des_tel varchar(13),
 des_email varchar(50),
 id_usuario int,
 PRIMARY KEY (id_pessoa),
);


--cria tabela funcionario 
CREATE TABLE funcionario(
 id_pessoa_funcionario int identity(1, 1) NOT NULL,
 num_funcionario_mat int FOREIGN KEY REFERENCES pessoa(id_pessoa) UNIQUE NOT NULL,
 data_admissao date,
 num_cod_ctps varchar(8),
 num_pis varchar(11),
 des_cargo varchar(45),
 dat_demissao date,
 PRIMARY KEY (id_pessoa_funcionario)
);


--cria tabela hospedes
CREATE TABLE hospedes(
 id_pessoa_hospede int identity(1, 1)NOT NULL,
 num_hospede int FOREIGN KEY REFERENCES pessoa(id_pessoa) UNIQUE,
 des_preferencias varchar(255),
 PRIMARY KEY (id_pessoa_hospede)
);


--Cria tabela tipos de apartamento
CREATE TABLE tipo_apartamento (
 id_tipo_apartamento int identity(1, 1) NOT NULL,
 des_tipo_apartamento varchar(20), --descrição do apartamento
 val_tipo_apartamento DECIMAL(5,2), --preço apartamento
 PRIMARY KEY (id_tipo_apartamento)
);


--insere 3 tipos de apartamento com valor diferente
INSERT INTO [dbo].[tipo_apartamento](
	[des_tipo_apartamento], 
	[val_tipo_apartamento])
VALUES
	('1 quarto', 100),
	('2 quartos', 250),
	('3 quartos', 350)
GO


--cria tabela apartamento
CREATE TABLE apartamento (
 id_apartamento_num int identity(1, 1) NOT NULL,
 num_andar int, -- andar do apartamento
 des_apartamento varchar(255),
 id_tipo_apartamento int FOREIGN KEY REFERENCES tipo_apartamento(id_tipo_apartamento), --numero do quarto
 PRIMARY KEY (id_apartamento_num)
);


--insere 15 apartamentos(3 por andar)
INSERT INTO [dbo].[apartamento]
	([num_andar]
	,[des_apartamento]
	,[id_tipo_apartamento])
VALUES
	(2, '1 quarto', 1),
	(2, '2 quarto', 2),
	(3, '3 quarto', 3)
GO


--cria tabela de reserva, checkin, checkout
CREATE TABLE reserva_hospedagem(
 id_res_hospedagem int identity(1, 1) NOT NULL,
 id_pessoa int FOREIGN KEY REFERENCES pessoa(id_pessoa),
 dat_entrada date,
 dat_saida date,
 dat_checkin date,
 dat_checkout date,
 val_total DECIMAL(5,2),-- valor do quarto
 var_acrescimo DECIMAL(5,2), --valor final
 sta_apartamento char(1),
 id_apartamento_num int FOREIGN KEY REFERENCES apartamento(id_apartamento_num), --numero do quarto
 PRIMARY KEY (id_res_hospedagem)
);










