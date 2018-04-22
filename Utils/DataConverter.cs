using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class DataConverter
    {
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(str.Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries),
                (v) => StrToValue<T>(v));
        }

        public static string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return String.Join(separator, arr);
        }
    }
}
