namespace Control_de_acceso
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuDeO = new System.Windows.Forms.Panel();
            this.BotonDeP = new System.Windows.Forms.Button();
            this.BotonDeR = new System.Windows.Forms.Button();
            this.BotonDeh = new System.Windows.Forms.Button();
            this.RutinasFoto = new System.Windows.Forms.PictureBox();
            this.Horarios = new System.Windows.Forms.DataGridView();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDemarcas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuDeO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RutinasFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horarios)).BeginInit();
            this.panelDemarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(187, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1141, 603);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.BackColor = System.Drawing.Color.Black;
            this.UsuarioLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsuarioLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UsuarioLabel.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsuarioLabel.ForeColor = System.Drawing.Color.Red;
            this.UsuarioLabel.Location = new System.Drawing.Point(187, 5);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(142, 22);
            this.UsuarioLabel.TabIndex = 3;
            this.UsuarioLabel.Text = "Bienvenido Rene";
            this.UsuarioLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(3, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(22, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = " ≡ ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuDeO
            // 
            this.menuDeO.Controls.Add(this.BotonDeP);
            this.menuDeO.Controls.Add(this.BotonDeR);
            this.menuDeO.Controls.Add(this.BotonDeh);
            this.menuDeO.Location = new System.Drawing.Point(12, 62);
            this.menuDeO.Name = "menuDeO";
            this.menuDeO.Size = new System.Drawing.Size(169, 540);
            this.menuDeO.TabIndex = 6;
            this.menuDeO.Visible = false;
            this.menuDeO.Paint += new System.Windows.Forms.PaintEventHandler(this.menuDeO_Paint);
            // 
            // BotonDeP
            // 
            this.BotonDeP.BackColor = System.Drawing.SystemColors.ControlText;
            this.BotonDeP.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonDeP.ForeColor = System.Drawing.Color.Red;
            this.BotonDeP.Location = new System.Drawing.Point(3, 83);
            this.BotonDeP.Name = "BotonDeP";
            this.BotonDeP.Size = new System.Drawing.Size(159, 30);
            this.BotonDeP.TabIndex = 8;
            this.BotonDeP.Text = "Patrocinadores";
            this.BotonDeP.UseVisualStyleBackColor = false;
            this.BotonDeP.Click += new System.EventHandler(this.button5_Click);
            // 
            // BotonDeR
            // 
            this.BotonDeR.BackColor = System.Drawing.SystemColors.ControlText;
            this.BotonDeR.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonDeR.ForeColor = System.Drawing.Color.Red;
            this.BotonDeR.Location = new System.Drawing.Point(0, 43);
            this.BotonDeR.Name = "BotonDeR";
            this.BotonDeR.Size = new System.Drawing.Size(159, 34);
            this.BotonDeR.TabIndex = 7;
            this.BotonDeR.Text = "Rutinas";
            this.BotonDeR.UseVisualStyleBackColor = false;
            this.BotonDeR.Click += new System.EventHandler(this.button4_Click);
            // 
            // BotonDeh
            // 
            this.BotonDeh.BackColor = System.Drawing.SystemColors.ControlText;
            this.BotonDeh.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonDeh.ForeColor = System.Drawing.Color.Red;
            this.BotonDeh.Location = new System.Drawing.Point(0, 3);
            this.BotonDeh.Name = "BotonDeh";
            this.BotonDeh.Size = new System.Drawing.Size(159, 34);
            this.BotonDeh.TabIndex = 6;
            this.BotonDeh.Text = "Horario";
            this.BotonDeh.UseVisualStyleBackColor = false;
            this.BotonDeh.Click += new System.EventHandler(this.button3_Click);
            // 
            // RutinasFoto
            // 
            this.RutinasFoto.BackgroundImage = global::Control_de_acceso.Properties.Resources.rutina__1_;
            this.RutinasFoto.Location = new System.Drawing.Point(233, 65);
            this.RutinasFoto.Name = "RutinasFoto";
            this.RutinasFoto.Size = new System.Drawing.Size(1049, 556);
            this.RutinasFoto.TabIndex = 8;
            this.RutinasFoto.TabStop = false;
            this.RutinasFoto.Visible = false;
            this.RutinasFoto.Click += new System.EventHandler(this.RutinasFoto_Click);
            // 
            // Horarios
            // 
            this.Horarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Horarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lunes,
            this.Martess,
            this.Miercoles,
            this.Jueves,
            this.Viernes});
            this.Horarios.GridColor = System.Drawing.Color.Black;
            this.Horarios.Location = new System.Drawing.Point(320, 130);
            this.Horarios.Name = "Horarios";
            this.Horarios.RowHeadersWidth = 62;
            this.Horarios.RowTemplate.Height = 33;
            this.Horarios.Size = new System.Drawing.Size(817, 225);
            this.Horarios.TabIndex = 7;
            this.Horarios.Visible = false;
            this.Horarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.MinimumWidth = 8;
            this.Lunes.Name = "Lunes";
            this.Lunes.Width = 150;
            // 
            // Martess
            // 
            this.Martess.HeaderText = "Martes";
            this.Martess.MinimumWidth = 8;
            this.Martess.Name = "Martess";
            this.Martess.Width = 150;
            // 
            // Miercoles
            // 
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.MinimumWidth = 8;
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Width = 150;
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.MinimumWidth = 8;
            this.Jueves.Name = "Jueves";
            this.Jueves.Width = 150;
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.MinimumWidth = 8;
            this.Viernes.Name = "Viernes";
            this.Viernes.Width = 150;
            // 
            // panelDemarcas
            // 
            this.panelDemarcas.Controls.Add(this.label2);
            this.panelDemarcas.Controls.Add(this.pictureBox5);
            this.panelDemarcas.Controls.Add(this.pictureBox4);
            this.panelDemarcas.Controls.Add(this.pictureBox3);
            this.panelDemarcas.Controls.Add(this.pictureBox2);
            this.panelDemarcas.Location = new System.Drawing.Point(205, 41);
            this.panelDemarcas.Name = "panelDemarcas";
            this.panelDemarcas.Size = new System.Drawing.Size(1099, 571);
            this.panelDemarcas.TabIndex = 9;
            this.panelDemarcas.Visible = false;
            this.panelDemarcas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDemarcas_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(460, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "PATROCINIOS ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Control_de_acceso.Properties.Resources._20afe3cbb837c500555b755376d38a4d__1_;
            this.pictureBox5.Location = new System.Drawing.Point(834, 154);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(226, 216);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Control_de_acceso.Properties.Resources.Under_Armour_logotipo__1_;
            this.pictureBox4.Location = new System.Drawing.Point(562, 154);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(230, 216);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(287, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 216);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Control_de_acceso.Properties.Resources.descarga;
            this.pictureBox2.Location = new System.Drawing.Point(35, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 221);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1342, 663);
            this.Controls.Add(this.panelDemarcas);
            this.Controls.Add(this.RutinasFoto);
            this.Controls.Add(this.menuDeO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Horarios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuDeO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RutinasFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horarios)).EndInit();
            this.panelDemarcas.ResumeLayout(false);
            this.panelDemarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label UsuarioLabel;
        private Button button1;
        private Button button2;
        private Panel menuDeO;
        private Button BotonDeP;
        private Button BotonDeR;
        private Button BotonDeh;
        private PictureBox RutinasFoto;
        private DataGridView Horarios;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martess;
        private DataGridViewTextBoxColumn Miercoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
        private Panel panelDemarcas;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}