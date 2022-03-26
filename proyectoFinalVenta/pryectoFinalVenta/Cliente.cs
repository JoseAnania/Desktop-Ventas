using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryectoFinalVenta
{
    class Cliente : Persona // por Herencia (Cliente es una Persona)
    {
        private int nroCliente;
        private int tipoCliente;

        public int pNroCliente
        {
            set { nroCliente = value; }
            get { return nroCliente; }
        }
        public int pTipoCliente
        {
            set { tipoCliente = value; }
            get { return tipoCliente; }
        }

        public Cliente() : base() // Métodos: vacío y con parámetros (más los de la clase de la que hereda, es decir Persona)
        {
            nroCliente = 0;
            tipoCliente = 0;
        }
        public Cliente(int nroCliente, int tipoCliente, string nombre, string direccion, int dni, bool sexo) : base(nombre, direccion, dni, sexo)
        {
            this.nroCliente = nroCliente;
            this.tipoCliente = tipoCliente;
        }

        public string toStringTipoCliente() // Definimos los Tipos de Clientes 
        {
            string tc = "";
            switch (tipoCliente)
            {
                case 1: { tc = "Responsable Inscripto"; break; }
                case 2: { tc = "Monotributista"; break; }
                case 3: { tc = "Consumidor Final"; break; }
                default: { tc = "No Designo Tipo de Cliente"; break; }
            }
            return tc;
        }

        public string toStringCliente()
        {
            return
                "Numero De Cliente: " + nroCliente + '\n'
                + "Tipo De Cliente: " + toStringTipoCliente() + "\n"
                + base.toStringPersona();
        }
    }
}
               
