using MySql.Data.MySqlClient;

namespace ToDoList;

public class ShowToDoList
{

    public static void ShowList(MySqlConnection connection)
    {
      
        var showAllTitle = "SELECT Title,Description FROM tasks";
        using (var show = new MySqlCommand(showAllTitle, connection))
        {
            var  ss = show.ExecuteReader();
            while (ss.Read())
            {
                Console.WriteLine("Tytuł: " + ss.GetString(0));
                Console.WriteLine("opis: " + ss.GetString(1));
                Console.WriteLine(" ");
            }
        }
        
        
        
        
    }
    
    
    
}