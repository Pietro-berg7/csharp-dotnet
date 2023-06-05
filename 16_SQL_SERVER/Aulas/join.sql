SELECT
	C.Nome,
	C.Sobrenome,
	C.Email,
	E.Rua,
	E.Bairro,
	E.Cidade,
	E.Estado
FROM
	Clientes c
INNER JOIN Enderecos e ON C.Id = E.IdCliente
WHERE C.Id = 4


--SELECT
--	Clientes.Nome,
--	Clientes.Sobrenome,
--	Clientes.Email,
--	Enderecos.Rua,
--	Enderecos.Bairro,
--	Enderecos.Cidade,
--	Enderecos.Estado
--FROM
--	Clientes
--INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
--WHERE Clientes.Id = 4