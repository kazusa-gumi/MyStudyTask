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

            // My work
            // WriteLine=コンソールに文字を出力するメソッド、WriteLine（）の括弧の中身は引数
            // セミコロンをステートメントということもあります。
            //　プログラムで重要なのはデバック、console.logをフロントで見るのと同じ容量。
            Console.WriteLine("Hello World!");


            // 定数 １とか２とか
            // 変数　aとかxとか

                // 文字列型
                string newName; // 変数宣言, camelCaseで記載
                newName = "kazusa"; //　値を代入
                Console.WriteLine(newName);

                newName = "Ken";
                Console.WriteLine(newName); // 上書きする感じ

                // データ型

                // 整数型
                int x = 1;
                Console.WriteLine(x);
                //　これより上記のあたいの渡し方の方がいい。
                int k;
                k = 12;
                Console.WriteLine(k);

                // 浮動小数点型(最後にmをつけるルール）
                decimal y = 1.23m;
                Console.WriteLine(y);

                // 文字型
                char c = 'a';
                Console.WriteLine(c);

                // 文字型
                string s = "aiueo";
                Console.WriteLine(s);

                //論理型 boolean 大文字で出力される。
                bool is_ok = true;
                Console.WriteLine(is_ok);



                // User Input
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your age is:" + age);

        }
    }
}

