using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO.Ports;
using System.Threading;
using System.Windows.Threading;
using System.Diagnostics;

namespace WPFPageSwitch
{
	public partial class Gameplay : UserControl, ISwitchable
	{
        SerialPort serial = new SerialPort();
        string recieved_data;
        public Gameplay()
		{
			InitializeComponent();
            Connect_btn.Content = "Connect";
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                Comm_Port_Names.Items.Add(s);
            }
        }
        private void Connect_Comms(object sender, RoutedEventArgs e)
        {
            if (Connect_btn.Content == "Connect")
            {
                //Sets up serial port
                serial.PortName = Comm_Port_Names.Text;
                //serial.BaudRate = Convert.ToInt32(Baud_Rates.Text);
                serial.BaudRate = 230400;
                serial.Handshake = System.IO.Ports.Handshake.None;
                serial.Parity = Parity.None;
                serial.DataBits = 8;
                serial.StopBits = StopBits.One;
                serial.ReadTimeout = 200;
                serial.WriteTimeout = 50;
                serial.Open();

                //Sets button State and Creates function call on data recieved
                Connect_btn.Content = "Disconnect";
                serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Recieve);

            }
            else
            {
                try // just in case serial port is not open could also be acheved using if(serial.IsOpen)
                {
                    serial.Close();
                    Connect_btn.Content = "Connect";
                }
                catch
                {
                }
            }
        }
        private delegate void UpdateUiTextDelegate(string text);
        private void Recieve(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Collecting the characters received to our 'buffer' (string).
            recieved_data = serial.ReadExisting();
            this.Dispatcher.Invoke((Action)(() =>
            {//this refer to form in WPF application 
                if (recieved_data == "0")
                    elipsa.Fill = new SolidColorBrush(Colors.Red);
                else if (recieved_data == "1")
                    elipsa.Fill = new SolidColorBrush(Colors.Green);
            }));

            //Debug.WriteLine(recieved_data);
        }
        private void Send_Data0(object sender, RoutedEventArgs e)
        {
            SerialCmdSend("0");
        }
        private void Send_Data1(object sender, RoutedEventArgs e)
        {
            SerialCmdSend("1");
        }
        public void SerialCmdSend(string data)
        {
            if (serial.IsOpen)
            {
                try
                {
                    // Send the binary data out the port
                    byte[] hexstring = Encoding.ASCII.GetBytes(data);
                    //There is a intermitant problem that I came across
                    //If I write more than one byte in succesion without a 
                    //delay the PIC i'm communicating with will Crash
                    //I expect this id due to PC timing issues ad they are
                    //not directley connected to the COM port the solution
                    //Is a ver small 1 millisecound delay between chracters
                    foreach (byte hexval in hexstring)
                    {
                        byte[] _hexval = new byte[] { hexval }; // need to convert byte to byte[] to write
                        serial.Write(_hexval, 0, 1);
                        Thread.Sleep(1);
                    }
                }
                catch (Exception ex)
                {
                    //para.Inlines.Add("Failed to SEND" + data + "\n" + ex + "\n");
                    //mcFlowDoc.Blocks.Add(para);
                    //Commdata.Document = mcFlowDoc;
                }
            }
            else
            {
            }
        }
        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	Switcher.Switch(new MainMenu());
        }
        #endregion
    }
}