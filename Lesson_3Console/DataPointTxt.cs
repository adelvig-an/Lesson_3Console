using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lesson_3Console
{
    public class DataPointTxt : DataPointHelper
    {
        public override IEnumerable<DataPoint> Read(string filePath) 
        { 
            //throw new NotImplementedException();
            return 
                File.ReadLines(filePath)
                .Select(Parse);
        }
        public override bool Write(string filePath, IEnumerable<DataPoint> dataPoints) 
        { 
            try 
            { 
                File.WriteAllLines(filePath, dataPoints.Select(dp => dp.ToString())); 
                return true; 
            } 
            catch 
            { 
                return false; 
            } 
        }

        public DataPoint Parse(string str)
        {
            // $"({X}, {Y}) : {Value}";    
            // 1. Разбить строку на две части по ":"    
            var sParts = str.Split(':')
                // удаляем пробельные символы в начале и в конце строк            
                .Select(part => part.Trim())
                .ToArray();
            // проверяем что части на самом деле ровно 2 а не больше или меньше    
            if (sParts.Length != 2)
            {
                throw new ArgumentException("");
            }
            // проверяем что первая часть действительно окружена скобками    
            if (sParts[0].First() != '(' && sParts[0].Last() != ')')
            {
                throw new ArgumentException("");
            }
            // 2.1. Избавиться от окружающих круглых скобок    
            var sCoord = sParts[0].Substring(1, sParts[0].Length - 2);
            // 2.2. Разбить строку по ','    
            var sCoords = sCoord.Split(',');
            // проверяем что чисел на самом деле ровно 2 а не больше или меньше    
            if (sCoords.Length != 2)
            {
                throw new ArgumentException();
            }
            // 2.3. Каждую новую часть преобразовать в float 
            var x = float.Parse(sCoords[0]);
            var y = float.Parse(sCoords[1]);
            // 3. Value имеет тип string так что никаких дополнительных действий не требуется 
            var value = sParts[1];    
            // теперь остается только создать объект DataPoint  
            // все данные уже есть  
            return new DataPoint
            {
                X = x,
                Y = y,
                Value = value
            };
        }
    }
}
