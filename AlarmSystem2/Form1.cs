using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Data.OleDb;
using System.Threading;

namespace AlarmSystem2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Pilar1, Pilar2, Pilar3, TIME FROM `testschema`.`testtable` ORDER BY ID desc LIMIT 1";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=Settha15;database=testschema");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chartS1.Series["Series1"].Points.AddXY(reader.GetString("TIME"), reader.GetString("Pilar1"));
                chartS2.Series["Series2"].Points.AddXY(reader.GetString("TIME"), reader.GetString("Pilar2"));
                chartS3.Series["Series3"].Points.AddXY(reader.GetString("TIME"), reader.GetString("Pilar3"));
            }
            
            
            
            /*int milliseconds = 2000;
            for (int i=0;i<10;i++)
            {
                reader.Read();
                chartS1.Series["Series1"].Points.AddXY(reader.GetString("TIME"), reader.GetString("Pilar1"));
                chartS2.Series["Series2"].Points.AddXY(reader.GetString("TIME"), reader.GetString("Pilar2"));
                chartS3.Series["Series3"].Points.AddXY(reader.GetString("TIME"), reader.GetString("Pilar3"));
                System.Threading.Thread.Sleep(2000);
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
