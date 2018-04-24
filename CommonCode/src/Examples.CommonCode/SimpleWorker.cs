using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;

namespace Examples.CommonCode
{
    public class SimpleWorker
    {
        public string DoWork(IEnumerable<string[]> records)
        {
            if (records == null)
            {
                throw new ArgumentNullException(nameof(records));
            }

            using (var writer = new StringWriter())
            {
                using (var serializer = new CsvSerializer(writer))
                {
                    foreach (var record in records)
                    {
                        serializer.Write(record);
                        serializer.WriteLine();
                    }
                }
                return writer.GetStringBuilder().ToString();
            }
        }
    }
}
