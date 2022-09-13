using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_acceso
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Load += Menu_Load;
        }

        private void Menu_Load(object? sender, EventArgs e)
        {
            UsuarioLabel.Text = "Bienvenid@ " + usuarioActivo;
            Horarios.Rows.Add(horarioActivo);
        }

        public string usuarioActivo;
        public string[] horarioActivo;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuDeO.Visible = !menuDeO.Visible;
        //    //if (menuDeO.Visible == false)
        //    {
        //        menuDeO.Visible = true;
        //    }
        //    else
        //    {
        //        menuDeO.Visible = false;
        //    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           RutinasFoto.Visible = !RutinasFoto.Visible;
            Horarios.Visible = false;
            panelDemarcas.Visible = false;
        }

        private void menuDeO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Horarios.Visible = !Horarios.Visible;
            RutinasFoto.Visible = false;
            panelDemarcas.Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelDemarcas.Visible = !panelDemarcas.Visible;
            RutinasFoto.Visible = false;
            Horarios.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelDemarcas.Visible = !panelDemarcas.Visible;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Cerrar1_Click(object sender, EventArgs e)
        {
          
        }

        private void RutinasFoto_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar2_Click(object sender, EventArgs e)
        {
           
        }

        private void panelDemarcas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            panelDemarcas.Visible=false;
        }
    }
}
