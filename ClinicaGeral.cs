using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class ClinicaGeral : IValoravel
    {
        protected const double valorConsulta = 80;
        public double valor()
        {
            return valorConsulta;
        }
    }
}
