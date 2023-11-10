using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    public static int ParseInt(string s)
    {
        return WordsToInt(SeparateToWords(s));
    }

    private static List<string> SeparateToWords(string s)
    {
        List<string> words = new List<string>();
        for (int index = 0, start = 0, stringLen = s.Length; index < stringLen; index++)
        {

            if (!Char.IsLetter(s[index]))
            {
                words.Add(s.Substring(start, index - start));
                start = index + 1;
            }
            if (index == stringLen - 1)
            {
                words.Add(s.Substring(start));
            }
        }
        return words;
    }

    private static int WordsToInt(List<string> words)
    {
        int result = 0, totalResult = 0;
        for (int i = 0, end = words.Count - 1; i <= end; i++)
        {
            if (nums.ContainsKey(words[i]))
            {
                int current = nums[words[i]];

                    switch ((Orders)current)
                    {
                        case Orders.Hundred:
                            result *= current;
                            break;
                        case Orders.Thousand:
                            result *= current;
                            totalResult += result;
                            result = 0;
                            break;
                        case Orders.Million:
                            return current;
                        default:
                            result += current;
                            break;
                    }
            }
        }
        return result + totalResult;
    }

    private static Dictionary<string, int> nums = new Dictionary<string, int>()
    {
        {"and", 0 },
        {"one",1 },
        {"two",2},
        {"three",3},
        {"four",4},
        {"five",5 },
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9},
        {"ten", 10},
        {"eleven", 11},
        {"twelve", 12},
        {"thirteen", 13},
        {"fourteen", 14},
        {"fifteen", 15},
        {"sixteen", 16},
        {"seventeen", 17},
        {"eighteen", 18},
        {"nineteen", 19},
        {"twenty", 20},
        {"thirty", 30},
        {"forty", 40},
        {"fifty", 50},
        {"sixty", 60},
        {"seventy", 70},
        {"eighty", 80},
        {"ninety", 90},
        {"hundred", 100},
        {"hundreds", 100},
        {"thousand", 1_000},
        {"million", 1_000_000},
        {"thousands", 1_000},
        {"millions", 1_000_000},
    };

    private enum Orders
    {
        Hundred = 100,
        Thousand = 1000,
        Million = 1000_000,
    }
}