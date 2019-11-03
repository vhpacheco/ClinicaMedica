using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Coparticipação : Cliente
    {
        protected const double desconto = 0.1;
        public Coparticipação(string nome, string cpf) : base(nome, cpf) { }

        public override double ValorConsulta(Consulta consulta)
        {
            return base.ValorConsulta(consulta) * desconto;
        }
    }
}
