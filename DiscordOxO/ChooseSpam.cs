using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace DiscordOxO
{
    public enum Chooses { SpamServer = 1, SpamDM, AddToken, GenerateToken, NoChoose }


    class ChooseSpam
    {
        public static Action Choose()
        {
        restart:
            Action choose;


            Console.ForegroundColor = Color.White;
            Console.WriteLine("1.サーバーにスパム");
            Console.WriteLine("2.DMにスパム");
            Console.WriteLine("3.tokenを追加");
            Console.WriteLine("4.tokenを生成");
            int Choose = int.Parse(Console.ReadLine());
            switch (Choose)
            {
                case 1:
                    Console.WriteLine("1.サーバーにスパムに決定しました");
                    return choose = AddToken.TokenAdder;
                case 2:
                    Console.WriteLine("2.DMにスパムに決定しました");
                    return choose = SpamDM.DMSpamer;
                case 3:
                    Console.WriteLine("3.tokenを追加に決定しました");
                    return choose = AddToken.TokenAdder;
                case 4:
                    Console.WriteLine("4.tokenを生成に決定しました");
                    return choose = GenerateToken.TokenGenerrator;
            }
            Console.WriteLine("有効な数字を入力してください");
            goto restart;
        }
    }
}
