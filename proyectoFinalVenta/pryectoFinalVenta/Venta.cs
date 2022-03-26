using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryectoFinalVenta
{
    class Venta // Definición de Atributos. Por composición agregamos Cliente y Artículo
    {
        private int nroVenta;
        private DateTime fecha;
        private int cantidad;
        private Cliente cliente;
        private Articulo articulo;

        public int pNroVenta
        {
            set { nroVenta = value; }
            get { return nroVenta; }
        }
        public DateTime pFecha
        {
            set { fecha = value; }
            get { return fecha; }
        }
        public int pCantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }
        public Cliente pCliente
        {
            set { cliente = value; }
            get { return cliente; }
        }
        public Articulo pArticulo
        {
            set { articulo = value; }
            get { return articulo; }
        }

        public double calcularMonto() //Método para calcular el Monto de la Venta (Precio * Cantidad). Precio debemos "traerlo" de la clase Artículo 
        {
            return Math.Round(articulo.pPrecio * cantidad, 2);
        }

        public Venta() //Métodos: vacío y con parámetros
        {
            nroVenta = 0;
            fecha = DateTime.Today;
            cantidad = 0;
            cliente = null;
            articulo = null;
        }
        public Venta(int nroVenta, DateTime fecha, int cantidad, Cliente cliente, Articulo articulo)
        {
            this.nroVenta = nroVenta;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.cliente = cliente;
            this.articulo = articulo;
        }

        public string toStringVenta()
        {
            return
                "Numero De Venta: " + nroVenta + "\n"
                + "Fecha: " + fecha.ToShortDateString() + "\n"
                + "Cantidad: " + cantidad + "\n"
                + "Monto de Venta: " + calcularMonto() + "\n"
                + cliente.toStringCliente() + articulo.toStringArticulo();
        }
    }
}

