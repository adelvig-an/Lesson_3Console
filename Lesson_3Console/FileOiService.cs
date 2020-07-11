using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lesson_3Console
{
    public abstract class FileOiService
    {
        private readonly string PATH;

        public FileOiService()
        {

        }

        //public IEnumerable<Student> LoadData()
        //{
        //    var fileExist = File.Exists(PATH);
        //    if (fileExist == true)
        //    {
        //        File.ReadAllLines(PATH);
        //        return new IEnumerable<Student>();
        //    }
        //    Console.WriteLine("Файл отсутствует");
            
            
        //}

        public void SaveData(string path, IEnumerable<Student> studentList)
        {
            File.WriteAllLines(path, studentList.Select(student => student.ToString()));
        }
    }
}
