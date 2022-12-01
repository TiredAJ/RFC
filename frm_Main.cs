//main form for the Controller
//FS -> FlightSimulator.exe

using System.Diagnostics;

namespace RCF
{
    public partial class frm_Main : Form
    {
        const bool DEVMODE = true; //skips asking where to load the exe from

        //private string Sim_Loc;
        private RemoteFlightController RFCHandle = new RemoteFlightController();

        public frm_Main()
        {InitializeComponent();}

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (!DEVMODE)
            {
			    //loads up the second form
                frm_SimLoc FRM_SimLoc = new frm_SimLoc();
			    FRM_SimLoc.ShowDialog();
			
			    //disposes of the second form when it's done
                FRM_SimLoc.Dispose();
            }
            else
            {
                Process.Start(Environment.CurrentDirectory + "\\FlightSimulator.exe");
            }

            TextBox[] TempControls =
            {
                txt_AirSpeed, txt_Pitch, txt_Altitude,
                txt_VSpeed, txt_Warning
            };

            RFCHandle.SetControls(TempControls);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
			//checks if the user has inputted an IP and port
            if (txt_IPAddress.Text == "")
            {
                MessageBox.Show("Please enter an IP address");
                return;
            }
            else if (nud_Port.Value == 0)
            {
                MessageBox.Show("Please enter a port");
                return;
            }

			//attempts to connect to the FS
            if (RFCHandle.Connect(txt_IPAddress.Text, (int)nud_Port.Value) == false)
            {
				//error message
                MessageBox.Show("There was an issue establishing a connection");
                return;
            }

            MessageBox.Show("Connected successfully!");
        }

        private void TRB_Changed(object sender, EventArgs e)
        {
            txt_Throttle.Text = tbr_Throttle.Value.ToString() + "%";
            txt_ElvPitch.Text = tbr_ElvPitch.Value.ToString("0.#") + "°";

            RFCHandle.UpdateInput(tbr_Throttle.Value, (double)(tbr_ElvPitch.Value/10));
        }
    }
}