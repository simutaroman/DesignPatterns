using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {
        List<object> parts = new List<object>();
        public void Add(object part)
        {
            parts.Add(part);
        }
        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var part in parts)
            {
                var type = part.GetType().ToString();
                if (type == "System.String")
                    sb.AppendLine(part as String);
                else
                    sb.AppendLine(type);
            }
            return sb.ToString();
        }
    }
}
