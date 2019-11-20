using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    abstract class Pessoa
    {
        protected List<Consulta> consultas;

        public string cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                if (value.Length == 11)
                {
                    foreach (char c in value.ToCharArray())
                    {
                        if (!Char.IsNumber(c))
                        {
                            cpf = "___.___.___-__";
                        }
                        else
                        {
                            cpf = Convert.ToUInt64(value).ToString(@"000\.000\.000\-00");
                        }
                    }

                }
                else
                { cpf = "___.___.___-__"; }
            }
        }
        public string nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            consultas = new List<Consulta>();
        }
        public abstract double valorConsulta(Consulta consulta);
        public abstract string extratoConsulta();
    }
}
