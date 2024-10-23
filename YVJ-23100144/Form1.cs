namespace YVJ_23100144
{
    public partial class Form1 : Form
    {
        Cliente miCliente = new Cliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente miCliente = new Cliente();

            miCliente.NombreCliente = this.txtNombre.Text;
            miCliente.Telefono = Convert.ToString(this.txtTelefono.Text);
            miCliente.CorreoElectronico = Convert.ToString(this.txtCorreo.Text);

            //miCliente.InsertarCliente(miCliente);

            dtgInformacion.Rows.Add(miCliente.NombreCliente, miCliente.Telefono, miCliente.CorreoElectronico);
      

            MessageBox.Show("Los datos se han capturado correctamente");

            foreach (Control x in grpDatosCliente.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void dtgInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
