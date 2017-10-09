using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_ejemplo
{
    class Metodos_Persona
    {// clase para almacenar nuestros metodos
        public static string ObtenerFicha(Persona NuevaPersona){
            //metodo de tipo string (recibimos el objeto)
        string DatosFicha = "Datos de Persona" + " " + NuevaPersona.Nombre + " " + NuevaPersona.Paterno + " " + NuevaPersona.Materno + " " + "Edad:" + NuevaPersona.Edad;
        //almacenamos en un string los elementos del objeto
        return DatosFicha; //retornamos el string ante su invocacion
        }

        
    }
}
