using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class SobDemanda : Consulta, IValoravel
    {
        public SobDemanda(Pessoa medico) : base(DateTime.Now, medico) { }
        public double Valor()
        {
            return 0;
        }
    }
}
