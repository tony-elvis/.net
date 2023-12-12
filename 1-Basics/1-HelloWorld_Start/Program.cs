// using System;
// using System.Collections.Generic;

// public class WeightedAverage
// {
//     public static double Mean(IList<int> numbers, IList<int> weights)
//     {
//         if((numbers.Count != weights.Count) ||
//          (numbers.Count == 0 || weights.Count == 0) ||
//          (numbers == null || weights == null)){
//             throw new Exception("error");
//         }
        
//         int total = 0;
//         int totalWeights = 0;
//         for (int i = 0; i < numbers.Count; i++)
//         {
//             total += numbers[i] * weights[i];
//             totalWeights += weights[i];
//         }
//         return total / totalWeights;
//     }

//     public static void Main(string[] args)
//     {
//         int[] values = new int[] { 2, 3 };
//         int[] weights = new int[] { 4, 2 };

//         Console.WriteLine(WeightedAverage.Mean(values, weights));
//     }
// }

// using System;
// using System.Collections.Generic;

// public class WeightedAverage
// {
//     public static double Mean(IList<int> numbers, IList<int> weights)
//     {
//         if ((numbers.Count != weights.Count) ||
//             (numbers.Count == 0 || weights.Count == 0) ||
//             (numbers == null || weights == null))
//         {
//             throw new Exception("Error: Invalid input");
//         }

//         int total = 0;
//         int totalWeights = 0;
//         for (int i = 0; i < numbers.Count; i++)
//         {
//             total += numbers[i] * weights[i];
//             totalWeights += weights[i];
//         }

//         if (totalWeights == 0)
//         {
//             throw new Exception("Error: Total weight cannot be zero.");
//         }

//         // Convertir al menos uno de los operandos a double antes de la división
//         return (double)total / totalWeights;
//     }

//     public static void Main(string[] args)
//     {
//         int[] values = new int[] { 2, 3 };
//         int[] weights = new int[] { 4, 2 };

//         try
//         {
//             Console.WriteLine(WeightedAverage.Mean(values, weights));
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }



// using System;
// using System.Collections.Generic;

// public class Hobbies
// {
//     private readonly Dictionary<string, string[]> hobbies = new Dictionary<string, string[]>();
    
//     public void Add(string hobbyist, params string[] hobbies)
//     {
//         this.hobbies.Add(hobbyist, hobbies);
//     }
    
//     public List<string> FindAllHobbyists(string hobby)
//     {
        
//         List<string> people = new List<string>() { "Steve", "Chad" };
//         foreach (var index in Enumerable.Range(111, 3))
//         {
//             Console.WriteLine($"Student {index} is {students2[index].FirstName} {students2[index].LastName}");
//         }
//         return people;
//     }
    
//     public static void Main(string[] args)
//     {
//         Hobbies hobbies = new Hobbies();
//         hobbies.Add("Steve", "Fashion", "Piano", "Reading");
//         hobbies.Add("Patty", "Drama", "Magic", "Pets");
//         hobbies.Add("Chad", "Puzzles", "Pets", "Yoga");

//         hobbies.FindAllHobbyists("Yoga").ForEach(item => Console.WriteLine(item));
//     }
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Hobbies
// {
//     private readonly Dictionary<string, string[]> hobbies = new Dictionary<string, string[]>();

//     public void Add(string hobbyist, params string[] hobbies)
//     {
//         this.hobbies.Add(hobbyist, hobbies);
//     }

//     public List<string> FindAllHobbyists(string hobby)
//     {
//         List<string> hobbyists = new List<string>();

//         foreach (var kvp in hobbies)
//         {
//             string hobbyist = kvp.Key;
//             string[] hobbiesList = kvp.Value;

//             if (hobbiesList.Contains(hobby, StringComparer.OrdinalIgnoreCase))
//             {
//                 hobbyists.Add(hobbyist);
//             }
//         }

//         return hobbyists;
//     }

//     public static void Main(string[] args)
//     {
//         Hobbies hobbyManager = new Hobbies();
//         hobbyManager.Add("Steve", "Fashion", "Piano", "Yoga");
//         hobbyManager.Add("Patty", "Drama", "Magic", "Pets");
//         hobbyManager.Add("Chad", "Puzzles", "Pets", "Yoga");

//         hobbyManager.FindAllHobbyists("Yoga").ForEach(item => Console.WriteLine(item));
//     }
// }



// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Prefix
// {
//     public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
//     {
//         // throw new InvalidOperationException("Waiting to be implemented.");
//         IEnumerable<string> u;
//         foreach(string word in words){
//             u = word.Substring (prefixLength);

//         }

//         return u;
        
//     }
    
//     public static void Main(string[] args)
//     {
//         // Should print "flo", "fle", and "fla" since those are the distinct, length 3 prefixes.
//         foreach (var p in AllPrefixes(3, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
//             Console.WriteLine(p);
//     }
// }

using System;
using System.Collections.Generic;

public class Prefix
{
    public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
    {
        //List<string> result = new List<string>();
         HashSet<string> result = new HashSet<string>();

        foreach (string word in words)
        {
            if (word.Length >= prefixLength)
            {
                string prefix = word.Substring(0, prefixLength);
                result.Add(prefix);
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        // Should print "flo", "fle", and "fla" since those are the distinct, length 3 prefixes.
        foreach (var p in AllPrefixes(3, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
            Console.WriteLine(p);
    }
}


//////
// using System;

// public class ChineseBox
// {
//     private readonly ChineseBox containedBox;

//     public ChineseBox() { }

//     public ChineseBox(ChineseBox containedBox)
//     {
//         this.containedBox = containedBox;
//     }

//     public int NumberOfSmallerBoxes
//     {
//         get
//         {
//             throw new System.NotImplementedException("Waiting to be implemented.");
//         }
//     }

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(new ChineseBox(new ChineseBox()).NumberOfSmallerBoxes);
//     }
// }

// using System;

// public class ChineseBox
// {
//     private readonly ChineseBox containedBox;

//     public ChineseBox() { }

//     public ChineseBox(ChineseBox containedBox)
//     {
//         this.containedBox = containedBox;
//     }

//     public int NumberOfSmallerBoxes
//     {
//         get
//         {
//             if (containedBox == null)
//             {
//                 return 0;
//             }
//             else
//             {
//                 return 1 + containedBox.NumberOfSmallerBoxes;
//             }
//         }
//     }

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(new ChineseBox(new ChineseBox(new ChineseBox())).NumberOfSmallerBoxes);
//     }
// }

// SELECT *
// FROM CITY
// WHERE CountryCode = 'USA' AND Population > 100000;

// SELECT COUNT(CITY) - COUNT(DISTINCT CITY) AS Difference
// FROM STATION;


// SELECT CITY, LENGTH(CITY) AS Length
// FROM STATION
// ORDER BY LENGTH(CITY), CITY
// LIMIT 1;


// SELECT CITY, LENGTH(CITY) AS Length
// FROM STATION
// ORDER BY LENGTH(CITY) DESC, CITY
// LIMIT 1;

// SELECT DISTINCT CITY
// FROM STATION
// WHERE CITY REGEXP '^[aeiouAEIOU]';

// SELECT DISTINCT CITY
// FROM STATION
// WHERE LEFT(CITY, 1) IN ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U');


// SELECT DISTINCT CITY
// FROM STATION
// WHERE RIGHT(CITY, 1) IN ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U');


// SELECT DISTINCT CITY
// FROM STATION
// WHERE LOWER(LEFT(CITY, 1)) IN ('a', 'e', 'i', 'o', 'u') AND LOWER(RIGHT(CITY, 1)) IN ('a', 'e', 'i', 'o', 'u');

// SELECT DISTINCT CITY
// FROM STATION
// WHERE LOWER(LEFT(CITY, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');

// SELECT DISTINCT CITY
// FROM STATION
// WHERE LOWER(LEFT(CITY, 1)) NOT IN ('a', 'e', 'i', 'o', 'u')
//    OR LOWER(RIGHT(CITY, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');

