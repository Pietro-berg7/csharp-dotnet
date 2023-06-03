SELECT * FROM Produtos 

SELECT COUNT(*) QuantidadeProdutos FROM Produtos

SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M'