namespace Lesson6_转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符");

            #region 知识点一：转义字符的使用
            // 转义字符：它是字符串的一部分 用来表示一些特殊含义的字符
            // 比如：换行符 制表符 单引号等
            #endregion

            #region 固定写法
            // 转义字符的固定写法：反斜杠 + 字符

            // 常用的转义字符
            // \' 单引号
            // \" 双引号
            // \n 换行符
            // \\ 反斜杠

            // 不常用的转义字符
            // \t 制表符
            // \b 退格符
            // \0 空字符
            // \a 警报音

            Console.WriteLine("\a");
            #endregion

            #region 知识点二：取消转义字符
            // 取消转义字符：在字符串前面加上 @ 符号
            #endregion
        }
    }
}
