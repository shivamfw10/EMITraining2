using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialiazation_Deserialization // Note: actual namespace depends on the project name.
{
    [XmlRoot("EmployeeDetails")]
    public class Program {
        public class Employee
        {
            [XmlAttribute("EmployeeId")]
            public int id;
            [XmlAttribute("EmployeeName")]
            public string name;
            [XmlAttribute("EmployeeLocation")]
            public string location;
        }

        public static void SerializaData(Employee emp)
        {
            FileStream fileStream = new FileStream("C:\\cSharp\\Demo2.txt",
                FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            xmlSerializer.Serialize(fileStream, emp);
            fileStream.Close();
        }



        public static void DeSerialzeData()
        {
            FileStream fileStream = new FileStream("C:\\cSharp\\Demo2.txt",
              FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            Employee emp = (Employee)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            Console.WriteLine($"Name {emp.name} location {emp.location} ");
        }



        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter ID,Name and Location");
            employee.id = Convert.ToInt32(Console.ReadLine());
            employee.name = Console.ReadLine();
            employee.location = (Console.ReadLine());
            SerializaData(employee);
            DeSerialzeData();
            Console.ReadLine();
        }
    }
}