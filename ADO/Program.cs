

using Npgsql;

var connectionString = "host=localhost;db=northwind;uid=bulskov;pwd=henrik";

var connection = new NpgsqlConnection(connectionString);
connection.Open();

var cmd = new NpgsqlCommand();
cmd.Connection = connection;
cmd.CommandText = "select * from categories";

var rdr = cmd.ExecuteReader();

while(rdr.Read())
{
    Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)}");
}
