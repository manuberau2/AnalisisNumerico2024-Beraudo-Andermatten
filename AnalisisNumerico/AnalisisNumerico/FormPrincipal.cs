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

        #endregion Funciones Submenus

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

        #endregion BotonesUnidad1

        #region BotonesUnidad2

        private void BtnUnidad2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelUnidad2);
        }

        private void BtnGaussJordan_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioGaussJordan());
            OcultarSubMenu();
        }

        private void BtnGaussSeidel_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioGaussSeidel());
            OcultarSubMenu();
        }

        #endregion BotonesUnidad2

        #region BotonesUnidad3

        private void BtnUnidad3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelUnidad3);
        }

        private void BtnRegresionLineal_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioRegresionLineal());
            OcultarSubMenu();
        }

        private void BtnRegresionPolinomial_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioRegresionPolinomial());
            OcultarSubMenu();
        }

        #endregion BotonesUnidad3

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

        private void BtnUnidad4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelUnidad4);
        }
    }
}