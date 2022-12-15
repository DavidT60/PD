using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
//using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Data.SqlClient;


namespace ProjectDLS
{
    public partial class Form3 : Form
    {

        DataBaseCall dataBase = new DataBaseCall();
        GlobalVariables varGlo = new GlobalVariables();

        public string connectionsString = "Server=DESKTOP-FB9EHDC;Database=pj1;Trusted_Connection=True;";//String Connection
        string getDataId;//Filter Id Patient..//
        string idPatient ="NULL";// Get the Key Id

        //Data DOC //
        public string DocId;
        public  string PatientsEmail = "davidceballo11@gmail.com";//This Will Send an Email


        // this get Current Date //
        public string Date = DateTime.Now.ToString("yyyy-MM-dd");// egt the current TIme




        public Form3()
        {
            InitializeComponent();
            ShowCompletedData.Hide();
            PanelPasient.Hide();
            panelToAdd.Hide();
            AllComplted.Hide();
            this.keySexComboBox.DropDownStyle = ComboBoxStyle.DropDownList; //Fix the combox, so is nor possible write in it.
            SaveDatas.Hide();
            EditByDoc.Hide();

            NameP.ReadOnly = true;
            LastNameP.ReadOnly = true; 
            EdadP.ReadOnly = true; 
            enailP.ReadOnly = true;
            GteGridDatesUser.ReadOnly = true;

            currentConsults();

            if (Class1.name != "Admin")
            {
                InputID.ReadOnly = true;
                InputID.Text = Class1.trakID;
            }
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nextfrom = new Form2();
            nextfrom.Show();
        }



        private void SendEmal_Click(object sender, EventArgs e)
        {

            Email senserClass = new Email();

            if (ImputName.Text != "" & ImputLastname.Text != "" & InputID.Text != "" & ComboBoxTratamient.Text != "")
            {

                string patienteEmail = dataBase.textFiller("EmailPaciente", "SELECT EmailPaciente FROM Paciente WHERE id = " + idPatient);// if the email is invalid then just we get alert  > posd: ALL EMAIL ARE FAKE USER JUST ONE IS REA
                string textContainer = "SOME TEXT AS MESSAGE";



               //DocId   
              string comboxBox = ComboBoxTratamient.Text.ToString();
              string IdDocData = "NULL";
              string IdTratamient = "NULL";
              
                //USERS's EMAILS//
              string DocEMail = "";// Into the email Patient has to by the rmail doc
                try {

                    IdDocData = dataBase.DataFillInit("SELECT id FROM " + "DocDentist" + " WHERE " + "DocId" + "= " + "'" + DocId + "'").ToString();
                    DocEMail =  dataBase.DataFill("SELECT DocEmail FROM " + "DocDentist" + " WHERE " + "DocId" + "= " + "'" + DocId + "'").ToString();
                    IdTratamient = dataBase.DataFillInit("SELECT id FROM " + "Tratamientos" + " WHERE " + "tratamientoTipo" + "= " + "'" + ComboBoxTratamient.Text.ToString() + "'").ToString();

                    Console.WriteLine(dataBase.DataFillInit("SELECT id FROM " + "DocDentist" + " WHERE " + "DocId" + "= " + "'" + DocId + "'").ToString());
                    Console.WriteLine(dataBase.DataFillInit("SELECT id FROM " + "Tratamientos" + " WHERE " + "tratamientoTipo" + "= " + "'" + ComboBoxTratamient.Text.ToString() + "'").ToString());

                }
                catch (Exception errType){
                 MessageBox.Show("Error, 84 line  :" + errType,
                 "NOT COMPLETDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                senserClass.EmailSender(IdDocData, IdTratamient, DocId, comboxBox, textContainer, patienteEmail, dateTimePicker1Date.Value.ToString(), idPatient, getDataId, richTextBox1.ToString());

                ImputLastname.Text = "";
                InputID.Text = "";
                ImputName.Text = "";
                ComboBoxTratamient.Text = "";
                PaientID.Text = "";
                MessageBox.Show("Enviamos un Email de la Consulta ","Accion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
;

            }


            else
            {
                MessageBox.Show("Es importante que Completes todo los Inputs Para Notificar la Consulta ", "NOT COMPLETDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             
            }
            LoadConsults(idPatient);

            // CLEAR INPUTS //
            ImputName.Clear();
            ImputLastname.Clear();
            InputID.Clear();
            ComboBoxTratamient.Text = "";
            if (Class1.name != "Admin")
            {
                PaientID.Clear();
            }

            PanelPasient.Hide();
            richTextBox1.Clear();

        }

         /// <summary>
        /// ADD PATIENTS SECTION
        /// </summary>

        private void NextConfirmation_Click(object sender, EventArgs e)
        {
            panelToAdd.Show();

        }


        //Crear Input Data//
        private void Db1_Click(object sender, EventArgs e)
        {
            ClearINputs();  
        }


        private void AllComplted_Click(object sender, EventArgs e)
        {
            ClearINputs();
        }

        private void ClearINputs()
        {

            KeyName.Clear();
            KeyLastName.Clear();
            KeyEmail.Clear();
            KeyContact.Clear();
            KeyAge.Clear();
            keyDirecction.Clear();
            keySexComboBox.Text = "";
            ShowCompletedData.Hide();
            AllComplted.Hide();

        }



        private void Loader()
        {

            // TextFill //
            ShowCompletedData.Show();
            AllComplted.Show();

            Dataname.Text = dataBase.textFiller("NombrePaciente", "SELECT * FROM Paciente WHERE StatusAC = 'Active'");
            DatalastName.Text = dataBase.textFiller("ApellidoPaciente", "SELECT * FROM Paciente WHERE StatusAC = 'Active'");
            DataId.Text = dataBase.textFiller("PacienteID", "SELECT * FROM Paciente WHERE StatusAC = 'Active'");

        }








        private void AddPatient_Click(object sender, EventArgs e)
        {


            // INSERTING PROCEDURES
            AddPatient.Hide();
            //Random Genrator
            Random randomNumber = new Random();
            int randomData = randomNumber.Next(3000);

            string PacienteNombre = KeyName.Text.Substring(0, 1).ToString().ToUpper() + KeyName.Text.Substring(1).ToString().ToLower(); //varchar Data//CamelCaseFormat NameKeyName.Text.ToString(); //varchar Data//CamelCaseFormat Name
            string PacienteApellido = KeyLastName.Text.Substring(0, 1).ToString().ToUpper() + KeyLastName.Text.Substring(1).ToString().ToLower();//varchar Data
            string PacienteSexo = keySexComboBox.Text.ToString(); //varchar Data
            int PacienteEdad = int.Parse(KeyAge.Text); //int data
            string PacienteContacto = KeyContact.Text.ToString(); //varchar Data
            string PacienteEmail = KeyEmail.Text.ToString();// varchar Data
            string DireccionPaciente = keyDirecction.Text.ToString(); //varchar Data
            string PacienteID = KeyName.Text.Substring(0, 1).ToString().ToUpper() + KeyLastName.Text.Substring(0, 1).ToString().ToUpper() + "-" + randomData.ToString();//Data int AutoGenerate// iS EQUAL TO THE FIRST LATTER OF NAME +  FIRST LATTER OF LASTNAME EJ: David Rivera id = DR-RandomNumber
            string StatusAc = "Active";

            dataBase.insertProceduresPatients(PacienteNombre, PacienteApellido, PacienteSexo, PacienteEdad, PacienteContacto, PacienteEmail, DireccionPaciente, PacienteID, StatusAc);

            Loader();
      }






        // Search Patients Sections Code //
        private void getData(string typeUp)
        {
            try
            {
                string gCommand = "SELECT * FROM Paciente WHERE PacienteID = " + "'" + getDataId + "'";
   

                   idPatient = dataBase.textFiller("id", gCommand).ToString();
                   string DataName = dataBase.textFiller("NombrePaciente", gCommand).ToString();
                   string DatLastaName = dataBase.textFiller("ApellidoPaciente", gCommand).ToString();
                   string DataEdad = dataBase.textFiller("EdadPaciente", gCommand).ToString();
                   string DataEmail = dataBase.textFiller("EmailPaciente", gCommand).ToString();
                   string contact = dataBase.textFiller("ContactoPaciente", gCommand).ToString();
                   string Sex = dataBase.textFiller("SexoPaciente", gCommand).ToString();


                   Console.WriteLine(" | " + DataName + " | " + DatLastaName + " | " + DataEdad + " | " + DataEmail);

                   if (typeUp == "ADDP"){
                            NameP.Text = DataName;
                            LastNameP.Text = DatLastaName;
                            EdadP.Text = DataEdad;
                            enailP.Text = DataEmail;

                            varGlo.typeSet[0] = "NombrePaciente";
                            varGlo.typeSet[1] = "ApellidoPaciente";
                            varGlo.typeSet[2] = "EdadPaciente";
                             varGlo.typeSet[3] = "EmailPaciente";
                        }

                   if(typeUp == "ADDC"){
                            LoadConsults(idPatient);
                            name1.Text = DataName;
                            lname2.Text = DatLastaName;
                            email6.Text = DataEmail;
                            sex4.Text =  Sex;
                            age5.Text = DataEdad;
                            email3.Text = contact;
                            PatientsEmail =DataEmail;//This Will Send an Email
                        }



                    if (DataName.ToString() == "")
                    {
                        DataIdFilter.Text = "";
                        EditByDoc.Hide();
                        MessageBox.Show("Completar Parametros ID No Encontrado", "ERROR INSERING DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

            }
            catch (Exception typeErr)
            {
                MessageBox.Show("Am Error in the Process  Fill Data: Error 270 Type: " + typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void FilterPatient_Click(object sender, EventArgs e)
        {
            EditByDoc.Show();
            if(DataIdFilter.Text.ToString() == " ")
            {
                MessageBox.Show("Completar Parametros ID", "ERROR INSERING DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Console.WriteLine("GETTING ID");
            Console.WriteLine(getDataId);
            getData("ADDP");


        }

        private void DataIdFilter_TextChanged(object sender, EventArgs e)
          {
            getDataId = DataIdFilter.Text.ToString().ToUpper();
                
          }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveDatas.Show();
            NameP.ReadOnly = false;
            LastNameP.ReadOnly = false;
            EdadP.ReadOnly = false;
            enailP.ReadOnly = false;

        }



      async private void SaveDatas_Click(object sender, EventArgs e){
            // Comparing Data actual with the data Update, using Array //
            varGlo.typeOfdataTexBox[0] = NameP.Text.ToString();
            varGlo.typeOfdataTexBox[1] = LastNameP.Text.ToString();
            varGlo.typeOfdataTexBox[2] = EdadP.Text.ToString();
            varGlo.typeOfdataTexBox[3] = enailP.Text.ToString();

            SaveDatas.Hide();


            for (int counter = 0; counter < varGlo.typeOfdata.Length; counter++)
            {
                if (varGlo.typeOfdata[counter] != varGlo.typeOfdataTexBox[counter]){
                    Console.WriteLine("===============DATA BASE EXECUTION=====================");
                    //..Method Set update..//

                    if (varGlo.typeSet[counter] == "EdadPaciente"){
                        // set Id Update
                       dataBase.SetUpdate("UPDATE Paciente SET " + varGlo.typeSet[counter] + "= " + varGlo.typeOfdataTexBox[counter] + " WHERE id = " + idPatient, counter);
                    }

                    else{
                        Console.WriteLine("UPDATE Paciente SET " + varGlo.typeSet[counter] + "= " + "'" + varGlo.typeOfdataTexBox[counter] + "'" + " WHERE id = " + idPatient);
                        dataBase.SetUpdate("UPDATE Paciente SET " + varGlo.typeSet[counter] + "= " + "'" + varGlo.typeOfdataTexBox[counter] + "'" + " WHERE id = " + idPatient, counter);
                    }

                }
            }


            //unedit Input Just Read//
            NameP.ReadOnly = true;
            LastNameP.ReadOnly = true;
            EdadP.ReadOnly = true;
            enailP.ReadOnly = true;

            getData("ADDP");

        }




        //BUtton Close Pannel Edit Usar//
        private void button2_Click(object sender, EventArgs e)
        {
            DataIdFilter.Text = "";
            FilterPatient.Hide();
            EditByDoc.Hide();
        }

        // ADD CONSULT SECTION CODE//

        private void FinderPasint_Click(object sender, EventArgs e)
        {
            if (ImputName.Text != "" & ImputLastname.Text != "" & InputID.Text != "" & ComboBoxTratamient.Text != "")
            {
                PanelPasient.Show();

                ImputName.Text.ToString();
                ImputLastname.Text.ToString();
                InputID.Text.ToString();
                ComboBoxTratamient.Text.ToString();

                getData("ADDC");
            }
            else
                {
                    MessageBox.Show("Es importante que Completes todo los Inputs Para Notificar la Consulta ", "NOT COMPLETDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

            }

        private void PaientID_TextChanged(object sender, EventArgs e)
        {
            getDataId = PaientID.Text.ToString().ToUpper();

        }


        private void InputID_TextChanged(object sender, EventArgs e)
        {

            DocId = InputID.Text.ToString().ToUpper();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            ImputLastname.Text = "";
            InputID.Text = "";
            ImputName.Text = "";
            ComboBoxTratamient.Text = "";
            PaientID.Text = "";
        }

        private void ClosePp_Click(object sender, EventArgs e)
        {
            PanelPasient.Hide();
        }

        
        


        private void LoadConsults(string PatientId){

            try
            {
                dataBase.GridFill(GteGridDatesUser, "SELECT fecha, ConsultaId  FROM Consultas WHERE fecha  >= " + "'" + Date + "'" + " AND PacienteId =" + PatientId, "Consultas");
                dataBase.GridFill(CurrentConsults, "SELECT * FROM Consultas WHERE fecha = " + "'" + Date + "'", "Consultas");

            }
            catch (Exception typeErr)
            {
                MessageBox.Show("An Error in the Process  Fill Tables: Error 656: Type: " + typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }






        private void currentConsults()
        {

            try
            { 

                dataBase.GridFill(CurrentConsults, "SELECT * FROM Consultas WHERE fecha = " + "'" + Date + "'", "Consultas");
            }
            catch (Exception typeErr)
            {
                MessageBox.Show("An Error in the Process  Fill Tables: Error 786: Type: " + typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void LoadAgan_Click(object sender, EventArgs e)
        {
            currentConsults();
        }
    }

}
