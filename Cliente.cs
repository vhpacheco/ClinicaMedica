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
        public override double ValorConsulta(Consulta consulta)
        {
            return consulta.ValorFinal();
        }

        public override string ExtratoConsulta()
        {
            return "Paciente: {}\nCPF: {}\n";
        }
    }
}
