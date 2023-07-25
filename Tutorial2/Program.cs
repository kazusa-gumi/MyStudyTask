// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//Console.WriteLine("文字を入力してください");
//string input = Console.ReadLine();
//Console.Write("入力文字:");
//Console.WriteLine(input);
//Console.ReadKey();


//using System;

//namespace HelloWorld
//{
// C#はclass内で実行される
//    class Program
//    {
// C#はmain関数で開始・終了する
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//Console.WriteLine("Hello World!");

//int x;
//x = 5;
//Console.WriteLine(x);


using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mark = 20;
            if (mark >= 60)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("not pass");
            }

            int myNum = 5;
            double myDoubleNumber = 2.5;
            char myChar = 'K';
            bool myBoolean = false;
            string myString = "naoikazusadesu";

            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNumber);
            Console.WriteLine(myChar);
            Console.WriteLine(myBoolean);
            Console.WriteLine(myString);

            // DataType 5
            // varはなんでも入る。
            var myNum1 = 5;
            var myDoubleNumber1 = 2.5;
            var myChar1 = 'K';
            var myBoolean1 = false;
            var myString1 = "naoikazusadesu";

            Console.WriteLine(myNum1);
            Console.WriteLine(myDoubleNumber1);
            Console.WriteLine(myChar1);
            Console.WriteLine(myBoolean1);
            Console.WriteLine(myString1);

            // Commnet

            // User Input
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);

            // My work
            // WriteLine=コンソールに文字を出力するメソッド、WriteLine（）の括弧の中身は引数
            // セミコロンをステートメントということもあります。
            //　プログラムで重要なのはデバック、console.logをフロントで見るのと同じ容量。
            Console.WriteLine("Hello World!");
        }
    }
}

