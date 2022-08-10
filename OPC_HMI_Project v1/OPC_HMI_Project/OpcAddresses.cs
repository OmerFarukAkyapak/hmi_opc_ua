namespace OPC_HMI_Project
{
    public static class OpcAddresses
    {
        // Server Adresi
        public const string ServerAddress = "opc.tcp://10.0.0.20:4840";
        // X değerlerinin node adresleri
        public const string X_Pos = "nsu=http://OPC-UA;ns=4;i=43";
        public const string X_Hedef_Pos = "nsu=http://OPC-UA;ns=4;i=44";
        public const string X_Set = "nsu=http://OPC-UA;ns=4;i=45";
        public const string X_Go = "nsu=http://OPC-UA;ns=4;i=46";
        // Y değerlerinin node adresleri
        public const string Y_Pos = "nsu=http://OPC-UA;ns=4;i=47";
        public const string Y_Hedef_Pos = "nsu=http://OPC-UA;ns=4;i=48";
        public const string Y_Set = "nsu=http://OPC-UA;ns=4;i=49";
        public const string Y_Go = "nsu=http://OPC-UA;ns=4;i=50";
        // Z değerlerinin node adresleri
        public const string Z_Pos = "nsu=http://OPC-UA;ns=4;i=51";
        public const string Z_Hedef_Pos = "nsu=http://OPC-UA;ns=4;i=52";
        public const string Z_Set = "nsu=http://OPC-UA;ns=4;i=53";
        public const string Z_Go = "nsu=http://OPC-UA;ns=4;i=54";
    }
}
