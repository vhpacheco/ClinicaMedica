﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Agendada : Consulta, IValoravel
    {
        public double Valor()
        {
            return 0;
        }

        public double ValorFinal(Consulta consulta)
        {
            return 0;
        }

    }
}