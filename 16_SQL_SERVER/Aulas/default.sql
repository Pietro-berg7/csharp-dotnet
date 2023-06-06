SELECT * FROM Produtos

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero)
VALUES ('Produto teste 3', 10, 'G', 'M')

ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro