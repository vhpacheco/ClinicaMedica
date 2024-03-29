﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Medico : Pessoa
    {
        private IValoravel especialidade;
        public Medico(IValoravel especialidade, string nome, string cpf) : base(nome, cpf)
        {
            this.especialidade = especialidade;
        }
        public override double valorConsulta(Consulta consulta)
        {
            return 0;
        }

        public override string extratoConsulta()
        {
            return "";
        }
    }
}
