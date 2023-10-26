CREATE DATABASE BDEcommerce
GO

USE BDEcommerce
GO

CREATE TABLE Produto
(
	ProdutoId	int				primary key		identity,
	Nome		varchar(200)	not null,
	Preco		decimal(9,2)	not null
)

INSERT INTO Produto Values('Lapis', 1.50)
INSERT INTO Produto Values('Caneta', 2.50)
INSERT INTO Produto Values('Caderno', 7.20)

UPDATE Produto
SET Nome = 'Lapis', Preco= 1.50
WHERE ProdutoId = 1;

SELECT * FROM Produto


CREATE TABLE Cliente
(
		ClienteId		int				primary key		identity,
		Name			varchar(200)	not null,
		Email			varchar(200)	not null,
		Password		varchar(20)		not null
)

SELECT * FROM Cliente
   --// propriedades:
   -- private int clienteId;
   -- private string name;
   -- private string email;
   -- private string password;
