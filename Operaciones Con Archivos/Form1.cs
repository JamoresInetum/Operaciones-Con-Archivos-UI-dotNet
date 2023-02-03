namespace Operaciones_Con_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            Helper.GuardarEnArchivo(Program.FICHERO, tEscribirTexto.Text);
            tEscribirTexto.Text = "";
        }

        private void btnAñadirTexto_Click(object sender, EventArgs e)
        {
            Helper.AñadirEnArchivo(Program.FICHERO, "\n" + tAgregarTexto.Text);
            tAgregarTexto.Text = "";
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = Helper.LeerDeArchivo(Program.FICHERO);
            
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            Helper.GuardarEnArchivo(Program.FICHERO, "");
            lblMensaje.Text = "";
        }

        private void btnSumarArchivo_Click(object sender, EventArgs e)
        {
            Helper.GuardarSumaEnArchivo(Program.FICHERO, Program.RESULTADO_SUMA);
            lblMensaje.Text = Helper.LeerDeArchivo(Program.RESULTADO_SUMA);
        }
    }
}