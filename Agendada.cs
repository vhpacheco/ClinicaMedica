using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Agendada : Consulta, IValoravel
    {
        public Agendada(DateTime data, Pessoa medico) : base(data, medico) { }
        public double valor()
        {
            return 0;
        }

        public override double valorFinal()
        {
            return 0;
        }
    }
}
