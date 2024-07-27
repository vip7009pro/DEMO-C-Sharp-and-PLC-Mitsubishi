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

        public struct VisionData {
            public float speedInverter_Value;
            public float delayTrigger_Value;
            public float materialDiameter_Value;
            public float p1p2Distance_Value;
            public int pCountingforTrigger_Value;
            public float speed_Value;
            public float tactTime_Value;
        }
        VisionData vsd = new VisionData();
        
       
        public float speedInverter_Value = 0f;
        public float delayTrigger_Value = 0f;
        public float materialDiameter_Value = 0f;
        public float p1p2Distance_Value = 0f;
        public int pCountingforTrigger_Value = 1;
        public float speed_Value = 0f;
        public float tactTime_Value = 0f;

        public string speedInverter_Add = "R300";
        public string delayTrigger_Add = "R62";
        public string materialDiameter_Add = "R184";
        public string p1p2Distance_Add = "R182";
        public string pCountingforTrigger_Add = "D4000";
        public string speed_Add = "R190";
        public string tactTime_Add = "D61";

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
            timer2.Start();
            //backgroundWorker1.RunWorkerAsync();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                int[] arrayData = new int[2];
                //length speed
                plc.ReadDeviceBlock(speed_Add, 2, out arrayData[0]);
                vsd.speed_Value = wordsToFloat(arrayData);
                //inverter speed
                plc.ReadDeviceBlock(speedInverter_Add, 2, out arrayData[0]);
                vsd.speedInverter_Value = wordsToFloat(arrayData);
                //Delay trigger
                plc.ReadDeviceBlock(delayTrigger_Add, 2, out arrayData[0]);
                vsd.delayTrigger_Value = wordsToFloat(arrayData);
                //materialDiameter_Value
                plc.ReadDeviceBlock(materialDiameter_Add, 2, out arrayData[0]);
                vsd.materialDiameter_Value = wordsToFloat(arrayData);
                //p1p2Distance
                plc.ReadDeviceBlock(p1p2Distance_Add, 2, out arrayData[0]);
                vsd.p1p2Distance_Value = wordsToFloat(arrayData);
                //counting for trigger value               
                int read_result;
                plc.GetDevice(txtAdress.Text, out read_result);
                vsd.pCountingforTrigger_Value = read_result;
                //tactimeValue
                plc.ReadDeviceBlock(tactTime_Add, 2, out arrayData[0]);
                vsd.tactTime_Value = wordsToFloat(arrayData);

                backgroundWorker1.ReportProgress(1, vsd);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            VisionData progress = (VisionData)e.UserState;
            tbcntfortrigger.Text = progress.pCountingforTrigger_Value.ToString();
            tbDelayTrigger.Text = progress.delayTrigger_Value.ToString();
            tbMaterialDiameter.Text = progress.materialDiameter_Value.ToString();
            tbP1P2Distance.Text = progress.p1p2Distance_Value.ToString();
            tbSpeed.Text = progress.speed_Value.ToString();
            tbSpeedInverter.Text = progress.speedInverter_Value.ToString();
            tbTactTime.Text = progress.tactTime_Value.ToString();

        }

        private void Speed(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M855", Convert.ToInt16("1"));
            plc.SetDevice("M855", Convert.ToInt16("0"));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int[] arrayData = new int[2];
            //length speed
            plc.ReadDeviceBlock(speed_Add, 2, out arrayData[0]);
            lbSpeed.Text = wordsToFloat(arrayData).ToString();
            //inverter speed
            plc.ReadDeviceBlock(speedInverter_Add, 2, out arrayData[0]);
            lbSpeedInverter.Text = wordsToFloat(arrayData).ToString();
            //Delay trigger
            plc.ReadDeviceBlock(delayTrigger_Add, 2, out arrayData[0]);
            lbDelayTrigger.Text = wordsToFloat(arrayData).ToString();
            //materialDiameter_Value
            plc.ReadDeviceBlock(materialDiameter_Add, 2, out arrayData[0]);
            lbMaterialDiaMeter.Text = wordsToFloat(arrayData).ToString();
            //p1p2Distance
            plc.ReadDeviceBlock(p1p2Distance_Add, 2, out arrayData[0]);
            lbP1P2Distance.Text = wordsToFloat(arrayData).ToString();
            //counting for trigger value               
            int read_result;
            plc.GetDevice(pCountingforTrigger_Add, out read_result);
            lbCountingForTrigger.Text = read_result.ToString();
            //tactimeValue
            plc.ReadDeviceBlock(tactTime_Add, 2, out arrayData[0]);
            lbTactTime.Text = wordsToFloat(arrayData).ToString();

        }
    }
}
