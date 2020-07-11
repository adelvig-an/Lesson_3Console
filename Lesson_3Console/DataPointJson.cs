using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson_3Console
{
    public class DataPointJson : DataPointHelper
    {
        public override IEnumerable<DataPoint> Read(string filePath)
        {
            throw new NotImplementedException();
            //return
            //    File.ReadLines(filePath)
            //    .Select(Parse);
        }
        public override bool Write(string filePath, IEnumerable<DataPoint> dataPoints)
        {
            try 
            {
                string json = JsonConvert.SerializeObject(dataPoints);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
