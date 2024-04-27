using Tuplas__Operador_Ternário_e_Desconstrução_de_um_Objeto_com_C_.Models;

// LeituraArquivo arquivo = new LeituraArquivo();

// // quando vc n precisar de uma das informações da tupla e só colocar um _ no lugar
// var (sucesso,linhasArquivo, QuantidadeDeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//    Console.WriteLine("Quantidade linhas do arquivo:" + QuantidadeDeLinhas); 
//    foreach(string linha in linhasArquivo)
//    {
//      Console.WriteLine(linha);
//    } 
// }
// else{
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }


// Serialização 

using Newtonsoft.Json;
using System.Data;

DateTime dataAtual = DateTime.Now; // pegar a data exata 
List<Venda> listaVendas = new List<Venda>();
Venda v1 = new Venda(1,"Material de escritorio",25.00M,dataAtual);
Venda v2 = new Venda(2,"Licença de Sotware",110.00M,dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

// Newtonsoft e um pacote que ajuda a serealizar

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //PRA QUEBRAR LINHA
File.WriteAllText("Arquivos/vendas.json", serializado); //criando arquivo em json
Console.WriteLine(serializado);

//Desearilizar um objeto 

string ConteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(ConteudoArquivo);
foreach (Venda venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id},Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}




