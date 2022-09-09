using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp_Training
{
    class FileIO_Demo
    {
        public void CreateFile() {
            FileStream fileStream = new FileStream("C:\\cSharp\\Demo.txt", FileMode.Create, FileAccess.Write);
            string s = "Welcome to FileDemo";
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(s);
            writer.Close();
            fileStream.Close();
        }
        public void WriteText() {
            FileStream fileStream = new FileStream("C:\\cSharp\\Demo.txt", FileMode.Append, FileAccess.Write);
            string s = "Hello I'm Here";
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(s);
            writer.Close();
            fileStream.Close();
        }
        public void ReadFile() {
            FileStream filestream = new FileStream("C:\\cSharp\\Demo.txt", FileMode.Open, FileAccess.Read);
            string s;
            StreamReader reader = new StreamReader(filestream);
            s = reader.ReadToEnd();
            WriteLine(s);
        }
    }
    internal class Program {
        static void Main(string[] args) {
            FileIO_Demo d = new FileIO_Demo();
            d.CreateFile();
        }
    }
}
