using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class SobDemanda : Consulta, IValoravel
    {
        // Pessoa medico,int tipo, Pessoa paciente, DateTime data
        public SobDemanda(Pessoa medico, Pessoa paciente) : base(medico, paciente, DateTime.Now ) { }
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
