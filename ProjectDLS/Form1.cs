using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjectDLS
{
    public partial class Form1 : Form
    {
        DataBaseCall dataBase = new DataBaseCall();

        public Form1()
        {
            InitializeComponent();
            //this.TypeUserIs.DropDownStyle = ComboBoxStyle.DropDownList; Fix the combox, so is nor possible write in it.

            CancelPss.Hide();

        }



        private void SendRequest_Click_1(object sender, EventArgs e)
        {
 
            string[] idReturned = { "id", "Nombre"};// retreun array string cell..//
            string[] tablesCells = { "Email", "Passwrd"}; //cell validation just two parametre..//
             //Admin Validation--------------------------------------------------------------------------
            if (dataBase.validation("SELECT * FROM Adimn", emailinput.Text.ToString(), password.Text.ToString(),  tablesCells , idReturned)){
                  this.Hide();
                  Form2 nextfrom = new Form2();
                  Class1.name = "Admin";
                  Class1.trakerName = idReturned[0];
                  Class1.trakID = idReturned[1];
                emailinput.Clear();
                password.Clear();
                nextfrom.Show();
                  return;//if Admin is Matched, then close DataBase and then Open the Other Windown

             }



            //Doc Validation------------------------------------------------------------------------
            string[] idReturned2 = {"DocNombre", "id", "StatusAc", "DocID" };// retreun array string cell..//
            string[] tablesCells2 = { "DocEmail", "DocDentistPin" }; //cell validation just two parametre..//
            if (dataBase.validation("SELECT * FROM DocDentist", emailinput.Text.ToString(), password.Text.ToString(), tablesCells2, idReturned2))
            {
                string[] idReturned22 = { "DocNombre", "id", "StatusAc", "DocID" };// retreun array string cell..//
                dataBase.me("SELECT * FROM DocDentist WHERE DocDentistPin = " +"'"+password.Text.ToString()+"'", "DocDentist", idReturned22);
                this.Hide();
                Form2 nextfrom = new Form2();
                Class1.name = "Employer";
                Class1.trakerName = idReturned2[1];
                Class1.trakID = dataBase.textFiller("DocID", "SELECT * FROM DocDentist WHERE DocDentistPin = "+"'"+password.Text.ToString()+"'");

                emailinput.Clear();
                password.Clear();

                if (idReturned2[2].ToString().ToLower() == "Desactive".ToString().ToLower() || idReturned2[2].ToString().ToLower() == "Desactive".ToString().ToLower())
                {
                    this.Show();
                    Console.WriteLine("BLOCKED ACCOUNT");
                    ActionsActive.Text = idReturned2[0] + " no puedes acceder con tu estado Desactivado, Consultar con un Administrador.";
                    RichTextBox rtb2 = new RichTextBox();
                    ActionsActive.ForeColor = System.Drawing.Color.Red;
                    emailinput.Text = "";
                    password.Text = "";
                    return;
                }
                nextfrom.Show();

            }




            emailinput.Clear();
            password.Clear();
            indicator.Text = "Email o Clave de Acceso no Correcto.";
            RichTextBox rtb1 = new RichTextBox();
            indicator.ForeColor = System.Drawing.Color.Red;


        }
        //close Global Function




        //Show Botton to Clrear textBox  Cancel Proccsse
        private void password_TextChanged(object sender, EventArgs e)
        {
            CancelPss.Show();
            if (password.Text == "" & emailinput.Text == "") CancelPss.Hide();

        }



        private void emailinput_TextChanged(object sender, EventArgs e)
        {
            CancelPss.Show();
            if(emailinput.Text =="" & password.Text=="") CancelPss.Hide();

        }
        //Creat Text Box
        private void CancelPss_Click(object sender, EventArgs e)
        {
            password.Clear();
            emailinput.Clear();

        }

        private void leaveApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
        }
    }
   
 }
