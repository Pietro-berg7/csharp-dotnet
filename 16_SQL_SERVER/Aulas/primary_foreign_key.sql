CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)
)


INSERT INTO Enderecos VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'MG')


SELECT * FROM Clientes WHERE Id = 4
SELECT * FROM Enderecos WHERE IdCliente = 4