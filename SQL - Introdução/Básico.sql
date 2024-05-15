--SELECT * FROM Clientes
--WHERE Nome LIKE 'G%'
--ORDER BY Id

--INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
--VALUES ('Carlos', 'Miguel', 'email@email.com', 1, GETDATE())

--INSERT INTO Clientes VALUES ('Carlos Miguel', 'Webber', 'email@email.com', 1, GETDATE())

--SELECT * FROM Clientes WHERE Nome = 'Carlos'

--SELECT * FROM Clientes

--BEGIN TRAN
--ROLLBACK

--UPDATE Clientes
--SET Email = 'atualizado@email.com',
--	AceitaComunicados = 0
--WHERE Id = 1001

--SELECT * FROM Clientes;

--DELETE Clientes
--Where Id = 1001

CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL
)

SELECT * FROM Produtos