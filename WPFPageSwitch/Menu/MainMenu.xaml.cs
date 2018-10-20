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
	public partial class MainMenu : UserControl, ISwitchable
	{

        //LoginWindowForm loginForm;
        //RegisterForm registerForm;
        #region variables
        //Richtextbox
        FlowDocument mcFlowDoc = new FlowDocument();
        Paragraph para = new Paragraph();
        //Serial 
        SerialPort serial = new SerialPort();
        string recieved_data;
        int i = 50000;
        double a = 0;
        double b = 1;
        double c = 1;
        double d = 0;
        double f = 0;
        string hexValue;
        int g = 99;
        char ch = (char)99;



        #endregion

        public MainMenu()
		{
			InitializeComponent();
            Connect_btn.Content = "Connect";
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                Comm_Port_Names.Items.Add(s);
            }

            //loginForm = new LoginWindowForm();
            //registerForm = new RegisterForm();

            //loginForm.SubmitClicked += new EventHandler(loginWindowForm_SubmitClicked);
            //registerForm.SubmitClicked += new EventHandler(registerForm_SubmitClicked);
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
                f = a * Math.Pow(2, 3) + b * Math.Pow(2, 2) + c * 2 + d;
                
                hexValue = f.ToString();
                //Debug.WriteLine(hexValue);
                
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
            //recieved_data = serial.ReadExisting();
            if (serial.BytesToRead > 0)
            {
                recieved_data = serial.ReadExisting();
                //Dispatcher.Invoke(DispatcherPriority.Send, new UpdateUiTextDelegate(WriteData), recieved_data);


                //SerialCmdSend(rnd.Next(206, 211).ToString() + "#");
                //string hexValue = f.ToString("X");
                String s = f.ToString();
                SerialCmdSend(ch.ToString());
                //Debug.WriteLine(c.ToString());
            }
            Random rnd = new Random();
            Debug.WriteLine(recieved_data);
        }
        private void WriteData(string text)
        {
            // Assign the value of the recieved_data to the RichTextBox.
            para.Inlines.Add(text);
            mcFlowDoc.Blocks.Add(para);
            Commdata.Document = mcFlowDoc;
        }
        private void Send_Data(object sender, RoutedEventArgs e)
        {
            SerialCmdSend(SerialData.Text);
            SerialData.Text = "";
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
                    para.Inlines.Add("Failed to SEND" + data + "\n" + ex + "\n");
                    mcFlowDoc.Blocks.Add(para);
                    Commdata.Document = mcFlowDoc;
                }
            }
            else
            {
            }
        }

        private void newGameButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Switcher.Switch(new Gameplay());
		}

		private void loadGameButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Switcher.Switch(new LoadGame());
		}

		private void optionButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Switcher.Switch(new Option());
		}

        //private void ShowMessageBox(string title, string message, MessageBoxIcon icon)
        //{
            //MessageBoxChildWindow messageWindow =
            //    new MessageBoxChildWindow(title, message, MessageBoxButtons.Ok, icon);

            //messageWindow.Show();
        //}

        #region Event For Child Window
        private void loginWindowForm_SubmitClicked(object sender, EventArgs e)
        {
            //ShowMessageBox("Login Successful", "Welcome, " + loginForm.NameText, MessageBoxIcon.Information);

        }

        private void registerForm_SubmitClicked(object sender, EventArgs e)
        {
        }


        #endregion

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void loginTextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Switcher.Switch(new Login());
        }

        private void registerTextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Switcher.Switch(new Register());
        }
        #endregion
		
	}
}