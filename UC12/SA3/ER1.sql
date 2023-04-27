CREATE DATABASE TesteSeguranca;

USE TesteSeguranca;

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) NOT NULL,
	Senha VARCHAR(50) NOT NULL
);

INSERT INTO Usuarios VALUES ('email@email.com', 1234);

SELECT * FROM Usuarios;

SELECT Email, Senha FROM Usuarios;

SELECT Id, Email, Senha FROM Usuarios;

SELECT Email, HASHBYTES('MD2',Senha) FROM Usuarios;

SELECT Email, HASHBYTES('MD2',Senha) AS 'Senha Hash' FROM Usuarios;
SELECT Email, HASHBYTES('MD4',Senha) AS 'Senha Hash' FROM Usuarios;
SELECT Email, HASHBYTES('MD5',Senha) AS 'Senha Hash' FROM Usuarios;
SELECT Email, HASHBYTES('SHA',Senha) AS 'Senha Hash'FROM Usuarios;
SELECT Email, HASHBYTES('SHA1',Senha) AS 'Senha Hash'FROM Usuarios;
SELECT Email, HASHBYTES('SHA2_256',Senha) AS 'Senha Hash'FROM Usuarios;
SELECT Email, HASHBYTES('SHA2_512',Senha) AS 'Senha Hash'FROM Usuarios;



