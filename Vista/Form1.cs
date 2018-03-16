using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;




namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Validador j = new Validador();
            j.entero(textBox1.Text);
            j.edad(textBox3.Text);
            j.Decimal(textBox2.Text);
            MessageBox.Show("Validos: "+j.validados+"\n"+ "Invalidos: " + j.invalidos);
        }
    }
}
