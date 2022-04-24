using System.Data.SqlClient;
using System.Data;

namespace ADONetPractice
{
    public class Program
    {
        private const string CONNECTION_STRING = "Server=NEELRONG\\SQLEXPRESS;Database=CSharpD11;User Id=sa;Password=2410";
        private static SqlConnection _sqlConnection;
        
        static void Main(string[] args)
        {
            _sqlConnection = new SqlConnection(CONNECTION_STRING);

            //Execution code
            var insertSql = "insert into Person (Name, Age, Address) values('Blake', 25, 'Florida, USA')";
            var updateSql = "update Person set Name = 'Jones', Age = 29, Address = 'Utah, USA' where id = 2";
            var deleteSql = "delete from Person where id = 3";
            Write(insertSql);
            Write(updateSql);
            Write(deleteSql);

            
            var result = Read("Person");
            foreach(var row in result)
            {
                foreach(var col in row)
                {
                    Console.WriteLine($"{col.key} -> {col.value}");
                }
                Console.WriteLine(new String('=', 7));
            }

            var dataSet = ReadTable("Person");
            for(var i = 0; i<dataSet.Tables.Count; i++)
            {
                for(var j = 0; j<dataSet.Tables[i].Rows.Count; j++)
                {
                    for(var k = 0; k<dataSet.Tables[i].Rows[j][k]; k++)
                    {
                        Console.WriteLine($"{dataSet.Tables[i].Rows[j][k]} -> {dataSet.Tables[i].Rows[j][k]}");
                    }
                }
            }
            

            _sqlConnection.Dispose();
        }

        public static void Write(string sql)
        {
            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                using var command = new SqlCommand(sql, _sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                Console.WriteLine("There was an error in database " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(_sqlConnection?.State != ConnectionState.Closed)
                _sqlConnection?.Close();
            }
            
        }

        
    }
}