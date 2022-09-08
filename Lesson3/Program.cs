using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            ///שרשור מחרוזת אך ורק בסימן פלוס
            string firstName = "yarin ";
            string af = " shaer";
            string cc = firstName + af;
            Console.WriteLine(cc);

            //אופרטורים 
            int num1 = 5;
            int num2 = 2;
            double sum = num1 + num2;
            Console.WriteLine("sum : {0}", sum);
            sum = num1 - num2;
            Console.WriteLine("sum : {0}", sum);
            sum = num1 / num2;
            Console.WriteLine(sum);
            sum = num1 % num2;
            Console.WriteLine(sum);
            sum = num1 * num2;
            Console.WriteLine(sum);

            //להגדיר 2 משתנים מספרים שלמים
            //לעשות כפל ולהציג את התוצאה
            Console.WriteLine(num1 * num2);
            //להגדיר 2 משתנים מסוג מחרוזת לשרשר בניהם ולהציג במסך
            Console.WriteLine(firstName + af);

            Console.WriteLine(" enter a number ");
            int a = int.Parse(Console.ReadLine());//1234
            int b10 = a % 10;
            Console.WriteLine(b10);
            int c100 = (a % 100) / 10;
            Console.WriteLine(c100);
            int d1000 = (a % 1000) / 100;
            Console.WriteLine(d1000);
            int e10000 = (a % 10000) / 1000;
            Console.WriteLine(e10000);
            //Console.WriteLine(ab);

           // אופרטורים יחסיים
            int age = 13;
            bool isMinor = (age > 18);
            Console.WriteLine(isMinor);//false
            isMinor = (age <= 18);
            Console.WriteLine(isMinor);//true
            bool isBarMitzvaAge = (age == 13);
            Console.WriteLine(isBarMitzvaAge);
            bool isFarAwayFromTwenty = (age + 10) > 30;
            Console.WriteLine(isFarAwayFromTwenty);//
            bool isBarMitzvaAgeC = (age != 13); //שונה
            Console.WriteLine(isBarMitzvaAgeC);
            bool isAnd = (age != 13) && (age != 12);
            Console.WriteLine(isAnd);
            isAnd = (age != 13) && (age == 13);
            Console.WriteLine(isAnd);
            isAnd = (age == 12) && (age == 13);
            Console.WriteLine(isAnd);
            bool isOr = (age != 13) || (age != 12);
            Console.WriteLine(isOr);
            isOr = (age < 13) || (age == 13);
            Console.WriteLine(isOr);
            bool isAge13 = (age < 13);
            Console.WriteLine(isAge13);//
            bool isNot = (!(age < 13));
            Console.WriteLine(isNot);
            Console.WriteLine((age == 12) && (age == 13));
            Console.WriteLine(!((age == 12) && (age == 13)));


            //לקלוט מהשתמש את הגילו שלו מספר שלם

            //להדפיס אם המספר שלו קטן מ 30 להדפיס true או  false להציב במשתנה bool  
            // האם המספר שלו קטן מ20 וגם שהמספר שונה מ 2
            //האם המספר שלו קטן מ2 או שהמספר שלו קטן מ10








        }
    }
}
