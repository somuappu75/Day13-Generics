using System;

namespace Find_Maximum_Problem
{
 public class Program : IComparable
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
        }
       
        /// <summary>
        /// find maximun
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns>maximum number of 3 integers</returns>
        public int IntegerMaximum(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0)
            {
                return (num1.CompareTo(num3) > 0) ? num1 : num3;
            }
            else
            {
                return (num2.CompareTo(num3) > 0) ? num2 : num3;
            }
        }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
