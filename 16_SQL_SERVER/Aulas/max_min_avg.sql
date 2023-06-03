SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos

SELECT MAX(Preco) ProdutoMaisCaroTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos

SELECT MIN(Preco) ProdutoMaisBaratoTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT AVG(Preco) Media FROM Produtos