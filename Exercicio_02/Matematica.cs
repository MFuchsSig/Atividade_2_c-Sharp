using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Matematica
    {
        public static int exponenciacao(int Base, int Exp)
        {
            int Resultado = Base;

            for(int i =1; i < Exp; i++)
            {
                Resultado = Resultado * Base;
            }
                    
            return Resultado;
        }


    }
}
