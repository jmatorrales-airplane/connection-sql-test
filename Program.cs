// AIRPLANE_JORDI\MSSQLSERVER01


using System.Data.SqlClient;

class connectionsqltestc{
    public static void Main (String[] args)
    {
        string connetionString;
        SqlConnection cnn;
        connetionString = @"Data Source=AIRPLANE_JORDI\MSSQLSERVER01;Database=test;Integrated Security=True;";
        cnn = new SqlConnection(connetionString);
        cnn.Open();
        Console.WriteLine("Connection Open  !");



        // String query = "create table pruebas (ej1 varchar(10), ej2 varchar(10))"; // crear tabla

        //string query = "insert into pruebas values('hola1', 'adios1');"; // insertar

        //SqlCommand command = new SqlCommand(query, cnn);
        //try
        //{
        //    command.ExecuteNonQuery();
        //    Console.WriteLine("insert successful");
        //}
        //catch (SqlException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        SqlCommand command = new SqlCommand("Select * from pruebas", cnn); // visualizar
        //SqlCommand command = new SqlCommand("Select id from [table1] where name=@zip", conn);
        //command.Parameters.AddWithValue("@zip", "india");
        // int result = command.ExecuteNonQuery();
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                Console.WriteLine(reader["ej1"] + $" {reader["ej2"]}");
            }
        }


        cnn.Close();
    }
}