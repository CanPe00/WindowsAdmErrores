using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAdmErrores
{
    public class Medico
    {

        public string Especialidad { get; set; }
        public int Matricula { get; set; }
        //public string Nombre { get; set ; }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set {
                nombre = value;

                if (nombre.Trim().Length < 1 || nombre.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
                }
                
            }
        }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Medico(string nombre)
        {
            //nombre = nombre.Trim();
            //if(nombre.Length < 1 || nombre.Length > 50)
            //{
            //    throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
            //}

            Nombre = nombre;
            
        }
    }
}
