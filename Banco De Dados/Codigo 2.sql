Select * From Produtos

-- Count 
Select Count(*) QuantidadeProdutos from Produtos

Select Count(*) From Produtos Where Tamanho = 'M'

-- SUM
Select Sum(Preco) PrecoTotal From Produtos
Select Sum(Preco) PrecoTotal From Produtos Where Tamanho = 'M'

-- Min,Max,AVG
Select Max(Preco) From Produtos
Select Max(Preco) From Produtos Where Tamanho = 'M'
Select Min(Preco) From Produtos
Select Min(Preco) From Produtos Where Tamanho = 'M'
Select AVG(Preco) From Produtos -- media 

-- Concatenando Colunas
Select Nome + ' - ' + Cor + ' - ' + Genero NomeProduto from Produtos

Select Nome + ' - ' + Cor + ' - ' + Genero NomeProduto,
UPPER(Nome) Nome, -- deixar tudo maiusculo
Lower (Cor) Cor  -- deixar tudo minusculo
from Produtos

-- Adicionando Coluna 

Alter Table Produtos Add DataCadastro DATETIME2
Select * From Produtos

Update Produtos Set DataCadastro = GETDATE()

-- Formatando Data

Select Nome + ' - ' + Cor + ' - ' + Genero NomeProduto,
UPPER(Nome) Nome, -- deixar tudo maiusculo
Lower (Cor) Cor,  -- deixar tudo minusculo
Format (DataCadastro,'dd/MM/yyyy hh:mm') Data
from Produtos

-- Agrupando dados 

Select Tamanho,Count(*) From Produtos Group By Tamanho

Select Tamanho,Count(*) Quantidade From Produtos where Tamanho <> '' Group By Tamanho order by Quantidade Desc

-- Chave estrangeira
Create Table Enderecos (
Id int Primary key identity(1,1) not null,
IdCliente int Null,
Rua varchar(255),
Bairro varchar(255),
Cidade varchar(255),
Estado char(2) null,

 Constraint FK_Enderecos_Clientes Foreign key(IdCliente)
 References Clientes(id) -- criando chave estrangeira e referenciando em outra tabela
)

Select * From Enderecos

INSERT INTO Enderecos Values(4,'Rua Manuel bairros de lima', 'Porto Da Areia', 'Estancia', 'SP')

Select * From Clientes where Id= 4
Select * From Enderecos where IdCliente = 4

-- JOIN 

Select * From Clientes INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
Where Clientes.Id =4










