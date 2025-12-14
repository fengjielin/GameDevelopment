namespace Lesson9_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");

            #region 作用
            //string str = Console.ReadLine();
            //int number = int.Parse(str); // 如果输入的不是数字 程序会报错并卡死

            // 异常捕获 可以避免当程序报错时，出现程序卡死的情况

            #endregion

            #region 基本语法

            try 
            {
                // 可能会报错的代码
                // 将会在代码报错时进行捕获
            }
            catch(Exception e)
            {
                // 当try中的代码报错时 会执行这里的代码
                // Exception e 可以获取到报错的具体信息
            }
            finally 
            {
                // 不管try中的代码是否报错 都会执行这里的代码
            }

            #endregion

            #region 实践
            try
            {
                string str = Console.ReadLine();
                int number = int.Parse(str);
            }
            catch (Exception e)
            {
                Console.WriteLine("报错信息=" + e);
                Console.WriteLine("输入的不是数字，请重新输入");
            }
            finally {
                Console.WriteLine("执行完毕！不管是否报错都会执行这里的代码");
            }
            #endregion

            // 练习
            // 1.请用户输入一个数字，如果输入有误，则提示用户重新输入
            // 2.提示用户输入姓名、语文、数学、英语成绩，如果输入有误，则提示用户重新输入，否则将输入的3门成绩用整型变量存储
        }
    }
}
