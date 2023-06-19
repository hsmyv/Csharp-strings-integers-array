using System;
using System.Text;

namespace firstproject
{
    class Program
    {
        static void Main(string[] args)
        {

            #region arrays
            /* //multidimensional array
            int[,] nums =
            {
                {1,2,3 },
                {4,5,6 }
            };
            Console.WriteLine(nums[0,2]);
            */

            /* //Resize 
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Resize(ref numbers, 8);
            Console.WriteLine(numbers.Length);
            */
            #endregion

            #region StringMethods
            /*
              string name = "Hello World";
              string s = "";
              Console.WriteLine(name.Length);
              Console.WriteLine(name.StartsWith("H"));
              Console.WriteLine(name.EndsWith("d"));
              Console.WriteLine(name.Replace("o", "s"));
              Console.WriteLine(name.Remove(1,2));
              Console.WriteLine(name.Substring(1,2));
              Console.WriteLine(name.Trim(new char[] {' '}));
              Console.WriteLine(string.IsNullOrEmpty(s));
              Console.WriteLine(string.IsNullOrEmpty(name));
              */

            /*
            reverse("Hasan");
            Console.WriteLine(BuilderReverse("Hasan"));
            */
            #endregion


            #region integers
            /*
              int a = 5;
              Console.WriteLine(a);
              CheckNumber(out a);
              Console.WriteLine(a);
              */


            /*
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers1[0]);
            int[] numbers2 = numbers1;
            numbers2[0] = 55;
            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers2[0]);
            */
            //CheckArr(numbers1);
            //Console.WriteLine(numbers1[0]);
            #endregion

            #region
            /*
            string[] students = {"Nihad", "Nejla", "Hasan", "Nijat"};
            int[] ages = { 12, 243, 5, 6, 3, 34 };
            GetAges(ages);
            // checkName(students);
            */
            #endregion

        }

        #region Reverse
        static StringBuilder BuilderReverse(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result.Append(str[i]);
            }
            return result;
        }
        static void reverse(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);

            }
        }

        #endregion


        #region integers
        /*
             static void CheckNumber(out int num)
        {
            num = 1000;
            Console.WriteLine($"Method num : {num}");
        }

        static void CheckArr(int[] nums)
        {
            nums[0] = 1000;
            Console.WriteLine($"Method num: { nums[0]}");
        }
         */
        #endregion


        #region forandforeach
        /*
        static void checkName(string[] students)
        {

            //for (int i = 0; i < students.Length; i++)
            //{
            //    if(students[i] == "Hasan")
            //    {
            //        Console.WriteLine("Finded");
            //    }
            //}

            foreach (var item in students)
            {
                Console.WriteLine(item);
                if (item == "Hasan")
                {
                    Console.WriteLine("Finded using  foreach");
                    return;
                }
            }
        }

        static void GetAges(int[] ages)
        {
            foreach (var item in ages)
            {
                bool isOld = IsOld(item);
                if(isOld)
                {
                    Console.WriteLine("It is true");
                }
            }
        }


        static bool IsOld(int age)
        {
            if (age > 30)
                return true;

            return false;
            
        }
        */
        #endregion

    }
}
