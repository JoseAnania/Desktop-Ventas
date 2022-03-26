using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryectoFinalVenta
{
    abstract class Persona // Se hace abstracta la clase porque después la llamaremos a través de Cliente (quien la hereda)
    {
        protected string nombre;
        protected string direccion;
        protected int dni;
        protected bool sexo;

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pDireccion
        {
            set { direccion = value; }
            get { return direccion; }
        }
        public int pDni
        {
            set { dni = value; }
            get { return dni; }
        }
        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public Persona() // Métodos: vacío y con parámetros
        {
            nombre = "";
            direccion = "";
            dni = 0;
            sexo = false;
        }
        public Persona(string nombre, string direccion, int dni, bool sexo)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.dni = dni;
            this.sexo = sexo;
        }

        public string toStringSexo() // Definimos como "true" a Femenino según consigna 
        {
            if (sexo == true)
                return "Femenino";
            else
                return "Masculino";
        }

        public string toStringPersona() 
        {
            return
               "Nombre: " + nombre + "\n"
               + "Direccion: " + direccion + "\n"
               + "Documento: " + dni + "\n"
               + "Sexo: " + toStringSexo() + "\n";
        }
    }
}
