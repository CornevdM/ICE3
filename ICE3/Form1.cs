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

namespace ice3
{
    public partial class Form1 : Form
    {
        private static string path = System.IO.Path.GetFullPath(@"..\..\..\") + "list.txt";


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LineSplitter();
            
           
            
        }

        private void LineSplitter()
        {
            StreamReader sr = new StreamReader(path, true);
            string wordInput = txtSearch.Text;
            string[] array = sr.ReadLine().Split(",");
            
            foreach (var word in array)
            {
                listBox1.Items.Add(word);
            }
        }
      



    }



}
