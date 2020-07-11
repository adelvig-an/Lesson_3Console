using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3Console
{
    public abstract class DataPointHelper 
    { 
        public abstract bool Write(string filePath, IEnumerable<DataPoint> dataPoints); 
        public abstract IEnumerable<DataPoint> Read(string filePath); 
    }
}
