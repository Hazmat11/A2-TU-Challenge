using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 18) return true;
            else return false;
        }

        public static bool IsEven(int a)
        {
            if ( a % 2 == 0 ) return true;
            else return false;
        }

        public static bool IsDivisible(int a, int b) {
            if ( a % b ==0 ) return true;
            else return false;
        }

        public static bool IsPrimary(int a)
        {
            if (a % 1 == 0 && a % a == 0) return true;
            else return false;
        }

        public static List<int> GetAllPrimary(int a)
        {
            throw new NotImplementedException();
        }

        public static int Power2(int a)
        {
            a = a * a;
            return a;
        }

        public static int Power(int a, int b)
        {
            double c = Math.Pow(a, b);
            int p = (int)c;
            return p;
        }

        public static int IsInOrder(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        public static List<int> Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }
    }
}
