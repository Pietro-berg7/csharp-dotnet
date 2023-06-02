--SELECT * FROM Clientes
--WHERE Nome LIKE '%G%'
--ORDER BY Nome, Sobrenome



--INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
--VALUES ('Pietro', 'Berganaschi', 'email@test.com', 1, GETDATE())

--INSERT INTO Clientes VALUES ('Pietro', 'Berganaschi', 'email@test.com', 1, GETDATE())

SELECT * FROM Clientes WHERE Nome = 'Pietro'

UPDATE Clientes
SET Email = 'emailatualizado@test.com',
	AceitaComunicados = 0
WHERE Id = 1002