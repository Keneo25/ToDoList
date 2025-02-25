using MySql.Data.MySqlClient;

namespace ToDoList;

public class CheckToDoList
{
    public static void CheckList(MySqlConnection connection)
    {
        var counterTaskIdQuestion = "SELECT COUNT(*) FROM tasks";
        var taskIdCounter = 0;
        using (var cmd = new MySqlCommand(counterTaskIdQuestion, connection))
        {
            taskIdCounter = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Liczba taskow to:" + taskIdCounter);
        }
    }
}