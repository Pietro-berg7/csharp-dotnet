SELECT * FROM Produtos

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Produto teste', 10, 'G', 'M', GETDATE())

ALTER TABLE Produtos
ADD UNIQUE(Nome)