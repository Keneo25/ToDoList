using MySql.Data.MySqlClient;

namespace ToDoList;

public class DeleteToDoList
{

    public static void DeleteList(MySqlConnection connection)
    {
        var showToDelete = "SELECT TaskID,Title FROM tasks";
        using (var show = new MySqlCommand(showToDelete, connection))
        {
            var ss = show.ExecuteReader();
            while (ss.Read())
            {
                Console.WriteLine("ID:" + ss.GetInt32(0));
                Console.WriteLine("Tytuł: " + ss.GetString(1));
                Console.WriteLine(" ");
            }

            ss.Close();
        }
        Console.WriteLine("Napisz liczbe ID którą chcesz usunąć: ");
        var numberOfDelete = Console.ReadLine();
        var dd = int.Parse(numberOfDelete);
        var deleteMysql = "DELETE FROM tasks WHERE TaskID = @TaskID ";
        using (var delete = new MySqlCommand(deleteMysql, connection))
        {
            delete.Parameters.AddWithValue("@TaskID", dd);
            delete.ExecuteScalar();
        }
    }
}