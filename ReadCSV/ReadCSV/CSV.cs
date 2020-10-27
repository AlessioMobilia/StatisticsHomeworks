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

            //get the type of the first row
            foreach (string field in row)
            {
                detectedTypes[count] = DetectType(field);
                count++;
            }

            //check if the type of the csv are all string (in this case nothing can be said and return false)
            foreach(Type t in detectedTypes)
            {
                if (t != typeof(string))
                    return false;
            }

            //check if the type of the first row are all string and in case return true
            foreach (Type t in types)
            {
                if (t != typeof(string))
                    return true;
            }

            return false; //return false if the first string contain value that are not strings
        }
        
        static public bool isNullField(string field)
        {
            field.Trim();
            return field == "";
        }

        static public Type[] DetectTypes(string path, string delimiter, int RowNumber)
        {
            //int RowNumber = 100; //number of row that check for types
            List<string[]> csv = Read(path, delimiter, RowNumber);
            int dim = csv[0].Length;
            Type[] Types = new Type[dim];
            csv.RemoveAt(0); //remove the first row (they can be the variable names)

            //loop the row
            for (int i = 0; i < dim; i++)
            {
                //calculate the distribution of types in the column
                Dictionary<Type, int> detectedTypes = new Dictionary<Type, int>();           
                foreach (string[] row in csv)
                {
                    Type t = DetectType(row[i]); //detect the type of the field

                    if (t != null)
                    {
                        if (detectedTypes.ContainsKey(t))
                            detectedTypes[t]++;
                        else
                            detectedTypes.Add(DetectType(row[i]), 1);
                    }
                    
                }


                //chose the more suitable type for the column
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
            

        //check the time of a string
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

            //return the delimiter that result with more field in the first row of the csv
            foreach (string d in delimiters)
            {
                dim = CheckDelimiter(d, path); //check the number of field with a given delimiter
                if (dim > max)
                {
                    max = dim;
                    delimiter = d;
                }
            }

            return delimiter;

        }

        //check the number of field with a given delimiter
        private static int CheckDelimiter(string delimiter,string path)
        {
            using TextFieldParser parser = new TextFieldParser(path);
            int lenght = 0;
            try
            {
                parser.Delimiters = new string[] { delimiter };
                string[] parts = parser.ReadFields();
                lenght = parts.Length;
            }
            catch
            {
            }
            
            parser.Close();
            return lenght;
            
        }


    }
}
