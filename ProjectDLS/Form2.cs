using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectDLS
{
    public partial class Form2 : Form
    {
        public string connectionsString = "Server=DESKTOP-FB9EHDC;Database=pj1;Trusted_Connection=True;";//String Connection

        DataBaseCall dataBase = new DataBaseCall();

        public Form2()
        {
            InitializeComponent();
            StaffAd.Hide();
            Reporte.Hide();
            Reports.Hide();
        }

        public string currentType { get; set; }

        //Current user is Admin? Yes: Then it is going to get more accessibility to more different tools, otherwise it will not.

        private void OpenPasienteForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nextfrom = new Form3();
            nextfrom.Show();
        }

        private void GoStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nextfrom = new Form4();
            nextfrom.Show();
        }

        private void StaffAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nextfrom = new Form5();
            nextfrom.Show();
        }
        private void Reporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            from6 nextfrom = new from6();
            nextfrom.Show();

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 nextfrom = new Form7();
            nextfrom.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (Class1.name == "Admin")//it's not admin.
            {

                Console.WriteLine("Access As " + Class1.name);
                StaffAd.Show();
                Reporte.Show();
                Reports.Show();


                hello.Text = "Bienvenido " + dataBase.DataFill("SELECT Nombre FROM Adimn WHERE id = " + Class1.trakerName);
                return;
                
            }

            hello.Text = "Acceso Como" + dataBase.DataFill("SELECT DocNombre FROM DocDentist WHERE id=" + Class1.trakerName);
          
           }

        private void ApplicationClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nextfrom = new Form1();
            nextfrom.Show();

        }


    }
    }
