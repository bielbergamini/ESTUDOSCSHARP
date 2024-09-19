using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBanco
{
    class Conta
    {
        private int NumeroConta;
        public string NomeTitular { get; private set; }
        private int DepInicial { get; set; }



        public Conta()
        {

        }

        public Conta(int numeroConta, string nomeTitular, int depInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            DepInicial = depInicial;

        }







    }


    }




