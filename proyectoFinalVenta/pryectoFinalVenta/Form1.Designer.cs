namespace pryectoFinalVenta
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.grbVenta = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroVenta = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.grbArticulo = new System.Windows.Forms.GroupBox();
            this.cboTipoArticulo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNroArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipoArticulo = new System.Windows.Forms.Label();
            this.lblNroArticulo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblValuacionV = new System.Windows.Forms.Label();
            this.grbResultados = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblPorcentajeAP500 = new System.Windows.Forms.Label();
            this.lblPorcentajeRIM = new System.Windows.Forms.Label();
            this.grbMontoPromedio = new System.Windows.Forms.GroupBox();
            this.lblConsumidorFinal = new System.Windows.Forms.Label();
            this.lblPorcentajeCF = new System.Windows.Forms.Label();
            this.lblPorcentajeM = new System.Windows.Forms.Label();
            this.lblMonotributista = new System.Windows.Forms.Label();
            this.lblResponsableInscripto = new System.Windows.Forms.Label();
            this.lblPromedioVenta = new System.Windows.Forms.Label();
            this.lblPorcentajeRI = new System.Windows.Forms.Label();
            this.lblCF = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblRI = new System.Windows.Forms.Label();
            this.lblMontoV = new System.Windows.Forms.Label();
            this.btnVentaMayor = new System.Windows.Forms.Button();
            this.btnArticuloBarato = new System.Windows.Forms.Button();
            this.lblArticulosVendidos = new System.Windows.Forms.Label();
            this.lblValuacionTotal = new System.Windows.Forms.Label();
            this.lblValuacionVenta = new System.Windows.Forms.Label();
            this.lblPA500 = new System.Windows.Forms.Label();
            this.lblPRIM = new System.Windows.Forms.Label();
            this.lblArticulosV = new System.Windows.Forms.Label();
            this.lblValuaciónT = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbVenta.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbArticulo.SuspendLayout();
            this.grbResultados.SuspendLayout();
            this.grbMontoPromedio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbVenta
            // 
            this.grbVenta.BackColor = System.Drawing.Color.Transparent;
            this.grbVenta.Controls.Add(this.dtpFecha);
            this.grbVenta.Controls.Add(this.txtCantidad);
            this.grbVenta.Controls.Add(this.txtNroVenta);
            this.grbVenta.Controls.Add(this.lblCantidad);
            this.grbVenta.Controls.Add(this.lblFecha);
            this.grbVenta.Controls.Add(this.lblNroVenta);
            this.grbVenta.Enabled = false;
            this.grbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVenta.Location = new System.Drawing.Point(12, 68);
            this.grbVenta.Name = "grbVenta";
            this.grbVenta.Size = new System.Drawing.Size(248, 121);
            this.grbVenta.TabIndex = 1;
            this.grbVenta.TabStop = false;
            this.grbVenta.Text = "Venta";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(113, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(113, 85);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroVenta.Location = new System.Drawing.Point(113, 17);
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(100, 20);
            this.txtNroVenta.TabIndex = 0;
            this.txtNroVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroVenta_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(47, 88);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(13, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de Venta:";
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVenta.Location = new System.Drawing.Point(6, 20);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(93, 13);
            this.lblNroVenta.TabIndex = 0;
            this.lblNroVenta.Text = "Número de Venta:";
            // 
            // grbCliente
            // 
            this.grbCliente.BackColor = System.Drawing.Color.Transparent;
            this.grbCliente.Controls.Add(this.rbtFemenino);
            this.grbCliente.Controls.Add(this.rbtMasculino);
            this.grbCliente.Controls.Add(this.cboTipoCliente);
            this.grbCliente.Controls.Add(this.txtDni);
            this.grbCliente.Controls.Add(this.txtDireccion);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.lblSexo);
            this.grbCliente.Controls.Add(this.lblDni);
            this.grbCliente.Controls.Add(this.lblDireccion);
            this.grbCliente.Controls.Add(this.txtNroCliente);
            this.grbCliente.Controls.Add(this.lblNombre);
            this.grbCliente.Controls.Add(this.lblTipoCliente);
            this.grbCliente.Controls.Add(this.lblNroCliente);
            this.grbCliente.Enabled = false;
            this.grbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(12, 195);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(248, 259);
            this.grbCliente.TabIndex = 2;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemenino.Location = new System.Drawing.Point(150, 219);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 6;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.Location = new System.Drawing.Point(67, 219);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 5;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Monotributista",
            "Consumidor Final"});
            this.cboTipoCliente.Location = new System.Drawing.Point(113, 51);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(108, 21);
            this.cboTipoCliente.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(67, 181);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(154, 20);
            this.txtDni.TabIndex = 4;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(67, 144);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(154, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(67, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(6, 219);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 13);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(6, 184);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "D.N.I. :";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 147);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCliente.Location = new System.Drawing.Point(113, 17);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(108, 20);
            this.txtNroCliente.TabIndex = 0;
            this.txtNroCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCliente_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCliente.Location = new System.Drawing.Point(18, 54);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(81, 13);
            this.lblTipoCliente.TabIndex = 0;
            this.lblTipoCliente.Text = "Tipo de Cliente:";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCliente.Location = new System.Drawing.Point(6, 20);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(97, 13);
            this.lblNroCliente.TabIndex = 0;
            this.lblNroCliente.Text = "Número de Cliente:";
            // 
            // grbArticulo
            // 
            this.grbArticulo.BackColor = System.Drawing.Color.Transparent;
            this.grbArticulo.Controls.Add(this.cboTipoArticulo);
            this.grbArticulo.Controls.Add(this.txtPrecio);
            this.grbArticulo.Controls.Add(this.txtDescripcion);
            this.grbArticulo.Controls.Add(this.lblPrecio);
            this.grbArticulo.Controls.Add(this.txtNroArticulo);
            this.grbArticulo.Controls.Add(this.lblDescripcion);
            this.grbArticulo.Controls.Add(this.lblTipoArticulo);
            this.grbArticulo.Controls.Add(this.lblNroArticulo);
            this.grbArticulo.Enabled = false;
            this.grbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbArticulo.Location = new System.Drawing.Point(12, 460);
            this.grbArticulo.Name = "grbArticulo";
            this.grbArticulo.Size = new System.Drawing.Size(248, 152);
            this.grbArticulo.TabIndex = 3;
            this.grbArticulo.TabStop = false;
            this.grbArticulo.Text = "Artículo";
            // 
            // cboTipoArticulo
            // 
            this.cboTipoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoArticulo.FormattingEnabled = true;
            this.cboTipoArticulo.Items.AddRange(new object[] {
            "Alimentos",
            "Perfumería",
            "Limpieza"});
            this.cboTipoArticulo.Location = new System.Drawing.Point(113, 51);
            this.cboTipoArticulo.Name = "cboTipoArticulo";
            this.cboTipoArticulo.Size = new System.Drawing.Size(108, 21);
            this.cboTipoArticulo.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(113, 114);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(108, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(113, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(108, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(59, 117);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtNroArticulo
            // 
            this.txtNroArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroArticulo.Location = new System.Drawing.Point(113, 17);
            this.txtNroArticulo.Name = "txtNroArticulo";
            this.txtNroArticulo.Size = new System.Drawing.Size(108, 20);
            this.txtNroArticulo.TabIndex = 0;
            this.txtNroArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroArticulo_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(33, 84);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblTipoArticulo
            // 
            this.lblTipoArticulo.AutoSize = true;
            this.lblTipoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoArticulo.Location = new System.Drawing.Point(18, 54);
            this.lblTipoArticulo.Name = "lblTipoArticulo";
            this.lblTipoArticulo.Size = new System.Drawing.Size(86, 13);
            this.lblTipoArticulo.TabIndex = 0;
            this.lblTipoArticulo.Text = "Tipo de Artículo:";
            // 
            // lblNroArticulo
            // 
            this.lblNroArticulo.AutoSize = true;
            this.lblNroArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroArticulo.Location = new System.Drawing.Point(6, 20);
            this.lblNroArticulo.Name = "lblNroArticulo";
            this.lblNroArticulo.Size = new System.Drawing.Size(102, 13);
            this.lblNroArticulo.TabIndex = 0;
            this.lblNroArticulo.Text = "Número de Artículo:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(21, 615);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(53, 51);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblValuacionV
            // 
            this.lblValuacionV.AutoSize = true;
            this.lblValuacionV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuacionV.Location = new System.Drawing.Point(6, 33);
            this.lblValuacionV.Name = "lblValuacionV";
            this.lblValuacionV.Size = new System.Drawing.Size(97, 13);
            this.lblValuacionV.TabIndex = 0;
            this.lblValuacionV.Text = "Monto de la Venta:";
            // 
            // grbResultados
            // 
            this.grbResultados.BackColor = System.Drawing.Color.Transparent;
            this.grbResultados.Controls.Add(this.btnClientes);
            this.grbResultados.Controls.Add(this.lblPorcentajeAP500);
            this.grbResultados.Controls.Add(this.lblPorcentajeRIM);
            this.grbResultados.Controls.Add(this.grbMontoPromedio);
            this.grbResultados.Controls.Add(this.btnVentaMayor);
            this.grbResultados.Controls.Add(this.btnArticuloBarato);
            this.grbResultados.Controls.Add(this.lblArticulosVendidos);
            this.grbResultados.Controls.Add(this.lblValuacionTotal);
            this.grbResultados.Controls.Add(this.lblValuacionVenta);
            this.grbResultados.Controls.Add(this.lblPA500);
            this.grbResultados.Controls.Add(this.lblPRIM);
            this.grbResultados.Controls.Add(this.lblArticulosV);
            this.grbResultados.Controls.Add(this.lblValuaciónT);
            this.grbResultados.Controls.Add(this.lblValuacionV);
            this.grbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResultados.Location = new System.Drawing.Point(298, 118);
            this.grbResultados.Name = "grbResultados";
            this.grbResultados.Size = new System.Drawing.Size(280, 459);
            this.grbResultados.TabIndex = 6;
            this.grbResultados.TabStop = false;
            this.grbResultados.Text = "Resultados";
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Location = new System.Drawing.Point(63, 404);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(129, 40);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Condición de la mayoría de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblPorcentajeAP500
            // 
            this.lblPorcentajeAP500.AutoSize = true;
            this.lblPorcentajeAP500.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeAP500.Location = new System.Drawing.Point(205, 368);
            this.lblPorcentajeAP500.Name = "lblPorcentajeAP500";
            this.lblPorcentajeAP500.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentajeAP500.TabIndex = 0;
            this.lblPorcentajeAP500.Text = "0";
            // 
            // lblPorcentajeRIM
            // 
            this.lblPorcentajeRIM.AutoSize = true;
            this.lblPorcentajeRIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeRIM.Location = new System.Drawing.Point(205, 341);
            this.lblPorcentajeRIM.Name = "lblPorcentajeRIM";
            this.lblPorcentajeRIM.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentajeRIM.TabIndex = 0;
            this.lblPorcentajeRIM.Text = "0";
            // 
            // grbMontoPromedio
            // 
            this.grbMontoPromedio.Controls.Add(this.lblConsumidorFinal);
            this.grbMontoPromedio.Controls.Add(this.lblPorcentajeCF);
            this.grbMontoPromedio.Controls.Add(this.lblPorcentajeM);
            this.grbMontoPromedio.Controls.Add(this.lblMonotributista);
            this.grbMontoPromedio.Controls.Add(this.lblResponsableInscripto);
            this.grbMontoPromedio.Controls.Add(this.lblPromedioVenta);
            this.grbMontoPromedio.Controls.Add(this.lblPorcentajeRI);
            this.grbMontoPromedio.Controls.Add(this.lblCF);
            this.grbMontoPromedio.Controls.Add(this.lblM);
            this.grbMontoPromedio.Controls.Add(this.lblRI);
            this.grbMontoPromedio.Controls.Add(this.lblMontoV);
            this.grbMontoPromedio.Location = new System.Drawing.Point(9, 113);
            this.grbMontoPromedio.Name = "grbMontoPromedio";
            this.grbMontoPromedio.Size = new System.Drawing.Size(257, 138);
            this.grbMontoPromedio.TabIndex = 3;
            this.grbMontoPromedio.TabStop = false;
            this.grbMontoPromedio.Text = "Montos Promedios de Ventas";
            // 
            // lblConsumidorFinal
            // 
            this.lblConsumidorFinal.AutoSize = true;
            this.lblConsumidorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumidorFinal.Location = new System.Drawing.Point(196, 104);
            this.lblConsumidorFinal.Name = "lblConsumidorFinal";
            this.lblConsumidorFinal.Size = new System.Drawing.Size(13, 13);
            this.lblConsumidorFinal.TabIndex = 0;
            this.lblConsumidorFinal.Text = "0";
            // 
            // lblPorcentajeCF
            // 
            this.lblPorcentajeCF.AutoSize = true;
            this.lblPorcentajeCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeCF.Location = new System.Drawing.Point(20, 104);
            this.lblPorcentajeCF.Name = "lblPorcentajeCF";
            this.lblPorcentajeCF.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentajeCF.TabIndex = 0;
            this.lblPorcentajeCF.Text = "0";
            // 
            // lblPorcentajeM
            // 
            this.lblPorcentajeM.AutoSize = true;
            this.lblPorcentajeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeM.Location = new System.Drawing.Point(20, 78);
            this.lblPorcentajeM.Name = "lblPorcentajeM";
            this.lblPorcentajeM.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentajeM.TabIndex = 0;
            this.lblPorcentajeM.Text = "0";
            // 
            // lblMonotributista
            // 
            this.lblMonotributista.AutoSize = true;
            this.lblMonotributista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonotributista.Location = new System.Drawing.Point(196, 78);
            this.lblMonotributista.Name = "lblMonotributista";
            this.lblMonotributista.Size = new System.Drawing.Size(13, 13);
            this.lblMonotributista.TabIndex = 0;
            this.lblMonotributista.Text = "0";
            // 
            // lblResponsableInscripto
            // 
            this.lblResponsableInscripto.AutoSize = true;
            this.lblResponsableInscripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsableInscripto.Location = new System.Drawing.Point(196, 51);
            this.lblResponsableInscripto.Name = "lblResponsableInscripto";
            this.lblResponsableInscripto.Size = new System.Drawing.Size(13, 13);
            this.lblResponsableInscripto.TabIndex = 0;
            this.lblResponsableInscripto.Text = "0";
            // 
            // lblPromedioVenta
            // 
            this.lblPromedioVenta.AutoSize = true;
            this.lblPromedioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioVenta.Location = new System.Drawing.Point(139, 26);
            this.lblPromedioVenta.Name = "lblPromedioVenta";
            this.lblPromedioVenta.Size = new System.Drawing.Size(13, 13);
            this.lblPromedioVenta.TabIndex = 0;
            this.lblPromedioVenta.Text = "0";
            // 
            // lblPorcentajeRI
            // 
            this.lblPorcentajeRI.AutoSize = true;
            this.lblPorcentajeRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeRI.Location = new System.Drawing.Point(20, 51);
            this.lblPorcentajeRI.Name = "lblPorcentajeRI";
            this.lblPorcentajeRI.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentajeRI.TabIndex = 0;
            this.lblPorcentajeRI.Text = "0";
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCF.Location = new System.Drawing.Point(63, 104);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(90, 13);
            this.lblCF.TabIndex = 0;
            this.lblCF.Text = "Consumidor Final:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(63, 78);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(76, 13);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "Monotributista:";
            // 
            // lblRI
            // 
            this.lblRI.AutoSize = true;
            this.lblRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRI.Location = new System.Drawing.Point(63, 51);
            this.lblRI.Name = "lblRI";
            this.lblRI.Size = new System.Drawing.Size(81, 13);
            this.lblRI.TabIndex = 0;
            this.lblRI.Text = "Resp. Inscripto:";
            // 
            // lblMontoV
            // 
            this.lblMontoV.AutoSize = true;
            this.lblMontoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoV.Location = new System.Drawing.Point(6, 26);
            this.lblMontoV.Name = "lblMontoV";
            this.lblMontoV.Size = new System.Drawing.Size(133, 13);
            this.lblMontoV.TabIndex = 0;
            this.lblMontoV.Text = "Monto Promedio de Venta:";
            // 
            // btnVentaMayor
            // 
            this.btnVentaMayor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaMayor.Location = new System.Drawing.Point(140, 266);
            this.btnVentaMayor.Name = "btnVentaMayor";
            this.btnVentaMayor.Size = new System.Drawing.Size(113, 50);
            this.btnVentaMayor.TabIndex = 2;
            this.btnVentaMayor.Text = "Venta con más Artículos";
            this.btnVentaMayor.UseVisualStyleBackColor = true;
            this.btnVentaMayor.Click += new System.EventHandler(this.btnVentaMayor_Click);
            // 
            // btnArticuloBarato
            // 
            this.btnArticuloBarato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticuloBarato.Location = new System.Drawing.Point(21, 266);
            this.btnArticuloBarato.Name = "btnArticuloBarato";
            this.btnArticuloBarato.Size = new System.Drawing.Size(113, 50);
            this.btnArticuloBarato.TabIndex = 1;
            this.btnArticuloBarato.Text = "Artículo más barato";
            this.btnArticuloBarato.UseVisualStyleBackColor = true;
            this.btnArticuloBarato.Click += new System.EventHandler(this.btnArticuloBarato_Click);
            // 
            // lblArticulosVendidos
            // 
            this.lblArticulosVendidos.AutoSize = true;
            this.lblArticulosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosVendidos.Location = new System.Drawing.Point(148, 87);
            this.lblArticulosVendidos.Name = "lblArticulosVendidos";
            this.lblArticulosVendidos.Size = new System.Drawing.Size(13, 13);
            this.lblArticulosVendidos.TabIndex = 0;
            this.lblArticulosVendidos.Text = "0";
            // 
            // lblValuacionTotal
            // 
            this.lblValuacionTotal.AutoSize = true;
            this.lblValuacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuacionTotal.Location = new System.Drawing.Point(148, 61);
            this.lblValuacionTotal.Name = "lblValuacionTotal";
            this.lblValuacionTotal.Size = new System.Drawing.Size(13, 13);
            this.lblValuacionTotal.TabIndex = 0;
            this.lblValuacionTotal.Text = "0";
            // 
            // lblValuacionVenta
            // 
            this.lblValuacionVenta.AutoSize = true;
            this.lblValuacionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuacionVenta.Location = new System.Drawing.Point(148, 33);
            this.lblValuacionVenta.Name = "lblValuacionVenta";
            this.lblValuacionVenta.Size = new System.Drawing.Size(13, 13);
            this.lblValuacionVenta.TabIndex = 0;
            this.lblValuacionVenta.Text = "0";
            // 
            // lblPA500
            // 
            this.lblPA500.AutoSize = true;
            this.lblPA500.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPA500.Location = new System.Drawing.Point(6, 368);
            this.lblPA500.Name = "lblPA500";
            this.lblPA500.Size = new System.Drawing.Size(170, 13);
            this.lblPA500.TabIndex = 0;
            this.lblPA500.Text = "Artículos con Precio mayor a $500";
            // 
            // lblPRIM
            // 
            this.lblPRIM.AutoSize = true;
            this.lblPRIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRIM.Location = new System.Drawing.Point(6, 341);
            this.lblPRIM.Name = "lblPRIM";
            this.lblPRIM.Size = new System.Drawing.Size(139, 13);
            this.lblPRIM.TabIndex = 0;
            this.lblPRIM.Text = "Resp. Inscriptos Masculinos";
            // 
            // lblArticulosV
            // 
            this.lblArticulosV.AutoSize = true;
            this.lblArticulosV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosV.Location = new System.Drawing.Point(6, 87);
            this.lblArticulosV.Name = "lblArticulosV";
            this.lblArticulosV.Size = new System.Drawing.Size(102, 13);
            this.lblArticulosV.TabIndex = 0;
            this.lblArticulosV.Text = "Artículos Vendidos: ";
            // 
            // lblValuaciónT
            // 
            this.lblValuaciónT.AutoSize = true;
            this.lblValuaciónT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuaciónT.Location = new System.Drawing.Point(6, 61);
            this.lblValuaciónT.Name = "lblValuaciónT";
            this.lblValuaciónT.Size = new System.Drawing.Size(113, 13);
            this.lblValuaciónT.TabIndex = 0;
            this.lblValuaciónT.Text = "Monto Total de Venta:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 50);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Enabled = false;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(554, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(205, 615);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 51);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 673);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbResultados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbArticulo);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.grbVenta.ResumeLayout(false);
            this.grbVenta.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbArticulo.ResumeLayout(false);
            this.grbArticulo.PerformLayout();
            this.grbResultados.ResumeLayout(false);
            this.grbResultados.PerformLayout();
            this.grbMontoPromedio.ResumeLayout(false);
            this.grbMontoPromedio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox grbArticulo;
        private System.Windows.Forms.ComboBox cboTipoArticulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNroArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipoArticulo;
        private System.Windows.Forms.Label lblNroArticulo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblValuacionV;
        private System.Windows.Forms.GroupBox grbResultados;
        private System.Windows.Forms.Label lblValuacionVenta;
        private System.Windows.Forms.Label lblValuacionTotal;
        private System.Windows.Forms.Label lblValuaciónT;
        private System.Windows.Forms.Label lblArticulosVendidos;
        private System.Windows.Forms.Label lblArticulosV;
        private System.Windows.Forms.Label lblPromedioVenta;
        private System.Windows.Forms.Button btnArticuloBarato;
        private System.Windows.Forms.Button btnVentaMayor;
        private System.Windows.Forms.GroupBox grbMontoPromedio;
        private System.Windows.Forms.Label lblMontoV;
        private System.Windows.Forms.Label lblResponsableInscripto;
        private System.Windows.Forms.Label lblRI;
        private System.Windows.Forms.Label lblConsumidorFinal;
        private System.Windows.Forms.Label lblMonotributista;
        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblPorcentajeCF;
        private System.Windows.Forms.Label lblPorcentajeM;
        private System.Windows.Forms.Label lblPorcentajeRI;
        private System.Windows.Forms.Label lblPorcentajeRIM;
        private System.Windows.Forms.Label lblPRIM;
        private System.Windows.Forms.Label lblPorcentajeAP500;
        private System.Windows.Forms.Label lblPA500;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
    }
}

