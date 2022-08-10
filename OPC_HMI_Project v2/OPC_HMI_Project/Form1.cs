using OpcLabs.EasyOpc.UA.OperationModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OPC_HMI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool TaskXIsRunning, TaskYIsRunning, TaskZIsRunning;
        private CancellationTokenSource cancellationTokenSource;
        private readonly List<BaseAxis> baseAxisList = new List<BaseAxis>();
        private void Form1_Load(object sender, EventArgs e)
        {   
            baseAxisList.Add(new AxisX(50));
            baseAxisList.Add(new AxisY(10));
            baseAxisList.Add(new AxisZ(5));
            baseAxisList.Add(new AxisX(100));
            baseAxisList.Add(new AxisZ(20));
            baseAxisList.Add(new AxisY(50));
            baseAxisList.Add(new AxisX(0));
            baseAxisList.Add(new AxisY(0));
            baseAxisList.Add(new AxisZ(0));
            listBox1.DataSource = baseAxisList;
        }
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

                var axis = new AxisX(targetPos);
                await axis.Execute(easyUAClient1);
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

                var axis = new AxisY(targetPos);
                await axis.Execute(easyUAClient1);
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
            int targetPos = Convert.ToInt32(txtZTarget.Text);

            try
            {
                TaskZIsRunning = true;
                txtZTarget.Enabled = false;
                btnZGo.Enabled = false;

                var axis = new AxisZ(targetPos);
                await axis.Execute(easyUAClient1);
            }
            finally
            {
                txtZTarget.Enabled = true;
                btnZGo.Enabled = true;
                TaskZIsRunning = false;
            }
        }
        private async void btnGo_Click(object sender, EventArgs e)
        {
            IProgress<int> progress = new Progress<int>(index => listBox1.SelectedIndex = index);

            try
            {
                firstControl();
                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;

                await Task.Run(async () =>
                    {
                        for (int i = 0; i < baseAxisList.Count; i++)
                        {
                            progress.Report(i);

                            if (token.IsCancellationRequested)
                                return;

                            await baseAxisList[i].Execute(easyUAClient1);
                        }
                    }, token);
            }
            finally
            {
                lastControl();
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
        private void firstControl()
        {
            TaskXIsRunning = true;
            TaskYIsRunning = true;
            TaskZIsRunning = true;
            txtXTarget.Enabled = false;
            txtYTarget.Enabled = false;
            txtZTarget.Enabled = false;
            btnXGo.Enabled = false;
            btnYGo.Enabled = false;
            btnZGo.Enabled = false;
            btnGo.Enabled = false;
            btnStop.Visible = true;
        }
        private void lastControl()
        {
            TaskXIsRunning = false;
            TaskYIsRunning = false;
            TaskZIsRunning = false;
            txtXTarget.Enabled = true;
            txtYTarget.Enabled = true;
            txtZTarget.Enabled = true;
            btnXGo.Enabled = true;
            btnYGo.Enabled = true;
            btnZGo.Enabled = true;
            btnGo.Enabled = true;
            btnStop.Visible = false;
        }
    }
}

