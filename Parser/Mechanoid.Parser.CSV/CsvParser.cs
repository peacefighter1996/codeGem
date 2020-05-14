using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Mechanoid.Parser.CSV
{
    public class CsvParser<T> : Parser.DataLoader<T>
    {
        readonly bool hasHeader;
        public CsvParser(bool hasHeader = false)
        {
            this.hasHeader = hasHeader;
        }

        public T ParseDocument(string filePath)
        {
            throw new NotImplementedException();
        }

        public T[] ParseMultiObjectDocument(string filePath)
        {
            var stream = new StreamReader(filePath);
            List<T> resultList = new List<T>();
            var row = string.Empty;
            bool firstrow = true;
            do
            {
                row = stream.ReadLine();
                if (!string.IsNullOrWhiteSpace(row)&& !firstrow)
                {
                    var DataType = typeof(T);
                    var obj = typeof(T).GetConstructor(Type.EmptyTypes)?.Invoke(null);
                    if (obj == null) throw (new InvalidCastException());
                    var properties = DataType.GetProperties();
                    string[] objects = row.Split(',');
                    for (int i = 0; i < objects.Length-1; i++)
                    {
                        if (properties[i].PropertyType == typeof(string))
                        {
                            DataType.GetProperty(properties[i].Name)
                                .GetSetMethod()
                                ?.Invoke(obj, new object[1] { (object)objects[i] });
                        }
                        else if (properties[i].PropertyType == typeof(int))
                        {
                            DataType.GetProperty(properties[i].Name)
                                .GetSetMethod()
                                ?.Invoke(obj, new object[1] { int.Parse(objects[i]) });
                        }

                    }
                    resultList.Add((T)obj);
                }

                firstrow = false;
            } while (row != null);
            return (resultList.ToArray());

        }

    }
}
