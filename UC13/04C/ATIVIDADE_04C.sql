--ATIVIDADE 4C

--CRIAÇÃO DA BASE DE DADOS
CREATE DATABASE RpgResposta;

--COLOCAR BASE DE DADOS EM USO
USE RpgResposta;

--CRIAÇAO DAS TABELAS NO BANCO
CREATE TABLE Usuarios
(
	UsuarioId INT PRIMARY KEY IDENTITY,
	Email VARCHAR(150) UNIQUE NOT NULL,
	Senha VARCHAR(255) NOT NULL
);

CREATE TABLE Classes
(
	ClasseId INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(150) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
);

CREATE TABLE Personagens
(
	PersonagemId INT PRIMARY KEY IDENTITY,
	NomePersonagem VARCHAR(10) UNIQUE NOT NULL,
	UsuarioId INT UNIQUE FOREIGN KEY REFERENCES Usuarios(UsuarioId),
	ClasseId INT FOREIGN KEY REFERENCES Classes(ClasseId)
);

CREATE TABLE Habilidades
(
	HabilidadeId INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(150) UNIQUE NOT NULL
);

CREATE TABLE ClassesHabilidades
(
	ClasseId INT FOREIGN KEY REFERENCES Classes(ClasseId),
	HabilidadeId INT FOREIGN KEY REFERENCES Habilidades(HabilidadeId)
);

--INSERÇÃO DE DADOS NO BANCO DE DADOS
INSERT INTO Usuarios VALUES ('Danos', 'Senha1234');
INSERT INTO Usuarios VALUES ('Teste', 'Senha1234');
INSERT INTO Classes VALUES ('Monge','Descrição do Monge');
INSERT INTO Habilidades VALUES ('Recuperar Vida');
INSERT INTO Personagens (NomePersonagem, UsuarioId, ClasseId) VALUES ('DeuBug',1,1);
INSERT INTO ClassesHabilidades(ClasseId, HabilidadeId) VALUES (1,1);

--SELEÇÃO DE DADOS DO BANCO
SELECT * FROM Usuarios;
SELECT * FROM Classes;
SELECT * FROM Habilidades;
SELECT * FROM Personagens;
SELECT * FROM ClassesHabilidades;

SELECT Email, Senha FROM Usuarios WHERE Email = 'Danos';

-- ALTERAÇÃO NOS DADOS
UPDATE Usuarios SET Email = 'Teste Alterado' WHERE UsuarioId = 1;

-- EXCLUSAO DE DADOS
DELETE FROM Usuarios WHERE UsuarioId = 1;


