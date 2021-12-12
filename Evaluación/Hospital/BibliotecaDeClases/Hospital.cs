using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Hospital
    {
        public string nombre;
        public string apellido;
        Queue<Paciente> listaDeEspera;

        public enum Especialidades
        {
            Cardiologia,   
            Emergencias, 
            Pediatria,
            Odontologia

        }

        public Hospital(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Hospital ()
        {
            listaDeEspera = new Queue<Paciente>();
        }

        ///Metodo para asignar pacientes a la lista de espera.
        public void AsignarPacientes(Paciente p)
        {
            listaDeEspera.Enqueue(p);
        }
        
        public Queue<Paciente> VerPacientes()
        {
            return listaDeEspera;
        }

        public void EliminarPaciente(Paciente p)
        {
            listaDeEspera.Enqueue(p);
        }

    }
}
