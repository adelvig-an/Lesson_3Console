using System;
using System.Collections.ObjectModel;

namespace Lesson_3Console
{
    class Program
    {
        //public static ObservableCollection<Student> StudentList { get; set; }

        //public Student Student { get; }

        static void Main(string[] args)
        {
            //var testData = new Student[]
            //{
            //    new Student(),
            //    new Student()
            //};

            //new FileTxt().SaveData("temp.txt", testData);

            const string filePath = "temp_2.josn"; 
            var dataPoint1 = new DataPoint(); 
            var dataPoint2 = new DataPoint() { X = 10, Y = 30, Value = "Test" }; 
            var dataPoints = new DataPoint[] { dataPoint1, dataPoint2 }; 
            Console.WriteLine("Тест"); 
            foreach (var dp in dataPoints) 
            { 
                Console.WriteLine(dp); 
            }

            //DataPointHelper helper = new DataPointTxt(); 
            //var b = helper.Write(filePath, dataPoints); 
            //Console.WriteLine(b ? "Записано" : "Ошибка");

            //var dataPointsR = helper.Read(filePath); 
            //Console.WriteLine("Считываем"); 
            //foreach (var dp in dataPointsR) 
            //{ 
            //    Console.WriteLine(dp); 
            //}


            DataPointHelper helper = new DataPointJson();
            var b = helper.Write(filePath, dataPoints);
            Console.WriteLine(b ? "Записано" : "Ошибка");
        }
    }
}
