using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace elab
{
   public class ArrayMethod
    {
        public int GetCount(int[] mass)
        {
            int counter = 0;
            int maxElem = -2;

            if (mass.Sum() % mass.Length != 0)
            {
                return -1;
            }
            else if (mass.Length == 1)
            {
                return 0;
            }
            else if (mass.Length == 2)
            {
                return (mass[0] + mass[1]) / 2;
            }
            else
            {
                int[] checker = new int[mass.Length];
                for (int i = 0; i < checker.Length; i++) checker[i] = 0;
                int max2 = -1;
                
                int num = mass.Sum() / mass.Length;
                
                // Цикл по всем элементам массива
                // От 0 до размера массива
                while (mass.Distinct().Count() != 1)
                {
                    int minVal = mass.Min();
                    int indexMin = Array.IndexOf(mass, minVal);
                    int max = -1;
                    int index = -1;
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (max < mass[i])
                        {
                            max2 = max;
                            max = mass[i];
                            index = i;
                        }
                    }
                    checker[index] = 1;
                    maxElem = mass[index];
                    int indexOfMin = MinOfNeigh(mass, index, indexMin,checker);
                    int cot = (mass[index] - num);
                    counter += cot;
                    mass[index] -= cot;
                    mass[indexOfMin] += cot;
                }
                return counter;
            }
        }
        private int MinOfNeigh(int[] mass, int index, int indexOfMinValue, int[] checker)
        {
            if (index == mass.Length - 1)
            {
                if (mass[0] < mass[index - 1]) return 0;
                else if (mass[0] == mass[index - 1]) return 0;
                else { return index - 1; }
            }
            else if (index == 0)
            {
                if (mass[mass.Length - 1] < mass[1]) return mass.Length - 1;
                else if (mass[mass.Length - 1] == mass[1]) return mass.Length - 1;
                else { return 1; }
            }
            else
            {
                if (mass[index - 1] < mass[index + 1]) { 
                    if(checker[index-1]!=1)
                    return index - 1;
                    else { return index + 1; }
                
                }
                else if (mass[index - 1] == mass[index + 1]) return MinOfPair(mass,index);
                else {
                    if (checker[index + 1] != 1)
                        return index + 1;
                    else { return index - 1; }
                }
            }
        }
        private int MinOfPair(int[] mass, int index)
        {
            return (mass[index - 1] + mass[index - 2] < mass[index + 1] + mass[index + 2]) ? index - 1 : index + 1;
        }
    }
}
