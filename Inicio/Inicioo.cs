using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inicio t1 = new Inicio();
            t1.Show();
        }
    }
}
