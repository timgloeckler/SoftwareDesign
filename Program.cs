using System;

namespace Aufgabe3_Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Value from 0 to 1023!");
            string numberString = Console.ReadLine();
            Console.WriteLine("Enter a number base!");
            string toBaseString = Console.ReadLine();
            Console.WriteLine ("Enter a convert number base!");
            string startNumberBaseConvertString = Console.ReadLine();
            int fromBase = Int32.Parse(toBaseString);
            int toBase = Int32.Parse(startNumberBaseConvertString);
            int number = Int32.Parse(numberString);

            if (0 <= number && number <= 1023){
            ConvertToBaseFromDecimal(number, fromBase);
            ConvertToDecimalFromBase(number, fromBase);
            }
            else {
            Console.WriteLine("Value must be between 0 and 1023!");
            }
        }
        
       static void ConvertToBaseFromDecimal(int number, int fromBase) {
                int lastHexalNumber = (number % 10)*(fromBase^0);
                int secondlastHexalNumber = ((number % 100 - lastHexalNumber)/10)*(fromBase^1);
                int thirtlastHexalNumber = ((number % 1000 - lastHexalNumber - secondlastHexalNumber)/100)*(fromBase^2);
                int fourthlastHexalNumber = ((number % 10000 - lastHexalNumber - secondlastHexalNumber - thirtlastHexalNumber)/1000)*(fromBase^3);
                int FinalHexalNumber=(lastHexalNumber + secondlastHexalNumber + thirtlastHexalNumber + fourthlastHexalNumber);
                Console.WriteLine("The hexal number of " + number +" is " + FinalHexalNumber);
       }
  
        static void ConvertToDecimalFromBase(int number, int fromBase) {
                int firstDezimalNumber = (number % fromBase); 
                int firstDevisionNumber = (number / fromBase);   
                int secondDezimalNumber = (firstDevisionNumber % fromBase); 
                int secondDevisionNumber = (firstDevisionNumber / fromBase);
                int thirtDezimalNumber = (secondDevisionNumber % fromBase); 
                int thirtDevisionNumber = (secondDevisionNumber / fromBase);
                int fourthDezimalNumber = (thirtDevisionNumber % fromBase); 
                int fourthDevisionNumber = (thirtDevisionNumber  / fromBase);
                string finalDezimalNumberString = (firstDezimalNumber +""+  secondDezimalNumber +""+ thirtDezimalNumber +""+ fourthDezimalNumber);
                int finalDezimalNumberInt = Int32.Parse(finalDezimalNumberString);
                Console.WriteLine("The decimal number of the hexal number " + number + " is " + finalDezimalNumberInt);
        }
        static void ConvertNumberToBaseFromBase(int number, int fromBase, int endNumberBaseInt){
            //if(2<= frombase &&)
        }   //Habe mit Benjamin zusammengearbeitet und wir haben diese Teilaufgabe nicht ausreichend verstanden, um sie zu lösen.

    }
}
