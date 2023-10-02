// See https://aka.ms/new-console-template for more information
//Interactively parse through certain indices of a string array
//Beginning with cutting the effective size of the inputted array to a lower amount of indicies
//The text file being read from has over 400,000 english words

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


class stringProgram
{

    static void Main(string[] args)
    { 
    string[] wordArray = File.ReadAllLines(@"C:\Users\pernl\source\repos\String Program\words.txt");

        int halveData = wordArray.Length / 100;

        for(int i = 0; i < halveData; i++)
        {
            {
                Console.WriteLine(wordArray[i]);
            }

        }
    }

}