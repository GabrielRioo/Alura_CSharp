﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(846, 456879);
            Funcionario funcionario = null;

            new ContaCorrente(123, 456789);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
