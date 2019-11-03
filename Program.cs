using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ClinicaMedica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ortopedia ortopedia = new Ortopedia();
            Otorrino otorrino = new Otorrino();
            ClinicaGeral clinicaGeral = new ClinicaGeral();
            //Criando medicos
            Pessoa DrJoaquim = new Medico(ortopedia,"Dr. Joaquim","12345678912");
            Pessoa DraIsabela = new Medico(clinicaGeral,"Dra. Isabela","75698240912");
            Pessoa DraPatricia = new Medico(otorrino,"Dra. Patricia","89652678912");
            //Criando pacientes
            Pessoa Carlos = new Normal("Carlos","45678912354");
            Pessoa Joana = new Convenio("Joana","78945612364");
            Pessoa Marcio = new Convenio("Marcio","85274196356");

            void AgendarConsulta(DateTime data, Medico medico)
            {
                Consulta consultaMarcada = new Agendada(DateTime.Now, DraPatricia);
            }
        }

        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>();
        //         });
    }
}
