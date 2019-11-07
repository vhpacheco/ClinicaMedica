using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Normal : Cliente
    {
        public Normal(string nome, string cpf) : base(nome, cpf) { }
        public override double valorConsulta(Consulta consulta)
        {
            return consulta.valorFinal();
        }
    }
}
