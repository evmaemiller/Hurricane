using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello User!");
        Console.Write("Hurricane wind speed (mph): ");
        
        if (double.TryParse(Console.ReadLine(), out double windSpeed)) {
            string outcome = ClassifyHurricane(windSpeed);
            Console.WriteLine($"{outcome}");
        }
    }

    static string ClassifyHurricane(double windSpeed) {
        if (windSpeed >= 157) {
            return "Category Five Hurricane";
        }
        else if (windSpeed >= 130) {
            return "Category Four Hurricane";
        }
        else if (windSpeed >= 111) {
            return "Category Three Hurricane";
        }
        else if (windSpeed >= 96) {
            return "Category Two Hurricane";
        }
        else if (windSpeed >= 74) {
            return "Category One Hurricane";
        }
        else {
            return "Not a hurricane";
        }
    }
}