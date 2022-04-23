using System;

namespace Laba4_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex firstComplexNumber = new Complex(5.5, -10.8); 
            Console.WriteLine($"FirstComplexNumber = {firstComplexNumber}");
            Complex secondComplexNumber = new Complex(7.4, -4.5);
            Console.WriteLine($"SecondComplexNumber = {secondComplexNumber}");

            Console.WriteLine("----------------------------------------------------");
            Complex sumComplexNumber = firstComplexNumber + secondComplexNumber;
            Console.WriteLine($"SumComplexNumber = {sumComplexNumber}");
            Complex subtractionComplexNumber = firstComplexNumber - secondComplexNumber;
            Console.WriteLine($"SubtractionComplexNumber = {subtractionComplexNumber}");

            Console.WriteLine("----------------------------------------------------");
            double realNumberOne = 12.5;
            Console.WriteLine($"RealNumberOne = {realNumberOne}");
            Complex sumComplexAndRealNumber = sumComplexNumber + realNumberOne;
            Console.WriteLine($"SumComplexAndRealNumber = {sumComplexAndRealNumber}");

            Console.WriteLine("----------------------------------------------------");
            double realNumberTwo = 9.8;
            Console.WriteLine($"RealNumberTwo = {realNumberTwo}");
            Complex sumRealAndComplexNumber = realNumberTwo + sumComplexNumber;
            Console.WriteLine($"SumRealAndComplexNumber = {sumRealAndComplexNumber}");

            Console.WriteLine("----------------------------------------------------");
            Complex divisionComplexNumber = firstComplexNumber / secondComplexNumber;
            Console.WriteLine($"DivisionComplexNumber = {divisionComplexNumber}");
            Complex multiplicationComplexNumber = firstComplexNumber * secondComplexNumber;
            Console.WriteLine($"MultiplicationComplexNumber = {multiplicationComplexNumber}");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"FirstComplexNumber: {firstComplexNumber}");
            Console.WriteLine($"FirstComplexNumber ++: {firstComplexNumber++}");
            Console.WriteLine($"FirstComplexNumber --: {firstComplexNumber--}");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"SecondComplexNumber != FirstComplexNumber: {secondComplexNumber != firstComplexNumber}");
            Complex thirdComplexNumber = firstComplexNumber;
            Console.WriteLine($"FirstComplexNumber == ThirdComplexNumber: {firstComplexNumber == thirdComplexNumber}");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"firstComplexNumber < secondComplexNumber: {firstComplexNumber < secondComplexNumber}");
            Console.WriteLine($"firstComplexNumber > secondComplexNumber: {firstComplexNumber > secondComplexNumber}");

            Console.WriteLine("----------------------------------------------------");
            Complex fouthComplexNumber = new Complex(0, 0);
            Console.WriteLine($"fouthComplexNumber =  {fouthComplexNumber}" );
            if (fouthComplexNumber)
            {
                Console.WriteLine("fouthComplexNumber = true");
            }
            else
            {
                Console.WriteLine("fouthComplexNumber = false");
            }
            Console.WriteLine("----------------------------------------------------");
            Complex fifthComplexNumber = new Complex(0,0);
            Console.WriteLine($"fifthComplexNumber = {fifthComplexNumber}");
            fifthComplexNumber[0] = 16;
            fifthComplexNumber[1] = -8;
            fifthComplexNumber[2] = 100;
            Console.WriteLine($"fifthComplexNumber = {fifthComplexNumber}");
            try
            {
                Console.WriteLine($"fifthComplexNumber[0] = {fifthComplexNumber[0]}");
                Console.WriteLine($"fifthComplexNumber[1] = {fifthComplexNumber[1]}");
                Console.WriteLine($"fifthComplexNumber[2] = {fifthComplexNumber[2]}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception = {e.Message}");
            }
            Console.WriteLine("----------------------------------------------------");
            double oneNumber = -17.5;
            Console.WriteLine($"oneNumber = {oneNumber}");
            Complex sixthComplexNumber = oneNumber; //неявно
            Console.WriteLine($"sixthComplexNumber = {sixthComplexNumber}");
            oneNumber = (double)thirdComplexNumber; //явно
            Console.WriteLine($"OneNumber = {oneNumber}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"sumComplexNumber = {sumComplexNumber}");
            Console.WriteLine($"realNumberOne = {realNumberOne}");
            Console.WriteLine($"sumComplexNumber / realNumberOne = {sumComplexNumber / realNumberOne}");


        }
    }
}
