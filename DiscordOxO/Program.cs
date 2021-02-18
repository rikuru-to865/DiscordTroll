using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace DiscordOxO
{
    
    class Program
    {
        static void Main()
        {
            Console.WriteAscii("DISCORD TROLL TOOL -V 0.1", Color.FromArgb(100, 100, 200));
            Console.WriteLine("rikuru_to#7754", Color.Aqua);


            Action UserChoose = ChooseSpam.Choose(); //選択肢を入力
            UserChoose();
        }
    }
}
