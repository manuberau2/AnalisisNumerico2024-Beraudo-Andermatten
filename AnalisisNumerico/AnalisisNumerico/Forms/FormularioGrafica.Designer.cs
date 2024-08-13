namespace AnalisisNumerico.Forms
{
    partial class FormularioGrafica
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
            WebViewGeogebra = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WebViewGeogebra).BeginInit();
            SuspendLayout();
            // 
            // WebViewGeogebra
            // 
            WebViewGeogebra.AllowExternalDrop = true;
            WebViewGeogebra.CreationProperties = null;
            WebViewGeogebra.DefaultBackgroundColor = Color.White;
            WebViewGeogebra.Dock = DockStyle.Fill;
            WebViewGeogebra.Location = new Point(0, 0);
            WebViewGeogebra.Name = "WebViewGeogebra";
            WebViewGeogebra.Size = new Size(975, 548);
            WebViewGeogebra.TabIndex = 0;
            WebViewGeogebra.ZoomFactor = 1D;
            // 
            // FormularioGrafica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 548);
            Controls.Add(WebViewGeogebra);
            Name = "FormularioGrafica";
            Text = "Gráfico";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)WebViewGeogebra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebViewGeogebra;
    }
}