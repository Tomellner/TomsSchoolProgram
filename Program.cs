using System;
using System.Data.SqlClient;

namespace TomsSchoolProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string mainMenuInput;
            string menuInput;
            string secondMenuInput;

            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Database=Toms School;Trusted_Connection=True;MultipleActiveResultSets=true;";

            while (isRunning)
            {
                mainMenuInput = "";
                menuInput = "";
                secondMenuInput = "";
                Console.Clear();
                Console.WriteLine("Välkommen till skoldatabasen! Välj ett alternativ");
                Console.WriteLine("1: Hämta personal");
                Console.WriteLine("2: Hämta alla elever");
                Console.WriteLine("3: Hämta alla elever i en klass");
                Console.WriteLine("4: Hämta alla betyg den senaste månaden");
                Console.WriteLine("5: Hämta lista med kurser och snittbetyg");
                Console.WriteLine("6: Lägg till elev");
                Console.WriteLine("7: Lägg till personal");
                Console.WriteLine("8: Avsluta");
                mainMenuInput = Console.ReadLine();

                switch (mainMenuInput)
                {
                    // Get employees
                    case "1":
                        bool employeeMenuIsRunning = true;
                        while (employeeMenuIsRunning)
                        {
                            Console.Clear();
                            Console.WriteLine("---Hämta personal---");
                            Console.WriteLine("1: All personal");
                            Console.WriteLine("2: Lärare");
                            Console.WriteLine("3: Admins");
                            Console.WriteLine("4: Rektorer");
                            Console.WriteLine("5: Vaktmästare");
                            Console.WriteLine("6: Gå tillbaka");
                            menuInput = Console.ReadLine();

                            switch (menuInput)
                            {
                                case "1":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + ", jobbar som " + reader["Position"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "2":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Position = 'Teacher'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + ", jobbar som " + reader["Position"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Position = 'Admin'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + ", jobbar som " + reader["Position"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "4":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Position = 'Principal'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + ", jobbar som " + reader["Position"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "5":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Position = 'Janitor'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + ", jobbar som " + reader["Position"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "6":
                                    Console.Clear();
                                    employeeMenuIsRunning = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("---Du måste mata in en siffra mellan 1 och 6!---");
                                    break;
                            }
                        }
                        break;
                    // Get all students
                    case "2":
                        bool pupilMenuIsRunning = true;
                        while (pupilMenuIsRunning)
                        {
                            Console.Clear();
                            Console.WriteLine("---Hämta alla elever---");
                            Console.WriteLine("1: Efternamnssorterade, A-Ö");
                            Console.WriteLine("2: Förnamnssorterade, A-Ö");
                            Console.WriteLine("3: Efternamnssorterade, Ö-A");
                            Console.WriteLine("4: Förnamnssorterade, Ö-A");
                            Console.WriteLine("5: Gå tillbaka");
                            menuInput = Console.ReadLine();

                            switch (menuInput)
                            {
                                case "1":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students ORDER BY [Last Name]", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["Last Name"] + ", " + reader["First Name"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "2":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students ORDER BY [First Name]", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students ORDER BY [Last Name] DESC", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["Last Name"] + ", " + reader["First Name"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "4":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students ORDER BY [First Name] DESC", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "5":
                                    Console.Clear();
                                    pupilMenuIsRunning = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("---Du måste mata in en siffra mellan 1 och 5!---");
                                    break;
                            }
                        }
                        break;
                    // Get students from a specific class
                    case "3":
                        bool studentClassMenuIsRunning = true;
                        while (studentClassMenuIsRunning)
                        {
                            Console.Clear();
                            Console.WriteLine("---Hämta elever från en viss klass---");
                            Console.WriteLine("1: TEK");
                            Console.WriteLine("2: SAM");
                            Console.WriteLine("3: MED");
                            Console.WriteLine("4: Gå tillbaka");
                            menuInput = Console.ReadLine();

                            switch (menuInput)
                            {
                                case "1":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Class = 'TEK'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + " går i klass " + reader["Class"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "2":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Class = 'SAM'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + " går i klass " + reader["Class"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Class = 'MED'", sqlConnection);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    Console.WriteLine(reader["First Name"] + " " + reader["Last Name"] + " går i klass " + reader["Class"]);
                                                }
                                            }
                                            Console.WriteLine("Tryck enter för att gå tillbaka");
                                            Console.ReadLine();
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Fel");
                                        }
                                    }
                                    break;
                                case "4":
                                    Console.Clear();
                                    studentClassMenuIsRunning = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("---Du måste mata in en siffra mellan 1 och 4!---");
                                    break;
                            }
                        }
                        break;
                        // Get grades from the last month
                    case "4":
                        Console.Clear();
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                sqlConnection.Open();
                                SqlCommand cmd = new SqlCommand("SELECT * FROM Grades WHERE GradeDate >= DATEADD(MONTH, -1, GETDATE()) AND GradeDate <= GETDATE();", sqlConnection);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine("Betyget " + reader["GivenGrade"] + " gavs ut " + reader["GradeDate"]);
                                    }
                                }
                                Console.WriteLine("Tryck enter för att gå tillbaka");
                                Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Fel");
                            }
                        }
                        break;
                    // Get average grades and highest/lowest grades
                    case "5":
                        Console.Clear();
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                sqlConnection.Open();
                                SqlCommand cmd = new SqlCommand("SELECT AVG(GivenGrade) AS AverageGrade, MAX(GivenGrade) AS HighestGrade, MIN(GivenGrade) AS LowestGrade FROM Grades;", sqlConnection);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine("Snittbetyg: " + reader["AverageGrade"]);
                                        Console.WriteLine("Maxbetyg: " + reader["HighestGrade"]);
                                        Console.WriteLine("Minbetyg: " + reader["LowestGrade"]);
                                    }
                                }
                                Console.WriteLine("Tryck enter för att gå tillbaka");
                                Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Fel");
                            }
                        }
                        break;
                    // Add new student
                    case "6":
                        Console.Clear();
                        Console.WriteLine("---Lägg till ny elev---");
                        Console.WriteLine("Förnamn:");
                        string studentFirstName = Console.ReadLine();
                        Console.WriteLine("Efternamn:");
                        string studentLastName = Console.ReadLine();
                        Console.WriteLine("Klass:");
                        string studentClass = Console.ReadLine();
                        InsertNewStudent(connectionString, studentFirstName, studentLastName, studentClass);
                        break;
                    // Add new employee
                    case "7":
                        Console.Clear();
                        Console.WriteLine("---Lägg till ny anställd---");
                        Console.WriteLine("Förnamn:");
                        string employeeFirstName = Console.ReadLine();
                        Console.WriteLine("Efternamn:");
                        string employeeLastName = Console.ReadLine();
                        Console.WriteLine("Position:");
                        string employeePosition = Console.ReadLine();
                        InsertNewEmployee(connectionString, employeeFirstName, employeeLastName, employeePosition);
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Tack för idag!");
                        isRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("---Du måste mata in en siffra mellan 1 och 8!---");
                        break;
                }
            }
        }


        static void InsertNewStudent(string connectionString, string studentFirstName, string studentLastName, string studentClass)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Students ([First Name], [Last Name], Class) VALUES (@FirstName, @LastName, @Class)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", studentFirstName);
                    command.Parameters.AddWithValue("@LastName", studentLastName);
                    command.Parameters.AddWithValue("@Class", studentClass);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result < 1)
                    {
                        Console.WriteLine("Fel");
                    }
                    else
                    {
                        Console.WriteLine("En ny elev har lagts till!");
                    }
                }
            }
        }

        static void InsertNewEmployee(string connectionString, string employeeFirstName, string employeeLastName, string employeePosition)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Employees ([First Name], [Last Name], Position) VALUES (@FirstName, @LastName, @Position)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", employeeFirstName);
                    command.Parameters.AddWithValue("@LastName", employeeLastName);
                    command.Parameters.AddWithValue("@Position", employeePosition);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result < 1)
                    {
                        Console.WriteLine("Fel");
                    }
                    else
                    {
                        Console.WriteLine("En ny anställd har lagts till!");
                    }
                }
            }
        }




    }
}