using Inicio;
using Inicio.DTO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseDTO course = new CourseDTO();
            course.Name = txtcurso.Text;
            course.Class = textclass.Text;
            course.Period = cboPeriod.SelectedText;
            course.Year = Convert.ToInt32(numYear.Value);


            MessageBox.Show("Cadastro realizado com sucesso.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseDTO course = new CourseDTO();
            course.Name = txtcurso.Text;
            course.Class = textclass.Text;
            course.Period = cboPeriod.SelectedText;
            course.Year = Convert.ToInt32(numYear.Value);


            MessageBox.Show("Cadastro realizado com sucesso.");

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inicioo t1 = new Inicioo();
                t1.Show();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar t = new Consultar();
            t.Show();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                if ((textBox1.Text == "Simone") &&
                    (textBox2.Text == "simone14"))
                {

                    Inicio t1 = new Inicio();
                    t1.Show();
                    this.Visible = false;

                }
                else

                {


                    MessageBox.Show("Login ou senha invalidos");
                
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
