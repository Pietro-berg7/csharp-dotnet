SELECT
	Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProduto,
	UPPER(Nome) Nome,
	LOWER(Cor) Cor,
	FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') Data
FROM Produtos