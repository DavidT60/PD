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
    public partial class Form5 : Form
    {
        public string connectionsString = "Server=DESKTOP-FB9EHDC;Database=pj1;Trusted_Connection=True;";//String Connection
        string currentUserId;// Get the id of the user in the dataGrid Seleted
        DataBaseCall dataBade = new DataBaseCall();

        public Form5()
        {
            InitializeComponent();
            AdderAdmin.Hide();
            Btn7.Hide(); emp6.Hide();
            this.SexType.DropDownStyle = ComboBoxStyle.DropDownList; //Fix the combox, so is nor possible write in it.
            this.Edit3C.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            SaveEditionButton.Hide();
             //Panels To Add and Remove patients and Employer
            PanelAbout.Hide();//Employers

            ActiverEdition.Hide();//Button For edit dataGrid data Is Hidden|   
            Remover.Hide();
            PanelAdd.Hide();
            RemoveAdmin.Hide();



            DataViewEmployers.ReadOnly = true;//Just Read, we can not Edit Data.
            PatientsGridview.ReadOnly = true;////Just Read, we can not Edit Data

            Edit1.ReadOnly = true;
            Edit2.ReadOnly = true;
            //Edit3C.ReadOnly = true;
            Edit4.ReadOnly = true;
            Edit5.ReadOnly = true;
            Edit6.ReadOnly = true;
            Edit7.ReadOnly = true;

            editPass1.ReadOnly = true;
            editPss2.ReadOnly = true;

        }

        private void AddAmin_Click(object sender, EventArgs e)
        {
            //AdminRemuver.Hide();
            AdderAdmin.Show();
        }



        private void BackFromStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nextfrom = new Form2();
            nextfrom.Show();
        }


        private void Initial()
        {
            try
            {
                dataBade.GridFill(DataViewEmployers, "Select * FROM DocDentist WHERE  StatusAc = " + "'Active'", "DocDentist");
                dataBade.GridFill(PatientsGridview, "Select * FROM Paciente WHERE  StatusAc = " + "'Active'", "Paciente");
            }
            catch (Exception typeErr) {
                MessageBox.Show("An Error in the Process  Fill Tables: Error 67:88 Type: " + typeErr,"ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }






        private void button7_Click(object sender, EventArgs e)
        {
            Initial();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Console.WriteLine("FILLING BOTH TABLES");
            Initial();

        }

        //Sections Actions Inserts
        //IMPORTANT ACTION, : IT SEND DATA WHEN ADD NEW Patient
        private void PatientInsert_Click(object sender, EventArgs e)
        {
            if(Nm2.Text == "" || Nm3.Text == "" || Nm4.Text == "" || Nm5.Text == "" || Nm6.Text == "" || Nm6.Text == "")
            {
                MessageBox.Show("COMPLETAR TODOS LOS PARAMETROS ANTES DE ENVIAR ⚠️", "EL USUARIO NO CUMPLE CON LOS PARAMETROS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Random Genrator
                Random randomNumber = new Random();
            int randomData = randomNumber.Next(3000);

            //:::::VALUES:::::://  
            string PacienteNombre = Nm1.Text.Substring(0, 1).ToString().ToUpper() + Nm1.Text.Substring(1).ToString().ToLower(); //varchar Data//CamelCaseFormat Name
            string PacienteApellido = Nm2.Text.Substring(0, 1).ToString().ToUpper() + Nm2.Text.Substring(1).ToString().ToLower();//varchar Data
            string PacienteSexo = comboBoxSex.Text.ToString(); //varchar Data
            int PacienteEdad = int.Parse(Nm6.Text); //int data
            string PacienteContacto = Nm4.Text.ToString(); //varchar Data
            string PacienteEmail = Nm5.Text.ToString();// varchar Data
            string DireccionPaciente = Nm3.Text.ToString(); //varchar Data
            string PacienteID = Nm1.Text.Substring(0, 1).ToString().ToUpper() + Nm2.Text.Substring(0, 1).ToString().ToUpper() + "-" + randomData.ToString();//Data int AutoGenerate// iS EQUAL TO THE FIRST LATTER OF NAME +  FIRST LATTER OF LASTNAME EJ: David Rivera id = DR-RandomNumber
            string StatusAc = "Active";
 
            string saveDate = "EXEC Insert_Patiente '" + @PacienteNombre + "','" + @PacienteApellido + "','" + @PacienteSexo + "'," + @PacienteEdad + ",'" + @PacienteContacto + "','" + @PacienteEmail + "','" + @DireccionPaciente + "','" + @PacienteID + "','" +  @StatusAc + "'";
            dataBade.useProcedures(saveDate);

                Initial();
                Nm1.Text = "";
                Nm2.Text = "";
                //employer3.Text = "";
                Nm3.Text = "";
                Nm4.Text = "";
                Nm5.Text = "";
                Nm6.Text = "";
            
        }



        //IMPORTANT ACTION, : IT SEND DATA WHEN ADD NEW EMPLOYER
        private void ActionSender_Click(object sender, EventArgs e)
        {

            //DocNombre✅, DocApellido✅, DocSexo✅, DocEdad✅, DocContacto✅, DocDentistPin✅, DocEmail✅, DireccionDoc✅, DocID
            if(employer1.Text == "" || employer2.Text == "" || SexType.Text == "" || employer4.Text == "" || employer5.Text == "" || employer6.Text == "" || employer6.Text == "")
            {
                MessageBox.Show("COMPLETAR TODOS LOS PARAMETROS ANTES DE ENVIAR ⚠️", "EL USUARIO NO CUMPLE CON LOS PARAMETROS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Random Genrator
            Random randomNumber = new Random();
            int randomData = randomNumber.Next(2000);

            //:::::VALUES:::::://  
            string DocNombre = employer1.Text.Substring(0, 1).ToString().ToUpper() + employer1.Text.Substring(1).ToString().ToLower(); //varchar Data//CamelCaseFormat Name
            string DocApellido = employer2.Text.Substring(0, 1).ToString().ToUpper() + employer2.Text.Substring(1).ToString().ToLower();//varchar Data
            string DocSexo = SexType.Text.ToString(); //varchar Data
            int DocEdad = int.Parse(employer7.Text); //int data
            string DocContacto = employer5.Text.ToString(); //varchar Data
            string DocDentistPin = DocNombre + DocApellido + DocEdad.ToString().ToLower();//varchar Data //Default Will be equal to  🚧//DocNombre+DocApellido+edad🚧 lowerCase
            string DocEmail = employer6.Text.ToString();// varchar Data
            string DireccionDoc = employer4.Text.ToString(); //varchar Data
            string DocID = employer1.Text.Substring(0, 1).ToString().ToUpper() + employer2.Text.Substring(0, 1).ToString().ToUpper() + "-" + randomData.ToString();//Data int AutoGenerate// iS EQUAL TO THE FIRST LATTER OF NAME +  FIRST LATTER OF LASTNAME EJ: David Rivera id = DR-RandomNumber
            string StatusAc = "Active";

            //Call Data Base//
              string saveDate = "EXEC Insert_Employer '" + @DocNombre + "','" + @DocApellido + "','" + @DocSexo + "'," + @DocEdad + ",'" + @DocContacto + "','" + @DocDentistPin + "','" + @DocEmail + "','" + @DireccionDoc + "','" + @DocID + "','" + @StatusAc +"'";
              dataBade.useProcedures(saveDate);
             
                Initial();
                employer1.Text = "";
                employer2.Text = "";
                //employer3.Text = "";
                employer4.Text = "";
                employer5.Text = "";
                employer6.Text = "";
                employer7.Text = "";
            
        }

        //pannel1
        private void DataViewEmployers_Click(object sender, EventArgs e)
        {
            if(DataViewEmployers.SelectedRows.Count >= 2) { return; }
            foreach (DataGridViewRow row in DataViewEmployers.SelectedRows)
            {
                if (row.Cells[0].Value.ToString() == "") { return; }
            }

            ActiverEdition.Show();//Button For edit dataGrid data Is Showed|   
            Remover.Show();
            PanelAbout.Show();//Panel Data
            SaveEditionButton.Show();

            users.Hide();
            employers.Show();

            //⚠️⚠️⚠️⚠️ Hide savesPatiente when edit is important, becouse we don't want to update patient with Doc Data⚠️⚠️⚠️⚠️
            Savepatientedata.Hide();
            //When this event is ivoked then saver Patient is desactivied//

            foreach (DataGridViewRow row in DataViewEmployers.SelectedRows)
            { 
                currentUserId = row.Cells[0].Value.ToString();//Id
                Edit1.Text = row.Cells[1].Value.ToString();
                Edit2.Text = row.Cells[2].Value.ToString();
                Edit3C.Text = row.Cells[3].Value.ToString();
                Edit4.Text = row.Cells[4].Value.ToString();
                Edit5.Text = row.Cells[5].Value.ToString();
                Edit6.Text = row.Cells[7].Value.ToString();
                Edit7.Text = row.Cells[8].Value.ToString();

                editPass1.Show();
                editPss2.Show();
                label30.Show();
                label31.Show();

                editPass1.Text = "******";//Cell 6
                editPss2.Text = "******";//Cell 6
            }

        }

        //pannel2
        private void PatientsGridview_Click(object sender, EventArgs e)
        {
            if(PatientsGridview.SelectedRows.Count >= 2) { return; }
            foreach (DataGridViewRow row in PatientsGridview.SelectedRows)
            {
                if (row.Cells[0].Value.ToString() == "") { return; }

            }

            PanelAbout.Show();
            RemoveAdmin.Show();
            ActiverEdition.Show();//Button For edit dataGrid data Is Showed|   

            //⚠️⚠️⚠️⚠️ Hide savesEmployer when edit is important, becouse we don't want to update doc with patient Data⚠️⚠️⚠️⚠️
            SaveEditionButton.Hide();
            //When this event is ivoked then saver is desactivied//
            Savepatientedata.Show();

            employers.Hide();
            users.Show();

            foreach (DataGridViewRow row in PatientsGridview.SelectedRows)
            {
                currentUserId = row.Cells[0].Value.ToString();//Id
                Edit1.Text = row.Cells[1].Value.ToString();
                Edit2.Text = row.Cells[2].Value.ToString();
                Edit3C.Text = row.Cells[3].Value.ToString();
                Edit4.Text = row.Cells[4].Value.ToString();
                Edit5.Text = row.Cells[5].Value.ToString();
                Edit6.Text = row.Cells[6].Value.ToString();
                Edit7.Text = row.Cells[7].Value.ToString();

                editPass1.Hide();
                editPss2.Hide();
                label30.Hide();
                label31.Hide();
            }

        }




        private void ActiverEdition_Click(object sender, EventArgs e)
        {
            ActiverEdition.Hide();
            PanelAbout.Show();//Show
            Remover.Show();

            Edit1.ReadOnly = false;
            Edit2.ReadOnly = false;
            //Edit3C.ReadOnly = false;
            Edit4.ReadOnly = false;
            Edit5.ReadOnly = false;
            Edit6.ReadOnly = false;
            Edit7.ReadOnly = false;

            editPass1.ReadOnly = false;
            editPss2.ReadOnly = false;

        }

        private void ClosePanel_Click(object sender, EventArgs e)
        {
            ActiverEdition.Hide();//Button For edit dataGrid data Is Hidden|   
            PanelAbout.Hide();//Panel Data
            Remover.Hide();
            PanelAdd.Hide();

        }


        private void AddDataPanel_Click(object sender, EventArgs e)
        {
            PanelAdd.Show();
        }
        

        ///UPDATA DATA BASE!!!!!---------------------------------------------------------------------------------------------------------------------------------------------
        public void UpDatBs(string dat, string table, string UpdataDataAs = "NULL")
        {
            if(UpdataDataAs == "NULL")
            {
                return;
            }
             
            //cmd.CommandText = "UPDATE DocDentist SET " + UpdataDataAs + " = " + dat + " WHERE id = " + int.Parse(currentUserId);
            Console.WriteLine("UPDATE " + table +" SET " + UpdataDataAs + "= " + "'" + dat + "'"+ " WHERE id = " + int.Parse(currentUserId));
            dataBade.SetUpdate("UPDATE " + table + " SET " + UpdataDataAs + "= " + "'" + dat + "'" + " WHERE id = " + int.Parse(currentUserId));
            

            Initial();

        }
        ///UPDATA DATA BASE!!!!!---------------------------------------------------------------------------------------------------------------------------------------------





        // Saver Section  UPdate//
        private void Savepatientedata_Click(object sender, EventArgs e)
        {

            SaveEditionButton.Hide();
            ActiverEdition.Show();
            Console.WriteLine("Checking Data...");

            

            int arrayValues = -1;
            var DataBase = new string[7] { "null", "null", "null", "null", "null", "null", "null"};

            foreach (DataGridViewRow row in PatientsGridview.SelectedRows) // This run once time, just when i seleted a person in the DataGrid
            {  

                if (PatientsGridview.SelectedRows.Count > 1)
                {
                    MessageBox.Show("You Can not Select More than 1 Row");// bug: this return if seleted more than two people in the Datagrid
                    return;
                }

                //DataViewEmployers.Columns[1].HeaderText;
                //9/7/2022    // If any of the input change, then if will pass the header text in an array// showing the save button
                if (row.Cells[1].Value.ToString() != Edit1.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[1].HeaderText; Console.WriteLine(row.Cells[1].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[2].Value.ToString() != Edit2.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[2].HeaderText; Console.WriteLine(row.Cells[2].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[3].Value.ToString() != Edit3C.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[3].HeaderText; Console.WriteLine(row.Cells[3].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[4].Value.ToString() != Edit4.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[4].HeaderText; Console.WriteLine(row.Cells[4].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[5].Value.ToString() != Edit5.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[5].HeaderText; Console.WriteLine(row.Cells[5].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[6].Value.ToString() != Edit6.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[7].HeaderText; Console.WriteLine(row.Cells[7].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[7].Value.ToString() != Edit7.Text.ToString()) { arrayValues++; DataBase[arrayValues] = PatientsGridview.Columns[8].HeaderText; Console.WriteLine(row.Cells[8].Value.ToString() + " Changed"); Savepatientedata.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
               

                Edit1.ReadOnly = true;
                Edit2.ReadOnly = true;

                Edit4.ReadOnly = true;
                Edit5.ReadOnly = true;
                Edit6.ReadOnly = true;
                Edit7.ReadOnly = true;

                editPass1.ReadOnly = true;
                editPss2.ReadOnly = true;


                var dataUp = new string[7] { Edit1.Text, Edit2.Text, Edit3C.Text, Edit4.Text, Edit5.Text, Edit6.Text, Edit7.Text };

                for (int index = 0; 0 < DataBase.Length; index++)
                {
                    if (index == DataBase.Length) return;
                    if (DataBase[index] != "NO_CG" & DataBase[index] != "null")
                    {
                        Console.WriteLine("Updateing: " + dataUp[index] + ":" + DataBase[index]);
                        UpDatBs(dataUp[index],"Paciente", DataBase[index]);

                    }

                }

                ActiverEdition.Show();

            }


        }

        private void SaveEditionButton_Click(object sender, EventArgs e)
        {

            //Text checkTexr//🚧


            SaveEditionButton.Hide();
            ActiverEdition.Show();

            Console.WriteLine("Checking Data...");
            int arrayValues = -1;
            var DataBase = new string[10] {"null", "null", "null", "null", "null", "null", "null", "null", "null", "null"};

            foreach (DataGridViewRow row in DataViewEmployers.SelectedRows)
            {

                if(DataViewEmployers.SelectedRows.Count > 1)
                {
                    MessageBox.Show("You Can not Select More than 1 Row");
                    return;
                }

                //MessageBox.Show(row.Cells[1].Value.ToString() + " == " +Edit1.Text.ToString());
                //Console.WriteLine(row.Cells[1].Value.ToString() == Edit1.Text.ToString());

                //DataViewEmployers.Columns[1].HeaderText;
                //9/7/2022
                if (row.Cells[1].Value.ToString() != Edit1.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[1].HeaderText;  Console.WriteLine(row.Cells[1].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[2].Value.ToString() != Edit2.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[2].HeaderText;  Console.WriteLine(row.Cells[2].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[3].Value.ToString() != Edit3C.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[3].HeaderText;  Console.WriteLine(row.Cells[3].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[4].Value.ToString() != Edit4.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[4].HeaderText;  Console.WriteLine(row.Cells[4].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[5].Value.ToString() != Edit5.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[5].HeaderText;  Console.WriteLine(row.Cells[5].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[7].Value.ToString() != Edit6.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[7].HeaderText;  Console.WriteLine(row.Cells[7].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (row.Cells[8].Value.ToString() != Edit7.Text.ToString()) { arrayValues++; DataBase[arrayValues] = DataViewEmployers.Columns[8].HeaderText;  Console.WriteLine(row.Cells[8].Value.ToString() + " Changed"); SaveEditionButton.Show(); }
                else { arrayValues++; DataBase[arrayValues] = "NO_CG"; };
                if (editPass1.Text != editPss2.Text)
                {
                    MessageBox.Show("Las claves de acceso tiene que ser la misma.");
                }
                else { 
                    
                     // Alert I will going to change my password //
                   
                    arrayValues++; DataBase[arrayValues] = "NO_CG"; 
                }

                Edit1.ReadOnly = true;
                Edit2.ReadOnly = true;

                Edit4.ReadOnly = true;
                Edit5.ReadOnly = true;
                Edit6.ReadOnly = true;
                Edit7.ReadOnly = true;

                editPass1.ReadOnly = true;
                editPss2.ReadOnly = true;


                var dataUp = new string[10] {Edit1.Text, Edit2.Text, Edit3C.Text, Edit4.Text, Edit5.Text, Edit6.Text, Edit7.Text, editPass1.Text, editPss2.Text, "end"};
                int dataCount = 0;
                
                for(int index = 0; 0 < DataBase.Length; index++)
                {
                    if (index == DataBase.Length) return;
                    if (DataBase[index] != "NO_CG" & DataBase[index] != "null")
                    {
                        Console.WriteLine("Updateing: "+ dataUp[index] + ":"  + DataBase[index]);
                        UpDatBs(dataUp[index],"DocDentist", DataBase[index]);

                    }

                }

                ActiverEdition.Show();

            }
        }

        //user
        private void RemoveAdmin_Click(object sender, EventArgs e)
        {
              string saveDate = "UPDATE Paciente SET StatusAC = 'Desactive' WHERE id = " + int.Parse(currentUserId);
                //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
                try
                {
                    dataBade.SetUpdate(saveDate);
                    Console.WriteLine("DELETING.......");
                }
                catch (Exception err)
                {
                    Console.WriteLine("⚠️ FOUND ON" + err);
                    MessageBox.Show("An Error in the Process Insert Data: Error 121 Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                 }


            Initial();
            PanelAbout.Hide();

        }





        //Employer
        private void Remover_Click(object sender, EventArgs e)
        {
             string saveDate = "UPDATE DocDentist SET StatusAC = 'Desactive' WHERE id = " + int.Parse(currentUserId);
              //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
               try{
                       dataBade.SetUpdate(saveDate);
               }catch (Exception err){
                        Console.WriteLine("⚠️ FOUND ON" + err);
                        MessageBox.Show("An Error in the Process Insert Data: Error 121 Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
               Initial();
                

            PanelAbout.Hide();
        }



        // DELETE ALL TEXTBOX //
        private void Btn7_Click(object sender, EventArgs e)
        {
            Nm1.Text = "";
            Nm2.Text = "";
            Nm3.Text = "";
            Nm4.Text = "";
            Nm5.Text = "";
            Nm6.Text = "";

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            PanelAbout.Hide();
            Remover.Hide();
            RemoveAdmin.Hide();


            Edit1.ReadOnly = true;
            Edit2.ReadOnly = true;
            //Edit3C.ReadOnly = true;
            Edit4.ReadOnly = true;
            Edit5.ReadOnly = true;
            Edit6.ReadOnly = true;
            Edit7.ReadOnly = true;

            editPass1.ReadOnly = true;
            editPss2.ReadOnly = true;





        }


    }
}
