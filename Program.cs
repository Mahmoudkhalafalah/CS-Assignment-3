using System.Diagnostics;
using System.Text;

namespace Assignment_3
{
    enum DAYS
    {
        SUNDAY = 1, MONDAY = 2, TUESDAY = 3, WEDNESDAY = 4, THURSDAY = 5, FRIDAY = 6, SATURDAY = 7
    }
    internal class Program
    {
        public static bool CheckExistence(string? first, string? second)
        {
            if (first == null || second == null) return false;

            foreach (var c in first)
            {
                if (second.Contains(c)) return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //#region Question 1
            //string productsList = "";
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < 5000; i++)
            //{
            //    productsList += "PROD-" + i + ',';
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            //// bad practice because a new string will be created in the heap with each iteration
            //StringBuilder productList = new StringBuilder();
            //stopwatch.Restart();
            //stopwatch.Start();
            //for (int i = 0; i < 5000; i++)
            //{
            //    productList.Append($"PROD-{i}, ");
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

            //#endregion

            //#region Question 2
            //DAYS day = DAYS.MONDAY;
            //Console.WriteLine("Which day? ");
            //if (!Enum.TryParse<DAYS>(Console.ReadLine(), true, out day))
            //{
            //    Console.WriteLine("Invaild day");
            //}
            //else
            //{
            //    double price = 0;
            //    int age = 0;
            //    Console.WriteLine("How old are you? ");
            //    if (int.TryParse(Console.ReadLine(), out age))
            //    {

            //        Console.WriteLine("Do you have valid Id? y/N");
            //        var validId = Console.ReadLine() == "y";



            //        if (age < 5)
            //        {
            //            price = 0;
            //            Console.WriteLine("Free Ticket Because you are uder 5.");
            //        }
            //        else if (age <= 12)
            //        {
            //            price += 30;
            //            Console.WriteLine("Ticket price for older than 5 and under 12 is 30");
            //        }
            //        else if (age < 59)
            //        {
            //            price += 50;
            //            Console.WriteLine("Ticket price for older than 12 and under 39 is 40");
            //        }
            //        else if (age >= 60)
            //        {
            //            price += 25;
            //            Console.WriteLine("Ticket for older than 60 is 25");
            //        }

            //        if (validId && age > 5)
            //        {
            //            price *= 0.8;
            //            Console.WriteLine("20% discount for students");
            //        }
            //        if (age > 5 && (day == DAYS.SATURDAY || day == DAYS.FRIDAY))
            //        {
            //            price += 10;
            //            Console.WriteLine("+10 for WeekEnd days");
            //        }
            //        Console.WriteLine("Final Price: {0}", price);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Age");
            //    }
            //}
            //#endregion

            //#region Question 3
            //string fileExtension = ".pdf";
            //string fileName;

            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileName = "PDF Document";
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileName = "Word Document";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileName = "Excel SpreadSheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileName = "Image File";
            //        break;
            //    default:
            //        fileName = "unknown Type";
            //        break;
            //}

            //fileName = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".doc" or ".docx" => "Word Document",
            //    ".xls" or ".xlsx" => "Excel",
            //    ".jpg" or ".png" or ".gif" => "Image",
            //    _ => "unknown Type"
            //};

            //#endregion

            //#region Question 4
            //int temp = 35;
            //string advice = temp < 0 ? "Freezing! Stay indoors." : temp < 15 ? "Cold! Wear a jacket." : temp < 25 ? "Pleasant Weather." : temp < 35 ? "Warm. Stay Hydrated." : "Hot! Avoid sun exposure.";
            //// No, ?. is readable when a single line if and else only if there is multiple lines or else if it is not useful
            //#endregion

            //#region Question 5
            //string? password;
            //bool eightChars, capitalLetter, oneDigit, spaces;
            //int trials = 0;
            //do
            //{
            //    Console.WriteLine("Enter a password");
            //    password = Console.ReadLine();
            //    eightChars = password?.Length < 8;
            //    capitalLetter = CheckExistence(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //    oneDigit = CheckExistence(password, "0123456789");
            //    spaces = password?.Contains(' ') ?? false;
            //    if (!eightChars) Console.WriteLine("The password has to be 8 letters at  least");
            //    if (!capitalLetter) Console.WriteLine("The password must contain at least 1 capital letter");
            //    if (spaces) Console.WriteLine("The password shouldn't contain spaces");
            //    if (!oneDigit) Console.WriteLine("The password must contain at least 1 digit");

            //    trials++;
            //    if (trials == 5)
            //    {
            //        Console.WriteLine("Account Locked"); break;
            //    }
            //} while (!eightChars || !capitalLetter || !oneDigit || spaces);
            //if (eightChars || capitalLetter || oneDigit || !spaces)
            //{
            //    Console.WriteLine("Password accepted!");
            //}
            //#endregion

            #region Question 6
            int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            foreach (int score in scores)
                Console.Write(score < 50 ? $"Failing Score: {score}\n" : "");

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 90)
                {
                    Console.WriteLine($"the first score 90 is at index {i}");
                    break;
                }
            }
            int total = 0;
            foreach (int score in scores)
                if (score > 40)
                    total += score;

            Console.WriteLine($"Average: {total / scores.Length}");

            int[] grades = { 0, 0, 0, 0, 0 };

            foreach (int score in scores)
            {
                if (score >= 90) grades[0]++;
                else if (score >= 80) grades[1]++;
                else if (score >= 70) grades[2]++;
                else if (score >= 60) grades[3]++;
                else grades[4]++;
            }
            Console.WriteLine($"A: {grades[0]}");
            Console.WriteLine($"B: {grades[1]}");
            Console.WriteLine($"C: {grades[2]}");
            Console.WriteLine($"D: {grades[3]}");
            Console.WriteLine($"F: {grades[4]}");
            #endregion

        }
    }
}
