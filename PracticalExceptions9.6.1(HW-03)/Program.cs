/*
Задание 1
Создайте свой тип исключения.
Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. Реализуйте конструкцию TryCatchFinally,
в которой будет итерация на каждый тип исключения (блок finally по желанию).
В блоке catch выведите в консольном сообщении текст исключения.
*/
using System;

namespace NException;

    public class ProgramException
    {
    public static void Input()
    {
        Console.WriteLine("enter the first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = a / b;
    }

        static void Main(string[] args)
        {

        try
        {
            Input();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can't divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("The value is not in the appropriate format");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Non-empty argument");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("The index is outside the bounds of the array or collection.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType());
        }
        finally
        {
            Console.WriteLine("Block finally");
        }


    }
    }
