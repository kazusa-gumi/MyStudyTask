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

            // User Input
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is:" + age);

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

            // ⑤エスケープ文字
            Console.WriteLine("HelloWorld");
            // Console.WriteLineは1行で表示する。

            //　エスケープ文字
            // /tは空白を表現する
            Console.WriteLine("Hello \t world");
            // /nは改行を表現する
            Console.WriteLine("Hello \n world");
            // option　+ ¥で バックスラッシュ打てます
            Console.WriteLine("c: \\dire\repos");
            // @はそのまま出力 @"~"何があってもそのまま出力される
            Console.WriteLine(@"############
Hello
World!!!!
########");
            Console.WriteLine(@"\t\n\\");

            // ⑥ 文字列連結
            string firstName = "Ai";
            string message = "Good morning";

            // +で結合可能になる。
            Console.WriteLine(message + " " + firstName);
            // "${}, {}"も可能
            Console.WriteLine($"{ message} {firstName}");

            string URL = $@"c:\dir\{firstName}\data.txt";
            Console.WriteLine(URL);

            // ⑦演算子
            int x1 = 10;
            int y1 = 3;
            // mは小数点の目印
            decimal d = 1.5m;
            // + - / %はオペレーターと言われる。xとかyはオペランドという
            Console.WriteLine(x1 + y1);
            Console.WriteLine(x1 - y1);
            Console.WriteLine(x1 / y1);
            // 10/3して余った数字を出す今回なら１だよね
            Console.WriteLine(x1 % y1);

            // 結合する
            Console.WriteLine(x1+ " is answer");
            Console.WriteLine(x1 + y1 + " is answer");

            //⑧浮動小数点(Floating point)型が異なるけど、結果は出せる。
            Console.WriteLine(x1 + d);
            Console.WriteLine(x1 - d);
            Console.WriteLine(x1 * d);
            //　小数点以下までしっかり表示する。
            Console.WriteLine(x1 / d);

            //型変換 整数→小数点へ変換
            Console.WriteLine((decimal)x / (decimal)y);

            double d2 = 2.5;
            Console.WriteLine((float)d2);

            //演算子＋α
            int x2 = 10;
            Console.WriteLine(x2);

            // x2 = x2 + 10 logで出力したい時に使用する。解析とか
            //　元々あった数値をいじりたくない時とかに使用できる
            x2 += 10;
            Console.WriteLine(x2);

            x2 -= 10;
            Console.WriteLine(x2);

            x2 *= 10;
            Console.WriteLine(x2);

            x2 /= 10;
            Console.WriteLine(x2);

            // 足される前の結果が出てくる。X++：表示後に足す（ここよく出る）
            Console.WriteLine(x2++);
            Console.WriteLine(x2++);
            Console.WriteLine(x2);

            //++X：表示前に足す
            Console.WriteLine(++x2);
            Console.WriteLine(++x2);

            // ⑩ライブラリ マイクロソフトが用意した標準ライブラリ
            // .Netクラスライブラリの標準ライブラリを使用。System.Rondomクラス
            //インスタンス生成 diceという変数にオブジェクトの参照を格納、物を意識する.
            //変数を１つのサイコロとしてみましょうって感じ。
            // インスタンスを生成
            Random dice = new Random();
            // Nextはの Randomのメソッド diceオブジェクトの1~6までの何かの数字を出してくれるかんじ
            //まず、`Random dice = new Random(); により、Random` クラスの新しいインスタンス dice を初期化しています。
            //そして、`int roll = dice.Next(1, 7); で、Next(int minValue, int maxValue)`
            //メソッドを用いて、1から6までの整数のうちの任意の一つを生成し、その値を roll に代入しています。
            //この Next(int minValue, int maxValue) メソッドでは、最小値は含まれ、最大値は排除されるため、
            //この例では1から6までの値が得られます。つまり、サイコロを振ったときの結果を模倣しています。

            // Nextメソッドはランダムな数値を取り出すメソッドです。
            int roll = dice.Next(1, 7);
            // Consoleというclassの中のWriteLineというメソッドを使用してる認識
            Console.WriteLine(roll);

            roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            // Basic 3 of 9 operator

            // ユーザーに値を入れさせるメソッド,Convert.ToInt32()はその文字列を整数(int)に変換する
            // classActivity 1
            Console.Write("Enter x:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int z = x3 + y3;
            Console.WriteLine("z is " + z);

            // classActivity 2
            Console.Write("Please enter the temperature in Celsius: ");
            string userInput = Console.ReadLine();

            // Attempt to convert user input to a double (decimal number)
            // doubole:小数点、TryParseは文字列を小数点の型に変換
            if (double.TryParse(userInput, out double celsius))
            {
                // Conversion from Celsius to Fahrenheit
                // celsius→Fahrenheitに変換するために以下の式で計算
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}°F");
            }
            else
            {
                // If the conversion did not succeed (the user did not enter a valid number)
                Console.WriteLine("Invalid input. Please enter a valid number next time.");
            }


        }
    }
}

