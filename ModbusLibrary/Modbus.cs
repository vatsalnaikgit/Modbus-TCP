using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace ModbusLibrary
{
        /*
         * Some Main Settings required in PLC.
         * Network Settings:
         * IP : 172.16.3.55
         * SubnetMask : 255.255.252.0
         * DefaultGateWauy : 172.16.0.1
         * 
         * Connection Settings:
         * 1. Remote I/O Master
         * 172.16.3.55 (54321)
         * 
         * 2.Modbus TCP Server
         * Local Host Port No: 2102
         * (Uncheck Allow Access by IP Address)
         * 
         * 3. Modbus TCP Client
         * Remote Host NO: 192.168.1.5 (502)
         */
    public class Modbus
    {
        ModbusClient modbus = new ModbusClient(); 

        public void Connect(string ip, int port)
        {
            if (ip == null)
            {
                ip = "172.16.3.55";
            }

            if (port == 0)
            {
                port = 2102;
            }
            
            modbus.Connect(ip, port);
        }

        public void Disconnect()
        {
            modbus.Disconnect();
        }

        #region ReadFromModbus
        public bool[] ReadInput(int address, int length)
        {
            bool[] result = new bool[length];

            result = modbus.ReadDiscreteInputs(address, length);

            return result;
        }

        public bool[] ReadCoils(int address, int length)
        {
            bool[] result = new bool[length];

            result = modbus.ReadCoils(address, length);

            return result;
        }

        public int[] ReadHoldingRegisters(int address, int length)
        {
            int[] result = new int[length];

            result = modbus.ReadHoldingRegisters(address, length);

            return result;
        }

        public int[] ReadInputRegisters(int address, int length)
        {
            int[] result = new int[length];

            result = modbus.ReadInputRegisters(address, length);

            return result;
        }
        #endregion

        #region WriteTOModbus
        public void WriteCoils(int startingAddress, bool[] value)
        {
            modbus.WriteMultipleCoils(startingAddress, value);
        }

        public void WriteRegisters(int startingAddress, int[] value)
        {
            modbus.WriteMultipleRegisters(startingAddress, value);
        }

        #endregion

    }
}
