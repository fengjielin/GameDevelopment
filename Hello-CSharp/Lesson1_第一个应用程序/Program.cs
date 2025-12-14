// 第一种注释 两杠注释 单行注释
// 第二种注释 斜杠星号注释 多行注释
// 第三种注释 三斜杠注释 文档注释

// 快捷键
// 注释：Ctrl + K + C
// 取消注释：Ctrl + K + U

// 单行注释 Ctrl + /
// 多行注释 Ctrl + Shift + /

// 引用命名空间（工具包）
using System;

/// <summary>
/// 本示例演示了如何在控制台应用程序中输出一行文本。
/// </summary>

// 1.命名空间 代码块
namespace Lesson1_第一个应用程序
{
    // 2.类 代码块
    internal class Program
    {
        // 3.函数 代码块 Main 函数是程序的入口点
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! 你好世界！");
            Console.WriteLine("你好！唐老狮");
            // 输出：Hello, World! 你好世界！
            /**
             * 请注意，这里的中文字符是可以正常显示的，这是因为 .NET Core 默认使用 UTF-8 编码。
             * 如果你的控制台不能正常显示中文字符，可以尝试修改控制台的编码方式。
             */

            // 6.5 控制台中 输入 打印 基础语句

            // 在控制台 打印一行信息 在打印信息结束后 自动空一行
            Console.WriteLine("Hello, World!");
            Console.WriteLine("冯杰林");

            // 在控制台 打印一行信息 在打印信息结束后 不自动空一行
            Console.Write("Hello, World!");
            Console.Write("冯杰林");

            Console.WriteLine(); // 空一行


            //检查玩家输入的代码
            //等待玩家输入完毕，在按回车键后才会据徐执行后面的代码
            //可以输入 很多信息 直到触发回车
            Console.WriteLine("请玩家输入");
            Console.ReadLine();

            //等待玩家按下任意键 按任意键后 就认为输入完毕
            Console.WriteLine("输入任意键结束输入");
            Console.ReadKey();

            Console.WriteLine(); // 空一行
            Console.WriteLine("玩家输入完毕！");

            // 输入
            // Console.ReadLine(); // 输入一行文本
            // Console.ReadKey();  // 输入一个按键

            // 输出
            // Console.WriteLine(); // 输出一行文本，结束后换行
            // Console.Write();     // 输出一行文本，结束后不换行
        }
    }
}