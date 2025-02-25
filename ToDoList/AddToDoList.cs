using MySql.Data.MySqlClient;

namespace ToDoList;

public class AddToDoList
{
    public static void AddTasks(MySqlConnection connection)
    {
        Console.WriteLine("Podaj TYTUŁ jakich ma miec task");
        var title = Console.ReadLine();

        Console.WriteLine("Podaj OPIS jaki ma miec");
        var description = Console.ReadLine();

        string addquestion = "INSERT INTO tasks (Title,Description) VALUES (@Title,@Description)";
        using (var add = new MySqlCommand(addquestion, connection))
        {
            add.Parameters.AddWithValue("@Title", title);
            add.Parameters.AddWithValue("@Description", description);
            add.ExecuteScalar();
        }
    }
}