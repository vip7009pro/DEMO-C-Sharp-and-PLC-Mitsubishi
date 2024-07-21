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
            plc.ActLogicalStationNumber = 1;
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

        public int [] floatToWords(float value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            byte[] highWord = { arr[2], arr[3] };
            byte[] lowWord = { arr[0], arr[1] };
            int valueD1 = BitConverter.ToInt16(lowWord, 0);
            int valueD3 = BitConverter.ToInt16(highWord, 0);
            int[] returnValue = { valueD1, valueD3 };
            return returnValue;

        }
        
        public float wordsToFloat(int[] doubles)
        {
            byte[] highWordByte = BitConverter.GetBytes(doubles[1]);
            byte[] lowWordByte = BitConverter.GetBytes(doubles[0]);
            byte[] combineWordByte = { lowWordByte[0],lowWordByte[1], highWordByte[0], highWordByte[1] };
            float value = BitConverter.ToSingle(combineWordByte, 0);
            return value;
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

        private void button9_Click(object sender, EventArgs e)
        {
            int[] wordsToWrite = floatToWords(float.Parse(txtValue.Text));
            plc.WriteDeviceBlock(txtAdress.Text, 2,ref wordsToWrite[0]);           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] arrayData = new int[2]; 
            plc.ReadDeviceBlock(txtAdress.Text,2,out arrayData[0]);
            txtValue.Text= wordsToFloat(arrayData).ToString();
        }
    }
}
