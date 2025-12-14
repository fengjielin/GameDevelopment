namespace Lesson11_字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接");

            #region 知识点一：字符串拼接方式1

            // 字符串拼接 是将多个字符串 连接成一个字符串的操作

            // 使用 + 运算符 可以将多个字符串 拼接成一个字符串

            #endregion

            #region 知识点二：字符串拼接方式2

            // 使用 string.Format 方法 也可以将多个字符串 拼接成一个字符串
            // 占位符 {0} {1} {2} ...
            string name = string.Format("冯{0}{1}", "杰", '林');
            Console.WriteLine(name);
            #endregion

            #region 控制台打印拼接
            Console.WriteLine("冯{0}{1}", "杰", '林');
            #endregion
        }
    }
}
