using OpcLabs.EasyOpc.UA;
using System.Threading.Tasks;

namespace OPC_HMI_Project
{
    public abstract class BaseAxis
    {
        public int TargetPosition { get; set; }

        public BaseAxis(int targetPosition)
        {
            TargetPosition = targetPosition;
        }

        public abstract Task Execute(EasyUAClient client);
    }
}
