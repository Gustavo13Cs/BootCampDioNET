Select * From Clientes;
Select * From Produtos;

Select * From Clientes ORDER BY Nome 
Select * From Clientes ORDER BY Nome Desc
Select * From Clientes ORDER BY Nome, Sobrenome

Select Nome,Sobrenome,Email From Clientes 

Select * From Clientes WHERE Nome = 'Ken'
Select * From Clientes WHERE Nome = 'Ken' AND Sobrenome = 'Sánchez'
Select * From Clientes WHERE Nome = 'Ken' OR Sobrenome = 'Sánchez'

Select * From Clientes Where  Nome Like 'G%'

INSERT INTO Clientes VALUES ('Gustavo','Cunha','email@email.com',0,'Jan  7 2009 12:00AM')

Update Clientes Set Email = 'gustavocunha0401@gmail.com' Where Id = 27 -- não pode esquecer de colocar o where, se n vai atualizar o de todos

Delete Clientes Where Id = 14

ROLLBACK
BEGIN TRAN

CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL
)