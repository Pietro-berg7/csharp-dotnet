--SELECT * FROM Clientes
--WHERE Nome LIKE '%G%'
--ORDER BY Nome, Sobrenome



INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Pietro', 'Berganaschi', 'email@test.com', 1, GETDATE())

SELECT * FROM Clientes WHERE Nome = 'Pietro'