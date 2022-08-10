using OpcLabs.EasyOpc.UA;
using System.Threading.Tasks;

namespace OPC_HMI_Project
{
    public class AxisY : BaseAxis
    {
        public AxisY(int targetPosition) : base(targetPosition){}

        public override Task Execute(EasyUAClient client)
        {
            return Task.Run(() =>
                {
                    OpcFunctions.WriteInt(client, OpcAddresses.Y_Hedef_Pos, TargetPosition);
                    OpcFunctions.WriteBool(client, OpcAddresses.Y_Set, false);
                    OpcFunctions.WriteBool(client, OpcAddresses.Y_Go, true);
                    OpcFunctions.WaitUntilValIsTrue(client, OpcAddresses.Y_Set);
                });
        }

        public override string ToString()
        {
            return $"Y: {TargetPosition}";
        }
    }
}
