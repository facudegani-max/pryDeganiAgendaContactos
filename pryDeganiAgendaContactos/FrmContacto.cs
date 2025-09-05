namespace pryDeganiAgendaContactos
{
    public partial class FrmContacto : Form
    {
        public FrmContacto()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        string vNombre = "";
        string vTelefono = "";
        string vResultado = "";
        int contador = 1;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            vNombre= txtContacto.Text;
            vTelefono= mtbTelefono.Text;

            String vResultado = contador +" " + "El contacto " + vNombre + " con telefono " + vTelefono + " fue cargado correctamente";
            contador = contador + 1;
            lstContacto_Telefono.Items.Add(vResultado);

            txtContacto.Clear();
            mtbTelefono.Clear();
            txtContacto.Focus();
        }
    }
}
