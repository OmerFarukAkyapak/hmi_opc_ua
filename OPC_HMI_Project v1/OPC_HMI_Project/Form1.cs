using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ömer Faruk Akyapak

namespace OPC_HMI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ömer Faruk Akyapak
            //OPC_HMI_Project
        }
        private static bool TaskXIsRunning, TaskYIsRunning, TaskZIsRunning;
        private async void Form1_Shown(object sender, EventArgs e)
        {
            await Task.Run(() =>
                {
                    OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.X_Set, false);
                    OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.Y_Set, false);
                    OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.Z_Set, false);
                });

            var args = new EasyUAMonitoredItemArguments[]
                {
                    new EasyUAMonitoredItemArguments(lblXValue, OpcAddresses.ServerAddress, OpcAddresses.X_Pos, 10),
                    new EasyUAMonitoredItemArguments(lblYValue, OpcAddresses.ServerAddress, OpcAddresses.Y_Pos, 10),
                    new EasyUAMonitoredItemArguments(lblZValue, OpcAddresses.ServerAddress, OpcAddresses.Z_Pos, 10),
                };

            easyUAClient1.SubscribeMultipleMonitoredItems(args);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TaskXIsRunning || TaskYIsRunning || TaskZIsRunning)
            {
                e.Cancel = true;
                return;
            }

            easyUAClient1.UnsubscribeAllMonitoredItems();
        }

        private void easyUAClient1_DataChangeNotification(object sender, EasyUADataChangeNotificationEventArgs e)
        {
            if (!e.Succeeded)
            {
                Debug.WriteLine(e.Exception);
                return;
            }

            if (!e.AttributeData.HasValue)
                return;

            if (e.Arguments.State is not Label label)
                return;

            int pos = Convert.ToInt32(e.AttributeData.Value);
            label.Text = pos.ToString();
        }

        private async void btnXGo_Click(object sender, EventArgs e)
        {
            int targetPos = Convert.ToInt32(txtXTarget.Text);

            try
            {
                TaskXIsRunning = true;
                txtXTarget.Enabled = false;
                btnXGo.Enabled = false;

                await Task.Run(() =>
                    {
                        OpcFunctions.WriteInt(easyUAClient1, OpcAddresses.X_Hedef_Pos, targetPos);
                        OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.X_Set, false);
                        OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.X_Go, true);
                        OpcFunctions.WaitUntilValIsTrue(easyUAClient1, OpcAddresses.X_Set);
                    });
            }
            finally
            {
                txtXTarget.Enabled = true;
                btnXGo.Enabled = true;
                TaskXIsRunning = false;
            }
        }

        private async void btnYGo_Click(object sender, EventArgs e)
        {
            int targetPos = Convert.ToInt32(txtYTarget.Text);

            try
            {
                TaskYIsRunning = true;
                txtYTarget.Enabled = false;
                btnYGo.Enabled = false;

                await Task.Run(() =>
                    {
                        OpcFunctions.WriteInt(easyUAClient1, OpcAddresses.Y_Hedef_Pos, targetPos);
                        OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.Y_Set, false);
                        OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.Y_Go, true);
                        OpcFunctions.WaitUntilValIsTrue(easyUAClient1, OpcAddresses.Y_Set);
                    });
            }
            finally
            {
                txtYTarget.Enabled = true;
                btnYGo.Enabled = true;
                TaskYIsRunning = false;
            }
        }

        private async void btnZGo_Click(object sender, EventArgs e)
        {
            int targetPos = Convert.ToInt32(txtYTarget.Text);

            try
            {
                TaskZIsRunning = true;
                txtZTarget.Enabled = false;
                btnZGo.Enabled = false;

                await Task.Run(() =>
                    {
                        OpcFunctions.WriteInt(easyUAClient1, OpcAddresses.Z_Hedef_Pos, targetPos);
                        OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.Z_Set, false);
                        OpcFunctions.WriteBool(easyUAClient1, OpcAddresses.Z_Go, true);
                        OpcFunctions.WaitUntilValIsTrue(easyUAClient1, OpcAddresses.Z_Set);
                    });
            }
            finally
            {
                txtZTarget.Enabled = true;
                btnZGo.Enabled = true;
                TaskZIsRunning = false;
            }
        }
    }
}

