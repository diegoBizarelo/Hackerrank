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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {
        int count = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] != i + 1) {
                count = change(arr, i, count);
            }
        }
        return count;
    }

    static int change(int[] a, int i, int c) {
        int aux = a[i];
        a[i] = a[aux-1];
        a[aux -1] = aux;
        if (a[i] != i + 1) {
            c = change(a, i, c);
        }
        return c + 1;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
