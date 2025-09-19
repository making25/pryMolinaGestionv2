using pryDiazGestionInventario;

namespace pryMolinaGestion
{
    public partial class gestionInventario : Form
    {
        public gestionInventario()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();

            clsConexionBD.ConectarBD();

            clsConexionBD.cargarCategoria(cmbcate);
        }

        private void rbtnnombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dato = txtDatoBuscar.Text;

            MessageBox.Show($"Buscando en la base de datos {dato}");
        }
    }
}
