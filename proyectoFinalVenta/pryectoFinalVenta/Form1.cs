using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryectoFinalVenta
{
    public partial class frmVenta : Form
    {
        double acumuladorVT; //Acumulador para calcular las Ventas Totales
        double acumuladorAV; //Acumulador para calcular los Artículos Vendidos
        double contadorV; //Contador de las Ventas realizadas (es decir que cuenta los registros)
        Articulo menor; //El Artículo de menor precio 
        Venta mayor; // La Venta con más artículos vendidos
        double contadorRI;//Contador de Responsables Inscriptos
        double acumuladorRI;//Acumulador de Responsables Inscriptos
        double contadorM;//Contador de Monotributistas
        double acumuladorM;//Acumulador de Monotributistas
        double contadorCF;//Contador de Consumidores Finales
        double acumuladorCF;//Acumulador de Consumidores Finales
        double contadorRIM;//Contador de Responsables Inscriptos y Masculinos
        double contadorA500;//Contador de Artículos mayores a $500

        private bool Validar() // Para que los campos no queden Vacíos
        {
            if (txtNroVenta.Text == "")
            {
                MessageBox.Show("El número de Venta no puede estar vacío", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroVenta.Focus();
                return false;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("No incluyó la Cantidad", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return false;
            }
            if (txtNroCliente.Text == "")
            {
                MessageBox.Show("El número de Cliente no puede estar vacío", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroCliente.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No incluyó el Nombre", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("La Dirección no puede estar vacía", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDireccion.Focus();
                return false;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe incluir el D.N.I.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDni.Focus();
                return false;
            }
            if (txtNroArticulo.Text == "")
            {
                MessageBox.Show("El número de Cliente no puede estar vacío", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroArticulo.Focus();
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("La Descripción está vacía", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe incluir un Precio", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return false;
            }

            else return true;
        }

        public frmVenta()
        {
            InitializeComponent();

            acumuladorVT = 0;
            acumuladorAV = 0;
            contadorV = 0;
            menor = null;
            mayor = null;
            contadorRI = 0;
            acumuladorRI = 0;
            contadorM = 0;
            acumuladorM = 0;
            contadorCF = 0;
            acumuladorCF = 0;
            contadorRIM = 0;
            contadorA500 = 0;


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)

            {
                Cliente c; //Para REGISTRAR un nuevo Cliente
                c = new Cliente();

                c.pNroCliente = Convert.ToInt32(txtNroCliente.Text);
                c.pTipoCliente = cboTipoCliente.SelectedIndex + 1;
                c.pNombre = txtNombre.Text;
                c.pDireccion = txtDireccion.Text;
                c.pDni = Convert.ToInt32(txtDni.Text);
                c.pSexo = rbtFemenino.Checked;

                Articulo a; // Para REGISTRAR un nuevo Artículo
                a = new Articulo();

                a.pNroArticulo = Convert.ToInt32(txtNroArticulo.Text);
                a.pDescripcion = txtDescripcion.Text;
                a.pPrecio = Convert.ToDouble(txtPrecio.Text);
                a.pTipoArticulo = cboTipoArticulo.SelectedIndex + 1;

                Venta v; // Para REGISTRAR una nueva Venta
                v = new Venta();

                v.pNroVenta = Convert.ToInt32(txtNroVenta.Text);
                v.pFecha = dtpFecha.Value;
                v.pCantidad = Convert.ToInt32(txtCantidad.Text);

                v.pCliente = c; //Por Composición de las clases. Usamos a Cliente y Artículo como atributos de Venta
                v.pArticulo = a;

                //3) Agregar los objetos visuales al entorno para mostrar los resultados de los cálculos siguientes:
                //a) Monto total de todas las ventas cargadas


                lblValuacionVenta.Text = "$" + Convert.ToString(v.calcularMonto()); //Para determinar el valor de cada venta

                acumuladorVT = acumuladorVT + v.calcularMonto();
                lblValuacionTotal.Text = "$" + Convert.ToString(acumuladorVT); //Para calcular la suma de cada venta

                //b) Cantidad de artículos vendidos en total

                acumuladorAV = acumuladorAV + Convert.ToDouble(txtCantidad.Text);
                lblArticulosVendidos.Text = Convert.ToString(acumuladorAV);

                //c) Promedio del monto de las ventas realizadas

                contadorV++;
                lblPromedioVenta.Text = "$" + Convert.ToString(Math.Round((acumuladorVT / contadorV), 2)); //Para calcular el monto promedio de las ventas

                //d) Datos del Artículo más barato

                if (contadorV == 1) //contador general de ventas
                    menor = v.pArticulo; // Relación de la Venta y el Artículo
                else if (a.pPrecio < menor.pPrecio) //Condiciones para encontrar el menor precio de un Articulo
                    menor = v.pArticulo;


                //e) Datos de la venta con la mayor cantidad de artículos vendidos(todos los datos, incluído los del clientes y artículo)

                if (contadorV == 1)//contador general de ventas
                    mayor = v; //Mayor Venta
                else if (v.pCantidad > mayor.pCantidad) //Condición
                    mayor = v;

                //f) Promedio del monto de venta por tipo de cliente

                if (c.pTipoCliente == 1) // Cuenta y Acumula las ventas sólo a Responsables Inscriptos
                {
                    contadorRI++;
                    acumuladorRI = acumuladorRI + v.calcularMonto();
                    lblResponsableInscripto.Text = "$" + Convert.ToString(Math.Round((acumuladorRI / contadorRI), 2));
                }
                else
                     if (c.pTipoCliente == 2)// Cuenta y Acumula las ventas sólo a Monotributistas
                {
                    contadorM++;
                    acumuladorM = acumuladorM + v.calcularMonto();
                    lblMonotributista.Text = "$" + Convert.ToString(Math.Round((acumuladorM / contadorM), 2));
                }
                else // Cuenta y Acumula las ventas sólo a Consumidores Finales
                {
                    contadorCF++;
                    acumuladorCF = acumuladorCF + v.calcularMonto();
                    lblConsumidorFinal.Text = "$" + Convert.ToString(Math.Round((acumuladorCF / contadorCF), 2));
                }

                //g) Porcentaje de ventas por tipo de cliente

                lblPorcentajeRI.Text = Convert.ToString(Math.Round(contadorRI / contadorV * 100, 2)) + "%";
                lblPorcentajeM.Text = Convert.ToString(Math.Round(contadorM / contadorV * 100, 2)) + "%";
                lblPorcentajeCF.Text = Convert.ToString(Math.Round(contadorCF / contadorV * 100, 2)) + "%";


                //h) Porcentaje de clientes Responsables inscriptos de sexo masculino

                if (c.pTipoCliente == 1 && c.pSexo == false) // Condiciones R.I. y Masculino
                    contadorRIM++;
                lblPorcentajeRIM.Text = Convert.ToString(Math.Round(contadorRIM / contadorV * 100, 2)) + "%";

                //i) Porcentaje de artículos con precios mayores a $ 500

                if (a.pPrecio >= 500) //Condicion Precio de Artículo mayor a $500.
                    contadorA500++;
                lblPorcentajeAP500.Text = Convert.ToString(Math.Round(contadorA500 / contadorV * 100, 2)) + "%";



                MessageBox.Show(v.toStringVenta());
                limpiarCampos();
            }
        }

        private void btnArticuloBarato_Click(object sender, EventArgs e)
        {
            MessageBox.Show(menor.toStringArticulo()); //Muestra los datos del Artículo más barato
        }

        private void btnVentaMayor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mayor.toStringVenta()); //Muestra los datos de la Venta con más Artículos Vendidos
        }

        private void btnClientes_Click(object sender, EventArgs e)
        //j) Informar si hay más ventas a clientes responsables inscriptos, monotributistas o consumidores finales.
        {
            if (contadorRI > contadorM && contadorRI > contadorCF) // Condiciones si hay más RI
                MessageBox.Show("Responsable Inscripto");
            else
                if (contadorM > contadorCF) // Condiciones si hay más M
                MessageBox.Show("Monotributista");
            else
                MessageBox.Show("Monotributista");
        }

        private void btnSalir_Click(object sender, EventArgs e) //Botón Salir
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
                Close();
        }


        private void limpiarCampos() // Método para limpiar los campos 
        {
            foreach (Control c in grbVenta.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            foreach (Control c in grbCliente.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            foreach (Control c in grbArticulo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            cboTipoArticulo.SelectedIndex = 0;
            cboTipoCliente.SelectedIndex = 0;
            rbtMasculino.Checked = true;
            txtNroVenta.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Botón Cancelar
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro que desea cancelar?" + "\n" + " Todos los datos se borrarán", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
                limpiarCampos();
        }

        public void habilitarCampos(bool x) // Método para habilitar los campos
        {
            grbArticulo.Enabled = x;
            grbCliente.Enabled = x;
            grbVenta.Enabled = x;
            btnRegistrar.Enabled = x;
            btnCancelar.Enabled = x;
            btnSalir.Enabled = x;
            btnNuevo.Enabled = x;
            txtNroVenta.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e) //Botón Nuevo
        {
            habilitarCampos(true);
            DialogResult opcion = MessageBox.Show("¿Registrar una nueva Venta?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
                habilitarCampos(true);
            limpiarCampos();
        }

        private void txtNroVenta_KeyPress(object sender, KeyPressEventArgs e) // Mensaje donde sólo se permiten Números
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) // Mensaje donde sólo se permiten Números
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtNroCliente_KeyPress(object sender, KeyPressEventArgs e) // Mensaje donde sólo se permiten Números
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) //Mensaje donde sólo se permiten Letras
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e) // Mensaje donde sólo se permiten Números
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtNroArticulo_KeyPress(object sender, KeyPressEventArgs e) // Mensaje donde sólo se permiten Números
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) // Mensaje donde sólo se permiten Números
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Debe ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
