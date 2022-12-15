using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;



namespace ProjectDLS
{
    class DataBaseCall
    {
        GlobalVariables stringConnection = new GlobalVariables();


        //Retrun any Spacifed String//
        public String DataFill(string commnadSql)
        {

            //class table
            DataTable dataSource = new DataTable();
            SqlDataAdapter dataAdater = new SqlDataAdapter(commnadSql, stringConnection.connection);
            dataAdater.Fill(dataSource);
            string data = (string)dataSource.Rows[0].ItemArray[0];
            return data.ToString();

        }


        // 12/5/2022 includes[Loggin]//
        public Boolean validation(string command, string emailUser, string userPassword, string[] comparetorMax2, string[] indentification)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
            {

                conn.Open(); //|Open My connection.
                             //Persons
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;//|Binding with my current open
                    cmd.CommandText = command;
                    SqlDataReader dataRead = cmd.ExecuteReader();//| It already contains The Data//| if i have more than 5 people i have to loop through them.
                    while (dataRead.Read())
                    {
                        // Variables validations ..//
                        string userEmailVlidValidation = dataRead[comparetorMax2[0]].ToString();
                        string userPasswordValidation = dataRead[comparetorMax2[1]].ToString();

                        if (emailUser.ToString() == userEmailVlidValidation.ToString() && userPasswordValidation.ToString() == userPassword.ToString())
                        {
                            // Array str  cell..//
                            for(int e = 0; e == indentification.Length; e++){
                                indentification[e] = dataRead[indentification[e]].ToString();// retrun a cell .//
                            }

                            dataRead.Close();
                            return true;
                        }


                     }

                 }


            }

                return false;
        }



        public Array me(string command, string table ,string[] filterCell)
        {

            using (SqlConnection conn = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
            {

                conn.Open(); //|Open My connection.
                             //Persons
                using (SqlCommand cmd = new SqlCommand())
                {

                    SqlCommand cmd3 = new SqlCommand(command, conn);
                    SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);////DataAdapter will acts as a Bridge between DataSet and database.
                    DataSet ds3 = new DataSet();
                    sda3.Fill(ds3, table);
                    SqlDataReader dataToread3 = cmd3.ExecuteReader();

                    int initial = 0;
                    while (dataToread3.Read())
                    {
                        for (int e = 0; e < filterCell.Length; e++)
                        {
                            if(dataToread3[filterCell[e]].ToString() != filterCell[e]) {
                                string dataString = dataToread3[filterCell[e]].ToString();
                                filterCell[e] = dataString; // If all are added then it will takes the last id
                            }
                            else
                            {
                                return filterCell;
                            }

                        }
                        initial++;
                    }



                }

                conn.Close(); //|CLose My connection.
                return filterCell;

            }
        }




        public void GridFill(DataGridView TableTOfill, string command, string strTable)
        {

            SqlConnection conn = new SqlConnection(stringConnection.connection);
            conn.Open();
            try
            {   //Collection Of Tables for DocDentist.
                Console.WriteLine(command);
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);////DataAdapter will acts as a Bridge between DataSet and database.
                DataSet ds = new DataSet();
                sda.Fill(ds, strTable);
                Console.WriteLine(ds);
                TableTOfill.DataSource = ds.Tables[0];//Get the collection of table in the DateSet

            }
            catch (Exception typeErr)
            {
                MessageBox.Show(":( " +typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            conn.Close();

        }



        public int DataFillInit(string commnadSql)
        {

            //class table
            DataTable dataSource = new DataTable();
            SqlDataAdapter dataAdater = new SqlDataAdapter(commnadSql, stringConnection.connection);
            dataAdater.Fill(dataSource);
            int v = (int)dataSource.Rows[0].ItemArray[0];
            return v;

        }


        // retrun a text output // 12 / 2 /22
        public string textFiller(string parametre, string Command = "")
        {

            Console.WriteLine(Command);
            SqlConnection conn = new SqlConnection(stringConnection.connection);
            conn.Open();
            try
            {

                string dataParametre = "No Text";
                using (SqlCommand cmdm = new SqlCommand())
                {
                    cmdm.Connection = conn;
                    cmdm.CommandText = Command;
                    SqlDataReader dataToread = cmdm.ExecuteReader();

                    int dataIndex = 1;
                    while (dataToread.Read())
                    {
                        dataParametre = dataToread[parametre].ToString();
                        dataIndex++;

                    }


                }
                conn.Close();
                Console.WriteLine(dataParametre);
                return dataParametre;
            }
            catch (Exception typeErr)
            {
                MessageBox.Show("An Error in the Process  Fill Tables: Error 138 Type: " + typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "NOvalied";
            }

        }



        // setUpdate  to the dataBase //  12/2/22
        public void SetUpdate( string command, int counter = 0)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
            {
                try
                {
                    // send Update..??true: false stay with the block bellow//
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;//|Binding with my current open

                        if (stringConnection.typeSet[counter] == "EdadPaciente")
                        {   // set Id Update
                            cmd.CommandText = command;
                        }
                        else
                        {
                            
                            cmd.CommandText = command;
                        }


                        SqlDataReader dataRead = cmd.ExecuteReader();//| It already contains The Data//| if i have more than 5 people i have to loop through tham

                    }
                    conn.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error " + err);
                    MessageBox.Show("An Error in the Process Update Error:407  Type: " + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }







        //INSERT IN DATA BASE//
        public void insertProceduresPatients(string PacienteNombre,  string PacienteApellido, string PacienteSexo, int PacienteEdad, string PacienteContacto, string PacienteEmail, string DireccionPaciente, string PacienteID, string StatusAc )
        {

            using (SqlConnection conn = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
            {
                conn.Open();
                string saveDate = "EXEC Insert_Patiente '" + @PacienteNombre + "','" + @PacienteApellido + "','" + @PacienteSexo + "'," + @PacienteEdad + ",'" + @PacienteContacto + "','" + @PacienteEmail + "','" + @DireccionPaciente + "','" + @PacienteID + "','" + @StatusAc + "'";

                //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
                try
                {
                    Console.WriteLine("INSERTING.......");

                    using (SqlCommand cmd = new SqlCommand(saveDate, conn))
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
                    return;
                    conn.Close();
                }

            }

        }



        public void fillComboxBox(string commnadSql,string row , ComboBox combox)
        {
            //class table
            SqlConnection con = new SqlConnection(stringConnection.connection);////Open My connection Insertting my connectionString.

                DataTable tablaDeTratmients = new DataTable();
                SqlDataAdapter dataProdustsAdater = new SqlDataAdapter();
                dataProdustsAdater.SelectCommand = new SqlCommand(commnadSql, con);
                dataProdustsAdater.Fill(tablaDeTratmients);

            combox.ValueMember = row;
            combox.DataSource = tablaDeTratmients;
            
        }


       public void InsertAnyTable(string  commnad)
        {
            using (SqlConnection connConsult = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
            {
                connConsult.Open();
               
                using (SqlCommand cmd = new SqlCommand(commnad, connConsult))
                {
                    Console.WriteLine(commnad);

                    //Active SQL Statement
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("COMPLETED SUCCEFULLY!!");

                }

                connConsult.Close();

            }
        }


        public void useProcedures(string command)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection.connection))////Open My connection Insertting my connectionString.
            {
                conn.Open();
                string saveDate = command;

                //OPEN DOOR, IMPORTSNT PORCCESS//In this proccess the data has to be  been evaluated to fix any error
                try
                {
                    Console.WriteLine("INSERTING.......");

                    using (SqlCommand cmd = new SqlCommand(saveDate, conn))
                    {                        //Active SQL Statement
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("COMPLETED SUCCEFULLY!!");
                    }


                }
                catch (Exception err)
                {
                    Console.WriteLine("⚠️ FOUND ON" + err);
                    MessageBox.Show("Action Procedure" + err, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    conn.Close();
                }

                conn.Close();
            }

        }


    }
}
