using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Lesson_3Console
{
    public class DataPointXml : DataPointHelper
    {
        public override IEnumerable<DataPoint> Read(string filePath)
        {
            throw new NotImplementedException();
        }

        public override bool Write(string filePath, IEnumerable<DataPoint> dataPoints)
        {
            //FileStream fstream = null;
            try
            {
                using var fstream = new FileStream(filePath, FileMode.OpenOrCreate);
                XmlSerializer serializer = new XmlSerializer(typeof(IEnumerable<DataPoint>));
                serializer.Serialize(fstream, dataPoints);
                //string json = JsonConvert.SerializeObject(dataPoints);
                //File.WriteAllText(filePath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
