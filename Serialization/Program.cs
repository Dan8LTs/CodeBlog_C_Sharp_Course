using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Serialisation
{
    class Program
    { 
        // Есть несколько видов сериализации(перевода файлов и т.п в бинарный код): Soap, Bin, Xml.
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, "Group " + i));
            }

            for (int i = 0; i < 300; i++)
            {
                var studen = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };
                students.Add(studen);
            }
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups);
            }
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = (List<Group>)binFormatter.Deserialize(file) as List<Group>;

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();


            var soapFormatter = new SoapFormatter();

            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, groups.ToArray());
            }
            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                var newGroups = (Group[])soapFormatter.Deserialize(file) as Group[];

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();


            var xmlFormatter = new XmlSerializer(typeof(List<Group>));
            using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, groups);
            }
            using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            {
                var newGroups = (List<Group>)xmlFormatter.Deserialize(file) as List<Group>;

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();

            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, students);
            }
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                var newStudents = (List<Student>)jsonFormatter.ReadObject(file) as List<Student>;

                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
