using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_ejemplo
{
    class Persona
    {   //propiedades de la clase Persona
        public string Nombre { get; set; } 
        //tipo de dato de propiedad,nombre de propiedad { modificador que obtiene el dato, modificador que da valor al dato}
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int Edad { get; set; }

        public Persona() { } //constructor abstracto

        public Persona(string Nombre, string Paterno, string Materno, int Edad) { //metodo constructor inicializar los datos del nuevo objeto
            //metodo de tipo objeto (recibimos los datos segun el tipo de dato)
            this.Nombre = Nombre;
            this.Paterno = Paterno;
            this.Materno = Materno;
            this.Edad = Edad;
        }
    }
}
