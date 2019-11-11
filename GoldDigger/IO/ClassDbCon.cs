// The class uses the System.Data and System.Data.SqlClient .NET libraries to be able to connect and
// communicate with a database. System.Data primarily is used handle datatypes we get
// from the database, and System.Data.SqlClient is for general communications with the database. 
using System.Data;
using System.Data.SqlClient;

namespace ProjectIO
{    
    /// <summary>
    /// The ClassDbCons purpose is to handle the connection to the DB.
    /// </summary>
    public class ClassDbCon
    {
        private string connectionString;
        private SqlConnection con;
        private SqlCommand command;

        /// <summary>
        /// Default constructor with no arguments
        /// </summary>
        public ClassDbCon()
        {
        }

        /// <summary>
        /// An overload construkter
        /// Set the SqlConnection based on the recived string
        /// Save the connectionstring in the field connectionString and the SqlConnection in the field con
        /// </summary>
        /// <param name="yourConString">A string with the connection settings</param> 
        public ClassDbCon(string yourConString)
        {
            connectionString = yourConString;
            con = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Set the SqlConnection based on the recived string
        /// Save the connectionstring in the field connectionString and the SqlConnection in the field con
        /// </summary>
        /// <param name="yourConString">A string with the connection settings</param>
        protected void SetCon(string yourConString)
        {
            connectionString = yourConString;
            con = new SqlConnection(connectionString);
        }

        /// <summary> 
        /// OpenDB is a method that trys to open the connection to the DB
        /// In the "if" statement it checks if con is not null,
        /// and if con.State is == ConnectionState.Closed then it use con.Open.
        /// if ConnectionState is open, or con is null
        /// it will Close the cennection and do recursive call of OpenDB
        /// </summary> 
        protected void OpenDB()
        {
            try
            {
                if (this.con != null && con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else
                {
                    CloseDB();
                    OpenDB();
                }
            }
            catch (SqlException sqlEx)
            {

                throw sqlEx;
            }
        }

        /// <summary>
        /// This method closes the connection to the DB
        /// It will throw a exception if anything goes wrong
        /// </summary>
        protected void CloseDB()
        {
            try
            {
                con.Close();
            }
            catch (SqlException sqlEx)
            {

                throw sqlEx;
            }
        }

        /// <summary> 
        /// This method takes an SQL-query as a parameter.
        /// The res variable holds an integer value that represents the outcome of ExecuteNonQuery.
        /// Field command is set to a new SqlCommand where the SQL-query and connection is defined.
        /// A connection to the database is opened and the SQL-command is executed by calling the
        /// command.ExecuteNonQuery() method. The outcome of the operation is stored in res (1 for succesful,
        /// and 0 for unsuccesful).         
        /// If anything goes wrong, an exception is thrown. 
        /// In Finally the CloseDB() will be called to close the
        /// connection, independed of an exception is thrown or not.
        /// Lastly, res is returned to the method caller.
        /// </summary>
        /// <param name="sqlQuery">String with the SQL-query</param>
        /// <returns>An integer representing the outcome of the execution</returns>
        protected int ExecuteNonQuery(string sqlQuery)
        {
            int res = 0;
            command = new SqlCommand(sqlQuery, con);
            try
            {
                OpenDB();
                res = command.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {

                throw sqlEx;
            }
            finally
            {
                CloseDB();

            }
            return res;
        }

        /// <summary> Morgan
        /// This method generates a DataTable.
        /// It then temporarily uses an SqlCommand (sqlQuery) and SqlDataAdapter to 
        /// exstract data from DB ,convert it and put it into the Datatable.
        /// Once done it desposes of the SqlCommand and SqlDataAdapter and closes the connection.
        /// </summary>
        /// <param name="sqlQuery">It uses the sqlQuery, which gives a command to the database, 
        /// and retrieves data from it.</param>
        /// <returns>The method returns the now data filled DataTable, so the data can be shown 
        /// in the application form.</returns> 
        /// 

        /// <summary> Mads
        /// The method starts by creating a new empty DataTable.
        /// A connection to the database is then opened.
        /// Inside a using-statement, "command" is set to a new SqlCommand where
        /// the SQL-query and connection is defined.
        /// An SqlDataAdapter is instantialized with "command" as the parameter inside
        /// another using-statement. The adapter sends the SQL-command to the database and
        /// fills the data that is returned into the empty DataTable. 
        /// If anything goes wrong, an exception is thrown.
        /// In the finally statement, CloseDB() will then be called to close the connection.
        /// The DataTable is then returned to the method caller.
        /// </summary>
        /// <param name="sqlQuery">String containing the SQL-query</param>
        /// <returns>DataTable containing rows relevant to the SQL-query</returns> 
        /// 
        /// <summary> Mathias
        /// new instance of DataTable.
        /// try catch with a using that creates 'command' that holds the Database settings 
        /// and connection strings.
        /// then the next using uses the SqlDataAdapter which is taking command as a parameter
        /// that fills the dtRes
        /// then the finally closes the DB and then dtRes gets returned.
        /// </summary>
        /// <param name="sqlQuery">String with an SQL-Query</param>
        /// <returns>dtRes which holds the DataTable</returns> 
        /// 
        /// <summary> Bobby
        /// Returns a DataTable with the values recived from the database
        /// </summary>
        /// <param name="sqlQuery">String with the SQL-query</param>
        /// <returns>A DataTable with values depenting on sqlQuery</returns> 
        //      Generete a new instance of DataTable 
        //      trys to catch any Exception that may appear 
        //      Calls a method that open the SqlConnection to the DataBase 
        //      Generete an SQL-Command based on sqlQuery
        //      then fill a var with values from the DataTable  
        //      the garbage-Collecter stops the use of command and adapter    
        //      Calls a method that colses the connection to the DataBase 
        /// <summary> Patrick
        /// Method creates a datatable, for values to be put in,
        /// It trys to OpenDB() followed by,
        /// SqlCommand(sql-Query) and SqlDataAdapter(command).
        /// The adapter.Fill(dtRes), will fill the datatable with the data.
        /// finally will CloseDB() even if it goes good or bad.
        /// </summary>
        /// <param name="sqlQuery">String sql-Query</param>
        /// <returns></returns> 

        protected DataTable DbReturnDataTable(string sqlQuery)
        {
            DataTable dtRes = new DataTable();
            try
            {
                OpenDB();

                using (command = new SqlCommand(sqlQuery, con))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dtRes);
                }
            }
            catch (SqlException sqlEx)
            {

                throw sqlEx;
            }
            finally
            {
                CloseDB();
            }
            return dtRes;
        }
    }
}
