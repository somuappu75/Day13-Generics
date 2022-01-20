using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Problem
{
     public class FindMaximumValue
    {
        public static void main(String[] args)
        {
            Find_Maximum_Problem<int> findMax = new Find_Maximum_Problem<int>();
            findMax.MaxMethod(3, 4, 8, 1, 60);
            Find_Maximum_Problem<int> findmax = new Find_Maximum_Problem<int>(5, 7, 9);
            findMax.TestMaximum();
        }
        //Integer Max
        public int IntegerMaximum(int value1, int value2, int value3)
        {
            if (value1.CompareTo(value2) > 0)
                return (value1.CompareTo(value3) > 0) ? value1 : value3;
            else
                return (value2.CompareTo(value3) > 0) ? value2 : value3;
        }

        //Float Max
        public float FloatMaximum(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0)
                return (num1.CompareTo(num3) > 0) ? num1 : num3;
            else
                return (num2.CompareTo(num3) > 0) ? num2 : num3;
        }
        //String Max
        public string StringMaximum(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0)
                return (str1.CompareTo(str3) > 0) ? str1 : str3;
            else
                return (str2.CompareTo(str3) > 0) ? str2 : str3;
        }


    }
    //method to Find MAx  using Generics #
    public class Find_Maximum_Problem<GenericType> where GenericType : IComparable
    {

        GenericType value1,
                    value2,
                    value3,
                    maxValue;
        
        
        public Find_Maximum_Problem() { }

        public Find_Maximum_Problem(GenericType value1, GenericType value2, GenericType value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public GenericType MaxMethod(params GenericType[] array)
        {
            int length = array.Length;
            Array.Sort(array);
            this.maxValue = array[array.Length - 1];
            PrintMax();
            return this.maxValue;
        }

        public void PrintMax()
        {
            Console.WriteLine($"Maximum value : {this.maxValue}");
        }
        public GenericType TestMaximum()
        {
            if (value1.CompareTo(value2) > 0)
                this.maxValue = (value1.CompareTo(value3) > 0) ? value1 : value3;
            else
                this.maxValue = (value2.CompareTo(value3) > 0) ? value2 : value3;

            PrintMax();
            return maxValue;
        }
    }
}
