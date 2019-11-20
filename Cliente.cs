using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    abstract class Cliente : Pessoa
    {
        public double totalPago;
        public Cliente(string nome, string cpf) : base(nome, cpf) { }

        public override string extratoConsulta()
        {
            StringBuilder extrato = new StringBuilder();
            extrato.AppendLine($"Paciente: {this.nome}");
            extrato.AppendLine($"CPF: {this.cpf}");
            foreach (Consulta consulta in this.consultas)
            {
                extrato.AppendLine();
                extrato.AppendLine($"Consulta: {consulta.identificador}");
                extrato.AppendLine($"Valor: {consulta.valorFinal()}");
                totalPago += consulta.valorFinal();
            }
            extrato.AppendLine($"Valor total: {this.totalPago.ToString("00")}");
            
            return extrato.ToString();
        }
    }
}
