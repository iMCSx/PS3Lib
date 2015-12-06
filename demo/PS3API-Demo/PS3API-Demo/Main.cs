using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace PS3API_Demo
{
    public partial class Main : Form
    {
        private PS3API PS3 = new PS3API();
        private Random rand = new Random();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            EnableOthersBox(false);
            if (PS3.GetCurrentAPI() == SelectAPI.TargetManager)
                PS3.PS3TMAPI_NET();
        }

        public void EnableOthersBox(bool active)
        {
            groupAttach.Enabled = active;
            groupMem.Enabled = active;
            groupArray.Enabled = active;
        }

        private void radioTM_CheckedChanged(object sender, EventArgs e)
        {
            EnableOthersBox(false);
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void radioCC_CheckedChanged(object sender, EventArgs e)
        {
            EnableOthersBox(false);
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                EnableOthersBox(true);
                string Message = "You are now connected with this API : " + PS3.GetCurrentAPIName();
                MessageBox.Show(Message, "Connected!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                EnableOthersBox(false);
                string Message = "Impossible to connect :/";
                MessageBox.Show(Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if(PS3.AttachProcess())
                MessageBox.Show("Current game is attached successfully.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show("No game process found!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSetRand_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[4];
            for (int i = 0; i < 4; i++)
                buffer[i] = (byte)rand.Next(0x10, 0x7E);
            PS3.SetMemory(0x10045000, buffer);
        }

        private void btnReadRand_Click(object sender, EventArgs e)
        {
            uint randBuff = PS3.Extension.ReadUInt32(0x10045000);
            MessageBox.Show("Value in memory is now : " + randBuff.ToString("X8"));
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(0x000019780, 1000 * 2);
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteInt16(0x00173BB0 + 2, 500);
        }

        private void btnCrArr_Click(object sender, EventArgs e)
        {
            // With the v4.5 feature, you can directly put the size of the array that you want, instead of to allocate a buffer yourself, the ctor do it for you.
            ArrayBuilder Build = new ArrayBuilder(0x50);
            Build.Write.SetBool(3, true);
            Build.Write.SetFloat(4, 1000);
            Build.Write.SetInt32(8, 1337);
            Build.Write.SetString(20, "iMCSx ArrayBuilder !");
            PS3.SetMemory(0x10060000, Build.ToArray());
            MessageBox.Show("Done, try to read now !");
        }

        private void btnReadArr_Click(object sender, EventArgs e)
        {
            byte[] buffer = PS3.Extension.ReadBytes(0x10060000, 0x50);
            ArrayBuilder Build = new ArrayBuilder(buffer);
            bool var1 = Build.Read.GetBool(3);
            float var2 = Build.Read.GetFloat(4);
            int var3 = Build.Read.GetInt32(8);
            string var4 = Build.Read.GetString(20);
            MessageBox.Show("Result from the array sent to memory is :\n\nPosition 3 - Bool - " + var1.ToString() + "\n\nPosition 4 - Float - " + var2.ToString() + "\n\nPosition 8 - Int32 - " + var3.ToString() + "\n\nPosition 20 - String - " + var4);

            string ok = PS3.Extension.ReadString(0x10060000 + 20);
            MessageBox.Show(ok);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            PS3.DisconnectTarget();
        }
    }
}
