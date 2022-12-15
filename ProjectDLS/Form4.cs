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
    public partial class Form4 : Form
    {

        Email EmailDa = new Email();
        DataBaseCall dataBase = new DataBaseCall();
        GlobalVariables varData = new GlobalVariables();

        public string connectionsString = "Server=DESKTOP-FB9EHDC;Database=pj1;Trusted_Connection=True;";//String Connection
        public int counterAmount = 0;
        public bool runningOnce = true;
        public string gloabHast = "#";
        public string Date = DateTime.Now.ToString("yyyy-MM-dd");// egt the current TIme
        public string modePayment = "NO";


        public string IDNDoc= "#";
        public string patient = "#";


        public string idPayment = "NULL";

        public int paymentMount = 0;
        public Form4()
        {
            InitializeComponent();
            AddFacturationPatient.Hide();
            this.typeOftratamient.DropDownStyle = ComboBoxStyle.DropDownList; //Fix the combox, so is nor possible write in it.

            if (Class1.name != "Admin")
            {
                p2.ReadOnly = true;
                p2.Text = Class1.trakID.ToUpper();
            }
            InfLoaderCalculation.Hide();
            codeFact.ReadOnly = true;
            FacturationG.Hide();

        }

        private void BackF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nextfrom = new Form2();
            nextfrom.Show();
        }

        private void InfLoaderCalculation_Click(object sender, EventArgs e)
        {
            tratamient.Text = "";
            personName.Text = "";
            PayMode.Show();

            ///FACTURATION DETAILS//
            //AddFacturationPatient.Show();
            if (idPayment == "NULL")
            {
                MessageBox.Show("NO AVAILABLE, INPUT PACIENTE", "EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            string command = "INSERT INTO DatallesFacturas VALUES(" + "'" + "#" + gloabHast + "'" + "," + "'" + Date + "'" + "," + "'" + paymentMount + "'" + "," +"'"+PayMode.Text+"by>:"+idItmeP+"'"+ ")";
            dataBase.InsertAnyTable(command);

                // Send Email Notification//
                string patienteEmail = dataBase.textFiller("EmailPaciente", "SELECT * FROM Paciente WHERE PacienteID = "+"'"+patient.ToString()+ "'");
                EmailDa.SenderEmailSim(patienteEmail, "A PAGO FUE COMPLETADO", "---");

           

            p1.Clear();
            p2.Clear();
            typeOftratamient.Text = "";

            MessageBox.Show("Enviamos un Email de la Factura " + modePayment + " en CXC", "Accion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            runningOnce = true;
            this.dataGetFacturation.DataSource = null;
            this.dataGetFacturation.Rows.Clear();
        }






        private void p1_TextChanged(object sender, EventArgs e)
        {
            Btn1.Show();
            patient = p1.Text.ToString().ToUpper();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            p2.Clear();
            p1.Clear();
            typeOftratamient.Text = "";
            PayMode.Text = "";
            codeFact.Text = "";
            GetIdPayment.Text = "";
            totalPayment.Text = "";
        }


        public string idItmeP = "";
        public string idItemD = "";
        public string idItemT = "";
     

        private void AddFacturation_Click(object sender, EventArgs e)
        {

            
            if (PayMode.Text == "")
            {
                MessageBox.Show("NO AVAILABLE, INPUT", "EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            PayMode.Text = PayMode.Text;
            PayMode.Hide();


            AddFacturation.Hide();
            AddFacturationPatient.Show();

            string idPatient = p1.Text.ToString().ToUpper();
            string idDoc = p2.Text.ToString().ToUpper();
            string tratamient = typeOftratamient.Text.ToString().ToUpper();

             //   >Search Data Patient       //
            //  >Search Data Doc          //
           //  >Search Data tratamient  //

            //1------------------------------------------------------------------------------------------------------
            string Date = DateTime.Now.ToString("yyyy-MM-dd");// egt the current TIme
            string[] Paciente = { "id", "NombrePaciente", "ApellidoPaciente", "EmailPaciente", "PacienteID" };
            dataBase.me("SELECT * FROM Paciente WHERE PacienteID= " + "'" + patient + "'", "Paciente", Paciente);

            idItmeP = Paciente[0].ToString();
            string name = Paciente[1].ToString();
            string lastName = Paciente[2].ToString();
            string DataEmail = Paciente[3].ToString();
            string IND = Paciente[4].ToString();


             labelGetname.Text = name;
             labelGetlastName.Text = lastName;
             getEMail.Text = DataEmail;
             GetIDN.Text = IND;


            //2------------------------------------------------------------------------------------------------------
            string[] DocDentist  = { "id", "DocNombre", "DocApellido", "DocEmail", "DocID" };
            dataBase.me("SELECT * FROM DocDentist WHERE DocID = " + "'" + idDoc + "'", "DocDentist", DocDentist);
            
            idItemD = DocDentist[0].ToString();
            string nameDOc = DocDentist[1].ToString();
            string lastNameDOc = DocDentist[2].ToString();
            string DataEmailDOc = DocDentist[3].ToString();
            string INDDOc = DocDentist[4].ToString();



            //3------------------------------------------------------------------------------------------------------
            string[] Tratamientos = { "id", "tratamientoTipo", "tratamientoCosto"};
            dataBase.me("SELECT * FROM Tratamientos WHERE tratamientoTipo= " + "'" + typeOftratamient.Text.ToString() + "'", "Tratamientos", Tratamientos);

            idItemT = Tratamientos[0].ToString();
            string typeOftratamients = Tratamientos[1].ToString();
            string price = Tratamientos[2].ToString();
            PaymendBox.Text = price;


        }





        private void fillDatagRid()
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd");// egt the current TIme
            dataBase.GridFill(dataGetFacturation, "SELECT pacienteId as Paciente, DocDentist as Doctor,tratameintoid as Tratamiento, modoCxC as CuentasxCombrar, CurrentTIme as Fecha  FROM Facturacion WHERE facturationCode= " + "'" + "#" + gloabHast + "'", "Facturacion");  
        }

        private int getGastTag()
        {

            if (!runningOnce) { return 0; };
            Random randomNumber = new Random();
            int randomData = randomNumber.Next(200000) * randomNumber.GetHashCode();
            gloabHast = randomData.ToString().Substring(1);
            return randomData;
            
        }


        private void AddFacturationToDataGrid_Click(object sender, EventArgs e)
        {
            
            getGastTag();

            string[] arrayData = { "id", "tratamientoTipo", "tratamientoCosto" };

            //it could be called in thi way below//
            //dataBase.me("SELECT * FROM Tratamientos WHERE tratamientoTipo= " + "'" + typeOftratamient.Text.ToString() + "'", "Tratamientos", arrayData)
            dataBase.me("SELECT * FROM Tratamientos WHERE tratamientoTipo= " + "'" + typeOftratamient.Text.ToString() + "'", "Tratamientos", arrayData);

            string getProces = "0";
            idItemT = arrayData[0];
            string typeOftratamients = arrayData[1].ToString();
            string price = arrayData[2].ToString();
            PaymendBox.Text = price;
            getProces = price;
            paymentMount += paymentMount + int.Parse(price);



               // Inser Data -----//
                InfLoaderCalculation.Show();
            //Payment..
            string time = DateTime.Now.ToString("h:mm:ss tt");

            string getPatienteName = dataBase.textFiller("NombrePaciente", "SELECT * FROM Paciente WHERE id="+idItmeP);
            string getPatienteDoctName = dataBase.textFiller("DocNombre", "SELECT * FROM DocDentist WHERE id=" + idItemD);
            string TratamienteName = dataBase.textFiller("tratamientoTipo", "SELECT * FROM Tratamientos WHERE id=" + idItemT);

            Console.WriteLine(getPatienteName + "LIFE SIGNAL 1 " + "Life Signal 02=>" + getPatienteDoctName + "Life Signal " + TratamienteName.ToString());

                if(PayMode.Text == "Credito") { modePayment = "SI"; }
                string saveDate = "INSERT INTO Facturacion " + "VALUES( " +"'"+getPatienteName+"'"+ "," +"'"+getPatienteDoctName+"'"+ "," +"'"+TratamienteName+"'"+ "," +"'"+PayMode.Text+"'"+ "," +"'"+getProces.ToString()+"'"+ "," + "'" + "#" + gloabHast + "'" + "," +"'"+modePayment+"'"+","+"'"+time.ToString() + Date.ToString()+"'"+")";
                codeFact.Text = "#" + gloabHast;
                totalPayment.Text = paymentMount.ToString();
                Console.WriteLine(saveDate);


            string cachtName = dataBase.textFiller("NombrePaciente", "SELECT * FROM Paciente WHERE id =" + idItmeP);
            string cachtNameTratamient = dataBase.textFiller("tratamientoTipo", "SELECT * FROM Tratamientos WHERE id =" + idItemT);
            personName.Text = cachtName;
            tratamient.Text = cachtNameTratamient;

            //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
            try
                {
                     dataBase.InsertAnyTable(saveDate);

                }catch (Exception err)
                {
                    Console.WriteLine("⚠️ FOUND ON" + err);
                    MessageBox.Show("An Error in the Process Insert Data: Error 206 Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            FacturationG.Show();
            runningOnce = false;
            fillDatagRid();
            AddFacturation.Show();
            AddFacturationPatient.Hide();
            

        }




        private void p2_TextChanged(object sender, EventArgs e)
        {
            IDNDoc = p2.Text.ToString().ToUpper();
        }

        private void GetIdPayment_TextChanged(object sender, EventArgs e)
        {
            idPayment = GetIdPayment.Text.ToString().ToUpper();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            dataBase.fillComboxBox("SELECT tratamientoTipo FROM Tratamientos;", "tratamientoTipo", typeOftratamient);

        }
    }
}
