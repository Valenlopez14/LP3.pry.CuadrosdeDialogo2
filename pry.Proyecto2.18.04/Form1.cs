using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry.Proyecto2._18._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SFguardar.FileName = "";
            SFguardar.ShowDialog();
            string archivo = SFguardar.FileName;


            StreamWriter sw = new StreamWriter(archivo);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            sw.Dispose();
            textBox1.Text = "";
        }
    }
}
