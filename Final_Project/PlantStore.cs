﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Final_Project
{
    public static class PlantStore
    {
        public static List<Plant> Plants = new List<Plant>();
        public static void Initializer()
        {
            StreamReader sr = new StreamReader("../../usdaplants_sm.csv");
            int index = 0;
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var r = line.Split(',');
                Plants.Add(new Plant(r[0], r[1], r[2], r[3], r[4], r[5], r[6],
                    r[7], r[8], r[9], r[10], r[11], r[12], r[13], r[14], r[15], r[16]));
                index++;
            }
        }
    }
}
