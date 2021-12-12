using System;
using BibliotecaDeClases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hospital> medicosDelHospital = new List<Hospital>();
            
            Hospital medicoCardiologia  = new Medico("Fermin", "Devs", "Cardiologia");
            Hospital medicoUrgencias = new Medico("Victoria", "Echeverria", "Urgencias");
            Hospital medicoPediatria = new Medico("Jorge", "Ibañez", "Pediatria");
            Hospital medicoOdontologia = new Medico("Marcela", "Delgado", "Odontologia");

            medicosDelHospital.Add(medicoOdontologia);
            medicosDelHospital.Add(medicoCardiologia);
            medicosDelHospital.Add(medicoPediatria);
            medicosDelHospital.Add(medicoUrgencias);

            Paciente paciente1= new Paciente ("Agustina", "Bruno", 123123213, 19, "No tiene");
            Paciente paciente2 = new Paciente("Lucia", "Verrati", 88559974, 27, "Cobertura Basica");
            Paciente paciente3 = new Paciente("Lucas", "Alvarez", 12312321, 14, "Cobertura Completa");

            paciente1.AsignarPacientes(paciente1);
            paciente2.AsignarPacientes(paciente2);
            paciente3.AsignarPacientes(paciente3);



            
        }
    }
}
