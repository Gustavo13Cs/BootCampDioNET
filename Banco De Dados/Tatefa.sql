-- 1 

Select Nome,Ano FROM Filmes

-- 2 

Select Nome,Ano,Duracao From Filmes ORDER BY Ano asc

-- 3 

Select * From Filmes WHERE Nome = 'De Volta para o futuro' 

-- 4 

Select * From Filmes WHERE Ano = '1997'

-- 5 

Select * From Filmes WHERE Ano > '2000'

-- 6

Select * From Filmes 
WHERE Duracao > '100' AND Duracao < '150'
ORDER BY Duracao ASC

-- 7 

Select Ano,Count(*) Quantidade From Filmes where Ano <> '' Group By Ano order by Quantidade Desc

-- 8 

Select * From Atores Where Genero = 'M'

-- 9 

Select * From Atores Where Genero = 'F' order by PrimeiroNome asc

-- 10 

-- 11 

-- 12







