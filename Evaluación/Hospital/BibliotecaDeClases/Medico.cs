using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Medico : Hospital
    {
        string especialidad;
        
        public Medico (string nombre, string apellido, string especialidad): base (nombre, apellido)
        {
            this.especialidad = especialidad;
        }

       
        }

        
        




    }
}
