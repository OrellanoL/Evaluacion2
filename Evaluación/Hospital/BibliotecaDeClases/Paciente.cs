using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Paciente : Hospital
    {
        int dni;
        int edad;
        string obraSocial;

        public Paciente (string nombre, string apellido, int dni, int edad, string obraSocial): base (nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.obraSocial = obraSocial;
        }


    }
}
