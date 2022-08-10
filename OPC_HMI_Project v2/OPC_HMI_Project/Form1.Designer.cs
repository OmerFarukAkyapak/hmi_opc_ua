namespace OPC_HMI_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblXTitle = new System.Windows.Forms.Label();
            this.lblXSubTitle = new System.Windows.Forms.Label();
            this.txtXTarget = new System.Windows.Forms.TextBox();
            this.btnXGo = new System.Windows.Forms.Button();
            this.lblXValue = new System.Windows.Forms.Label();
            this.pnlX = new System.Windows.Forms.Panel();
            this.tblX = new System.Windows.Forms.TableLayoutPanel();
            this.pnlY = new System.Windows.Forms.Panel();
            this.tblY = new System.Windows.Forms.TableLayoutPanel();
            this.lblYTitle = new System.Windows.Forms.Label();
            this.btnYGo = new System.Windows.Forms.Button();
            this.lblYValue = new System.Windows.Forms.Label();
            this.txtYTarget = new System.Windows.Forms.TextBox();
            this.lblYSubTitle = new System.Windows.Forms.Label();
            this.pnlZ = new System.Windows.Forms.Panel();
            this.tblZ = new System.Windows.Forms.TableLayoutPanel();
            this.lblZTitle = new System.Windows.Forms.Label();
            this.btnZGo = new System.Windows.Forms.Button();
            this.lblZValue = new System.Windows.Forms.Label();
            this.txtZTarget = new System.Windows.Forms.TextBox();
            this.lblZSubTitle = new System.Windows.Forms.Label();
            this.easyUAClient1 = new OpcLabs.EasyOpc.UA.EasyUAClient(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlX.SuspendLayout();
            this.tblX.SuspendLayout();
            this.pnlY.SuspendLayout();
            this.tblY.SuspendLayout();
            this.pnlZ.SuspendLayout();
            this.tblZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblXTitle
            // 
            this.lblXTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXTitle.AutoSize = true;
            this.lblXTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblXTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblXTitle.Location = new System.Drawing.Point(37, 12);
            this.lblXTitle.Margin = new System.Windows.Forms.Padding(12);
            this.lblXTitle.Name = "lblXTitle";
            this.lblXTitle.Size = new System.Drawing.Size(320, 58);
            this.lblXTitle.TabIndex = 0;
            this.lblXTitle.Text = "X POSITION";
            // 
            // lblXSubTitle
            // 
            this.lblXSubTitle.AutoSize = true;
            this.lblXSubTitle.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblXSubTitle.Location = new System.Drawing.Point(3, 188);
            this.lblXSubTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblXSubTitle.Name = "lblXSubTitle";
            this.lblXSubTitle.Size = new System.Drawing.Size(365, 27);
            this.lblXSubTitle.TabIndex = 1;
            this.lblXSubTitle.Text = "Write the Target Value for X Positon";
            // 
            // txtXTarget
            // 
            this.txtXTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXTarget.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtXTarget.Location = new System.Drawing.Point(3, 221);
            this.txtXTarget.Name = "txtXTarget";
            this.txtXTarget.Size = new System.Drawing.Size(388, 41);
            this.txtXTarget.TabIndex = 2;
            this.txtXTarget.Text = "0";
            // 
            // btnXGo
            // 
            this.btnXGo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnXGo.Location = new System.Drawing.Point(3, 268);
            this.btnXGo.Name = "btnXGo";
            this.btnXGo.Size = new System.Drawing.Size(121, 64);
            this.btnXGo.TabIndex = 3;
            this.btnXGo.Text = "Go!";
            this.btnXGo.UseVisualStyleBackColor = true;
            this.btnXGo.Click += new System.EventHandler(this.btnXGo_Click);
            // 
            // lblXValue
            // 
            this.lblXValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXValue.AutoSize = true;
            this.lblXValue.BackColor = System.Drawing.Color.Silver;
            this.lblXValue.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblXValue.Location = new System.Drawing.Point(87, 94);
            this.lblXValue.Margin = new System.Windows.Forms.Padding(12);
            this.lblXValue.MinimumSize = new System.Drawing.Size(220, 0);
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Padding = new System.Windows.Forms.Padding(2);
            this.lblXValue.Size = new System.Drawing.Size(220, 79);
            this.lblXValue.TabIndex = 4;
            this.lblXValue.Text = "0";
            this.lblXValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlX
            // 
            this.pnlX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlX.Controls.Add(this.tblX);
            this.pnlX.Location = new System.Drawing.Point(12, 12);
            this.pnlX.Name = "pnlX";
            this.pnlX.Padding = new System.Windows.Forms.Padding(12);
            this.pnlX.Size = new System.Drawing.Size(420, 387);
            this.pnlX.TabIndex = 5;
            // 
            // tblX
            // 
            this.tblX.ColumnCount = 1;
            this.tblX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblX.Controls.Add(this.lblXTitle, 0, 0);
            this.tblX.Controls.Add(this.btnXGo, 0, 4);
            this.tblX.Controls.Add(this.lblXValue, 0, 1);
            this.tblX.Controls.Add(this.txtXTarget, 0, 3);
            this.tblX.Controls.Add(this.lblXSubTitle, 0, 2);
            this.tblX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblX.Location = new System.Drawing.Point(12, 12);
            this.tblX.Name = "tblX";
            this.tblX.RowCount = 5;
            this.tblX.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblX.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblX.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblX.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblX.Size = new System.Drawing.Size(394, 361);
            this.tblX.TabIndex = 0;
            // 
            // pnlY
            // 
            this.pnlY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlY.Controls.Add(this.tblY);
            this.pnlY.Location = new System.Drawing.Point(438, 12);
            this.pnlY.Name = "pnlY";
            this.pnlY.Padding = new System.Windows.Forms.Padding(12);
            this.pnlY.Size = new System.Drawing.Size(420, 387);
            this.pnlY.TabIndex = 6;
            // 
            // tblY
            // 
            this.tblY.ColumnCount = 1;
            this.tblY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblY.Controls.Add(this.lblYTitle, 0, 0);
            this.tblY.Controls.Add(this.btnYGo, 0, 4);
            this.tblY.Controls.Add(this.lblYValue, 0, 1);
            this.tblY.Controls.Add(this.txtYTarget, 0, 3);
            this.tblY.Controls.Add(this.lblYSubTitle, 0, 2);
            this.tblY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblY.Location = new System.Drawing.Point(12, 12);
            this.tblY.Name = "tblY";
            this.tblY.RowCount = 5;
            this.tblY.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblY.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblY.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblY.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblY.Size = new System.Drawing.Size(394, 361);
            this.tblY.TabIndex = 0;
            // 
            // lblYTitle
            // 
            this.lblYTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYTitle.AutoSize = true;
            this.lblYTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblYTitle.Location = new System.Drawing.Point(37, 12);
            this.lblYTitle.Margin = new System.Windows.Forms.Padding(12);
            this.lblYTitle.Name = "lblYTitle";
            this.lblYTitle.Size = new System.Drawing.Size(319, 58);
            this.lblYTitle.TabIndex = 0;
            this.lblYTitle.Text = "Y POSITION";
            // 
            // btnYGo
            // 
            this.btnYGo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnYGo.Location = new System.Drawing.Point(3, 268);
            this.btnYGo.Name = "btnYGo";
            this.btnYGo.Size = new System.Drawing.Size(121, 64);
            this.btnYGo.TabIndex = 3;
            this.btnYGo.Text = "Go!";
            this.btnYGo.UseVisualStyleBackColor = true;
            this.btnYGo.Click += new System.EventHandler(this.btnYGo_Click);
            // 
            // lblYValue
            // 
            this.lblYValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYValue.AutoSize = true;
            this.lblYValue.BackColor = System.Drawing.Color.Silver;
            this.lblYValue.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYValue.Location = new System.Drawing.Point(87, 94);
            this.lblYValue.Margin = new System.Windows.Forms.Padding(12);
            this.lblYValue.MinimumSize = new System.Drawing.Size(220, 0);
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Padding = new System.Windows.Forms.Padding(2);
            this.lblYValue.Size = new System.Drawing.Size(220, 79);
            this.lblYValue.TabIndex = 4;
            this.lblYValue.Text = "0";
            this.lblYValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYTarget
            // 
            this.txtYTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYTarget.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYTarget.Location = new System.Drawing.Point(3, 221);
            this.txtYTarget.Name = "txtYTarget";
            this.txtYTarget.Size = new System.Drawing.Size(388, 41);
            this.txtYTarget.TabIndex = 2;
            this.txtYTarget.Text = "0";
            // 
            // lblYSubTitle
            // 
            this.lblYSubTitle.AutoSize = true;
            this.lblYSubTitle.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblYSubTitle.Location = new System.Drawing.Point(3, 188);
            this.lblYSubTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblYSubTitle.Name = "lblYSubTitle";
            this.lblYSubTitle.Size = new System.Drawing.Size(365, 27);
            this.lblYSubTitle.TabIndex = 1;
            this.lblYSubTitle.Text = "Write the Target Value for Y Positon";
            // 
            // pnlZ
            // 
            this.pnlZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZ.Controls.Add(this.tblZ);
            this.pnlZ.Location = new System.Drawing.Point(864, 12);
            this.pnlZ.Name = "pnlZ";
            this.pnlZ.Padding = new System.Windows.Forms.Padding(12);
            this.pnlZ.Size = new System.Drawing.Size(420, 387);
            this.pnlZ.TabIndex = 7;
            // 
            // tblZ
            // 
            this.tblZ.ColumnCount = 1;
            this.tblZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblZ.Controls.Add(this.lblZTitle, 0, 0);
            this.tblZ.Controls.Add(this.btnZGo, 0, 4);
            this.tblZ.Controls.Add(this.lblZValue, 0, 1);
            this.tblZ.Controls.Add(this.txtZTarget, 0, 3);
            this.tblZ.Controls.Add(this.lblZSubTitle, 0, 2);
            this.tblZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblZ.Location = new System.Drawing.Point(12, 12);
            this.tblZ.Name = "tblZ";
            this.tblZ.RowCount = 5;
            this.tblZ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblZ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblZ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblZ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblZ.Size = new System.Drawing.Size(394, 361);
            this.tblZ.TabIndex = 0;
            // 
            // lblZTitle
            // 
            this.lblZTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZTitle.AutoSize = true;
            this.lblZTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblZTitle.Location = new System.Drawing.Point(38, 12);
            this.lblZTitle.Margin = new System.Windows.Forms.Padding(12);
            this.lblZTitle.Name = "lblZTitle";
            this.lblZTitle.Size = new System.Drawing.Size(317, 58);
            this.lblZTitle.TabIndex = 0;
            this.lblZTitle.Text = "Z POSITION";
            // 
            // btnZGo
            // 
            this.btnZGo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnZGo.Location = new System.Drawing.Point(3, 268);
            this.btnZGo.Name = "btnZGo";
            this.btnZGo.Size = new System.Drawing.Size(121, 64);
            this.btnZGo.TabIndex = 3;
            this.btnZGo.Text = "Go!";
            this.btnZGo.UseVisualStyleBackColor = true;
            this.btnZGo.Click += new System.EventHandler(this.btnZGo_Click);
            // 
            // lblZValue
            // 
            this.lblZValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZValue.AutoSize = true;
            this.lblZValue.BackColor = System.Drawing.Color.Silver;
            this.lblZValue.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZValue.Location = new System.Drawing.Point(87, 94);
            this.lblZValue.Margin = new System.Windows.Forms.Padding(12);
            this.lblZValue.MinimumSize = new System.Drawing.Size(220, 0);
            this.lblZValue.Name = "lblZValue";
            this.lblZValue.Padding = new System.Windows.Forms.Padding(2);
            this.lblZValue.Size = new System.Drawing.Size(220, 79);
            this.lblZValue.TabIndex = 4;
            this.lblZValue.Text = "0";
            this.lblZValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtZTarget
            // 
            this.txtZTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZTarget.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZTarget.Location = new System.Drawing.Point(3, 221);
            this.txtZTarget.Name = "txtZTarget";
            this.txtZTarget.Size = new System.Drawing.Size(388, 41);
            this.txtZTarget.TabIndex = 2;
            this.txtZTarget.Text = "0";
            // 
            // lblZSubTitle
            // 
            this.lblZSubTitle.AutoSize = true;
            this.lblZSubTitle.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblZSubTitle.Location = new System.Drawing.Point(3, 188);
            this.lblZSubTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblZSubTitle.Name = "lblZSubTitle";
            this.lblZSubTitle.Size = new System.Drawing.Size(364, 27);
            this.lblZSubTitle.TabIndex = 1;
            this.lblZSubTitle.Text = "Write the Target Value for Z Positon";
            // 
            // easyUAClient1
            // 
            this.easyUAClient1.DataChangeNotification += new OpcLabs.EasyOpc.UA.EasyUADataChangeNotificationEventHandler(this.easyUAClient1_DataChangeNotification);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(1290, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 312);
            this.listBox1.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnGo.Location = new System.Drawing.Point(1290, 335);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(121, 64);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Go List!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnStop.Location = new System.Drawing.Point(1417, 335);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 64);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "STOP!";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1551, 411);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pnlZ);
            this.Controls.Add(this.pnlY);
            this.Controls.Add(this.pnlX);
            this.Name = "Form1";
            this.Text = "OPC/HMI v2 - Ömer Faruk Akyapak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnlX.ResumeLayout(false);
            this.tblX.ResumeLayout(false);
            this.tblX.PerformLayout();
            this.pnlY.ResumeLayout(false);
            this.tblY.ResumeLayout(false);
            this.tblY.PerformLayout();
            this.pnlZ.ResumeLayout(false);
            this.tblZ.ResumeLayout(false);
            this.tblZ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblXTitle;
        private System.Windows.Forms.Label lblXSubTitle;
        private System.Windows.Forms.TextBox txtXTarget;
        private System.Windows.Forms.Button btnXGo;
        private System.Windows.Forms.Label lblXValue;
        private System.Windows.Forms.Panel pnlX;
        private System.Windows.Forms.TableLayoutPanel tblX;
        private System.Windows.Forms.Panel pnlY;
        private System.Windows.Forms.TableLayoutPanel tblY;
        private System.Windows.Forms.Label lblYTitle;
        private System.Windows.Forms.Button btnYGo;
        private System.Windows.Forms.Label lblYValue;
        private System.Windows.Forms.TextBox txtYTarget;
        private System.Windows.Forms.Label lblYSubTitle;
        private System.Windows.Forms.Panel pnlZ;
        private System.Windows.Forms.TableLayoutPanel tblZ;
        private System.Windows.Forms.Label lblZTitle;
        private System.Windows.Forms.Button btnZGo;
        private System.Windows.Forms.Label lblZValue;
        private System.Windows.Forms.TextBox txtZTarget;
        private System.Windows.Forms.Label lblZSubTitle;
        private OpcLabs.EasyOpc.UA.EasyUAClient easyUAClient1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStop;
    }
}

