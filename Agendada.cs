using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Agendada : Consulta, IValoravel
    {
        public Agendada(Pessoa medico, Pessoa paciente, DateTime data) : base(medico, paciente, data) { }
        public double valor()
        {
            return 99;
        }

        public override double valorFinal()
        {
            return 99;
        }
    }
}
