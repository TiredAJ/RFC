using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/////
//	This form is just to (optionally) setup the flight sim with the controller	  //
//	It can eith load up the included FlightSimulator.exe program, or allow 		  //
//	the user to load their own. Alternatively, if the user already has the 		  //
//	program open, it just skips 												  //
																				////

namespace RCF
{
    public partial class frm_SimLoc : Form
    {
        public string UserLoc;
        bool FSisRunning = false;

        public frm_SimLoc()
        {InitializeComponent();}

        private void frm_SimLoc_Load(object sender, EventArgs e)
        {
			//basic intro for the user
            MessageBox.Show("Please enter the location of the FlightSimulator.exe " +
                "file, or click \"Default\" to use the included copy");

			//sets up the OpenFileDialog control
            ofd_FindFile.Filter = "Executables(*.exe;)|*.exe";
            ofd_FindFile.InitialDirectory = Environment.CurrentDirectory + "\\FlightSimulator.exe";
        }

        private void btn_FindFile_Click(object sender, EventArgs e)
        {
			//shows the dialog to the user
            ofd_FindFile.ShowDialog();

			//takes the path the user chose and saves it.
            UserLoc = ofd_FindFile.FileName;
			//displays the path
            txt_FileLoc.Text = UserLoc;
			//allows the user to proceed
            btn_Proceed.Enabled = true;
        }

        private void btn_Default_Click(object sender, EventArgs e)
        {
			//loads up the included executable
            UserLoc = Environment.CurrentDirectory + "\\FlightSimulator.exe";
            txt_FileLoc.Text = UserLoc;
            btn_Proceed.Enabled = true;
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
			//allows the user to use the executable they already have open
            FSisRunning = true;
            btn_Proceed.Enabled = true;
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {//proceeds with the RFC
			
			//checks if the the program needs to start a process for the FS
            if (FSisRunning != true)
            {Process.Start(UserLoc);}

			//closes the form and returns to the main form
            this.Close();
        }
    }
}
