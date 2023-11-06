using System;
namespace Choi {
    class Program {
        static void Main() {
            string input = Console.ReadLine();
            string[] inputs = input.Split();

            int hour = Int32.Parse(inputs[0]);
            int minute = Int32.Parse(inputs[1]);
            
            int timeInMinutes = hour * 60 + minute;
            timeInMinutes -= 45;
            timeInMinutes += 60 * 24;

            timeInMinutes = timeInMinutes % (60 * 24);

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;

            string hourString = hour.ToString();
            string minuteString = minute.ToString();

            string result = hourString + " " + minuteString;

            Console.WriteLine(result);
        }
    }
}