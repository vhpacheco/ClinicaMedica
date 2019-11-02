using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Convenio : Cliente
    {
        public override double ValorConsulta(Consulta consulta)
        {
            return 0;
        }
    }
}
