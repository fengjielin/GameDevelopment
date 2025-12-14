using System;

namespace HelloWorldCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] array = new string[0];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "位用户的信息：");
                string info = GetUserInfo();

                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = info;
            }

            Console.WriteLine(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        static string GetUserInfo()
        {
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();

            Console.WriteLine("请输入你的故乡：");
            string address = Console.ReadLine();

            Console.WriteLine("请输入你的爱好：");
            string hobby = Console.ReadLine();

            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();

            name = changeData(name);

            Console.WriteLine();
            string newInfo = "你的名字是：" + name + "，故乡是：" + address + "，爱好是：" + hobby + "，年龄是" + age + "岁";
            Console.WriteLine(newInfo);
            Console.WriteLine();

            return newInfo;
        }

        static string changeData( string name)
        {
            if (name == "张三")
            {
                name = "法外狂徒·张三";
                Console.WriteLine();
                Console.WriteLine("原来是小瘪三：" + name);
            }
            return name;
        }
    }
}
