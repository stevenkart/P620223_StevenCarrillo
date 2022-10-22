using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //Primero Escribimos las Propiedades Simples
        public int IDUsuarioRol { get; set; }
        public string Rol { get; set; }



        //Ahora se escribe las funciones y metodos(operaciones)

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //Paso 2.1 y 2.2 de seq Usuario Rol Listar
            Conexion MiCnn = new Conexion();

            // paso 2.3 y 2.4 
            //No es necesario documentar o explicar los pasos dentro de la ejecucion del proceso en la
            //programacion ya que como se va a usar tantas veces no se veria bien explicarlos

            R = MiCnn.EjecutarSelect("SPUsuarioRolListar");





            return R;
        }


    }
}
