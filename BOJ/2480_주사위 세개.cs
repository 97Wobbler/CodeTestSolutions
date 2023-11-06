using System;
using System.Collections.Generic;
using System.Linq;

namespace Choi {
    class Program {
        static void Main() {
            string[] inputs = Console.ReadLine().Split();
            int[] inputArray = inputs.Select(int.Parse).ToArray();

            Dictionary<int, int> counts = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 } };

            foreach (int input in inputArray) {
                counts[input]++;
            }

            if (counts.Values.Contains(3)) {
                When3ValueSame(counts);
            } else if (counts.Values.Contains(2)) {
                When2ValueSame(counts);
            } else {
                WhenAllValuesDiffers(inputArray);
            }
        }

        static void When3ValueSame(Dictionary<int, int> counts) {
            int key = counts.FirstOrDefault(x => x.Value == 3).Key;
            int result = key * 1000 + 10000;
            Console.WriteLine(result);
        }

        static void When2ValueSame(Dictionary<int, int> counts) {
            int key = counts.FirstOrDefault(x => x.Value == 2).Key;
            int result = key * 100 + 1000;
            Console.WriteLine(result);
        }

        static void WhenAllValuesDiffers(int[] inputArray) {
            int key = inputArray.Max();
            int result = key * 100;
            Console.WriteLine(result);
        }
    }
}