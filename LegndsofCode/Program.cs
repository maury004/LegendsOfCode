using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegndsofCode
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Console.WriteLine(EvaluarCadena(SepararCadena(input)));
        }

        public static String[] SepararCadena(String parametro)
        {
            return parametro.Split(' ');
        }

        public static List<int> EvaluarCadena(String[] cadena)
        {
            int contador = Convert.ToInt32(cadena[0]);
            List<int> listaNumeros = new List<int>();
            if ((contador*2) != (cadena.Length +1))
            {
                throw new Exception();
            } else
            {
                int iterador = 1;
                int inicio = Convert.ToInt32(cadena[iterador]);
                int fin = Convert.ToInt32(cadena[iterador+1]);


                for (int i = 0; i < contador; i++)
                {

                    for(int j = inicio; j <= fin; j++)
                    {
                        listaNumeros.Add(j);
                    }
                    iterador++;
                    inicio = Convert.ToInt32(cadena[iterador]);
                    fin = Convert.ToInt32(cadena[iterador + 1]);
                }
            }
            return listaNumeros;
        }
    }
}
