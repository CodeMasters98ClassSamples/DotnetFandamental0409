namespace DotnetFandamental0409.LearningConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 3;
            int[] nums = [2,3,5];

            string name = "parham";
            char[] chars = name.ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine($"{i} -> {chars[i]}");
            }

            int res = Sum(5, 15); //Call a method

            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int res2 = Sum(input1: num3, input2: num4);

            //int num1 = 15;
            //long num2 = 10;

            //num1 = (int)num2; // long into int
            //num2 = num1; //int into long -> implicit casting

            //Console.WriteLine(typeof(string));

            // if (num1 is long)
            // {
            // }

            //Console.WriteLine("name?");
            //string name = Console.ReadLine();
            //if (name == "parham") //parhamaaaaasdgfsdhfg ->
            //{

            //}

            // Error : ...

            int age = 0;
            Console.WriteLine("age?");
            for (; ; )
            {
                string ageStr = Console.ReadLine();
                age = int.Parse(ageStr);
                if (age > 10 && age < 100)
                    break;
                else
                    Console.WriteLine("Please enter valid age! (valid age is more than 10 and less than 100)");
            }


            string gender = "f";
            if (gender == "f")
            {

            }
            else if (gender == "m")
            {

            }
            else
            {

            }

            if (age > 18)
            {
                string name1 = "";
                Console.WriteLine("Your age is valid!");
            }
            else
            {
                return;
            }



            age.ToString();

            //debug
            //C# CaseSensitive
            Console.WriteLine("What is your name!");

            //DataType NameOfVaribale;
            string name = Console.ReadLine();

            //string concat
            Console.WriteLine("Thank you" + name);
        }

        //sign method
        static int Sum(int input1, int input2)
        {
            int result = input1 + input2;
            return result;
        }

        static int Sum(string inputStr1, string inputStr2)
        {
            int input1 = int.Parse(inputStr1);
            int input2 = int.Parse(inputStr2);

            int result = input1 + input2;

            return result;
        }

        static int Sum(int input1, int input2, int input3)
        {
            int result = input1 + input2 + input3;
            return result;
        }

    }
}