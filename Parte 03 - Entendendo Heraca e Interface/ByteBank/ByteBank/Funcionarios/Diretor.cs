﻿using ByteBank.Sisitemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            
        }

        public bool Autenticar(string senha)
        {
            return true;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {

            //return Salario + base.GetBonificacao();
            return Salario * 0.5;
        }
    }
}
