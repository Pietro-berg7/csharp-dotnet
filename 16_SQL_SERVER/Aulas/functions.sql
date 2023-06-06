--SELECT
--	Nome,
--	Preco,
--	FORMAT(Preco - Preco / 100 * 10, 'N2') PrecoComDesconto
--FROM Produtos WHERE Tamanho = 'M'

SELECT
	Nome,
	Preco,
	dbo.CalcularDesconto(Preco, 10) PrecoComDesconto
FROM Produtos WHERE Tamanho = 'M'

CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13, 2), @Porcentagem INT)
RETURNS DECIMAL(13, 2)
BEGIN
	RETURN @Preco - @Preco / 100 * @Porcentagem
END