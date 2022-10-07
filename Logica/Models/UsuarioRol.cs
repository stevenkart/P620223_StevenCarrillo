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

            //TODO: hay que programar la llamada al SP que retorna datos
            return R;
        }


    }
}
