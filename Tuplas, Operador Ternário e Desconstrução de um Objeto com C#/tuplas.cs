(int,string,string,decimal) tupla = (1,"Gustavo","Cunha", 1.69M); <-- melhor jeito -->
ValueTuple<int,string,string,decimal> outroexemplo = (1,"Gustavo","Cunha", 1.69M); 
var outroexemploTuplaCreate = Tuple.Create(1,"Gustavo","Cunha", 1.69M);


console.WriteLine($"Id: {tupla.Item1}");
console.WriteLine($"Nome: {tupla.Item2}");
console.WriteLine($"Sobrenome: {tupla.Item3}");
console.WriteLine($"Altura: {tupla.Item4}");

