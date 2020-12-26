using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerInformation
{
    public partial class getinfo : Form
    {
        dbworker dbw = new dbworker();
        comp _SendInformation;
        public getinfo(comp SendInformation)
        {
            InitializeComponent();
            _SendInformation = SendInformation;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getinfo_Load(object sender, EventArgs e)
        {
            var trying = dbw.test();
            label1.Text = trying.info;
            if (!trying.isOk)
                SendButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                _SendInformation.invent_no = int.Parse(InventNoTextBox.Text);
                _SendInformation.kabinet = KabinetTextBox.Text;
                _SendInformation.n_comp = nPCTextBox.Text;
                var trying = dbw.SendInformation(_SendInformation);
                if(trying.isOk)
                {
                    MessageBox.Show("Отправлено!");
                    this.Close();
                }
                else
                {
                    label1.Text = trying.info;
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }

        }
    }
}
