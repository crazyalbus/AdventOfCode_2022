using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOCSolutions
{
    public static class Solutions
    {
        public static int Day1a(string path)
        {
            int maxFood = 0;
            int tempFood = 0;

            
            foreach (string line in File.ReadLines(path))
            {
                if(String.IsNullOrEmpty(line))
                {
                    tempFood = 0;
                }
                else
                {
                    int food;
                    if (Int32.TryParse(line, out food))
                    {
                        tempFood += food;
                        if(tempFood > maxFood)
                            maxFood = tempFood;
                    }                  
                }
            }
            return maxFood;
        }

        public static int Day1b(string path)
        {
            ArrayList stashes = new ArrayList();
            int tempFood = 0;
            int maxFood = 0;

            foreach (string line in File.ReadLines(path))
            {
                if (String.IsNullOrEmpty(line))
                {
                    stashes.Add(tempFood);
                    tempFood = 0;
                }
                else
                {
                    int food;
                    if (Int32.TryParse(line, out food))
                    {
                        tempFood += food;
                    }
                }
            }
            
            stashes.Add(tempFood);
            stashes.Sort();

            for(int i = stashes.Count - 1; i > stashes.Count - 4; i--)
            {
                maxFood += (int) stashes[i];
            }

            return maxFood;
        }
    }
}
