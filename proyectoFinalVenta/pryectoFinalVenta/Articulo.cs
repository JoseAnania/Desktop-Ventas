using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryectoFinalVenta
{
    class Articulo
    {
        private int nroArticulo;
        private string descripcion;
        private double precio;
        private int tipoArticulo;

        public int pNroArticulo
        {
            set { nroArticulo = value; }
            get { return nroArticulo; }
        }
        public string pDescripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public double pPrecio
        {
            set { precio = value; }
            get { return precio; }
        }
        public int pTipoArticulo
        {
            set { tipoArticulo = value; }
            get { return tipoArticulo; }
        }

        public Articulo() // Métodos: vacío y con parámetros
        {
            nroArticulo = 0;
            descripcion = "";
            precio = 0;
            tipoArticulo = 0;
        }

        public Articulo(int nroArticulo, string descripcion, double precio, int tipoArticulo)
        {
            this.nroArticulo = nroArticulo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.tipoArticulo = tipoArticulo;
        }

        public string toStringTipoArticulo() // Definimos los Tipos de Artículos
        {
            string ta = "";
            switch (tipoArticulo)
            {
                case 1: { ta = "Alimentos"; break; }
                case 2: { ta = "Perfumería"; break; }
                case 3: { ta = "Limpieza"; break; }
                default: { ta = "No Designo Tipo de Artículo"; break; }
            }
            return ta;
        }

        public string toStringArticulo()
        {
            return
                "Numero de Articulo: " + nroArticulo + "\n"
                + "Descripcion: " + descripcion + "\n"
                + "Precio: " + precio + "\n"
                + "Tipo De Articulo:" + toStringTipoArticulo();
        }
    }
}
