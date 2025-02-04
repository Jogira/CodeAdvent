﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;


const Int32 BufferSize = 128;
using (var fileStream = File.OpenRead("../../../input.txt"))
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
{
    List<int> leftList = new List<int>();
    List<int> rightList = new List<int>();

    string line;
    while ((line = streamReader.ReadLine()) != null)
    {
        string[] row = line.Split("   ");

        if (row.Length >= 2)
        {
            leftList.Add(int.Parse(row[0]));
            rightList.Add(int.Parse(row[1]));
        }
    }
    leftList.Sort();
    rightList.Sort();

    int totalDistance = 0;
    for (var x = 0; x < leftList.Count; x++)
    {
        totalDistance += Math.Abs(leftList[x] - rightList[x]);
    }

    Console.WriteLine(totalDistance);

}


