using System;
using ModbusLibrary;

namespace ModbusTestConsole2
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Connect to PLC using Modbus
                Modbus modbus = new Modbus();

                modbus.Connect(null, 0);

                bool[] reading = modbus.ReadInput(0, 16);

                for (int i = 0; i < reading.Length; i++)
                {
                    Console.WriteLine("Value of Inputs " + (i) + " : " + reading[i].ToString());
                }

                modbus.WriteCoils(0, new bool[] { true, true });

                Console.Write("End -- Press any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
