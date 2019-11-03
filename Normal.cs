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
        public override double ValorConsulta(Consulta consulta)
        {
            return consulta.ValorFinal();
        }
    }
}
