SELECT * FROM Produtos

ALTER TABLE Produtos
ADD CONSTRAINT CHK_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F')

--INSERT INTO Produtos (Nome, Preco, Tamanho, Genero, DataCadastro)
--VALUES ('Produto teste2', 10, 'G', 'Z', GETDATE())

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Produto teste2', 10, 'G', 'M', GETDATE())