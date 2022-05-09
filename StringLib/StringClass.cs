using System.Text.RegularExpressions;
namespace StringLib {
    public class StringClass {

        public static string Reverse(string a) {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string Rotate(string a) {
            List<char> result = new List<char>(); //creates empty character list
            result.Add(a[a.Length - 1]); // adds last character to front of list
            for (int idx = 0; idx < a.Length-1; idx++) {//indexes through rest of string to add them in one at a time after
                result.Add(a[idx]);
            }
            return new string(result.ToArray());//returns string from result list after converted to array
        }
        public static string RemoveVowels(string a) {
            /* using regular expressions a = Regex.Replace(a, "[aeiouyAEIOUY]", "-");

             return a;
            */
            var result = string.Empty;
            foreach (var ch in a.ToCharArray()) {
                switch (ch.ToString().ToLower()) { //switch good for lots of discrete things to account for. use to lower to make sure don't have to check both cases
                    //convert string a to 
                    case "a": break;
                    case "e": break;
                    case "i": break;
                    case "o": break;
                    case "u": break;
                    default:
                    result += ch.ToString();
                    break;
                }
            }
            return result;
        }

        }
    }
