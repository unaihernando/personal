using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Newtonsoft.json eta system.Io gehitu behar dizkiot

using System.IO;
using Newtonsoft.Json;


namespace JsonVB
{
    public partial class Form1 : Form

    {
        DataTable dt;
  
        public Form1()
        {
            InitializeComponent();
        }
        //MyFirstJsonFile.json fitxeroa \bin\debug gunean gordeko dut
        //NuGet Newtonsoft.json paketea gehituko diot
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deserializatu egin behar dut artxiboa
            string filejson = File.ReadAllText(@"MyFirstJsonFile.json");
         dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            dataGridView1.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kontadorea edo akumuladorea zerotik hasiko dut
            string kont = null;
            //datatable-eko zutabe guztietatik pasatuko naiz.
            

            foreach (DataColumn zutabea in dt.Columns)
            {
                kont += zutabea.ColumnName + "\t\t";
            }
            kont += Environment.NewLine;
            foreach (DataRow lerroa in dt.Rows)
            {
                foreach (DataColumn zutabea in dt.Columns)
                {
                    kont += lerroa[zutabea.ColumnName] + "\t\t";
                }
                kont += Environment.NewLine;
            }
            txtbox1.Text = kont;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}