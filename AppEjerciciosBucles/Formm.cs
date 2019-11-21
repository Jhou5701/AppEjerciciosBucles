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
    public partial class Formm : Form
    {
        public Formm()
        {
            InitializeComponent();
        }

        private void Formm_Load(object sender, EventArgs e)
        {

        }
        private void btnllenar_Click(object sender, EventArgs e)
        {
          

        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            this.listnum.Sorted = true;
        }

        private void btnllenar_Click_1(object sender, EventArgs e)
        {
            this.listnum.Sorted = false;
            this.listnum.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = r.Next(1, 9);
                this.listnum.Items.Add(num);
            }
        }
    }
}
