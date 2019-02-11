using System;
using System.Collections.Generic;
using System.Linq;

namespace CountDuplicates
{
    public class StringCount
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter input string: ");

            string input = Console.ReadLine();

            GetCounts(input.Trim());

            Console.ReadLine();
        }

        public static IEnumerable<KeyValuePair<string, int>> GetCounts(string input)
        {
            Dictionary<string, int> HashTable = new Dictionary<string, int>();

            foreach (char item in input)
            {
                if ((item >= 48 && item <= 57) || (item >= 65 && item <= 90) || ((item >= 97 && item <= 122)))
                {
                    string lower = item.ToString().ToLowerInvariant();
                    if (HashTable.ContainsKey(lower))
                    {
                        int countOld = Convert.ToInt32(HashTable[lower]);
                        HashTable[lower] = ++countOld;
                    }
                    else
                    {
                        HashTable.Add(lower, 1);
                    }
                }
            }

            IEnumerable<KeyValuePair<string, int>> result =
                                            from p in HashTable
                                            where p.Value > 1
                                            select p;

            Console.WriteLine(" Count of more than 1 chars : " + result.Count());

            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            return result;
        }
    }
}
