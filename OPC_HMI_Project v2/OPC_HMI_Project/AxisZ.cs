using OpcLabs.EasyOpc.UA;
using System.Threading.Tasks;

namespace OPC_HMI_Project
{
    public class AxisZ : BaseAxis
    {
        public AxisZ(int targetPosition) : base(targetPosition) {}

        public override Task Execute(EasyUAClient client)
        {
            return Task.Run(() =>
                {
                    OpcFunctions.WriteInt(client, OpcAddresses.Z_Hedef_Pos, TargetPosition);
                    OpcFunctions.WriteBool(client, OpcAddresses.Z_Set, false);
                    OpcFunctions.WriteBool(client, OpcAddresses.Z_Go, true);
                    OpcFunctions.WaitUntilValIsTrue(client, OpcAddresses.Z_Set);
                });
        }

        public override string ToString()
        {
            return $"Z: {TargetPosition}";
        }
    }
}
