using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    Dictionary<string, int> dm = new Dictionary<string, int>();
        foreach (string word in note)
        {
            if (dictionary.ContainsKey(word))
                dictionary[word] += 1;                
            else
                dictionary.Add(word, 1);
        }
        
        foreach (string word in magazine) {
            if (dm.ContainsKey(word))
                dm[word] += 1;                
            else
                dm.Add(word, 1);
        }

        foreach (string word in dictionary.Keys) {
            if (!dm.ContainsKey(word)) {
                Console.WriteLine("No");
                return;
            }
            if (dictionary[word] > dm[word]) {
              Console.WriteLine("No");
              return;
            }
        }
        
        Console.WriteLine("Yes");
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
