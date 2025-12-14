namespace Lesson1_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 练习 1：在控制台中 依次输入 姓名 年龄 班级
            Console.WriteLine("请输出您的名字：");
            Console.ReadLine();
            Console.WriteLine("请输入您的年龄：");
            Console.ReadLine();
            Console.WriteLine("请输入您的班级：");
            Console.ReadLine();

            // 练习 2：问用户喜欢什么运动，不管用户输入什么，都回答“哈哈，好巧。我也喜欢这个运动”
            Console.WriteLine("您喜欢什么运动？");
            Console.ReadLine();
            Console.WriteLine("哈哈，好巧。我也喜欢这个运动");

            // 练习 3
            Console.WriteLine("接下来将输出10*10的空心星型方阵：");
            Console.WriteLine("**********");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("**********");
        }
    }
}
