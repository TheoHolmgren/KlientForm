using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace KlientForm
{
    public partial class Form1 : Form
    {
        TcpClient klient; //Sköter kommunikationen till servern
        int port = 12345; // Bestämmer porten

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSägHej_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(tbxIPAdress.Text); //Läser in IP-adressen från text-boxen
            klient = new TcpClient(); //Här skapas objektet klient
            klient.NoDelay = true; //Säger åt klienten att den inte ska ha någon fördröjning
            klient.Connect(adress, port); //Ansluter till den bestämda IP-adressen och porten

            if(klient.Connected) //Om klienten är ansluten till den bestämda IP-adressen och porten...
            {
                byte[] utData = Encoding.Unicode.GetBytes("Hej!"); //Omvandlar strängen "Hej!" till binär kod
                klient.GetStream().Write(utData, 0, utData.Length); //Skickar iväg den binära koden till servern
                klient.Close(); //Stänger klienten
            }

        }
    }
}
