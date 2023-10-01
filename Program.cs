// See https://aka.ms/new-console-template for more information
//interactively parse through the different words in text file by first character etc.
using System;
using System.IO;

string[] wordArray = File.ReadAllLines(@"C:\Users\pernl\source\repos\String Program\words.txt");

foreach (var word in wordArray)
{
    if(word  == "zoo")
    {
        Console.WriteLine(word);
    }
}
