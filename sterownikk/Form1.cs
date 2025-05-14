using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using Newtonsoft.Json.Linq;
using Opc.UaFx.Client;
using System.Globalization;
using System.Net.Sockets;

namespace sterownikk
{
    public partial class Form1 : Form
    {
        public SeriesCollection SeriesCollection { get; set; }

        private OpcClient opcClient;
        private OpcClientState opcClientState;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title="Nowy wykres",
                    Values = new ChartValues<double>()
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Oœ X"
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Oœ Y",
                LabelFormatter = value => value + "oC"
            });

            void AddToChart(double value)
            {
                SeriesCollection[0].Values.Add(value);
                cartesianChart1.Series = SeriesCollection;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcUrl = textBox1.Text;

            opcClient = new OpcClient(opcUrl);
            opcClientState = new OpcClientState();

            opcClientState = opcClient.State;
            if (opcClientState == OpcClientState.Created)
            {
                opcClient.Connect();
            }

            opcClientState = opcClient.State;
            if (opcClientState == OpcClientState.Connected)
            {
                pictureBox1.BackColor = Color.LimeGreen;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opcClient != null)
            {
                opcClient.Disconnect();
            }

            opcClientState = opcClient.State;

            if (opcClientState == OpcClientState.Connected)
            {
                pictureBox1.BackColor = Color.LimeGreen;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tagName = textBox2.Text;

            opcClientState = opcClient.State;

            if (opcClientState == OpcClientState.Connected && opcClient != null)
            {
                var temperature = opcClient.ReadNode(tagName);
                textBox3.Text = temperature.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (opcClient != null && opcClient.State == OpcClientState.Connected)
            {
                var tagName = textBox2.Text;

                OpcSubscription opcSubscription = opcClient.SubscribeNodes();
                var item = new OpcMonitoredItem(tagName, Opc.UaFx.OpcAttribute.Value);
                item.DataChangeReceived += Item_DataChangeReceived;
                item.SamplingInterval = 200;

                opcSubscription.AddMonitoredItem(item);
                opcSubscription.ApplyChanges();
            }
            else
            {
                MessageBox.Show("Brak po³¹czenia z serwerem OPC UA", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Item_DataChangeReceived(object sender, OpcDataChangeReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Item_DataChangeReceived(sender, e)));
                return;
            }

            double value;
            if (double.TryParse(e.Item.Value.ToString(), out value))
            {
                textBox3.Text = value.ToString("0.##");

                SeriesCollection[0].Values.Add(value);
                cartesianChart1.Series = SeriesCollection;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            opcClientState = opcClient.State;
            var tagName = textBox2.Text;

            if (opcClientState == OpcClientState.Connected)
            {
                float saveValue = (float)Convert.ToDecimal(textBox4.Text, CultureInfo.GetCultureInfo("en-US"));
                var Status = opcClient.WriteNode(tagName, saveValue);
            }
        }
    }
}
