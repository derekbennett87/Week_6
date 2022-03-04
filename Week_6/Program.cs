using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_6
{

   public class Program
    {
        public static void Main(string[] args)

        {
            ProblemOne();
            ProblemTwo();
        }
        public static void ProblemOne()
        {
            var names = new List<string>();
            while (true)
            {
                var name = GetName();
                if (string.IsNullOrEmpty(name))
                    break;

                names.Add(name);
                Console.WriteLine(NameMessage(names));

            }
        }
        public static string GetName()
        {
            Console.WriteLine("Enter a name. If you would like too exit leave blank and press enter.");
            return Console.ReadLine();
        }
        public static string NameMessage(List<string> names)
        {
            if (names.Count > 2)
                return names[0] + ", " + names[1] + " and " + GetLikes(names).Count + "  liked the post";
            if (names.Count == 2)
                return names[0] + "and " + names[1] + " liked the post";

            return names[0] + " liked the post";

        }
        public static List<string> GetLikes(List<string> names)
        {
            return names.GetRange(2, names.Count - 2);
        }
/// <summary>End of Program One 
/// ///////////////////
/// </summary>Start of Program 2 
        public static void ProblemTwo()
        {
            Dictionary<string, int> stringlist = new Dictionary<string, int>();

            Console.WriteLine("Please enter a sentence ");
            string s = Console.ReadLine();
             
            foreach (char ch in s)
                {
                String cStrg = ch.ToString();
                 if (stringlist .ContainsKey(cStrg))
                {
                    stringlist[cStrg] += 1;
                }
                 else
                {
                    stringlist.Add(cStrg, 1);
                }
            }
            stringlist.Remove(" ");
            int count3 = stringlist.Count;
            Console.WriteLine(" ");
            foreach (KeyValuePair<string, int> a in stringlist)
            {
                Console.WriteLine(a.Key + "  " + a.Value);
            }
        }
    }
}

        
    

    