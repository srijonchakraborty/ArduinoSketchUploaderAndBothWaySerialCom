/*
|-------------------------------------------------------------------------------|
|	This code was written by Srijon Chakraborty								    |
|	Main source code link on https://github.com/srijonchakro			        |
|	All my source codes are available on http://srijon.softallybd.com           |
|	C# Arduino Code Uploader		                                            |
|	LinkedIn https://bd.linkedin.com/in/srijon-chakraborty-0ab7aba7				|
|-------------------------------------------------------------------------------|
*/

using ArduinoUploader;
using ArduinoUploader.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace TestApp
{
    #region Form1 :class
    public partial class Form1 : Form,IDisposable
    {
        #region Properties
        
        #region ComPort : SerialPort
        private SerialPort _ComPort;
        public SerialPort ComPort
        {
            get { return _ComPort; }
            set { _ComPort = value; }
        }
        #endregion

        #region BaudRates : List<int>
        private List<int> _baudRates;

        public List<int> BaudRates
        {
            get { return _baudRates; }
            set { _baudRates = value; }
        }
        #endregion

        #region SelectedBaudRate : int
        private int _selectedBaudRate;
        public int SelectedBaudRate
        {
            get { return _selectedBaudRate; }
            set { _selectedBaudRate = value; }
        }
        #endregion

        #region PortNames : List<string>
        private List<string> _portNames;

        public List<string> PortNames
        {
            get { return _portNames; }
            set { _portNames = value; }
        }
        #endregion

        #region SelectedPortName : string
        private string _selectedPortName;
        public string SelectedPortName
        {
            get { return _selectedPortName; }
            set { _selectedPortName = value; }
        }
        #endregion

        #region Property ArduinoModelItems: Dictionary<ArduinoModel, string>

        private Dictionary<ArduinoModel, string> _ArduinoModelItems;
        public Dictionary<ArduinoModel, string> ArduinoModelItems
        {
            get
            {
                return _ArduinoModelItems;
            }
        }
        #endregion

        #region SelectedArduinoModel : ArduinoModel
        private ArduinoModel? _selectedArduinoModel;
        public ArduinoModel? SelectedArduinoModel
        {
            get { return _selectedArduinoModel; }
            set { _selectedArduinoModel = value; }
        }
        #endregion

        #endregion

        #region ctor
        public Form1()
        {
            InitializeComponent();
            SelectedArduinoModel = null;
            ComPort = new SerialPort();
            loadAllAvailablePorts();
            loadAllArduinoModel();
            loadAllArduinoBaudRates();
        }
        #endregion

        #region Private Methods
        void loadAllAvailablePorts()
        {
            try
            {
                PortNames = System.IO.Ports.SerialPort.GetPortNames()?.ToList();
                cmbxPort.DataSource = PortNames;
                if(PortNames!=null && PortNames.Count > 0)
                {
                    cmbxPort.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void loadAllArduinoModel()
        {

            try
            {
                _ArduinoModelItems = new Dictionary<ArduinoModel, string>();
                foreach (ArduinoModel value in Enum.GetValues(typeof(ArduinoModel)))
                {
                    _ArduinoModelItems.Add(value, value.ToString());
                }
                comBxArduino.DataSource = new BindingSource(ArduinoModelItems, null);
                comBxArduino.DisplayMember = "Key";
                comBxArduino.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void loadAllArduinoBaudRates()
        {
            BaudRates = new List<int>();
            BaudRates.Add(300);
            BaudRates.Add(600);
            BaudRates.Add(1200);
            BaudRates.Add(2400);
            BaudRates.Add(4800);
            BaudRates.Add(9600);
            BaudRates.Add(14400);
            BaudRates.Add(19200);
            BaudRates.Add(28800);
            BaudRates.Add(38400);
            BaudRates.Add(57600);
            BaudRates.Add(115200);

            comBoxBaudRate.DataSource = BaudRates;
            if (BaudRates != null && BaudRates.Count > 0)
            {
                comBoxBaudRate.SelectedIndex = 5;
            }
        }
        void doUpDate(object sender, EventArgs e)
        {
            try
            {
                var received = _ComPort?.ReadLine();
                richTextBoxData.Text = richTextBoxData.Text + received;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Private Callback

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "hex",
                    Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxFilePath.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClearPath_Click(object sender, EventArgs e)
        {
            textBoxFilePath.Text = string.Empty;
        }
        private void burnCodeOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ComPort != null && _ComPort.IsOpen)
                {
                    MessageBox.Show("Please disconnect first from arduino.");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxFilePath.Text) || string.IsNullOrWhiteSpace(SelectedPortName))
                {
                    MessageBox.Show("Please Select File Path.");
                    return;
                }
                if (SelectedArduinoModel == null)
                {
                    MessageBox.Show("Please Select an Arduino Model.");
                    return;
                }
                if (string.IsNullOrEmpty(SelectedPortName) || string.IsNullOrWhiteSpace(SelectedPortName))
                {
                    MessageBox.Show("Please Select a Port Name.");
                    return;
                }

                var uploader = new ArduinoSketchUploader(
                    new ArduinoSketchUploaderOptions()
                    {
                        FileName = @"" + textBoxFilePath.Text,
                        PortName = SelectedPortName,
                        ArduinoModel = SelectedArduinoModel.Value
                    });

                uploader.UploadSketch();
                MessageBox.Show("Code Upload Completed.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                int selectedIndex = cmb.SelectedIndex;
                var selectedValue = cmb.SelectedValue;
                dynamic selectedPort = cmb.SelectedItem;
                SelectedPortName = (string)selectedPort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comBxArduino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                dynamic selectedArduino = cmb.SelectedItem;
                SelectedArduinoModel = selectedArduino.Key;
                //int selectedIndex = cmb.SelectedIndex;
                //var selectedValue = cmb.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                int selectedIndex = cmb.SelectedIndex;
                var selectedValue = cmb.SelectedValue;
                dynamic selectedPort = cmb.SelectedItem;
                SelectedBaudRate = (int)selectedPort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnConnectToRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedPortName) || string.IsNullOrWhiteSpace(SelectedPortName))
            {
                MessageBox.Show("Please Select a Port Name.");
                return;
            }
            if (SelectedBaudRate<=0)
            {
                MessageBox.Show("Please Select a Baud Rate.");
                return;
            }
            _ComPort.DtrEnable = true;
            _ComPort.RtsEnable = true;
            _ComPort.PortName = SelectedPortName;
            _ComPort.BaudRate = SelectedBaudRate;
            //_ComPort.DS
            _ComPort.DataReceived += dataReceived_Completed;
            try
            {
                if (!_ComPort.IsOpen)
                {
                    _ComPort.Open();
                    richTextBoxData.Text = richTextBoxData.Text + "\nConnected.";
                }
                else
                {
                    MessageBox.Show("Port is already open.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataReceived_Completed(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new EventHandler(doUpDate));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ComPort != null && _ComPort.IsOpen)
                {
                    _ComPort.Close();
                    richTextBoxData.Text = richTextBoxData.Text + "\nDisconnected.";
                }
                else
                {
                    MessageBox.Show("Port is already closed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSendDataToArduino_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxSendData.Text)|| string.IsNullOrWhiteSpace(txtBoxSendData.Text))
            {
                MessageBox.Show("Please type something to send.");
                return;
            }
            if (_ComPort != null && _ComPort.IsOpen)
            {
                _ComPort.WriteLine(txtBoxSendData.Text);
            }
            else
            {
                MessageBox.Show("Please connect first with arduino.");
            }
        }

        #endregion

        #region Public Method
        public new void Dispose()
        {
            base.Dispose();
            try
            {
                if (_ComPort != null && _ComPort.IsOpen)
                {
                    _ComPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    } 
    #endregion
}
