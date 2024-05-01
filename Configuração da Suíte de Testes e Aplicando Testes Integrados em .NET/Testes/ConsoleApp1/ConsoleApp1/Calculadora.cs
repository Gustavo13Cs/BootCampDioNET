using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculadora
    {

        private List<string> listahistorico;

        public Calculadora() { 
            listahistorico = new List<string>();
        }
        public int somar (int num1, int num2)
        {
            int resultado = num1+ num2;

            listahistorico.Insert(0,"Res: " + resultado);
            return resultado;
        }

        public int sub(int num1, int num2)
        {
            int resultado = num1 - num2;
            listahistorico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int multi(int num1, int num2)
        {
            int resultado = num1 * num2;
            listahistorico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int divi(int num1, int num2)
        {
            int resultado = num1 / num2;
            listahistorico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public List<string> historico()
        {

            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
