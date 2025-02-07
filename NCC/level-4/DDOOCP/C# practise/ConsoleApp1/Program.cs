using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Services;
using System.Security.Principal;
using System.Threading;
using System.Xml.Linq;

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
            /*int mgmg = 23;  //1
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
            /*double physics = 70;
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
            Console.WriteLine("Grade " + grade); */
            /*14. The marks obtained by a student in 5 different subjects are input through the keyboard. The student gets a division as per the following rules: Write a program to calculate the division obtained by the student
•	Percentage above or equal to 60 - First division
•	Percentage between 50 and 59 - Second division
•	Percentage between 40 and 49 - Third division
•	Percentage less than 40 – Fail     */
            /* double S1 = 60;
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
             }*/
            /*char vowel = 'a';*/
            /*if( vowel == 'a')
            {
                Console.WriteLine("this is vowel"); 
            }
            else
            {
                Console.WriteLine("this is not vowel");
            }*/
            /* switch (vowel)
             {
                 case 'a': Console.WriteLine("this is vowel"); break;
                 case 'e': Console.WriteLine("this is vowel"); break;
                 case 'i':
                     Console.WriteLine("this is vowel"); break;
                 case 'o':
                     Console.WriteLine("this is vowel"); break;
                 case 'u':
                     Console.WriteLine("this is vowel"); break;
                 default: Console.WriteLine("this is not vowel"); break;
             }
             char grade = 'A';
             switch (grade)
             {
                 case 'A':
                     Console.WriteLine("Excellent"); break;
                 case 'B': Console.WriteLine("Well done"); break;
                 case 'C':
                     Console.WriteLine("Well done"); break;
                 case 'D':
                     Console.WriteLine("Pass"); break;
                 case 'F':
                     Console.WriteLine("Try again"); break;
                 default:
                     Console.WriteLine("Invalid inpuid"); break;
             }
             char vowels = 'h';
             switch (vowels)
             {
                 case 'a':
                 case 'e':
                 case 'i':
                 case 'o':
                 case 'u':
                     Console.WriteLine("this is vowel"); break;
                 default:
                     Console.WriteLine("this is not vowel"); break;
             }
             int num1 = 10;
             int num2 = 20;
             char operator1 = '+';
             /*if (operator1 == '+')
             {
                 Console.WriteLine("the sum of two values is " + (num1 + num2));
             }
             else if (operator1 == '-')
             { 
                 Console.WriteLine("the sub of two values is " + (num1 - num2));
             }
             else if (operator1 == '*')
             {
                 Console.WriteLine("the mul of two values is " + (num1 * num2));
             }
             else if (operator1 == '/')//sar lat
             {
                 Console.WriteLine("the div of the two values is " + (num1 / num2));
             }
             else if (operator1 == '%')// remainder
             {
                 Console.WriteLine("the mod if two values is " + (num1 % num2));
             }
             else
             {
                 Console.WriteLine("wrong operator");        
         }*/
            /*switch (operator1)
            {
                case '+':
                    Console.WriteLine("sum " + (num1 + num2)); break;
                    case '-':
                    Console.WriteLine("sub " + (num1 - num2)); break;
                    case '*':
                    Console.WriteLine("mul " + (num1  * num2)); break;
                    case '/':
                    Console.WriteLine("div " + (num1 / num2)); break;
                case '%':
                    Console.WriteLine("mod " + (num1 % num2)); break;
                default: Console.WriteLine("Invalid operator"); break;
            }
            int sum = 0;
            for(int i=1;i <= 3; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }*/
            /*for (int i=1;i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }*/
            /*string[] name = { "Aumg Aung", "C M", "Nal", "Ab" };
            Console.WriteLine(name[0]);
            Console.WriteLine(name.Length);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(name[i]);
            }
            int[] age = { 20, 19, 20, 21, 22, 26, 23, 17, 25, 27, 29 };
            Console.WriteLine(age.Length);
            for (int i = 0; i < age.Length; i++)
            { Console.WriteLine(age[i]); }
            int[] mark = { 250, 365, 450, 650, 222, 150, 350, 256 };
            int max = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                if (mark[i] > max) { max = mark[i]; }
            }
            Console.WriteLine("Max mark is " + max);
            int ii = 1;
            while (ii <= 10)
            {
                Console.WriteLine(ii);
                ii++;
            }
            int jj = 1;
            do
            {
                Console.WriteLine(jj + "jj");
                jj++;
            }
            while (jj < 10);
           /* for (int i= 1;i<= 10; i++)
            {
                Console.WriteLine(i);
            }*/
            /* int i = 1;
             while (i <= 10)
             {
                 Console.WriteLine(i);
                 i++;
             }*/
            /*int i = 10;
            while (i >= 1 == true)
            {
                Console.WriteLine(i);
                i--;
            }*/
            /* Console.WriteLine("Do you want to play again, please enter yes or no");
             string result = Console.ReadLine();
             /*Console.WriteLine(result);*/

            /*while (result == "yes")
            {
                Console.WriteLine("You are still playing game");
                Console.WriteLine("Do you want to play again, Please enter yes or no");
              result =  Console.ReadLine();
            }*/
            /* int i = 12;
             do
             {
                 Console.WriteLine(i);
                 i++;
             } while (i <= 10);*/
            /*int i = 12;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }*/
            /*int count = 0;
            for (int i=1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/
            /* string[] name = { "Aung Aung", "Zaw Zaw", "Moe Moe", "Kyaw Kyaw" };
             Console.WriteLine(name[0]);
             Console.WriteLine(name[1]);
             Console.WriteLine(name[2]);
             Console.WriteLine(name[3]);*/

            /* string[] employeename = new string[5];
             employeename[0] = "Aung Aung";
             employeename[1] = "Kyaw Kyaw";
             employeename[2] = "Moh Moh";
             employeename[3] = "Hin Hin";
             employeename[4] = "Lwin Lwin";


             Console.WriteLine(employeename[0]);
             Console.WriteLine(employeename[1]);
             Console.WriteLine(employeename[2]);
             Console.WriteLine(employeename[3]);
             Console.WriteLine(employeename[4]);
             Console.WriteLine(employeename.Length);*/
            /* string[] name = new string[5];*/
            /*Console.WriteLine("Enter a name");
            string tname = Console.ReadLine();
            Console.WriteLine("Your name is " + tname);
            name [0] = tname;
            Console.WriteLine("Enter a name");
            tname = Console.ReadLine();
            Console.WriteLine("Your name is " + tname);
            name[1] = tname;
            Console.WriteLine("Enter a name");
            tname = Console.ReadLine();
            Console.WriteLine("Your name is " + tname);
            name[2] = tname;
            Console.WriteLine("Enter a name");
            tname = Console.ReadLine();
            Console.WriteLine("Your name is " + tname);
            name[3] = tname;
            Console.WriteLine("Enter a name");
            tname = Console.ReadLine();
            Console.WriteLine("Your name is " + tname);
            name[4] = tname;*/
            /* for (int i = 0;i<= 4; i++) {
                 Console.WriteLine("Enter a name");
                 string tname = Console.ReadLine();
                 Console.WriteLine("Your name is " + tname);
                 name[i] = tname;
             }*/
            /* string[] city ={"Yangon", "Mandalay", "Npt", "M", "K" };
                string[] copycity = new string[5];
                for (int i = 0; i < city.Length; i++)
                {
                    copycity[i] = city[i];
                   onsole.WriteLine(copycity[i]);
                }
                for (int i = 0; i < copycity.Length; i++)
                {
                    Console.WriteLine(copycity[i]);
                }*/

            /* string[] name = { "AA", "BB", "CC", "DD", "EE" };
             /* for(int i = 0;i <name.Length; i++) { 
                  if (i %2 == 0) {
                      Console.WriteLine(name[i]);
                  }
             for (int i = 0; i < name.Length; i++)
             {
                 if (i % 2 == 1)
                 {
                     Console.WriteLine(name[i]);
                 }*/
            /* int sum = 0; 
             for(int i =1; i<= 5; i++)
              {
                  sum += i;
              }
              Console.WriteLine(sum);*/
            /* int sum = 0;
             int[] salary = { 20, 22, 30, 55, 60, 75 };
             for (int i = 0; i < salary.Length; i++) { 
             sum += salary [i];
             }
             Console.WriteLine(sum);
             int avg = sum / salary.Length;
             Console.WriteLine("Avarage is " + avg);*/
            /*int o = 1;      //question 1 Write a program to print all numbers from 1 to 100.
            while (o <= 100)
            {
                Console.WriteLine(o);
                o++;
            }
 
            for (int i = 100; i >= 1; i--)   // question 2 Write a program to print all natural numbers from 1 to 100 in reverse order.
            {
                Console.WriteLine(i);
            }
            // 3. Write a program to print all even numbers between 1 to 100.
            for (int j = 1; j <= 100; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
            }
            //4. Write a program to print all odd numbers between 1 to 100
            for (int e= 1; e <= 100; e++)
            {
                if (e%2 == 1)
                {
                    Console.WriteLine(e);
                }
            }*/
            //Write a program to count even number from 1 to 100.
            /* int count = 0;
             for (int z = 1; z <= 100; z++)
             {
                 if (z % 2 == 0)
                 {
                     count++;
                 }
             }
             Console.WriteLine(count);
             //Write a program to count odd number from 1 to 100.
             int counts = 0;
             for (int i = 1; i <= 100; i++)
             {
                 if (i % 2 == 1)
                 {
                     counts++;
                 }
             }
             Console.WriteLine(counts);
             //6. Write a program to count even and odd from 1 to 100.
             int allcount = 0;
             for (int e = 1; e <= 100; e++)
             {
                 if (e % 2 == 0 || e % 2 == 1)
                 {
                     allcount++;
                 }

             }
             Console.WriteLine(allcount);
             //7. Write a program to print number between 100 and 200 which are divisible by 3.
             for (int a = 100; a <= 200; a++)
             {
                 if (a % 3 == 0)
                 {
                     Console.WriteLine(a);
                 }
             }

             //9. Print all alphabets from a to z.
             Console.Write(" all alphabets from a to z is ");
             for (char ch = 'a'; ch <= 'z'; ch++)
             {
                 Console.Write(ch);
             }

             //10. Print all alphabets from z to a.
             Console.Write(" all alphabets from z to a is ");
             for (char cha = 'z'; cha >= 'a'; cha--)
             {
                 Console.Write(cha);
             }

             //11. Find sum of all natural number from 1 to 100.
             int sum = 0;

             for (int l = 1; l <= 100; l++)
             {
                 sum += l;
             }
             Console.WriteLine("the sum of all natural number is "+ sum);*/
            /* int[,] age = {     {10,20,30 } ,{20,30,40 }  };
             int[] age2 = { 10, 20, 30 };
             Console.WriteLine("Number of room in 1d array "+ age2.Length);
             Console.WriteLine( "number of room in 2d array" + age.Length);
             Console.WriteLine(age[0,0]);
             Console.WriteLine(age[0,1]);
             Console.WriteLine(age[0,2]);
             Console.WriteLine(age[1,0]);
             Console.WriteLine(age[1,1]);
             Console.WriteLine(age[1,2]);*/
            /*int[,] age = new int[3, 4];
            age[0,0] = 5;
            age[0,1] = 6;
            age[0,2] = 7;
            age[0,3] = 8;

            age[1,0] = 1;
            age[1,1] = 2;
            age[1,2] = 3;
            age[1,3] = 4;

            age[2, 0] = 10;
            age[2, 1] = 20;
            age[2,2] = 30;
            age[2, 3] = 40;

           /* Console.WriteLine("first row first col "+ age[0,0]);
            Console.WriteLine("first row second col" + age[0,1]);
            Console.WriteLine("first row third col "+ age[0,2]);
            Console.WriteLine("first row fourth col "+ age[0,3]);

            Console.WriteLine("second row first col " + age[1, 0]);
            Console.WriteLine("second row second col" + age[1, 1]);
            Console.WriteLine("second row third col " + age[1, 2]);
            Console.WriteLine("second row fourth col " + age[1, 3]);

            Console.WriteLine("third row first col " + age[2, 0]);
            Console.WriteLine("third row second col" + age[2, 1]);
            Console.WriteLine("third row third col " + age[2, 2]);
            Console.WriteLine("third row fourth col " + age[2, 3]);*/

            /* for (int i= 0; i<4; i++)   //for first row
               {
                   Console.WriteLine(age[0,i]);
               }
             for(int i=0; i<4; i++)  // for second row
            {
                Console.WriteLine(age[1,i]);
            }
             for(int i=0; i<4; i++) // for third row
            {
                Console.WriteLine(age[2,i]);
            }*/
            /* for (int j = 0; j < 3; j++) {    // for all row
                 for (int i = 0; i < 4; i++) 
                 {
                     Console.WriteLine(age[j,i]);
                 }
             }*/
            /*int[,] age = new int[3, 4];*/// object data type that why they add new
            /*Console.WriteLine("please enter a number");  // the long way
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num); // convert string to int
            age[0,0] = number;
            Console.WriteLine("the data is " + age[0,0]);
            
            Console.WriteLine("please enter a number");
             num = Console.ReadLine();
             number = Convert.ToInt32(num); // convert string to int
            age[0, 1] = number;
            Console.WriteLine("the data is " + age[0, 1]);

            Console.WriteLine("please enter a number");
            num = Console.ReadLine();
            number = Convert.ToInt32(num); // convert string to int
            age[0, 2] = number;
            Console.WriteLine("the data is " + age[0, 2]);

            Console.WriteLine("please enter a number");
            num = Console.ReadLine();
            number = Convert.ToInt32(num); // convert string to int
            age[0, 3] = number;
            Console.WriteLine("the data is " + age[0, 3]);*/


            /* for (int i = 0; i < 4; i++) {
                 Console.WriteLine("please enter a number");
                 string num = Console.ReadLine();
                 int number = Convert.ToInt32(num); // convert string to int
                 age[0, i] = number;
                 Console.WriteLine("the data is " + age[0, i]);
             }

             for (int i = 0; i < 4; i++)
             {
                 Console.WriteLine("please enter a number");
                 string num = Console.ReadLine();
                 int number = Convert.ToInt32(num); // convert string to int
                 age[1, i] = number;
                 Console.WriteLine("the data is " + age[1, i]);
             }

             for (int i = 0; i < 4; i++)
             {
                 Console.WriteLine("please enter a number");
                 string num = Console.ReadLine();
                 int number = Convert.ToInt32(num); // convert string to int
                 age[2, i] = number;
                 Console.WriteLine("the data is " + age[2, i]);
             }*/
            /*for (int j=0; j<3; j++)
             {
                 for(int i=0; i<4; i++)
                 {
                     Console.WriteLine("please enter a number");
                     string num = Console.ReadLine();
                     int number = Convert.ToInt32(num); // convert string to int
                     age[j, i] = number;
                     Console.WriteLine("the data is " + age[j, i]);// see the result immediately
                 }
             }*/
            /*  for (int j=0; j<3; j++)
               {
                   for(int i=0; i < 4; i++)
                   {
                       Console.WriteLine($"row {j} col {i} is " + age[j,i]);// this kind of writing will tell you what is what clearly
                       Console.WriteLine($"The result is {age[j,i]}"); // another way of writing the first one
                   }
               }// see the last result*/
            /* for(int i=0; i<5; i++)   // the long way
             {
                 Console.Write("*");
             }
             Console.WriteLine();
             for (int i = 0; i < 5; i++)
             {
                 Console.Write("*");
             }
             Console.WriteLine();
             for (int i = 0; i < 5; i++)
             {
                 Console.Write("*");
             }
             Console.WriteLine();*/
            /*for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }*/
            /*int sum = 0;
            int[] salary = { 100, 200, 250, 150, 350 };
            for(int i=0; i< salary.Length; i++)
            {

                Console.WriteLine($"Your salary is {salary[i]}" );
                sum += salary[i];

            }
            Console.WriteLine("the total salary of all employees is " + sum);
            /*  int sum = 0;
              for (int i=1; i<=5;  i++)
              {
                  sum += i;

              }
              Console.WriteLine(sum);*/
            // 5.Write a program to find the factorial value of given number.
            /* Console.WriteLine("enter a number for factorial value");
              int number = Convert.ToInt32(Console.ReadLine());
              if (number < 0) { Console.WriteLine("Factorial is not possible"); }
              else
              {
                  int factorial = 1;
                  for (int i = 1; i <= number; i++)
                  {
                      factorial *= i;
                  }
                  Console.WriteLine($"The factorial of {number} is {factorial}");
              }*/
            /* 14.Print the following output.Use nested for loop.
               *****
               *****
               *****
               *****
               *****    */


            /* for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            } */
            /* 15.Print the following output.Use nested for loop.
  *
  **
  ***
  ****
  *****    */

            /*for (int i = 1; i <= 5; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/
            /* 16.Print the following output.Use nested for loop.
 * ****
 ****
 ***
 **
 *         */
            /*for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
            /*17.Print the following output.Use simple for loop.
Output:
6
12
18
24
30
36
42
48
54
60*/
            /*   int ans = 6;
               for (int i =1; i<=10; i++)
               {

                   Console.WriteLine(ans*i);
               } */
            /*  18.Print the following output.Use simple for loop.
     6 * 1 = 6
     6 * 2 = 12
     6 * 3 = 18
     6 * 4 = 24
     6 * 5 = 30
     6 * 6 = 36
     6 * 7 = 42
     6 * 8 = 48

      6 * 9 = 54
     6 * 10 = 60
     6 * 11 = 66
     6 * 12 = 72         */
            /*  int multi = 6;
              for (int i = 1; i <= 12; i++)
              {

                  Console.WriteLine($"{multi} * {i}= {multi*i}");
              }   */
            /* 19.Print the following output.Use nested for loop.
 1 2 3 4 5
 1 2 3 4 5
 1 2 3 4 5
 1 2 3 4 5
 1 2 3 4 5    */
            /* for(int i= 1; i<=5; i++)
              {
                  for (int j=1; j<=5; j++)
                  {
                      Console.Write(j);
                  }
                  Console.WriteLine();
              }*/
            /* 20.Print the following output.Use nested for loop.
             1
             12
             123
             1234
             12345      */
            /*   for(int i=1; i<=5; i++)
{
   for(int j=1; j<=i; j++)
   {
       Console.Write(j);
   }
   Console.WriteLine();
}   */
            /* 21.Print the following output.Use nested for loop.
 1 1 1 1 1
 2 2 2 2 2
 3 3 3 3 3
 4 4 4 4 4
 5 5 5 5 5      */
            /* for (int i = 1; i <= 5;i++)
             {
                 for (int j = 1; j <=5;j++) 
                 {
                     Console.Write(i);
                 }
                 Console.WriteLine();
             }  */
            /*  22.Print the following output.Use nested for loop.
   1 
   2 2 
   3 3 3 
   4 4 4 4 
   5 5 5 5 5   */
            /*  for (int i = 1; i <= 5; i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write(i);
                  }
                  Console.WriteLine();
              }   */
            /* 23.Print the following output.Use nested for loop.
                 1
                 2 3
                 4 5 6
                 7 8 9 10
                 11 12 13 14 15
                 16 17 18 19 20 21 */
            /*  int num = 1;
              for (int i = 1; i <= 6; i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write(num +" ");
                      num++;
                  }
                  Console.WriteLine();
              }    */
            // 1.Write a program to copy all elements of one array into another array.

            /*int[] Array1 = { 1, 2, 3, 4, 5 };
             int[] Array2 = new int[Array1.Length];
             for (int i = 0; i < Array1.Length; i++)
             {
                 Array2[i] = Array1[i];
             }
             Console.WriteLine("Array2:");
             for (int i = 0; i < Array2.Length; i++)
             {
                 Console.WriteLine(Array2[i]);
             }*/
            //3.Write a program to print the elements of an array.

            /* int[] arr = { 1, 2, 3, 4, 5 };
             Console.WriteLine("Elements of the array:");
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i]);
             }*/
            // 4.Write a program to print the elements of an array in reverse order.
            /*[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Elements of the array in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }*/

            //  6.Write a program to print the elements of an array present on odd position.
            /*int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
            Console.WriteLine("Elements at odd positions (1st, 3rd, 5th, ...):");
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine(arr[i]);
            }*/
            // 7.Write a program to print the elements of an array present on even position.
            /* int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
             Console.WriteLine("Elements at even positions (2nd, 4th, 6th, ...):");
             for (int i = 1; i < arr.Length; i += 2)
             {
                 Console.WriteLine(arr[i]);
             }*/

            // 8.Write a program to print the largest element in an array.
            /* int[] arr = { 10, 20, 5, 45, 30 };
             int largest = arr[0];
             for (int i = 1; i < arr.Length; i++)
             {
                 if (arr[i] > largest)
                 {
                     largest = arr[i];
                 }
             }
             Console.WriteLine("The largest element in the array is: " + largest);*/
            // 9.Write a program to print the smallest element in an array.
            /* int[] arr = { 10, 20, 5, 45, 30 };
             int smallest = arr[0];
             for (int i = 1; i < arr.Length; i++)
             {
                 if (arr[i] < smallest)
                 {
                     smallest = arr[i];
                 }
             }
             Console.WriteLine("The largest element in the array is: " + smallest);*/
            //10.Write a program to print the sum of all the items of the array.

            /* int[] arr = { 1, 2, 3, 4, 5 };
             int sum = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 sum += arr[i];
             }
             Console.WriteLine("The sum of all items in the array is: " + sum);*/
            //15.	Write a   program to count even and odd number of an array and print it out.
            /* int[] arr = { 10, 21, 32, 43, 54, 65, 76, 87, 98 };
             int even = 0;
             int odd = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] % 2 == 0)
                 {
                     even++;
                 }
                 else
                 {
                     odd++;
                 }
             }
             Console.WriteLine("Count of even numbers: " + even);
             Console.WriteLine("Count of odd numbers: " + odd);*/
            //16.	Write a   program to print the average value of an array.
            /* int[] arr = { 10, 20, 30, 40, 50 };
             int sum = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 sum += arr[i];
             }
             int average = sum / arr.Length;
             Console.WriteLine("The average value of the array is: " + average);*/
            //17.	Write a   program to store number of value in an array using Scanner and print it.

            /*Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the value of element ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements of the array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            //18.	Write a   program to print sum of all odd number of an array.
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    odd += arr[i];
                }
            }
            Console.WriteLine("Sum of all odd numbers in the array: " + odd);*/



        }
    }
}
