using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusLibrary;

namespace ModbusUI
{
    public partial class ModbusUI : Form
    {
        public ModbusUI()
        {
            InitializeComponent();

           
        }

        private void readInputButton_Click(object sender, EventArgs e)
        {
            Modbus modbus = new Modbus();

            modbus.Connect(null, 0);    // Connect to PLC

            int address = 0;
            bool[] output = new bool[16];

            bool result = int.TryParse(readAddressTextBox.Text, out address);

            // Default it will read 16 bit
            output = modbus.ReadInput(address, 8);

            readResultListBox.Items.Clear();

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i])
                {
                    readResultListBox.Items.Add("Input Port : " + i);
                }
            }
            modbus.Disconnect();
        }
    }
}
