using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int op = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                op = list1[i] / list2[i];
                result.Add(op);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Out of range");
            }
        }
        return result;
    }
}