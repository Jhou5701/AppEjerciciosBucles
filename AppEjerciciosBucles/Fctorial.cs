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
    public partial class Fctorial : Form
    {
        public Fctorial()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtingreso.Text);
            long resultado = Funcioens.EjemploBucles.factorial(num);
            this.txtresultado.Text = resultado.ToString();
        }
    }
}
