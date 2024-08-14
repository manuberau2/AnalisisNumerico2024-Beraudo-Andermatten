
using AnalisisNumerico.Forms;

namespace AnalisisNumerico
{

    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #region Funciones Submenus
        private void OcultarSubMenu()
        {
            if (PanelUnidad1.Visible == true)
            {
                PanelUnidad1.Visible = false;
            }
            if (PanelUnidad2.Visible == true)
            {
                PanelUnidad2.Visible = false;
            }
            if (PanelUnidad3.Visible == true)
            {
                PanelUnidad3.Visible = false;
            }
            if (PanelUnidad4.Visible == true)
            {
                PanelUnidad4.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region BotonesUnidad1
        private void BtnUnidad1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelUnidad1);
        }

        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioBiseccion());
            //Abrir Formulario Biseccion
            OcultarSubMenu();
        }

        private void BtnReglaFalsa_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioReglaFalsa());
            //Abrir Formulario Regla Falsa
            OcultarSubMenu();
        }

        private void BtnNewtonRaphson_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioNewtonRaphson());
            //Abrir Formulario Newton Raphson
            OcultarSubMenu();
        }

        private void BtnSecante_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioSecante());
            //Abrir Formulario Secante
            OcultarSubMenu();
        }
        #endregion
        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            PanelFormularioHijo.Controls.Add(formularioHijo);
            PanelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}
