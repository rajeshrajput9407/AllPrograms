using NUnit.Framework;
using System;

namespace AllPrograms {
    public class Tests {
        String input = String.Empty;

        [SetUp]
        public void Setup()
        {
            input = "India";
        }

        [Test]
        public void CSharpprogramtoFindLengthofString()
        {
            int l = 0;
            foreach (char item in input) {
                l += 1;
            }
            Console.WriteLine("length of India is {0}", l);
        }

        [Test]
        public void CompareTwoStrings()
        {
            String A = "rajesh";
            String B = "rajesh";

            if (A == B) {
                Console.WriteLine("Equals");
            } else {
                Console.WriteLine("Not equals");
            }
        }

        [Test]
        public void ReverseString()
        {
            String reverse = String.Empty;
            int length = input.Length-1;
            while (length>=0) {
                reverse = reverse + input[length];
                length--;
            }
            Console.WriteLine(reverse);
        }

    }
}