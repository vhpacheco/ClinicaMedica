using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    abstract class Consulta
    {
        protected Pessoa medico;
        protected DateTime data;
        public Consulta(DateTime data, Pessoa medico)
        {
            this.data = data;
            this.medico = medico;
        }
        public abstract double valorFinal();
    }
}
