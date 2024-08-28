using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaCSHARP
{
    public class Alunos
    {
        public string Nome;
        public int Nota1, Nota2, Nota3;
        public int Resultados()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (Resultados() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int NotaRestante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - Resultados();
            }


        }
    }



}   

