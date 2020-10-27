using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace ReadCSV
{
    class CSV
    {

        static public List<string[]> Read(string path, string delimiter,int RowNumbers=-1)
        {
            using TextFieldParser parser = new TextFieldParser(path);

            
            parser.Delimiters = new string[] { delimiter };
            List<String[]> csv = new List<String[]>();
            string[] fields = null;
            if (RowNumbers < 0)
            {
                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    csv.Add(fields);
                }
            }
            else if (RowNumbers > 0)
            {
                int count = 0;
                while ((!parser.EndOfData) && (count < RowNumbers) )
                {
                    fields = parser.ReadFields();
                    csv.Add(fields);
                    count++;
                }

            }
                       
            parser.Close();
            return csv;

        }

        static public bool IsFirstRowNames(string path, string delimiter, Type[] types)
        {
            List<string[]> csv = Read(path, delimiter, 1);
            bool result = true;
            string[] row = csv[0];
            Type[] detectedTypes = new Type[row.Length];
            int count = 0;

            foreach (string field in row)
            {
                detectedTypes[count] = DetectType(field);
                count++;
            }

            foreach(Type t in detectedTypes)
            {
                if (t != typeof(string))
                    return false;
            }

            foreach (Type t in types)
            {
                if (t != typeof(string))
                    return true;
            }

            return false;
        }
        

        static public bool isNullField(string field)
        {
            field.Trim();
            return field == "";
        }

        static public Type[] DetectTypes(string path, string delimiter)
        {
            int RowNumber = 100;
            List<string[]> csv = Read(path, delimiter, RowNumber);
            int dim = csv[0].Length;
            Type[] Types = new Type[dim];
            csv.RemoveAt(0); //remove the first row (they can be the variable names)

            for (int i = 0; i < dim; i++)
            {
                Dictionary<Type, int> detectedTypes = new Dictionary<Type, int>();           
                foreach (string[] row in csv)
                {
                    Type t = DetectType(row[i]);

                    if (t != null)
                    {
                        if (detectedTypes.ContainsKey(t))
                            detectedTypes[t]++;
                        else
                            detectedTypes.Add(DetectType(row[i]), 1);
                    }
                    
                }


                if (detectedTypes.ContainsKey(typeof(string)))
                {
                    Types[i] = typeof(string);
                }
                else if (detectedTypes.ContainsKey(typeof(double)))
                {
                    Types[i] = typeof(double);
                }
                else if (detectedTypes.ContainsKey(typeof(Int64)))
                {
                    Types[i] = typeof(Int64);
                }
                else if (detectedTypes.ContainsKey(typeof(Int32)))
                {
                    Types[i] = typeof(Int32);
                }
                else if (detectedTypes.ContainsKey(typeof(bool)))
                {
                    Types[i] = typeof(bool);
                }
                else if (detectedTypes.ContainsKey(typeof(DateTime)))
                {
                    Types[i] = typeof(DateTime);
                }
                else
                {
                    Types[i] = typeof(string);
                }


            }

            return Types;

        }
            

        static public Type DetectType(String str)
        {
            Int32 intValue;
            Int64 bigintValue;
            double doubleValue;
            bool boolValue;
            DateTime dateValue;

            str.Trim();
            if (str == "")
                return null;
            if (bool.TryParse(str, out boolValue))
                return boolValue.GetType();
            if (DateTime.TryParse(str, out dateValue))
                return dateValue.GetType();
            if (Int32.TryParse(str, out intValue))
                return intValue.GetType();
            if (Int64.TryParse(str, out bigintValue))
                return bigintValue.GetType();
            if (double.TryParse(str, out doubleValue))
                return doubleValue.GetType();

            return str.GetType();

        }


        static public int FieldCount(string delimiter, string path) 
        {

            using TextFieldParser parser = new TextFieldParser(path);
            parser.Delimiters = new string[] { delimiter };
            string[] parts = parser.ReadFields();
            parser.Close();
            return parts.Length;
        }


        static public string DetectDelimiter(string path)
        {
            string[] delimiters = { ",", ";", "^", "/", "\\" };
            int max= 0, dim = 0;
            string delimiter=",";

            foreach (string d in delimiters)
            {
                dim = CheckDelimiter(d, path);
                if (dim > max)
                {
                    max = dim;
                    delimiter = d;
                }
            }

            return delimiter;

        }

        private static int CheckDelimiter(string delimiter,string path)
        {
            using TextFieldParser parser = new TextFieldParser(path);
            parser.Delimiters = new string[] { delimiter };
            string[] parts = parser.ReadFields();
            parser.Close();
            return parts.Length;
            
        }
    }
}
