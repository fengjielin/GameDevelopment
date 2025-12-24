namespace 必备知识点_控制台相关练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 通过 W,A,S,D 在控制台中控制一个黄色方块上下左右移动，注意边界问题；

            // 设置控制台大小
            // 获取最大窗口尺寸
            int maxWidth = Console.LargestWindowWidth;
            int maxHeight = Console.LargestWindowHeight;

            // 期望的窗口和缓冲区尺寸
            int desiredWidth = 60;
            int desiredHeight = 30;

            // 取最小值，防止超出最大限制
            int windowWidth = Math.Min(desiredWidth, maxWidth);
            int windowHeight = Math.Min(desiredHeight, maxHeight);

            // 先设置缓冲区，确保不小于窗口尺寸
            int bufferWidth = Math.Max(windowWidth, Console.BufferWidth);
            int bufferHeight = Math.Max(windowHeight, Console.BufferHeight);
            Console.SetBufferSize(bufferWidth, bufferHeight);

            // 再设置窗口尺寸
            Console.SetWindowSize(windowWidth, windowHeight);

            // 设置控制台背景色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            // 设置方块和颜色
            Console.ForegroundColor = ConsoleColor.Yellow;

            // 光标显隐
            Console.CursorVisible = false;

            // 获取当前光标位置
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            while (true) 
            {
                // 清除控制台
                //Console.Clear();

                Console.SetCursorPosition(x, y);
                Console.Write("■");

                // 获取玩家的输入信息
                ConsoleKeyInfo ki = Console.ReadKey(true);
                ConsoleKey key = ki.Key;

                // 把字母统一转换成方向键枚举
                if (ki.KeyChar == 'w' || ki.KeyChar == 'W') key = ConsoleKey.UpArrow;
                if (ki.KeyChar == 'a' || ki.KeyChar == 'A') key = ConsoleKey.LeftArrow;
                if (ki.KeyChar == 's' || ki.KeyChar == 'S') key = ConsoleKey.DownArrow;
                if (ki.KeyChar == 'd' || ki.KeyChar == 'D') key = ConsoleKey.RightArrow;

                // 清除方块
                Console.SetCursorPosition(x, y);
                Console.Write("  ");

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        y = Math.Max(y - 1, 0);
                        break;
                    case ConsoleKey.DownArrow:
                        y = Math.Min(y + 1, Console.BufferHeight - 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        x = Math.Max(x - 2, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        x = Math.Min(x + 2, Console.BufferWidth - 2);
                        break;
                }
            }

        }
    }
}
