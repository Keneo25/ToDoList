using MySql.Data.MySqlClient;

namespace ToDoList
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            { 
                string connectionString = "Server=localhost;Database=ToDoList;Uid=root;Pwd=;";
                MySqlConnection connection;
                
            using (connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Dodawanie
                Console.WriteLine("Witaj w ToDoList");
                Console.WriteLine(
                    "Wpisz 1 jesli chcesz dodac nowy task \nWpisz 2 jesli chcesz zoabczyc liste \nWpisz 3 jesli chcesz zobaczyc liczbe taskow \n" +
                    "Wpisz 4 jesli chcesz usunac task");
                var chose = Console.ReadLine();
                if (int.Parse(chose) == 1)
                {
                    AddToDoList.AddTasks(connection);
                    
                }

                //wyswietlanies
                if (int.Parse(chose) == 2)
                {
                    ShowToDoList.ShowList(connection);
                }

                //Sprawdzenie ile jest 
                if (int.Parse(chose) == 3)
                {
                   CheckToDoList.CheckList(connection);
                }

                if (int.Parse(chose) == 4)
                {
                   DeleteToDoList.DeleteList(connection);
                }
            }
          } 
        }
    }
}