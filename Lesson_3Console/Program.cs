using System;
using System.Collections.ObjectModel;

namespace Lesson_3Console
{
    class Program
    {
        public static ObservableCollection<Student> StudentList { get; set; }

        public Student Student { get; }

        static void Main(string[] args)
        {
            var testData = new Student[]
            {
                new Student(),
                new Student()
            };

            new FileTxt().SaveData("temp.txt", testData);
        }
    }
}
