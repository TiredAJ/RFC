namespace RCF
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_Readings = new System.Windows.Forms.GroupBox();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.txt_Warning = new System.Windows.Forms.TextBox();
            this.lbl_VSpeed = new System.Windows.Forms.Label();
            this.txt_VSpeed = new System.Windows.Forms.TextBox();
            this.lbl_Pitch = new System.Windows.Forms.Label();
            this.txt_Pitch = new System.Windows.Forms.TextBox();
            this.lbl_Altitude = new System.Windows.Forms.Label();
            this.txt_Altitude = new System.Windows.Forms.TextBox();
            this.lbl_AirSpeed = new System.Windows.Forms.Label();
            this.txt_AirSpeed = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_IPAddress = new System.Windows.Forms.Label();
            this.nud_Port = new System.Windows.Forms.NumericUpDown();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.gbx_Controls = new System.Windows.Forms.GroupBox();
            this.txt_ElvPitch = new System.Windows.Forms.TextBox();
            this.txt_Throttle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbr_ElvPitch = new System.Windows.Forms.TrackBar();
            this.tbr_Throttle = new System.Windows.Forms.TrackBar();
            this.gbx_Readings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
            this.gbx_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_ElvPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Throttle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Readings
            // 
            this.gbx_Readings.Controls.Add(this.lbl_Warning);
            this.gbx_Readings.Controls.Add(this.txt_Warning);
            this.gbx_Readings.Controls.Add(this.lbl_VSpeed);
            this.gbx_Readings.Controls.Add(this.txt_VSpeed);
            this.gbx_Readings.Controls.Add(this.lbl_Pitch);
            this.gbx_Readings.Controls.Add(this.txt_Pitch);
            this.gbx_Readings.Controls.Add(this.lbl_Altitude);
            this.gbx_Readings.Controls.Add(this.txt_Altitude);
            this.gbx_Readings.Controls.Add(this.lbl_AirSpeed);
            this.gbx_Readings.Controls.Add(this.txt_AirSpeed);
            this.gbx_Readings.Location = new System.Drawing.Point(141, 16);
            this.gbx_Readings.Name = "gbx_Readings";
            this.gbx_Readings.Size = new System.Drawing.Size(647, 149);
            this.gbx_Readings.TabIndex = 0;
            this.gbx_Readings.TabStop = false;
            this.gbx_Readings.Text = "Readings";
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Location = new System.Drawing.Point(330, 50);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(64, 20);
            this.lbl_Warning.TabIndex = 9;
            this.lbl_Warning.Text = "Warning";
            this.lbl_Warning.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_Warning
            // 
            this.txt_Warning.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Warning.Location = new System.Drawing.Point(330, 74);
            this.txt_Warning.Name = "txt_Warning";
            this.txt_Warning.Size = new System.Drawing.Size(181, 38);
            this.txt_Warning.TabIndex = 8;
            // 
            // lbl_VSpeed
            // 
            this.lbl_VSpeed.AutoSize = true;
            this.lbl_VSpeed.Location = new System.Drawing.Point(168, 83);
            this.lbl_VSpeed.Name = "lbl_VSpeed";
            this.lbl_VSpeed.Size = new System.Drawing.Size(104, 20);
            this.lbl_VSpeed.TabIndex = 7;
            this.lbl_VSpeed.Text = "Vertical Speed";
            // 
            // txt_VSpeed
            // 
            this.txt_VSpeed.Location = new System.Drawing.Point(168, 107);
            this.txt_VSpeed.Name = "txt_VSpeed";
            this.txt_VSpeed.Size = new System.Drawing.Size(156, 27);
            this.txt_VSpeed.TabIndex = 6;
            // 
            // lbl_Pitch
            // 
            this.lbl_Pitch.AutoSize = true;
            this.lbl_Pitch.Location = new System.Drawing.Point(6, 83);
            this.lbl_Pitch.Name = "lbl_Pitch";
            this.lbl_Pitch.Size = new System.Drawing.Size(41, 20);
            this.lbl_Pitch.TabIndex = 5;
            this.lbl_Pitch.Text = "Pitch";
            // 
            // txt_Pitch
            // 
            this.txt_Pitch.Location = new System.Drawing.Point(6, 107);
            this.txt_Pitch.Name = "txt_Pitch";
            this.txt_Pitch.Size = new System.Drawing.Size(156, 27);
            this.txt_Pitch.TabIndex = 4;
            // 
            // lbl_Altitude
            // 
            this.lbl_Altitude.AutoSize = true;
            this.lbl_Altitude.Location = new System.Drawing.Point(168, 26);
            this.lbl_Altitude.Name = "lbl_Altitude";
            this.lbl_Altitude.Size = new System.Drawing.Size(62, 20);
            this.lbl_Altitude.TabIndex = 3;
            this.lbl_Altitude.Text = "Altitude";
            // 
            // txt_Altitude
            // 
            this.txt_Altitude.Location = new System.Drawing.Point(168, 50);
            this.txt_Altitude.Name = "txt_Altitude";
            this.txt_Altitude.Size = new System.Drawing.Size(156, 27);
            this.txt_Altitude.TabIndex = 2;
            // 
            // lbl_AirSpeed
            // 
            this.lbl_AirSpeed.AutoSize = true;
            this.lbl_AirSpeed.Location = new System.Drawing.Point(6, 26);
            this.lbl_AirSpeed.Name = "lbl_AirSpeed";
            this.lbl_AirSpeed.Size = new System.Drawing.Size(68, 20);
            this.lbl_AirSpeed.TabIndex = 1;
            this.lbl_AirSpeed.Text = "Airspeed";
            // 
            // txt_AirSpeed
            // 
            this.txt_AirSpeed.Location = new System.Drawing.Point(6, 50);
            this.txt_AirSpeed.Name = "txt_AirSpeed";
            this.txt_AirSpeed.Size = new System.Drawing.Size(156, 27);
            this.txt_AirSpeed.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Controls.Add(this.lbl_Port);
            this.panel1.Controls.Add(this.lbl_IPAddress);
            this.panel1.Controls.Add(this.nud_Port);
            this.panel1.Controls.Add(this.txt_IPAddress);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 153);
            this.panel1.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(3, 113);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(114, 31);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(3, 57);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(35, 20);
            this.lbl_Port.TabIndex = 5;
            this.lbl_Port.Text = "Port";
            // 
            // lbl_IPAddress
            // 
            this.lbl_IPAddress.AutoSize = true;
            this.lbl_IPAddress.Location = new System.Drawing.Point(3, 4);
            this.lbl_IPAddress.Name = "lbl_IPAddress";
            this.lbl_IPAddress.Size = new System.Drawing.Size(78, 20);
            this.lbl_IPAddress.TabIndex = 4;
            this.lbl_IPAddress.Text = "IP Address";
            // 
            // nud_Port
            // 
            this.nud_Port.Location = new System.Drawing.Point(3, 80);
            this.nud_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_Port.Name = "nud_Port";
            this.nud_Port.Size = new System.Drawing.Size(114, 27);
            this.nud_Port.TabIndex = 2;
            this.nud_Port.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(3, 27);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(114, 27);
            this.txt_IPAddress.TabIndex = 3;
            // 
            // gbx_Controls
            // 
            this.gbx_Controls.Controls.Add(this.txt_ElvPitch);
            this.gbx_Controls.Controls.Add(this.txt_Throttle);
            this.gbx_Controls.Controls.Add(this.label2);
            this.gbx_Controls.Controls.Add(this.label1);
            this.gbx_Controls.Controls.Add(this.tbr_ElvPitch);
            this.gbx_Controls.Controls.Add(this.tbr_Throttle);
            this.gbx_Controls.Location = new System.Drawing.Point(12, 171);
            this.gbx_Controls.Name = "gbx_Controls";
            this.gbx_Controls.Size = new System.Drawing.Size(305, 267);
            this.gbx_Controls.TabIndex = 2;
            this.gbx_Controls.TabStop = false;
            this.gbx_Controls.Text = "Controls";
            // 
            // txt_ElvPitch
            // 
            this.txt_ElvPitch.Location = new System.Drawing.Point(211, 234);
            this.txt_ElvPitch.Name = "txt_ElvPitch";
            this.txt_ElvPitch.Size = new System.Drawing.Size(75, 27);
            this.txt_ElvPitch.TabIndex = 8;
            // 
            // txt_Throttle
            // 
            this.txt_Throttle.Location = new System.Drawing.Point(68, 234);
            this.txt_Throttle.Name = "txt_Throttle";
            this.txt_Throttle.Size = new System.Drawing.Size(75, 27);
            this.txt_Throttle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Throttle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elevator\r\nPitch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbr_ElvPitch
            // 
            this.tbr_ElvPitch.LargeChange = 2;
            this.tbr_ElvPitch.Location = new System.Drawing.Point(149, 26);
            this.tbr_ElvPitch.Maximum = 50;
            this.tbr_ElvPitch.Minimum = -50;
            this.tbr_ElvPitch.Name = "tbr_ElvPitch";
            this.tbr_ElvPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbr_ElvPitch.Size = new System.Drawing.Size(56, 235);
            this.tbr_ElvPitch.TabIndex = 4;
            this.tbr_ElvPitch.TabStop = false;
            this.tbr_ElvPitch.TickFrequency = 5;
            this.tbr_ElvPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbr_ElvPitch.ValueChanged += new System.EventHandler(this.TRB_Changed);
            // 
            // tbr_Throttle
            // 
            this.tbr_Throttle.Location = new System.Drawing.Point(6, 26);
            this.tbr_Throttle.Maximum = 100;
            this.tbr_Throttle.Name = "tbr_Throttle";
            this.tbr_Throttle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbr_Throttle.Size = new System.Drawing.Size(56, 235);
            this.tbr_Throttle.TabIndex = 3;
            this.tbr_Throttle.TickFrequency = 10;
            this.tbr_Throttle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbr_Throttle.ValueChanged += new System.EventHandler(this.TRB_Changed);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_Controls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbx_Readings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Main";
            this.Text = "Remote Flight Controller";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.gbx_Readings.ResumeLayout(false);
            this.gbx_Readings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
            this.gbx_Controls.ResumeLayout(false);
            this.gbx_Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_ElvPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Throttle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbx_Readings;
        private Panel panel1;
        private Button btn_Connect;
        private Label lbl_Port;
        private Label lbl_IPAddress;
        private NumericUpDown nud_Port;
        private TextBox txt_IPAddress;
        private TextBox txt_AirSpeed;
        private Label lbl_AirSpeed;
        private Label lbl_Altitude;
        private TextBox txt_Altitude;
        private Label lbl_Warning;
        private TextBox txt_Warning;
        private Label lbl_VSpeed;
        private TextBox txt_VSpeed;
        private Label lbl_Pitch;
        private TextBox txt_Pitch;
        private GroupBox gbx_Controls;
        private TextBox txt_ElvPitch;
        private TextBox txt_Throttle;
        private Label label2;
        private Label label1;
        private TrackBar tbr_ElvPitch;
        private TrackBar tbr_Throttle;
    }
}