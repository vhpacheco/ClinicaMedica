using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CONSULTAS - ESPECIALIDADE;  TIPO;   PACIENTE;   MÉDICO; DATA
// 3;2;10092948;11357;16/07/2019

// Tipo: 1 (agendada), 2 (sob demanda)

namespace ClinicaMedica
{
    abstract class Consulta
    {
        public int identificador;
        protected Pessoa medico;
        protected Pessoa paciente;
        protected DateTime data;
        public Consulta(Pessoa medico, Pessoa paciente, DateTime data)
        {
            this.identificador = new Random().Next(10000,99999);
            this.data = data;
            this.medico = medico;
            this.paciente = paciente;
        }
        public abstract double valorFinal();
    }
}
