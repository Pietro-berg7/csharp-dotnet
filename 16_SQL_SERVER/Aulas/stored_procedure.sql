SELECT * FROM Produtos

INSERT INTO Produtos (Nome, Preco, Tamanho, Genero)
VALUES ('Produto teste 3', 10, 'G', 'M')

EXEC InserirNovoProduto
'NOVO PRODUTO PROCEDURE',
'COLORIDO',
50,
'G',
'U'

--CREATE PROCEDURE InserirNovoProduto
--@Nome varchar(255),
--@Cor varchar(50),
--@Preco decimal,
--@Tamanho varchar(5),
--@Genero char(1)

--AS

--INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
--VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)




SELECT * FROM Produtos WHERE Tamanho = 'M'

EXEC ObterProdutosPorTamanho 'P'
EXEC ObterTodosProdutos

CREATE PROCEDURE ObterTodosProdutos
AS
SELECT * FROM Produtos


CREATE PROCEDURE ObterProdutosPorTamanho
@TamanhoProduto VARCHAR(5)
AS
SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto