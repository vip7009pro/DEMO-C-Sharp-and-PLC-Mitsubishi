using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace DEMO_C_Sharp_and_PLC_Mitsubishi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ActUtlType plc = new ActUtlType();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 0;
            plc.Open();
            string cpuname= "";
            int cputype;
            plc.GetCpuType(out cpuname, out cputype) ;
            label3.Text = "CPU Name: " + cpuname;
            label4.Text = "CPU Type: " + cputype;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int read_result;
            plc.GetDevice(txtAdress.Text, out read_result);
            txtValue.Text = read_result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plc.SetDevice(txtAdress.Text, Convert.ToInt16(txtValue.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            plc.SetDevice(txtAdress.Text, Convert.ToInt16(0));
            plc.SetDevice(txtAdress.Text, Convert.ToInt16(1));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            plc.SetDevice(txtAdress.Text, Convert.ToInt16(1));
            plc.SetDevice(txtAdress.Text, Convert.ToInt16(0));            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int read_result;
            plc.GetDevice(txtAdress.Text, out read_result);
            txtValue.Text = read_result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
