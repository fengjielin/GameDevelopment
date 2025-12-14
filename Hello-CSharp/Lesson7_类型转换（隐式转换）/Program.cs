namespace Lesson7_类型转换_隐式转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换_隐式转换");

            // 类型转换：不同变量类型之间的相互转换

            // 隐式转换的基本规则：不同类型之间自动转换
            // 大范围装小范围

            #region 知识点一：相同大类型之间的转换
            // 有符号 long > int > short > sbyte
            // 无符号 ulong > uint > ushort > byte
            // 浮点型 decimal（无法隐式转换） double > float
            // 特殊类型（不存在隐式转换） bool char string
            #endregion

            #region 知识点二：不同大类型之间的转换

            #region 无符号和有符号
            // 有符号类型不能隐式转换为无符号类型 有符号类型存在负数，无符号类型必然是无法包括的
            // 无符号类型可以隐式转换为有符号类型 无符号类型的范围需要小于有符号类型
            #endregion

            #region 整数（有、无符号）和浮点数
            // 浮点数可以装载任何类型的整数
            #endregion

            #region 特殊类型和其它类型

            // bool 无法与其它类型进行隐式转换
            // char 可以隐式转换为 int short long float double
            // [char类型是一个16位无符号整数，用于表示Unicode字符的编码值，取值范围是0~65535]
            // string 无法与其它类型进行隐式转换

            #endregion

            #endregion

            // 总结 隐式转换 规则
            // 高精度（大范围）装低精度（小范围）
            // double > float > 整数（无符号、有符号） > char
            // decimal > 整数（无符号、有符号） > char
            // string 和 bool 不能与其它类型进行隐式转换

            // 练习
            // 1.什么情况下会出现数据类型的隐式转换，请举例说明
            // 2.请将自己名字的每一个字符转换位成数字并打印出来

            int feng = '冯';
            int jie = '杰';
            int lin = '林';

            Console.WriteLine("“冯杰林”对应ASCII编码=" + feng + "_" + jie + "_" + lin);

        }
    }
}
