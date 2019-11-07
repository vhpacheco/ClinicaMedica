using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    abstract class Cliente : Pessoa
    {
        public Cliente(string nome, string cpf) : base(nome, cpf) { }

        public override string extratoConsulta()
        {
            return "Paciente: {}\nCPF: {}\n";
        }
    }
}
