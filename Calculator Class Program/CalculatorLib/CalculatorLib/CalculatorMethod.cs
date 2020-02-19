using System;

/*CREATE METHOD SYNTAX
public static var methodName(Arguments)
    {
        return function;
    }*/

namespace CalculatorLib
{
    public class CalculatorMethod
    {
        public static int calcAdd(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int calcSub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int calcMul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int calcDiv(int num1, int num2)
        {
            return num1 / num2;
        }
        
        public static int calcMod(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
