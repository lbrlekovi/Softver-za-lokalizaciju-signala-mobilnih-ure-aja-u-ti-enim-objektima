using DBLayer;
using Softver_za_lokalizaciju_signala.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softver_za_lokalizaciju_signala.Models;

namespace Softver_za_lokalizaciju_signala
{
    public partial class FrmMap : Form
    {
        public FrmMap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        class Node
        {
            public int brSobe;
            public int brMobitela;
            public Node next;
            public Node(int x)
            {
                brSobe = x;
                brMobitela = 0;
                next = null;
            }
        };
        class LinkedList
        {
            public Node head;
            public LinkedList()
            {
                head = new Node(0);
            }
            public int FindBr(int x)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                    if (temp.brSobe == x)
                    {
                        return temp.brMobitela;
                    }
                }
                return 0;
            }
            public void Add(int x)
            {
                Node temp = head;
                Node novi = new Node(x);
                while (temp.next != null) temp = temp.next;
                temp.next = novi;
            }
            public void Increment(int x)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                    if (temp.brSobe == x)
                    {
                        temp.brMobitela++;
                        return;
                    }
                }
                Add(x);
                return;
            }
        };

        private void FrmMap_Load(object sender, EventArgs e)
        {
            ShowMobileDevices();
        }
        private void ShowMobileDevices()
        {
            //dodaj način da se prepozna ako ima više mobitela na istom mjestu, npr. s listom zauzetosti soba
            var mobileDevices = MobileDeviceRepository.GetMobileDevices();
            List<Button> buttonMobileDevice = new List<Button>();
            LinkedList zauzetostSoba = new LinkedList();
            for (int i = 0; i < mobileDevices.Count; i++)
            {
                Location location = LocationRepository.GetLocation(mobileDevices[i].Lokacija);
                zauzetostSoba.Increment(location.Id);
                Button newButton = new Button();
                newButton.Size = new Size(22, 22);
                newButton.Text = "";
                newButton.Name = (i+1).ToString();
                newButton.Location = new Point(location.LokacijaX + (zauzetostSoba.FindBr(location.Id)*20), location.LokacijaY);
                newButton.BackColor = Color.LimeGreen;
                newButton.BringToFront();
                Controls.Add(newButton);
                buttonMobileDevice.Add(newButton);
                picMap.Controls.Add(newButton);
                newButton.Click += (s, e) =>
                {
                    MobileDevice mobileDevice = MobileDeviceRepository.GetMobileDevice(Int32.Parse(newButton.Name));
                    Person person = PersonRepository.GetPerson(mobileDevice.Vlasnik);
                    valIdMobileDevice.Text = mobileDevice.Id.ToString();
                    valIdMobileDevice.Visible = true;
                    valVlasnik.Text = person.Ime.TrimEnd() + " " + person.Prezime.TrimEnd();
                    valVlasnik.Visible = true;
                    valBrojPrekrsaja.Text = person.BrojPrekrsaja.ToString();
                    valBrojPrekrsaja.Visible = true;
                    if (person.Uloga == 2) valUloga.Text = "zaštitar";
                    if (person.Uloga == 1) valUloga.Text = "voditelj štićenog objekta";
                    valUloga.Visible = true;
                    if (mobileDevice.Dozvoljen)
                    {
                        valDozvoljen.Text = "Da";
                    } else
                    {
                        valDozvoljen.Text = "Ne";
                    }
                    valDozvoljen.Visible = true;
                };
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
            Close();
        }
    }
}
