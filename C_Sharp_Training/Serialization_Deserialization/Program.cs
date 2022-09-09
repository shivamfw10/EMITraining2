using System;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace Serialization_Deserialization
{
    [Serializable]
    class Employee
    {
        [NonSerialized]
        public int id;
        public string name;
        public string location;
        public Employee(int id, string name, string location)
        {
            this.id = id;
            this.name = name;
            this.location = location;
        }
    }
    class Program
    {
        public static void SerializeData()
        {
            Employee employee = new Employee(1, "Mayura", "Bangalore");
            FileStream fileStream = new
                FileStream("C:\\cSharp\\Demo1.txt",
                FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, employee);
            WriteLine("File Created successfully");
            fileStream.Close();
        }
        public static void DeserlizaData()
        {
            Employee employee;
            FileStream fileStream = new
                 FileStream("C:\\cSharp\\Demo1.txt",
                 FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            employee = (Employee)binaryFormatter.Deserialize(fileStream);
            WriteLine("Deserialize Data is");
            WriteLine($"Name is {employee.name}");
            fileStream.Close();
        }
        static void Main(string[] args)
        {
            SerializeData();
            DeserlizaData();
            ReadLine();
        }
    }
}
