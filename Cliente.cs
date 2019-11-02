using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Cliente : Pessoa
    {
        public override double ValorConsulta(Consulta consulta)
        {
            return 0;
        }

        public override string ExtratoConsulta()
        {
            return "";
        }
    }
}
