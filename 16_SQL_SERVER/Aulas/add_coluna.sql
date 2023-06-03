SELECT * FROM Produtos

ALTER TABLE Produtos
ADD DataCadastro DATETIME2

ALTER TABLE Produtos
DROP COLUMN DataCadastro

UPDATE Produtos SET DataCadastro = GETDATE()