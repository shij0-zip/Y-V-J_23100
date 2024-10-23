namespace YVJ_23100144
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpDatosCliente = new GroupBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            dtgInformacion = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            btnAgregarCliente = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInformacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // grpDatosCliente
            // 
            grpDatosCliente.Controls.Add(txtCorreo);
            grpDatosCliente.Controls.Add(txtTelefono);
            grpDatosCliente.Controls.Add(txtNombre);
            grpDatosCliente.Controls.Add(lblCorreo);
            grpDatosCliente.Controls.Add(lblTelefono);
            grpDatosCliente.Controls.Add(lblNombre);
            grpDatosCliente.Location = new Point(12, 12);
            grpDatosCliente.Name = "grpDatosCliente";
            grpDatosCliente.Size = new Size(298, 146);
            grpDatosCliente.TabIndex = 0;
            grpDatosCliente.TabStop = false;
            grpDatosCliente.Text = "Datos del Cliente";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(160, 101);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(123, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(95, 69);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(119, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(19, 108);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(135, 20);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo Electronico:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(19, 72);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // dtgInformacion
            // 
            dtgInformacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInformacion.Columns.AddRange(new DataGridViewColumn[] { colNombre, colTelefono, colCorreo });
            dtgInformacion.Location = new Point(12, 208);
            dtgInformacion.Name = "dtgInformacion";
            dtgInformacion.RowHeadersWidth = 51;
            dtgInformacion.Size = new Size(557, 188);
            dtgInformacion.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Resizable = DataGridViewTriState.True;
            // 
            // colTelefono
            // 
            colTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.Resizable = DataGridViewTriState.True;
            // 
            // colCorreo
            // 
            colCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCorreo.HeaderText = "Correo Electrónico";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.Resizable = DataGridViewTriState.True;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(380, 158);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(189, 35);
            btnAgregarCliente.TabIndex = 2;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(388, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(338, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 408);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dtgInformacion);
            Controls.Add(grpDatosCliente);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Cartera de Clientes";
            Load += Form1_Load;
            grpDatosCliente.ResumeLayout(false);
            grpDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInformacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosCliente;
        private DataGridView dtgInformacion;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnAgregarCliente;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
