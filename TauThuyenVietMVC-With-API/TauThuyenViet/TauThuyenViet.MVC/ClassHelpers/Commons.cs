using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TauThuyenViet.ClassHelpers
{
    public static class Commons
    {
        public static string ToUrlFormat(this string value)
        {
            string result = value;
            result = value.Replace(" ", "-").Replace("/", "-");
            Regex regex = new Regex("-+");
            result = regex.Replace(result, "-");
            //Bỏ dấu
            regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            result = result.Normalize(NormalizationForm.FormD);
            result = regex.Replace(result, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            return result.ToLower();
        }

        public static string GetFirstImage(this string value)
        {
            if (value == null)
                return string.Empty;

            string[] array = value.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            return array[0];
        }
    }
}
