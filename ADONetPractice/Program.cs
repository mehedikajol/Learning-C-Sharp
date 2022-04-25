using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace ADONetPractice
{
    public class Program
    {
        private const string CONNECTION_STRING = "Server=NEELRONG\\SQLEXPRESS;Database=CSharpD11;User Id=sa;Password=2410";
        private static SqlConnection _sqlConnection;

        static void Main(string[] args)
        {
            _sqlConnection = new SqlConnection(CONNECTION_STRING);

            /*
            var insertSql = "insert into Person (Name, Age, Address) values('Thomas', 23, 'LA, USA')";
            var updateSql = "update Person set Name = 'Brad', Age = 29, Address = 'CA, USA' where id = 5";
            var deleteSql = "delete from Person where id = 2";
            Write(insertSql);
            Write(updateSql);
            Write(deleteSql);
            */


            var result = Read("Person");
            foreach (var row in result)
            {
                foreach (var col in row)
                {
                    Console.Write($"{col.Key} -> {col.Value}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            var dataSet = ReadTable("Person");
            for(var i = 0; i<dataSet.Tables.Count; i++)
            {
                for(var j = 0; j<dataSet.Tables[i].Rows.Count; j++)
                {
                    for(var k = 0; k<dataSet.Tables[i].Columns.Count; k++)
                    {
                        Console.Write($"{dataSet.Tables[i].Rows[j][k]}\t");
                    }
                    Console.WriteLine();
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
                if (_sqlConnection?.State != ConnectionState.Closed)
                    _sqlConnection?.Close();
            }

        }

        public static IList<IDictionary<string, object>> Read(string tableName)
        {
            var result = new List<IDictionary<string, object>>();
            var query = "Select * from " + tableName;

            try
            {
                if (_sqlConnection.State != ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                using var command = new SqlCommand(query, _sqlConnection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    result.Add(row);
                }
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
                if (_sqlConnection?.State != ConnectionState.Closed)
                    _sqlConnection?.Close();
            }

            return result;
        }
    
        public static DataSet ReadTable(string tableName)
        {
            var dataSet = new DataSet();
            var query = "select * from " + tableName;

            try
            {
                if(_sqlConnection.State != ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }
                var dataTable = new DataTable("Person");

                dataTable.Columns.Add(new DataColumn("Name"));
                dataTable.Columns.Add(new DataColumn("Age"));
                dataTable.Columns.Add(new DataColumn("Address"));

                //var dataRow = dataTable.NewRow();

                //dataTable.Rows.Add(dataRow);
                dataSet.Tables.Add(dataTable);

                var adapter = new SqlDataAdapter(query, _sqlConnection);
                adapter.Fill(dataSet);

                /* 
                // Updating data in table using DataSet
                var dataRow = dataTable.NewRow();
                dataRow["Name"] = "Juliee";
                dataTable.Rows.Add(dataRow);
                adapter.Update(dataSet);
                */
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
                if (_sqlConnection?.State != ConnectionState.Closed)
                    _sqlConnection?.Close();
            }

            return dataSet;
        }

    }
}