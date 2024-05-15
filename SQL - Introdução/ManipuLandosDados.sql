--SELECT COUNT(*) QuantidadeProdutos FROM Produtos

--SELECT COUNT(*) TamanhosM FROM PRODUTOS WHERE Tamanho = 'M'

--SELECT * FROM PRODUTOS

--SELECT SUM(PRECO) PrecoTotal FROM PRODUTOS

--SELECT SUM(PRECO) PrecoM FROM PRODUTOS WHERE Tamanho = 'M'

--SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos

--SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos

--SELECT AVG(Preco) Media From Produtos

--SELECT 
--	Nome + ' - ' + Cor ProdutosCompleto,
--	UPPER(Nome) Nome,
--	LOWER(Cor) Cor
--FROM Produtos

--ALTER TABLE Produtos
--ADD DataCadastro DATETIME2

--ALTER TABLE Produtos
--DROP COLUMN DataCadastro 

--UPDATE Produtos SET DataCadastro = GETDATE()

--SELECT * FROM Produtos

--SELECT 
--	Nome + ' - ' + Cor ProdutosCompleto,
--	UPPER(Nome) Nome,
--	LOWER(Cor) Cor,
--	FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm')
--FROM Produtos

--SELECT 
--	Tamanho,
--	COUNT(*) Quantidade
--FROM Produtos
--WHERE Tamanho <> ''
--GROUP BY Tamanho
--ORDER BY Quantidade DESC

--CREATE TABLE Enderecos (
--	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	IdCliente int NULL,
--	Rua varchar(255) NULL,
--	Bairro varchar(255) NULL,
--	Cidade varchar(255) NULL,
--	Estador char(2) NULL,

--	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
--	REFERENCES Clientes(Id)
--)

--SELECT * FROM Enderecos WHERE IdCliente = 4
--SELECT * FROM Clientes WHERE Id = 4

--INSERT INTO Enderecos VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'RS')

SELECT
	C.Nome,
	C.Sobrenome,
	C.Email,
	E.Bairro,
	E.Cidade,
	E.Estador
FROM 
	Clientes C
INNER JOIN Enderecos E ON C.Id = E.IdCliente
WHERE C.Id = 4
