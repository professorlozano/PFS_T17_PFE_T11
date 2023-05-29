CREATE DATABASE Chapter
GO

USE Chapter
GO

CREATE TABLE Livros (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    QuantidadePaginas INT,
    Disponivel BIT
)
GO

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) 
VALUES ('Titulo A', 120, 1)
GO

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) 
VALUES ('Titulo B', 220, 0)
GO

-- UPDATE Livros SET Titulo = 'Titulo A1' Where Id = 1;

 -- DELETE FROM Livros WHERE Id = 1;

SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY, -- essa parte diferente do material web
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
    Tipo CHAR(1) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@sp.br', '1234', '0') -- adicionar o id
GO

SELECT * FROM Usuarios WHERE email = 'email@sp.br' AND senha = '1234'
GO
