namespace Control_de_acceso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> usuarios = new List<string>
            {
                "Rene",
                "Vanesa",
                "Alberto",
                "Luis Manuel"
            };
        List<string> contrasenas = new List<string>
           {
                "Rene11",
                "Vanesa08",
                "Alberto06",
                "LuisM01"
           };
        List<string[]> horarios = new List<string[]>
        {
                new string[] {"Pierna(2:00 a 2:30","Espalda(2:00 a 2:30)","Brazo(2:00 a 2:30)","Pecho(2:00 a 2:30)","Abdomen(2:00 a 2:30)"},
                new string[] {"Pierna(2:00 a 2:30","Espalda(2:00 a 2:30)","Brazo(2:00 a 2:30)","Pecho(2:00 a 2:30)","Abdomen(2:00 a 2:30)"},
                new string[] {"Pierna(2:00 a 2:30","Espalda(2:00 a 2:30)","Brazo(2:00 a 2:30)","Pecho(2:00 a 2:30)","Abdomen(2:00 a 2:30)"},
                new string[] {"Pierna(2:00 a 2:30","Espalda(2:00 a 2:30)","Brazo(2:00 a 2:30)","Pecho(2:00 a 2:30)","Abdomen(2:00 a 2:30)"},
        };
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTxt.Text;
            string contrasena = ContrasenaTxt.Text;


            //if (contrasena == "Rene11"&&usuario=="Rene")
            //{
            //    MessageBox.Show("Bienvenido de nuevo");
            //    new Form2().ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o Contrasena incorrecta");
            //}
            
            string encontrado = "No";
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i] == usuario && contrasenas[i] == contrasena)
                {
                    encontrado = "Si";

                    MessageBox.Show("Bienvenido " + usuarios[i]);
                    Menu menuform= new Menu();
                    menuform.usuarioActivo = usuario;
                    menuform.horarioActivo = horarios[i];
                    menuform.ShowDialog();

                }

            }
            if(encontrado == "No")
            {
                MessageBox.Show("Usuario o contrsena no validos");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
      {

        }

        private void ContrasenaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            MessageBox.Show("Bienvenido ");
            string nuevousuario = NuevoUsuariotxt.Text;
            string nuevacontrasena = NuevaContrasenatxt.Text;
            usuarios.Add(nuevousuario);
            contrasenas.Add(nuevacontrasena);
            horarios.Add(new string[] { "Pierna(2:00 a 2:30", "Espalda(2:00 a 2:30)", "Brazo(2:00 a 2:30)", "Pecho(2:00 a 2:30)", "Abdomen(2:00 a 2:30)" });

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }
    }
}