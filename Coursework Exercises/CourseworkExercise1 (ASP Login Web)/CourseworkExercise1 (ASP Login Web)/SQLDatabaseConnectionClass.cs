using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SQLClass
{
    public class SQLDatabaseConnectionClass
    {
        public SqlConnection ConnToSQL = new SqlConnection();
        public DataTable SQLTable = new DataTable();

        public SQLDatabaseConnectionClass()
        {
            ConnToSQL.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public void getData(string command) // Used to retrieve data within the database using "SELECT"
        {
            try
            {
                ConnToSQL.Open(); // Opens up a new connection to the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, ConnToSQL);
                dataAdapter.Fill(SQLTable); // Add or refresh the data in the dataset as specified within the DataTable name (SQLTable)
                
            }
            catch (Exception ex) // Catch the exception if there is an error
            {
                
            }
            finally
            {
                ConnToSQL.Close(); // Close the connection to the database once finished

            }
        }

        public void execute(string command)
        {
            try
            {
                ConnToSQL.Open();
                SqlCommand SQLcommand = new SqlCommand(command, ConnToSQL); // Creating a new instance of the Sqlcommand as SQLCommand
                // Passing in the command spcified by the user followed by the connection to the sql database
                int affectedRow = SQLcommand.ExecuteNonQuery();
                /* 
                 
                As the command is executed by the sql server it returns an interger. The interger returned represents the number of rows that have been affected.
                It follows on by having an IF statement which checks whether the number of rows affected is greater than zero. If yes, it means that the 
                command applied by the user has affected a row or several rows within the table of the database. 

                 */
                 if (affectedRow > 0)
                {

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                ConnToSQL.Close();
            }
        }

    }

    
}