using System;
using EasyModbus;

namespace ModbusTestConsole
{
    class Program
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
        static void Main(string[] args)
        {
            try
            {
                /*
                This is the default config from factory.
                string serverDefaultIP = "192.168.1.5";
                int serverDefaultPort = 12345;
                 */
                string networkIP = "172.16.3.55";
                int networkPort = 2102;

                ModbusClient modbusClient = new ModbusClient(networkIP, networkPort); //Ip-Address and Port of Modbus-TCP-Server 
                modbusClient.Connect(networkIP, networkPort);          //Connect to Server                
                Console.Clear();

                modbusClient.WriteMultipleCoils(0, new bool[] { true, true, true, true, true, true, false, true, true, true });    //Write Coils starting with Address 5

                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 16);
                bool[] readdis = modbusClient.ReadDiscreteInputs(0, 16);
                bool[] readCoils = modbusClient.ReadCoils(0, 16);
                int[] readInputRegister = modbusClient.ReadInputRegisters(22, 16);
                // Console Output
                for (int i = 0; i < readdis.Length; i++)
                {
                    Console.WriteLine("Value of Register " + (i) + " : " + readdis[i].ToString());
                }

                /*
                Console.WriteLine("Value of Discr. Input #1: " + modbusClient.ReadDiscreteInputs(0, 1)[0].ToString());  //Reads Discrete Input #1
                Console.WriteLine("Value of Input Reg. #10: " + modbusClient.ReadInputRegisters(9, 1)[0].ToString());   //Reads Inp. Reg. #10

                modbusClient.WriteSingleCoil(4, true);      //Writes Coil #5
                modbusClient.WriteSingleRegister(19, 4711); //Writes Holding Reg. #20

                Console.WriteLine("Value of Coil #5: " + modbusClient.ReadCoils(4, 1)[0].ToString());   //Reads Discrete Input #1
                Console.WriteLine("Value of Holding Reg.. #20: " + modbusClient.ReadHoldingRegisters(19, 1)[0].ToString()); //Reads Inp. Reg. #10
                modbusClient.WriteMultipleRegisters(49, new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
                modbusClient.WriteMultipleCoils(29, new bool[10] { true, true, true, true, true, true, true, true, true, true, });
                */

                modbusClient.Disconnect();                                                //Disconnect from Server
                
                Console.Write("End -- Press any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (Exception)
            {
                //throw new ApplicationException(ex.Message);
            }
        }
    }
}
