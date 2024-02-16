using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    // from C# Players Guide
    internal static class StringExtensions
    {
        public static string ToAlternating(this string text)
        {
            string result = "";
            bool isCapital = true;
            foreach (char letter in text)
            {
                result += isCapital ? char.ToUpper(letter) : char.ToLower(letter);
                isCapital = !isCapital;
            }
            return result;
        }
    }
}
