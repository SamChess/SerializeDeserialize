using System;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Lab1
{

    class Program
    {
        static void Main(string[] args)
        {

            var student = new Student();
            student.FirstName = "Samuel";
            student.LastName = "Mulwa";
            student.Age = 21;

            //Serialize
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(student.GetType());
            x.Serialize(Console.Out, student);
            Console.WriteLine();
            Console.ReadLine();
GCNotificationStatus init
            //Deserialize an xml file    
            XmlSerializer deserializer = new XmlSerializer(typeof(Student));
            System.IO.TextReader reader = new System.IO.StreamReader(@"D:\lab1\src\Lab1\deserialize.xml");
            object obj = deserializer.Deserialize(reader);
            Student XmlData = (Student)obj;
            Console.WriteLine(XmlData);
            reader.Close();
        }
    }
}
