using OpcLabs.EasyOpc.UA;
using System;
using System.Diagnostics;
using System.Threading;

namespace OPC_HMI_Project
{
    public static class OpcFunctions
    {
        public static int ReadInt(EasyUAClient client, string address)
        {
            try
            {
                object val = client.ReadValue(OpcAddresses.ServerAddress, address);
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{address} adresinden okuma yapılırken hata oluştu!");
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public static bool ReadBool(EasyUAClient client, string address)
        {
            try
            {
                object val = client.ReadValue(OpcAddresses.ServerAddress, address);
                return Convert.ToBoolean(val);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{address} adresinden okuma yapılırken hata oluştu!");
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public static void WriteInt(EasyUAClient client, string address, int val)
        {
            try
            {
                client.WriteValue(OpcAddresses.ServerAddress, address, val);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{address} adresine {val} değeri yazılırken hata oluştu!");
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public static void WriteBool(EasyUAClient client, string address, bool val)
        {
            try
            {
                client.WriteValue(OpcAddresses.ServerAddress, address, val);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{address} adresine {val} değeri yazılırken hata oluştu!");
                Debug.WriteLine(ex.Message);
                throw;
            }       
        }
        public static void WaitUntilValIsTrue(EasyUAClient client, string address)
        {
            while (true)
            {
                bool val = ReadBool(client, address);
                if (val)
                    return;
                Thread.Sleep(10);
            }
        }
    }
}
