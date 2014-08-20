using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using AnomalEvent.Properties;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace AnomalEvent.Classes
{
    class AnomalEventConnection
    {
        public static String SQLConnection = Settings.Default.DatabaseConnection;
        private static SqlConnection connection;

        public static Boolean CreateConnection()
        {
            try
            {
                var conn = Connection;
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла проблема при подключении к базе данных");
                return false;
            }
            return true;
        }
        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    
                    connection = new SqlConnection(SQLConnection);
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        MessageBox.Show("Возникла проблема подключения к Базе Данных");
                        Application.Exit();
                    }

                }
                return connection;
            }
            set { connection = value; }
        }
    }
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Place { get; set; }
        public int Guest { get; set; }

        public int IsPerson { get; set; }

        public static List<User> getList()
        {
            var list = new List<User>();
            list = AnomalEventConnection.Connection.Query<User>(@"
                    SELECT * 
                    FROM Users
                    WHERE IsPerson = 1").ToList();
            return list;
        } 
    }

    public class Authorizer
    {
        public static Boolean IsCorrect(string Login, string Password)
        {
            User result = (AnomalEventConnection.Connection).Query<User>(@" SELECT * FROM Users Where Login = @Login AND Password = @Password",
                new { Login = @Login, Password = @Password}).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public static User GetUser(string Login)
        {
            return (AnomalEventConnection.Connection).Query<User>(@" SELECT * FROM Users Where Login = @Login",
                new { Login = @Login}).FirstOrDefault();
        }

        public static User Instance;
    }

    class EventSystem
    {
        public String Id { get; set; }
        public String Name { get; set; }

    }

    public class AnEvent
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int? Id { get; set; }
        public DateTime EventDateTime { get; set; }
        public int? DepartmentId { get; set; }
        public int? EventCategoryId { get; set; }
        public String Description { get; set; }
        public int? ReliableEnergySystemId { get; set; }
        public int? CorrectiveMeasureId { get; set; }

        public int? OutfitId { get; set; }

        public String Report { get; set; }

        public int? ClassifiedBy { get; set; }

        public int? RegisteredBy { get; set; }


        public static List<AnEvent> getList()
        {
            var list = new List<AnEvent>();
            list = AnomalEventConnection.Connection.Query<AnEvent>(@"
                    SELECT * 
                    FROM AnEvents").ToList();
            return list;
        }
    }

    public class Category
    {
        public int? Id { get; set; }
        public String Name { get; set; }


        public static List<Category> getList()
        {
            var list = new List<Category>();
            list = AnomalEventConnection.Connection.Query<Category>(@"
                    SELECT * 
                    FROM Categories").ToList();
            return list;
        }
    }

    public class Department
    {
        public int? Id { get; set; }
        public String Name { get; set; }

        public static List<Department> getList()
        {
            var list = new List<Department>();
            list = AnomalEventConnection.Connection.Query<Department>(@"
                    SELECT * 
                    FROM Departments").ToList();
            return list;
        }
    }

    public class CorrectiveAction
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int? Id { get; set; }

        public String Name { get; set; }
        public int? ExecutorId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CuratorId { get; set; }
        public DateTime DateEnd { get; set; }
        public String Content { get; set; }
        public String Compliance { get; set; }
        public String FailReaason { get; set; }
        public String ExecutionStatus { get; set; }
        public int? EventId { get; set; }
        public int? Finished { get; set; }
        public String MemoNumber { get; set; }
        public DateTime MemoDate { get; set; }
    }

}
