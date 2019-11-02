using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public abstract class Pessoa
    {

        private string cpf;
        private string nome;
        protected List<Consulta> consultas = new List<Consulta>();

        public string Cpf
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

        public string Nome
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

        public virtual double ValorConsulta(Consulta consulta)
        {
            return consulta.ValorFinal();
        }

        public virtual string ExtratoConsulta()
        {
            string extrato = "";
            return extrato;
        }

    }
}
