using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Ortopedia : IValoravel
    {
        protected const double valorConsulta = 130;
        public double Valor()
        {
            return valorConsulta;
        }
    }
}
