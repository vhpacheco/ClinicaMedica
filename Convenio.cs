using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Convenio : Cliente
    {
        //Convenio com cobertura de 100%
        protected const double desconto = 1;
        public Convenio(string nome, string cpf) : base(nome, cpf) { }
        public override double ValorConsulta(Consulta consulta)
        {
            return consulta.ValorFinal();
        }
    }
}
