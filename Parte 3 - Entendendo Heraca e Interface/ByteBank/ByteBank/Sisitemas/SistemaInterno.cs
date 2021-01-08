﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sisitemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
