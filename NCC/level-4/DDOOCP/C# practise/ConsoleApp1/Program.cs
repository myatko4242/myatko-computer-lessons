using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C sharp C#
            /*
             * int
             * float
             * double
             * string
             * char
             * bool
             * Console.WriteLine(
             * */
            /* int age;
             age = 20;


             Console.WriteLine("Age is" + age);
             Console.WriteLine(age);
             Console.WriteLine("Hello");

             double price = 20.22;
             Console.WriteLine(price);
             Console.WriteLine("Price is " + price);

             string name = "Khin Thida";
             Console.WriteLine(name);

             char grade = 'A';
             Console.WriteLine("Your grade is " + grade);

             bool martial = true;
             Console.WriteLine("Your martial status is "+martial);

             int num1 = 10;
             num1 = num1 + 1;
             Console.WriteLine(num1);
             //single line comment
             /* multi line comment
              * 
              */
            /*num1 = ++num1; 
           Console.WriteLine(num1);

           int age1 = 20;
           if (age1 > 16 == true) { Console.WriteLine("You can attend Our uni"); }

           int num2 = 20;
            // post increment num = 20, num21
           Console.WriteLine(num2++); // 20 - 21
           Console.WriteLine(num2++); // 21 - 22
           Console.WriteLine(num2++); // 22 - 23

           int num3 = 20;  // pre increment
           Console.WriteLine(++num3); //21
           Console.WriteLine(++num3); //22

           int age3 = 20;
           int num10 = 20 + 30;
           num2++; //unary operator

           int x = 10;
           int y = 5;

           int z = x + y;
           Console.WriteLine(z);
           Console.WriteLine(x + y);
           Console.WriteLine("Subtration result is " + (x - y));

           z = x * y;
           Console.WriteLine("Multiplication result is " + z);

           // 20 + 3 
           // "Your age is " + 20;

           Console.WriteLine("Your age is " + (20 + 3));

           z = x / y; // 10/5 = // remainder = 0' quptient =2
           Console.WriteLine("The quotient is " + z);

           z = x % y;
           Console.WriteLine("The remainder is " + z); // 0

           int a = 5;
           int b = 10;

           Console.WriteLine( a == b );
           bool c = (a == b );
           Console.WriteLine(c); // false

           c = (a > b );
           Console.WriteLine(c); // false

           c = (a < b);
           Console.WriteLine(c); // true

           c = (a >= b);  // a > b or a == b
           Console.WriteLine(c); // false

           c = (a <= b); // a < b or a == b
           Console.WriteLine(c); // true

           bool aa = true;
           bool bb = false;
           bool cc = aa && bb;  // && all true then true. one false then all fasle

           bool aaa = true;
           bool bbb = false;
           bool rrr = aaa || bbb;
            Console.WriteLine("Result of all operator is " + rrr);
           // Console.WriteLine("Result of Logical operator AND is " + rrr);
           Console.WriteLine("NOt aaa is " + !aaa);

           // assingment operator

           int numa = 10;
           Console.WriteLine(numa);

           // numa = numa + 5;

           numa += 5;
           Console.WriteLine("answer "+ numa);

           int numb = 10;
           // numb = numb - 5;
           numb -= 5;
           Console.WriteLine("the answer is "+numb);

           int numc = 10;
           //numc = numc * 5;
           numc *= 5;
           Console.WriteLine("the answer is "+numc);

           int numd = 10;
           //numd = numd / 5;
           numd /= 5;
           Console.WriteLine("the answer is "+numd);

           int nume = 10;
           //nume = nume % 3;
           nume %= 3;
           Console.WriteLine("the remainder is "+nume);

           double sa = 12.33;
           double sb = 10.45;
           double sc = sa + sb;
           Console.WriteLine(sc);
           */

            //grading
            /*int mark = 75;
            if (mark > 90 == true) // == true no need to be honest
            {
                Console.WriteLine("you got grade A");
            }
            else
            {
                Console.WriteLine("you are not in grade A");
            }
            //condition if (mark > 90 == true) {Console.WriteLine("you got grade A");}
            // positive or negetive
            int num1 = 20;
            if (num1 > 0 == true)
            {
                Console.WriteLine("this is positive number");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("this is negetive number");
            }
            else
            {
                Console.WriteLine("the number is positive nor negative");
            }
            // vote or not
            int age = 12;
            if (age > 18 == true)
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("you are not eligible to vote");
            }
            // blood donate or not

            int age2 = 22;
            int lb = 99;
            // logical operator && || !
            if (age2 > 18 == true && lb > 100 == true)
            {
                Console.WriteLine("YOu can donate blood");
            }
            else
            {
                Console.WriteLine("you cannot donate blood");

            }

            int temperature = 35;
            if (temperature > 30)
            {
                Console.WriteLine("very hot");
            }
            else if (temperature >= 20 && temperature <= 30)
            {
                Console.WriteLine("warm");
            }
            else
            {

                Console.WriteLine("normal");
            }
            */
            // 1. Write a program to find maximum between two numbers
            int mgmg = 23;  //1
            int agag = 20;
            if (mgmg < agag)
            {
                Console.WriteLine("the maximum is agag");
            }
            else
            {
                Console.WriteLine("the maximum is mgmg");
            }
            //2. Write a program to find maximum between three numbers
            int aya = 20;  //2
            int mya = 10;
            int nay = 30;
            if (mya > nay && mya > aya)
            {
                Console.WriteLine("the maximum is mya");
            }
            else if (aya > mya && aya > nay)
            {
                Console.WriteLine("the maximum is aya");
            }
            else
            {
                Console.WriteLine("the maximum is nay");
            }
            //3. Write a program to check whether a number is negative, positive or zero
            int num1 = 1; //3
            if (num1 < 0)
            {
                Console.WriteLine("it is negative");

            }
            else if (num1 > 0)
            {
                Console.WriteLine("it is positive");
            }
            else
            {
                Console.WriteLine("it is zero");
            }
            //4.Write a program to check whether a number is divisible by 3 or not
            int num2 = 2; //4
            if (num2 % 3 == 0)
            {
                Console.WriteLine("it is divisible by 3");
            }
            else
            {
                Console.WriteLine("it isn't divisible by 3");
            }
            //5. Write a program to check whether a number is even or odd
            int num3 = 8;  //5
            if (num3 % 2 == 0)
            { Console.WriteLine("it is even"); }
            else
            {
                Console.WriteLine("it is odd");
            }
            //7. Write a program to input any alphabet and check whether it is vowel or consonant
            char jaye = 'R'; // 7
            if (jaye == 'A' || jaye == 'E' || jaye == 'I' ||
                jaye == 'O' || jaye == 'U')
            {
                Console.WriteLine("it is vowel");

            }
            else
            {
                Console.WriteLine("it is consonant");
            }
            //10. Write a program to input week number and print week day
            int number = 8; //10
            if (number == 1)
            {
                Console.WriteLine("it is MON");
            }
            else if (number == 2) {
                Console.WriteLine("it is TUE");
                    }
            else if (number == 3)
            {
                Console.WriteLine("it is WED");
                    }
            else if (number == 4)
            {
                Console.WriteLine("it is THU");
                    }
            else if (number == 5)
            {
                Console.WriteLine("it is FRI");
                    }
            else if (number == 6)
            {
                Console.WriteLine("it is SAT");
                    }
            else if(number == 7)
            {
                Console.WriteLine("it is SUN");
                    }
            else
            {
                Console.WriteLine("it isn't week number");
                    }
            //11. Write a program to input month number and print month Name
            int number1 = 14;  //11
            if (number1 == 1)
            {
                Console.WriteLine("it is JAN");
            }
            else if (number1 == 2)
            {
                Console.WriteLine("it is FEB");
            }
            else if (number1 == 3)
            {
                Console.WriteLine("it is MAC");
            }
            else if (number1 == 4)
            {
                Console.WriteLine("it is APR");
            }
            else if (number1 == 5)
            {
                Console.WriteLine("it is MAY");
            }
            else if (number1 == 6)
            {
                Console.WriteLine("it is JUN");
            }
            else if (number1 == 7)
            {
                Console.WriteLine("it is JUL");
            }
            else if (number1 == 8)
            {
                Console.WriteLine("it is AUG");
            }
            else if (number1 == 9)
            {
                Console.WriteLine("it is SEP");
            }
            else if (number1 == 10)
            {
                Console.WriteLine("it is OCT");
            }
            else if (number1 == 11)
            {
                Console.WriteLine("it is NOV");
            }
            else if (number1 == 12)
            {
                Console.WriteLine("it is DEC");
            }
            else
            {
                Console.WriteLine("it isn't month number");
            }
            //6. Write a program to check whether a character is alphabet or not (a to z or not)
            char word = 'b';
            if ((word >= 'a' && word <= 'z') || (word >= 'A' && word <= 'Z'))
            {
                Console.WriteLine("It is alphabet");
            }
            else
            {
                Console.WriteLine("It isn't alphabet");
            }
            //8. Write a program to input any character and check whether it is alphabet, digit or special character
            char words = '#';
            if ((words >= 'a' && words <= 'z') || (words >= 'A' && words <= 'Z'))
            {
                Console.WriteLine("It is alphabet");
            }
            else if (words >= '0' && words <= '9')
            {
                Console.WriteLine("It is digit");
            }
            else
            {
                Console.WriteLine("It is special character");
            }
            //9. Write a program to check whether a character is uppercase or lowercase alphabet
            char letter = 'c';
            if (letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("It is lower case alphabet");
            }
            else if (letter >= 'A' && letter <= 'Z')
            {
                Console.WriteLine("It is upper case alphabet");
            }
            else
            {
                Console.WriteLine("It is neither");
            }
            //12. Write a program to input a product selling price and buying price then calculate profit or loss 
            int product_selling_price = 100;
            int product_buying_price = 80;
            if (product_buying_price > product_selling_price)
            {
                Console.WriteLine("loss");
            }
            else if (product_buying_price < product_selling_price)
            {
                Console.WriteLine("profit");
            }
            else
            {
                Console.WriteLine("equal");
            }
            /*13.Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer.Calculate average and grade according to following:
            •	Percentage >= 90 % : Grade A
            •	Percentage >= 80 % : Grade B
            •	Percentage >= 70 % : Grade C
            •	Percentage >= 60 % : Grade D
            •	Percentage >= 40 % : Grade E
            •	Percentage < 40 % : Grade F      */
            double physics = 70;
            double Chemistry = 60;
            double Bio = 90;
            double Math = 80;
            double Computer = 70;
            double totalM = physics + Chemistry + Bio + Math + Computer;
            double average = totalM / 5;
            string grade;
            if (average >= 90)
            {
                grade = "A";
            }
            else if (average >= 80)
            {
                grade = "B";
            }
            else if (average >= 70)
            {
                grade = "C";
            }
            else if (average >= 60)
            {
                grade = "D";
            }
            else if (average >= 40)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine("Average percentage " + average + "%");
            Console.WriteLine("Grade " + grade);
            /*14. The marks obtained by a student in 5 different subjects are input through the keyboard. The student gets a division as per the following rules: Write a program to calculate the division obtained by the student
•	Percentage above or equal to 60 - First division
•	Percentage between 50 and 59 - Second division
•	Percentage between 40 and 49 - Third division
•	Percentage less than 40 – Fail     */
            double S1 = 60;
            double S2 = 70;
            double S3 = 70;
            double S4 = 80;
            double S5 = 50;
            double TM = S1 +S2 + S3 +S4 +S5;
            double percentage = TM / 5;
            string division;
            if (percentage >= 60)
            {
                division = "First Division";
            }
            else if (percentage >= 50 && percentage <= 59)
            {
                division = "Second Division";
            }
            else if (percentage >= 40 && percentage <= 49)
            {
                division = "Third Division";
            }
            else
            {
                division = "Fail";
            }
            Console.WriteLine("The student is in " + division);
            //
            //16. Find Youngest Age in Three of Student.
            //Eg: age - 21, 17, 19
           int Aage = 21;
            int Bage = 17;
            int Cage = 19;
            if (Aage < Bage && Aage < Cage)
            {
                Console.WriteLine("student A is the youngest");
            }
            else if (Bage < Aage && Bage < Cage)
            {
                Console.WriteLine("student B is the youngest");
            }
            else if (Cage < Aage && Cage < Bage)
            {
                Console.WriteLine("student C is the youngest");
            }
            else if (Aage == Bage && Aage < Cage)
            {
                Console.WriteLine("student A and B are the youngest");
            }
            else if (Aage == Cage && Aage < Bage)
            {
                Console.WriteLine("student A and C are the youngest");
            }
            else if (Bage == Cage && Bage < Aage)
            {
                Console.WriteLine("student C and B are the youngest");
            }
            else
            {
                Console.WriteLine("all students are same age");
            }
            //18. Write a program that accepts three numbers and check All numbers are equal or two number are equal or all are different.
            int Num1 = 10;
            int Num2 = 10;
            int Num3 = 11;
            if (Num1 == Num2 && Num2 == Num3)
            {
                Console.WriteLine("All numbers are equal.");
            }
            else if (Num1 == Num2 || Num1 == Num3 || Num2 == Num3)
            {
                Console.WriteLine("Two numbers are equal.");
            }
            else
            {
                Console.WriteLine("All numbers are different.");
            }
            //19. Write a program to create a simple calculator
            //20. Write a program to check whether the given integer is a multiple of 5
            int Number = 30;
            if (Number % 5 == 0)
            {
                Console.WriteLine("the integer is a multiple of 5.");
            }
            else
            {
                Console.WriteLine("the integer is not a multiple of 5.");
            }
            //29. Write a program to check whether a character is uppercase or lowercase alphabet.
            char Word = 'b';
            if (Word >= 'a' && Word <= 'z')
            {
                Console.WriteLine("It is lowercase alphabet");
            }
            else if (Word >= 'A' && Word <= 'Z')
            {
                Console.WriteLine("It is uppercase alphabet");
            }
            else
            {
                Console.WriteLine("It isn't alphabet");
            }
            //31. Write a program to read any month number in integer and display the number of days for this month.
            int number11 = 6;  //11
            if (number11 == 1)
            {
                Console.WriteLine("this month have 31 days");
            }
            else if (number11 == 2)
            {
                Console.WriteLine("this month have 28 days sometimes 29 days");
            }
            else if (number11 == 3)
            {
                Console.WriteLine("this month have 31 days");
            }
            else if (number11 == 4)
            {
                Console.WriteLine("this month have 30 days");
            }
            else if (number11 == 5)
            {
                Console.WriteLine("this month have 31 days");
            }
            else if (number11 == 6)
            {
                Console.WriteLine("this month have 30 days");
            }
            else if (number11 == 7)
            {
                Console.WriteLine("this month have 31 days");
            }
            else if (number11 == 8)
            {
                Console.WriteLine("this month have 31 days");
            }
            else if (number11 == 9)
            {
                Console.WriteLine("this month have 30 days");
            }
            else if (number11 == 10)
            {
                Console.WriteLine("this month have 31 days");
            }
            else if (number11 == 11)
            {
                Console.WriteLine("this month have 30 days");
            }
            else if (number11 == 12)
            {
                Console.WriteLine("this month have 31 days");
            }
            else
            {
                Console.WriteLine("it isn't month number");
            }
        }
    }
}
