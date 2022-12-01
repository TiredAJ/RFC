using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

//Main class to handle interfacing with the FS

namespace RCF
{
    internal class RemoteFlightController
    {
        private TcpClient rfc_Client = new TcpClient();
        private Thread TListener = null;
        private Thread TSender = null;
        private NetworkStream NStream = null;

        private TextBox[] TXTs = new TextBox[4];

        enum TXT : int
        {
            _Airspeed,
            _Pitch,
            _Altitude,
            _VSpeed,
            _Warning
        }

        private rfc_Controls RFC;
        private Telemetry RecTelemetry;

        public void SetControls(TextBox[] _TXTs)
        {TXTs = _TXTs;}

        public void UpdateInput(double _Throttle, double _ElvPitch)
        {
            RFC.Throttle = _Throttle;
            RFC.ElevatorPitch = _ElvPitch;

            TSender = new Thread(Sender);
            TSender.Start();
        }

        public bool Connect(string _IP, int _Port)
        {
            IPAddress IP = IPAddress.Parse(_IP);
            try
            {
                rfc_Client.Connect(IP, _Port);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!");
                return false;
                //throw;
            }

            TListener = new Thread(Listener);

            NStream = rfc_Client.GetStream();

            TListener.Start();

            return true;
        }

        private void Listener()
        {
            string Temp;

            while (true)
            {
                byte[] Buffer = new byte[4096];

                int ByteNum = NStream.Read(Buffer, 0, Buffer.Length);

                if (ByteNum > 0)
                {
                    Temp = Encoding.ASCII.GetString(Buffer, 0, ByteNum);

                    RecTelemetry = JsonSerializer.Deserialize<Telemetry>(Temp);

                    UpdateControls();
                }

            }
        }

        private void Sender()
        {
            if (rfc_Client.Connected)
            {
                string JsonPacket;

                JsonPacket = JsonSerializer.Serialize(RFC);

                byte[] Buffer = Encoding.ASCII.GetBytes(JsonPacket);

                NStream.Write(Buffer, 0, Buffer.Length);
            }
        }

        private void UpdateControls()
        {
            NumberFormatInfo NFI = new NumberFormatInfo { NumberGroupSeparator = ",", NumberDecimalDigits = 2 };

            Task Updater = Task.Run(() =>
            {
                TXTs[(int)TXT._Airspeed].BeginInvoke(new Action(() =>
                {
                    TXTs[(int)TXT._Airspeed].Text = RecTelemetry.Speed.ToString("N",NFI) + " knots";
                }));

                TXTs[(int)TXT._Pitch].BeginInvoke(new Action(() =>
                {
                    TXTs[(int)TXT._Pitch].Text = RecTelemetry.Pitch.ToString("N", NFI) + "°";
                }));

                TXTs[(int)TXT._Altitude].BeginInvoke(new Action(() =>
                {
                    TXTs[(int)TXT._Altitude].Text = RecTelemetry.Altitude.ToString("N", NFI) + " Feet";
                }));

                TXTs[(int)TXT._VSpeed].BeginInvoke(new Action(() =>
                {
                    TXTs[(int)TXT._VSpeed].Text = RecTelemetry.VerticalSpeed.ToString("N", NFI) + " Feet/min";
                }));

                TXTs[(int)TXT._Warning].BeginInvoke(new Action(() =>
                {
                    int Temp = RecTelemetry.WarningCode;
                    string Msg;

                    switch (Temp)
                    {
                        case 0:
                            {
                                Msg = "No warnings";
                                break;
                            }
                        case 1:
                            {
                                Msg = "Too Low";
                                break;
                            }
                        case 2:
                            {
                                Msg = "Stall";
                                break;
                            }
                        default:
                            {
                                Msg = "Possibly connection issues?";
                                break;
                            }
                    }

                    TXTs[(int)TXT._Warning].Text = Msg;
                }));
            });


        }
    }

    public struct rfc_Controls
    {
        public rfc_Controls(double _Throttle, double _ElvPitch)
        {
            Throttle = _Throttle;
            ElevatorPitch = _ElvPitch;
        }

        public double Throttle {get; set;}
        public double ElevatorPitch {get; set;}
    }

    public struct Telemetry
    {
        public double Altitude {get; set;}
        public double Speed {get; set;}
        public double Pitch {get; set;}
        public double VerticalSpeed {get; set;}
        public double Throttle {get; set;}
        public double ElevatorPitch {get; set;}
        public int WarningCode {get; set;}
    }
}
