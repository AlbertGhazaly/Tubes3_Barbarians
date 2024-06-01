using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LogicLibrary.AlayMatcher
{
    class AlayMatcher
    {
        public static bool AlayMatch(string normal, string alay)
        {
            string pattern = @"";
            var numberMap = new Dictionary<char, string>
            {
                { 'A', "4" },
                { 'E', "3" },
                { 'G', "6" },
                { 'I', "1" },
                { 'O', "0" },
                { 'S', "5" },
                { 'Z', "2" }
            };
            string vowels = "aeiouAEIOU";
            foreach (char c in normal)
            {
                if(numberMap.ContainsKey(char.ToUpper(c)))
                {
                    if(vowels.Contains(c))
                    {
                        pattern+=$"(?:{c}|{numberMap[char.ToUpper(c)]}|{(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))})?";
                    }
                    else
                    {
                        pattern+=$"(?:{c}|{numberMap[char.ToUpper(c)]}|{(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))})";
                    }
                }
                else if(vowels.Contains(c)){
                    pattern+=$"({c}|{(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))})?";
                }
                else
                {
                    pattern+=$"({c}|{(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))})";
                }
            }
            Console.WriteLine($"Pattern : {pattern}");
            
            Regex regex = new Regex(pattern);
            Match match = regex.Match(alay);
            if (match.Success)
            {
                Console.WriteLine($"Found match: {match.Value}");
                return true;
            }
            else
            {
                Console.WriteLine("No match found.");
                return false;
            }

        }       
    }
}
