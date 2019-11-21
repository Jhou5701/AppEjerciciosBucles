using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            int limite = int.Parse(this.txtlimites.Text);
            string cad = Funcioens.EjemploBucles.saludar(limite);
            this.txtresultado.Text = cad;
        }
    }
}
