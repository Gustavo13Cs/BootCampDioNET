using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas__Operador_Ternário_e_Desconstrução_de_um_Objeto_com_C_.Models
{
    public class LeituraArquivo
    {

        //usando tuplas em metodo
        public (bool Sucesso,string[] Linhas,int QuantidadeDeLinhas) LerArquivo(string caminho){
            
            try{
                 string [] linhas = File.ReadAllLines(caminho);

                 return(true,linhas,linhas.Count()); //tem q seguir a ordem
            }catch(Exception) {
                return (false, new string[0], 0);
            }
        }
    }
}