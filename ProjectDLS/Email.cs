using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Data.SqlClient;

namespace ProjectDLS
{
    class Email
    {
        GlobalVariables stringConnection = new GlobalVariables();




        async public void SenderEmailSim(string reciver, string SubJect, string body)
        {
            //var message = new MimeMessage();
            //message.From.Add(new MailboxAddress("Joey Tribbiani", "YOU_FROM_ADDRESS@gmail.com"));
            //message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "YOU_TO_ADDRESS@gmail.com"));
            //message.Subject = "How you doin'?";
            //message.Body = new TextPart("plain")


            string com = "c";

            try
            {
                System.Net.Mail.SmtpClient SmtpM = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage mailMss = new System.Net.Mail.MailMessage();

                //MailMessage Credential
                mailMss.From = new System.Net.Mail.MailAddress("davidceballo11@gmail.com");
                mailMss.To.Add(new System.Net.Mail.MailAddress(reciver));
                mailMss.Subject = SubJect;
                mailMss.IsBodyHtml = false;//It does not send the Content on HTML.
                mailMss.Body = body;
                mailMss.Priority = System.Net.Mail.MailPriority.Normal;

                //smtpm Credentials
                SmtpM.Host = "smtp.gmail.com";
                SmtpM.Port = 587;
                SmtpM.EnableSsl = true;
                SmtpM.UseDefaultCredentials = false;
                SmtpM.Credentials = new NetworkCredential("davidceballo11@gmail.com", "dqamkytmktuwozpr");
                SmtpM.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                SmtpM.Send(mailMss);
            }
            catch (Exception e)
            {
                //Caught a error sending Email..
                com = "0";
                Console.WriteLine("Caught a error sending Email..");
                Console.WriteLine("Type Error" + e.Message);
                MessageBox.Show("An Error in the Process: " + e, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }




        public void EmailSender(string IdDocData, string IdTratamient, string DocId, string comboxBox, string textContainer, string patienteEmail, string dateTimePicker1Date, string idPatient, string getDataId, string richTextBox1)
        {
            if (textContainer != " ")
            {
                Console.WriteLine("Sending....to: " + patienteEmail);
                if (patienteEmail == "davidceballo11@gmail.com")
                {
                    SenderEmailSim(patienteEmail, "This is not Valied Email", "Este Email Podra ser Respondido Hasta: " + dateTimePicker1Date);
                    return;
                }
                // INSERTING DATA TO //
                //Random Genrator
                if (IdDocData == "NULL" || idPatient == "NULL")
                {
                    MessageBox.Show("Es importante que Completes todo los Inputs como ID correctamente ", "NOT COMPLETDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Random randomNumber = new Random();
                int randomData = randomNumber.Next(3000);
                string Date = DateTime.Now.ToString("yyyy-MM-dd");// egt the current TIme
                Console.WriteLine("INSERT INTO Consultas  VALUES(" + "'C" + idPatient + "-" + randomData + "','" + idPatient + "','" + IdDocData + "','" + IdTratamient + "','" + "'" + dateTimePicker1Date + "'" + ")");

                using (SqlConnection connConsult = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
                {
                    connConsult.Open();
                    string saveDate = "INSERT INTO Consultas VALUES(" + "'C" + getDataId + "', " + idPatient + ", " + IdDocData + ", " + IdTratamient + ", '" + dateTimePicker1Date + "')";

                    //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
                    try
                    {
                        Console.WriteLine("INSERTING CONSULT......");

                        using (SqlCommand cmd = new SqlCommand(saveDate, connConsult))
                        {
                            Console.WriteLine(saveDate);

                            //Active SQL Statement
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("COMPLETED SUCCEFULLY!!");

                        }


                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("⚠️ FOUND ON" + err);
                        MessageBox.Show("An Error in the Process Insert Data: Error 121 Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connConsult.Close();

                        return;

                    }

                    connConsult.Close();
                    SenderEmailSim(patienteEmail, "RECORDATORIO", "Este Email Podra ser Respondido Hasta: " + dateTimePicker1Date + "\n" + richTextBox1 + "\n" + "Tipo de Consulta: " + comboxBox);

                }

            }
            else
            {
                MessageBox.Show("Tienes que especicar Mas de la Consulta", "Dat incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



        }




    }
}
