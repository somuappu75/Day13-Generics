using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Problem
{
    class FindMaximumValue
    {
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
                    value3;

        public GenericType TestMaximum(GenericType value1, GenericType value2, GenericType value3)
        {
            if (value1.CompareTo(value2) > 0)
                return (value1.CompareTo(value3) > 0) ? value1 : value3;
            else
                return (value2.CompareTo(value3) > 0) ? value2 : value3;
        }
    }
}
