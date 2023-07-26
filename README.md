# MyStudyTask
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
