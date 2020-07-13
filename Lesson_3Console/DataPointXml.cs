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
            FileStream fstream = null;
            try
            {
                fstream = new FileStream(filePath, FileMode.OpenOrCreate);
                XmlSerializer serializer = new XmlSerializer(typeof(IEnumerable<DataPoint>));
                TextWriter textWriter = new StreamWriter(filePath);
                serializer.Serialize(textWriter, dataPoints);
                textWriter.Close();
                //string json = JsonConvert.SerializeObject(dataPoints);
                //File.WriteAllText(filePath, json);
                return true;
            }
            catch
            {
                if (fstream != null)
                    fstream.Close();
                return false;
            }
        }
    }
}
