using OpcLabs.EasyOpc.UA;
using System.Threading.Tasks;

namespace OPC_HMI_Project
{
    public class AxisX : BaseAxis
    {
        public AxisX(int targetPosition) : base(targetPosition){}

        public override Task Execute(EasyUAClient client)
        {
            return Task.Run(() =>
                {
                    OpcFunctions.WriteInt(client, OpcAddresses.X_Hedef_Pos, TargetPosition);
                    OpcFunctions.WriteBool(client, OpcAddresses.X_Set, false);
                    OpcFunctions.WriteBool(client, OpcAddresses.X_Go, true);
                    OpcFunctions.WaitUntilValIsTrue(client, OpcAddresses.X_Set);
                });
        }

        public override string ToString()
        {
            return $"X: {TargetPosition}";
        }
    }
}
