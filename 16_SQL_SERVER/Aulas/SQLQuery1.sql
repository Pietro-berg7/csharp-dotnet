SELECT * FROM Produtos WHERE Tamanho = 'M'

EXEC ObterProdutosPorTamanho 'P'

CREATE PROCEDURE ObterProdutosPorTamanho
@TamanhoProduto VARCHAR(5)

AS

SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto