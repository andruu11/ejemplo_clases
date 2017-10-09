using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ficha_Click(object sender, EventArgs e)// Boton obtener ficha
        {
            Persona NuevaPersona = new Persona(); // inicializamos un objeto en la clase persona
            NuevaPersona.Nombre = nombre.Text;// almacenamos la caja de texto en la propiedad nombre de la clase persona en la invocacion NuevaPersona
            NuevaPersona.Paterno = Paterno.Text;// almacenamos la caja de texto en la propiedad paterno de la clase persona en la invocacion NuevaPersona
            NuevaPersona.Materno = Materno.Text;// almacenamos la caja de texto en la propiedad materno de la clase persona en la invocacion NuevaPersona
            NuevaPersona.Edad = Convert.ToInt32(Edad.Text);// almacenamos la caja de texto en la propiedad edad de la clase persona en la invocacion NuevaPersona
            try//manejador de excepciones
            {
                string datos = Metodos_Persona.ObtenerFicha(NuevaPersona); //invocamos nuestro metodo ObtenerFicha de obtener fichas (enviamos parametro de objeto NuevaPersona)
                MessageBox.Show(datos);//Mostramos la ficha
            }
            catch {
                MessageBox.Show("Error al ejecutar"); //enviamos el error de ejecucion como mensaje
            }
        }
    }
}
