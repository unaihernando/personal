using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Libreria berriak gehitu
using System.IO;
using Newtonsoft.Json;

namespace JSON.C
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(@"C:\Users\IN2DAM\source\repos\JSON.C\JSON.C\Json.json");
            dt = (DataTable)JsonConvert.DeserializeObject(jsonString, typeof(DataTable));
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kont = null;
            foreach (DataColumn zutabea in dt.Columns)
            {
                kont += zutabea.ColumnName + "\t\t";
            }
            kont += Environment.NewLine;
            foreach (DataRow lerroa in dt.Rows)
            {
                foreach (DataColumn zutabea in dt.Columns)
                {
                    kont = lerroa + "\t\t";
                }
                kont += Environment.NewLine;
            }
            textBox1.Text = kont;
        }
    }
}
