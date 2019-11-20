using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Otorrino : IValoravel
    {
        protected const double valorConsulta = 150;
        public double valor()
        {
            return valorConsulta;
        }
    }
}
