namespace AnalisisNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

        private void PanelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUnidad1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelUnidad1);
        }

        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            //Abrir Formulario Biseccion
            OcultarSubMenu();
        }

        private void BtnReglaFalsa_Click(object sender, EventArgs e)
        {
            //Abrir Formulario Regla Falsa
            OcultarSubMenu();
        }

        private void BtnNewtonRaphson_Click(object sender, EventArgs e)
        {
            //Abrir Formulario Newton Raphson
            OcultarSubMenu();
        }

        private void BtnSecante_Click(object sender, EventArgs e)
        {
            //Abrir Formulario Secante
            OcultarSubMenu();
        }
    }
}
