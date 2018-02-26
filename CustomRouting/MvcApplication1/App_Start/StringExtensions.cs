using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace MvcApplication1.App_Start
{
    public static partial class StringExtensions
    {
        public static string ToPascal(this string stringToConvert)
        {
            if (stringToConvert == null)
                return null;

            return CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(stringToConvert.ToLower());
        }

        public static int TryGetHashCode(this string value)
        {
            return value == null ? 0 : value.GetHashCode();
        }

        public static string[] ToUpper(this string[] stringArrayToConvert)
        {
            if (stringArrayToConvert == null)
                return null;

            var c = (string[])stringArrayToConvert.Clone();

            for (var i = 0; i < c.Length; i++)
                c[i] = c[i].ToUpper();

            return c;
        }

        public static string[] ToLower(this string[] stringArrayToConvert)
        {
            if (stringArrayToConvert == null)
                return null;

            var c = (string[])stringArrayToConvert.Clone();

            for (var i = 0; i < c.Length; i++)
                c[i] = c[i].ToLower();

            return c;
        }

        public static bool CaseIgnoreEquals(this string str1, string str2)
        {
            return str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool TrimmedCaseIgnoreEquals(this string str1, string str2)
        {
            return str1.Trim().CaseIgnoreEquals(str2.Trim());
        }

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        /// <summary>
        /// Creates a shortend version of a string, with optional follow-on characters.
        /// </summary>
        /// <param name="stringToShorten">The string you wish to shorten.</param>
        /// <param name="newLength">
        /// The new length you want the string to be (nearest whole word).
        /// </param>
        public static string ShortenString(this string stringToShorten, int newLength)
        {
            if (newLength > stringToShorten.Length) return stringToShorten;

            int cutOffPoint = stringToShorten.IndexOf(" ", newLength - 1);

            if (cutOffPoint <= 0)
                cutOffPoint = stringToShorten.Length;

            return stringToShorten.Substring(0, cutOffPoint);
        }

        public static string AddSpacesBetweenWords(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;
            var sb = new StringBuilder(str.Length * 2);
            sb.Append(str[0]);
            for (var i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    sb.Append(' ');
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public static string EncodeToBase64(this string str)
        {
            var b = Encoding.ASCII.GetBytes(str);
            return Convert.ToBase64String(b);
        }

        public static string DecodeFromBase64(this string str)
        {
            var b = Convert.FromBase64String(str);
            return Encoding.ASCII.GetString(b);
        }

        public static string HtmlFormatSpecialChars(this string strInput)
        {
            var strSpecialChars = "“,\"|”,\"|´,'|`,'|’,'|·,&middot;|©,&copy;|®,&reg;|™,&#8482|è,&egrave;|é,&eacute;|½,&frac12;|¼,&frac14;|¾,&frac34;".Split('|');
            var sb = new StringBuilder(strInput);
            foreach (string strChars in strSpecialChars)
            {
                var strChar = strChars.Split(',');
                sb.Replace(strChar[0], strChar[1]);
            }
            return sb.ToString();
        }

        public static long? ConvertToNullableLong(string value)
        {
            long output;
            if (long.TryParse(value, out output))
            {
                return output;
            }
            return null;
        }

        public static int? ConvertToNullableInt(string value)
        {
            int output;
            if (int.TryParse(value, out output))
            {
                return output;
            }
            return null;
        }

        public static bool IsNumeric(string value)
        {
            var regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(value);
        }

        public static bool IsAlphaNumeric(string value)
        {
            var regex = new Regex("^[a-zA-Z0-9]*$");
            return regex.IsMatch(value);
        }

        public static string ToJavascriptArray(this IEnumerable<string> stringArrayToConvert)
        {
            return string.Format("new Array({0})", string.Join(",", stringArrayToConvert.Select(e => string.Format("'{0}'", e))));
        }

        public static int? ToNullableInt(this string value)
        {
            int convertedValue;
            if (int.TryParse(value, out convertedValue) && convertedValue > 0) return convertedValue;
            return null;
        }

        public static decimal? ToNullableDecimal(this string value)
        {
            decimal convertedValue;
            if (decimal.TryParse(value, out convertedValue) && convertedValue > 0) return convertedValue;
            return null;
        }

        public static DateTime? ToNullableDateTime(this string value)
        {
            DateTime convertedValue;
            if (DateTime.TryParse(value, out convertedValue) && convertedValue != DateTime.MinValue) return convertedValue;
            return null;
        }

        public static int ToInt(this string value)
        {
            int convertedInt;
            int.TryParse(value, out convertedInt);
            return convertedInt;
        }

        public static long ToLong(this string value)
        {
            long convertedLong;
            long.TryParse(value, out convertedLong);
            return convertedLong;
        }

        public static bool ToBoolean(this string value)
        {
            bool convertedInt;
            bool.TryParse(value, out convertedInt);
            return convertedInt;
        }

        public static string ToUpperIgnoreNull(this string value)
        {
            if (value != null)
            {
                value = value.ToUpper(CultureInfo.InvariantCulture);
            }
            return value;
        }

        public static bool IsSafeCharacterMatch(this string value)
        {
            var regex = new Regex(@"^[^<>]{1,30}$");
            return regex.IsMatch(value);
        }

        public static bool IsCountryMatch(this string value)
        {
            var regex = new Regex(@"^.{1,20}$");
            return regex.IsMatch(value);
        }

        public static bool IsStateMatch(this string value)
        {
            var regex = new Regex(@"^.{2}$");
            return regex.IsMatch(value);
        }

        public static bool IsPhoneMatch(this string value)
        {
            var regex = new Regex(@"^[0-9\(\)+-^ext.\sx]{10,20}$");
            return regex.IsMatch(value.ToLower());
        }

        public static bool IsPoBoxMatch(this string value)
        {
            var regex = new Regex(@"^p.?\s?o.?\s*box.*|^(p.?\s?o.?\s?|pob|box)\s?#?[0-9]+|^post office box");
            return regex.IsMatch(value.ToLower());
        }

        public static bool IsZipCodeMatch(this string value)
        {
            var regex = new Regex(@"^[^<>]{5,10}$");
            return regex.IsMatch(value);
        }

        public static bool IsAddressMatch(this string value)
        {
            var regex = new Regex(@"^[^<>]{1,75}$");
            return regex.IsMatch(value);
        }

        public static string ToStoreNumber(this int storeNumber)
        {
            return string.Format("{0}{1}", storeNumber > 0 && storeNumber < 10 ? "0" : "", storeNumber);
        }

        public static string RandomAlphabets(int length = 1)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomAlphaNumeric(int length = 1)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string TruncateString(this string text, int length)
        {
            text = text ?? string.Empty;

            return ((text.Length > length) ? text.Remove(length) : text);
        }
    }
}