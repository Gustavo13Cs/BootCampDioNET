using Tuplas__Operador_Ternário_e_Desconstrução_de_um_Objeto_com_C_.Models;

LeituraArquivo arquivo = new LeituraArquivo();

// quando vc n precisar de uma das informações da tupla e só colocar um _ no lugar
var (sucesso,linhasArquivo, QuantidadeDeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
   Console.WriteLine("Quantidade linhas do arquivo:" + QuantidadeDeLinhas); 
   foreach(string linha in linhasArquivo)
   {
     Console.WriteLine(linha);
   } 
}
else{
    Console.WriteLine("Não foi possivel ler o arquivo");
}




