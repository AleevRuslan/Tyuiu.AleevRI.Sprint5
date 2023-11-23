﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AleevRI.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0, res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {
                            if (count == 6)
                            {
                                res++;
                                count = 0;
                            }
                            count = 0;
                        }
                        else
                        {
                            count++;
                        }
                    }
                }
                return res;
            }
          
        }
    }
}
