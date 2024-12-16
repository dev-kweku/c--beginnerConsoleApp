using System;
// vreating calculator a c# dev beginner
class Cal{
    static void Main(String[] args){
        double numberOne,numberTwo,Result;
        char operations;

        Console.Write("Enter your first value ::");
        numberOne=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your second value ::");
        numberTwo=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter and operator (+,-,*,/) : ");
        operations=Convert.ToChar(Console.ReadLine());

    // using switch for operation on math operations
        switch(operations){
            case '+':
                Result=numberOne+numberTwo;
                Console.WriteLine("{0} + {1}= {2}",numberOne,numberTwo,Result);
                break;
            case '-':
                Result=numberOne-numberTwo;
                Console.WriteLine("{0} - {1} = {2}",numberOne,numberTwo,Result);
                break;
            case '*':
                Result=numberOne*numberTwo;
                Console.WriteLine("{0} * {1} = {2}",numberOne,numberTwo,Result);
                break;
            case '/':
                if(numberTwo==0){
                    Console.WriteLine("Error: division by zero!");
                }else{
                    Result=numberOne/numberTwo;
                    Console.WriteLine("{0} / {1} = {2} ",numberOne,numberTwo,Result);
                }

                break;

                default:
                        Console.WriteLine("Invalid Operation");
                        break;


        }
    }
}