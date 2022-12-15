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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            consulsGrid.ReadOnly = true;
            ReportoLogs.ReadOnly = true;
            DataPatients.ReadOnly = true;
            Employers.ReadOnly = true;
        }
        public string connectionsString = "Server=DESKTOP-FB9EHDC;Database=pj1;Trusted_Connection=True;";//String Connection


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nextfrom = new Form2();
            nextfrom.Show();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // FILL ALL TABLES//
            SqlConnection conn = new SqlConnection(connectionsString);
            conn.Open();
            try { 
                SqlCommand cmd = new SqlCommand("Select * FROM DocDentist", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);////DataAdapter will acts as a Bridge between DataSet and database.
                DataSet ds = new DataSet();
                sda.Fill(ds, "DocDentist");
                Console.WriteLine(ds);
                Employers.DataSource = ds.Tables[0];//Get the collection of fable in the DateSet

                SqlCommand cmd2 = new SqlCommand("Select * FROM Paciente", conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);////DataAdapter will acts as a Bridge between DataSet and database.
                DataSet ds2 = new DataSet();
                sda2.Fill(ds2, "Paciente");
                Console.WriteLine(ds2);
                DataPatients.DataSource = ds2.Tables[0];//Get the collection of fable in the DateSet

                SqlCommand cmd3 = new SqlCommand("Select * FROM Logs", conn);
                SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);////DataAdapter will acts as a Bridge between DataSet and database.
                DataSet ds3 = new DataSet();
                sda3.Fill(ds3, "Logs");
                Console.WriteLine(ds3);
                ReportoLogs.DataSource = ds3.Tables[0];//Get the collection of fable in the DateSet



                SqlCommand cmd4 = new SqlCommand("Select * FROM Consultas", conn);
                SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);////DataAdapter will acts as a Bridge between DataSet and database.
                DataSet ds4 = new DataSet();
                sda4.Fill(ds4, "Consultas");
                Console.WriteLine(ds4);
                consulsGrid.DataSource = ds4.Tables[0];//Get the collection of fable in the DateSet



            }
            catch (Exception typeErr)
            {
                MessageBox.Show("An Error in the Process  Fill Tables: Error 76 Type: " + typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            conn.Close();
        }
    }
}
