using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HMIkelompok9
{
    public partial class Form1 : Form
    {
        String jam = "00";
        String menit = "00";
        String detik = "00";
        String hari = "1";
        String tanggal = "1";
        String bulan = "1";
        String tahun = "2000";
        String editjam = "00";
        String editmenit = "00";
        String editdetik = "00";
        String edithari = "1";
        String edittanggal = "1";
        String editbulan = "1";
        String edittahun = "2000";
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        String rcvData;
        String[] parseData;

        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            disableEdit();
            showDisplayClock(jam, menit, detik);
            showDisplayDate(hari, tanggal, bulan, tahun);

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            button1.Text = "Disconnect";
            port.DataReceived += Port_DataReceived;
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            button1.Text = "Connect";
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rcvData = port.ReadLine();
            this.Invoke(new EventHandler(ShowReadData));
        }

        private void ShowReadData(object sender, EventArgs e)
        {
            parseData = rcvData.Split(':');
            detik = parseData[0];
            menit = parseData[1];
            jam = parseData[2];
            hari = parseData[3];
            tanggal = parseData[4];
            bulan = parseData[5];
            tahun = parseData[6];
            showDisplayClock(jam, menit, detik);
            showDisplayDate(hari, tanggal, bulan, tahun);
        }

        private void dispClock_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            enableEdit();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            editdetik = editDetik.GetItemText(editDetik.SelectedItem);
            editmenit = editMenit.GetItemText(editMenit.SelectedItem);
            editjam = editJam.GetItemText(editJam.SelectedItem);
            String tempday = editHari.GetItemText(editHari.SelectedItem);
            if (tempday == "Monday")
            {
                edithari = "01";
            }
            else if (tempday == "Tuesday")
            {
                edithari = "02";
            }
            else if (tempday == "Wednesday")
            {
                edithari = "03";
            }
            else if (tempday == "Thursday")
            {
                edithari = "04";
            }
            else if (tempday == "Friday")
            {
                edithari = "05";
            }
            else if (tempday == "Saturday")
            {
                edithari = "06";
            }
            else
            {
                edithari = "07";
            }
            edittanggal = editTgl.GetItemText(editTgl.SelectedItem);
            if (edittanggal.Length < 2)
            {
                edittanggal = "0" + edittanggal;
            }
            String tempmonth = editBln.GetItemText(editBln.SelectedItem);
            if (tempmonth == "January")
            {
                editbulan = "01";
            }
            else if (tempmonth == "February")
            {
                editbulan = "02";
            }
            else if (tempmonth == "March")
            {
                editbulan = "03";
            }
            else if (tempmonth == "April")
            {
                editbulan = "04";
            }
            else if (tempmonth == "May")
            {
                editbulan = "05";
            }
            else if (tempmonth == "June")
            {
                editbulan = "06";
            }
            else if (tempmonth == "July")
            {
                editbulan = "07";
            }
            else if (tempmonth == "August")
            {
                editbulan = "08";
            }
            else if (tempmonth == "September")
            {
                editbulan = "09";
            }
            else if (tempmonth == "October")
            {
                editbulan = "10";
            }
            else if (tempmonth == "November")
            {
                editbulan = "11";
            }
            else
            {
                editbulan = "12";
            }
            edittahun= editTahun.Text;
            port.Write("#TRAN" + editdetik + editmenit + editjam + edithari + edittanggal + editbulan + edittahun + "\n"); ;
            disableEdit();
        }

        private void editJam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editMenit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
               
        private void editHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editTgl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editBln_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editTahun_TextChanged(object sender, EventArgs e)
        {

        }

        private void showDisplayClock(String jam, String menit, String detik)
        {
            this.dispClock.Text = jam + ":" + menit + ":" + detik;
        }

        private void showDisplayDate(String hari, String tgl, String bln, String thn)
        {
            if (hari == "1")
            {
                this.dispDay.Text = "Monday";
            }
            else if (hari == "2")
            {
                this.dispDay.Text = "Tuesday";
            }
            else if (hari == "3")
            {
                this.dispDay.Text = "Wednesday";
            }
            else if (hari == "4")
            {
                this.dispDay.Text = "Thursday";
            }
            else if (hari == "5")
            {
                this.dispDay.Text = "Friday";
            }
            else if (hari == "6")
            {
                this.dispDay.Text = "Saturday";
            }
            else
            {
                this.dispDay.Text = "Sunday";
            }
            String bulan;
            if (bln == "1")
            {
                bulan = "January";
            }
            else if (bln == "2")
            {
                bulan = "February";
            }
            else if (bln == "3")
            {
                bulan = "March";
            }
            else if (bln == "4")
            {
                bulan = "April";
            }
            else if (bln == "5")
            {
                bulan = "May";
            }
            else if (bln == "6")
            {
                bulan = "June";
            }
            else if (bln == "7")
            {
                bulan = "July";
            }
            else if (bln == "8")
            {
                bulan = "August";
            }
            else if (bln == "9")
            {
                bulan = "September";
            }
            else if (bln == "10")
            {
                bulan = "October";
            }
            else if (bln == "11")
            {
                bulan = "November";
            }
            else
            {
                bulan = "December";
            }
            this.dispDate.Text = tgl + " " + bulan + " " + thn;
        }

        private void disableEdit()
        {
            editJam.Enabled = false;
            editMenit.Enabled = false;
            editDetik.Enabled = false;
            editHari.Enabled = false;
            editTgl.Enabled = false;
            editBln.Enabled = false;
            editTahun.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void enableEdit()
        {
            editJam.Enabled = true;
            editMenit.Enabled = true;
            editDetik.Enabled = true;
            editHari.Enabled = true;
            editTgl.Enabled = true;
            editBln.Enabled = true;
            editTahun.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editDetik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
