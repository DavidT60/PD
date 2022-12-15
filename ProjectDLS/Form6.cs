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
    public partial class from6 : Form
    {

        int dataIdToAction; // Get the id of the user actually seleted
        string fromdata;
        DataBaseCall database = new DataBaseCall();

        public from6()
        {
            InitializeComponent();
            ActivePatient.Hide();
            reportesPatient.ReadOnly = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nextfrom = new Form2();
            nextfrom.Show();
        }

        private void from6_Load(object sender, EventArgs e)
        {

            Initial();
            reportesPatient.ReadOnly = true;
            ReporInactiveEmployer.ReadOnly = true;
        }



        private void Initial()
        {
            database.GridFill(reportesPatient, "Select * FROM Paciente WHERE  StatusAC = 'Desactive'", "Paciente");
            database.GridFill(ReporInactiveEmployer, "Select * FROM DocDentist WHERE  StatusAC = 'Desactive'", "DocDentist");

        }



        private void ActivePatient_Click(object sender, EventArgs e)
        {
            if (fromdata == "reportesPatient") {
                    //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
                    try
                    {
                        string saveDate = "UPDATE Paciente SET StatusAC = 'Active' WHERE id = " + dataIdToAction;
                        database.SetUpdate(saveDate);

                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("⚠️ FOUND ON" + err);
                        MessageBox.Show("An Error in the Process Insert Data: Error 96 Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
             ActivePatient.Hide();
             Initial();
         }




            if (fromdata == "ReporInactiveEmployer"){
 
                    //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
                    try{

                        string saveDate = "UPDATE DocDentist SET StatusAC = 'Active' WHERE id = " + dataIdToAction;
                        database.SetUpdate(saveDate);

                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("⚠️ FOUND ON" + err);
                        MessageBox.Show("An Error in the Process Insert Data: Error 96 Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    ActivePatient.Hide();
                    Initial();   
             }
        }



        private void reportesPatient_Click(object sender, EventArgs e)
        {
            ActivePatient.Hide();

            if (reportesPatient.SelectedRows.Count >= 2) {
                ActivePatient.Hide();
                return; 
            }
            foreach (DataGridViewRow row in reportesPatient.SelectedRows)
            {
              if(row.Cells[0].Value.ToString() == "") { return;  }
                dataIdToAction = int.Parse(row.Cells[0].Value.ToString());
                fromdata = reportesPatient.Name;
                Console.WriteLine(fromdata);
               
            }
            ActivePatient.Show();

        }

        private void ReporInactiveEmployer_Click(object sender, EventArgs e)
        {
            ActivePatient.Hide();

            if (reportesPatient.SelectedRows.Count >= 2)
            {   ActivePatient.Hide();
                 return; 
            }
            foreach (DataGridViewRow row in ReporInactiveEmployer.SelectedRows)
            {
                if (row.Cells[0].Value.ToString() == "") { return; }
                dataIdToAction = int.Parse(row.Cells[0].Value.ToString());
                fromdata = ReporInactiveEmployer.Name;
                Console.WriteLine(fromdata);

            }
            ActivePatient.Show();

        }
    }
}
