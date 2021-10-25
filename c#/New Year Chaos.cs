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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        int count = 0;
        for (int i = (q.Length - 1); i > 0; i--) {
            int q_breaker = 0;
            if (q[i] != i + 1) {
                for (int x = i-1; x > -1; x--) {
                    q_breaker++;
                    if (q_breaker > 2) {
                        Console.WriteLine("Too chaotic");
                        return;
                    } 
                    if (q[x] == i + 1) {
                    for (int k = x; k < x + q_breaker; k++) {
                        int aux = q[k];
                        q[k] = q[k+1];
                        q[k+1] = aux;
                    }
                    break;
                    }
                    
                }
            }
            count += q_breaker;
        }
        Console.WriteLine(count);
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
