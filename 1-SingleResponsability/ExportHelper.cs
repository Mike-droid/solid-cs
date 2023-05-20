using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper<T>
    {
        public void ExportData(IEnumerable<T> data, Func<T, string> toStringFunc)
        {
            string csv = string.Join(",", data.Select(toStringFunc).ToArray());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in data)
            {
                sb.AppendLine(toStringFunc(item));
            }
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.csv"), sb.ToString(), Encoding.Unicode);
        }
    }
}
