using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace CCAPI_Demo
{
    public partial class Form1 : Form
    {
        private Random Rand;
        private CCAPI PS3 = new CCAPI();
        private Thread TargetInfo;

        private bool threadIsRunning = false;
        private bool currentGame = false;
        private uint[] procs;
        public Form1()
        {
            Rand = new Random();
            TargetInfo = new Thread(new ThreadStart(InfoWorker));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableBoxes(false);
            comboBuzzer.SelectedIndex = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadIsRunning = false;
            TargetInfo.Abort();
            PS3.DisconnectTarget();
        }

        private void InfoWorker()
        {
            lblFW.Invoke((MethodInvoker)(() => { lblFW.Text = PS3.GetFirmwareVersion(); }));
            lblLV2.Invoke((MethodInvoker)(() => { lblLV2.Text = PS3.GetFirmwareType(); }));
            while (threadIsRunning)
            {
                string temp1 = PS3.GetTemperatureCELL();
                string temp2 = PS3.GetTemperatureRSX();
                lblCELL.Invoke((MethodInvoker)(() => { lblCELL.Text = temp1; }));
                lblRSX.Invoke((MethodInvoker)(() => { lblRSX.Text = temp2; }));
                PS3.ClearTargetInfo();
                Thread.Sleep(500);
            }
            TargetInfo.Abort();
        }

        private void EnableBoxes(bool active)
        {
            groupProc.Enabled = active;
            groupCID.Enabled = active;
            groupBuzz.Enabled = active;
            groupCID.Enabled = active;
            groupInfo.Enabled = active;
            groupLedColor.Enabled = active;
            groupLedMode.Enabled = active;
            groupNotify.Enabled = active;
            groupDefaultProc.Enabled = active;
            btnLed.Enabled = active;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (PS3.SUCCESS(PS3.ConnectTarget(BoxIP.Text)))
            {
                if (!TargetInfo.IsAlive)
                {
                    threadIsRunning = true;
                    TargetInfo.Start();
                }
                EnableBoxes(true);
                MessageBox.Show("Connected !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                EnableBoxes(false);
                MessageBox.Show("Impossible to connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            procs = new uint[64];
            PS3.GetProcessList(out procs);
            comboProcs.Items.Clear();
            for(int i = 0; i < procs.Length; i++)
            {
                string name = String.Empty;
                PS3.GetProcessName(procs[i], out name);
                comboProcs.Items.Add(name);
            }
            procs = null;
        }

        private void btnSetMem_Click(object sender, EventArgs e)
        {
            if (comboProcs.SelectedIndex >= 0 && BoxOffset.Text != "" && BoxValue.Text != "")
            {
                try
                {
                    uint processSelected = procs[comboProcs.SelectedIndex];
                    PS3.AttachProcess(processSelected);
                    uint offset = Convert.ToUInt32(BoxOffset.Text.Replace("0x", ""), 16);
                    uint value = Convert.ToUInt32(BoxValue.Text.Replace("0x", ""), 16);
                    PS3.Extension.WriteUInt32(offset, value);
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Please select a process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCID_Click(object sender, EventArgs e)
        {
            PS3.SetConsoleID(BoxCID.Text);
        }

        private void btnBuzzer_Click(object sender, EventArgs e)
        {
            if (comboBuzzer.SelectedIndex >= 0)
            {
                if (comboBuzzer.SelectedIndex == 0)
                    PS3.RingBuzzer(CCAPI.BuzzerMode.Continuous);
                else if (comboBuzzer.SelectedIndex == 1)
                    PS3.RingBuzzer(CCAPI.BuzzerMode.Single);
                else if (comboBuzzer.SelectedIndex == 2)
                    PS3.RingBuzzer(CCAPI.BuzzerMode.Double);
                else if (comboBuzzer.SelectedIndex == 3)
                    PS3.RingBuzzer(CCAPI.BuzzerMode.Triple);
            }
            else MessageBox.Show("Please select a buzzer mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioOn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioOff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBlink_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLed_Click(object sender, EventArgs e)
        {
            CCAPI.LedColor Color = CCAPI.LedColor.Green;
            CCAPI.LedMode Mode = CCAPI.LedMode.On;

            if (radioOn.Checked)
                Mode = CCAPI.LedMode.On;
            else if (radioOff.Checked)
                Mode = CCAPI.LedMode.Off;
            else if (radioBlink.Checked)
                Mode = CCAPI.LedMode.Blink;

            if (radioGreen.Checked)
                Color = CCAPI.LedColor.Green;

            if (radioRed.Checked)
                Color = CCAPI.LedColor.Red;

            PS3.SetConsoleLed(Color, Mode);
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            PS3.Notify(CCAPI.NotifyIcon.INFO, BoxNotify.Text);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if(PS3.SUCCESS(PS3.AttachProcess()))
            {
                currentGame = true;
                MessageBox.Show("Success!");
            }
            else MessageBox.Show("You're in a game ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDefProc_Click(object sender, EventArgs e)
        {
            if (currentGame)
            {
                PS3.Extension.WriteInt32(0x10050004, 1337);
                byte[] buffer = new byte[4];
                for (int i = 0; i < 4; i++)
                    buffer[i] = (byte)Rand.Next(255);
                PS3.SetMemory(0x10060000, buffer);
                MessageBox.Show("Random bytes set in memory, offset 0x10060000");
            }
            else MessageBox.Show("Attach the default game before.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                if (!TargetInfo.IsAlive)
                {
                    threadIsRunning = true;
                    TargetInfo.Start();
                }
                EnableBoxes(true);
                MessageBox.Show("Connected");
            }
            else
            {
                EnableBoxes(false);
                MessageBox.Show("Failed to connect");
            }
        }
    }
}
