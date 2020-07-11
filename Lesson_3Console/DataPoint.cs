using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3Console
{
    public class DataPoint
    {
        public float X { get; set; }
        public float Y { get; set; }
        public string Value { get; set; }
        public override string ToString() => $"({X}, {Y}) : {Value}";
    }
}
