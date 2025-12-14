namespace Lesson8_类型转换_显式转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换_显式转换");

            // 显式转换：手动处理 强制转换

            #region 知识点一：括号强转 [数值之间]
            // 作用：将高精度的类型强制转换为低精度的类型
            // 语法：变量类型 变量名 = (变量类型)变量;
            // 注意：精度问题（浮点） 范围问题（整型） 可能会出现数据丢失或溢出

            // 相同大类型之间的转换
            // 有符号类型之间
            // 无符号类型之间
            // 浮点型之间

            // 不同大类型之间的转换
            // 无符号和有符号
            // 浮点型和整型
            // char和数值类型
            // bool和string 无法使用括号强行转换
            #endregion

            #region 知识点二：Parse法 【字符串转对应类型】
            // 作用：将字符串类型转换为其它类型
            // 语法：变量类型 变量名 = 变量类型.Parse(字符串变量);
            // 注意：字符串变量必须是该类型所能表示的值 否则会报错

            // 有符号
            int intParse = int.Parse("123");
            //intParse = int.Parse("456.7"); // 报错 456.7 为浮点数 不能转换为int类型
            Console.WriteLine("intParse=" + intParse);

            // 无符号

            // 浮点型

            // 特殊类型

            #endregion

            #region Convert法 【更全面】
            // 作用：更准确的将 各个类型之间进行相互转换
            // 语法：变量类型 变量名 = Convert.To变量类型(变量或常量);
            // 注意：字符串变量必须是该类型所能表示的值 否则会报错

            // 字符串转整数
            int a = Convert.ToInt32("12");
            Console.WriteLine("a=" + a);

            // 浮点转整数
            a = Convert.ToInt32(12.64f);
            Console.WriteLine("a=" + a);

            a = Convert.ToInt32(true);
            Console.WriteLine("a=" + a);
            a = Convert.ToInt32(false);
            Console.WriteLine("a=" + a);

            a = Convert.ToInt32('A');
            Console.WriteLine("a=" + a);

            // 每种类型都存在对应的 Convert.ToXXX() 方法
            // sbyte： Convert.ToSByte();
            // short： Convert.ToInt16();
            // int： Convert.ToInt32();
            // long： Convert.ToInt64();

            // byte： Convert.ToByte();
            // ushort： Convert.ToUInt16();
            // uint： Convert.ToUInt32();
            // ulong： Convert.ToUInt64();

            // float： Convert.ToSingle();
            // double： Convert.ToDouble();
            // decimal： Convert.ToDecimal();

            // bool： Convert.ToBoolean();
            // char： Convert.ToChar();
            // string： Convert.ToString();

            #endregion

            #region 其它类型转string
            // 作用：拼接打印
            // 语法：变量类型 变量名 = 变量或常量.ToString();

            Console.WriteLine("123123" + 1 + true);
            #endregion

            Console.WriteLine("============================");
            // 练习
            // 1.显式类型转换有几种方式？它们分别是什么，请举例说明
            // 2.请将24069转为字符并打印出来
            char ch = (char)24069;
            Console.WriteLine("ch=" + ch);
            char ch2 = Convert.ToChar(24069);
            Console.WriteLine("ch2=" + ch2);
            // 3.提示用户输入姓名、语文、数学、英语成绩，并将输入的3门成绩用整型变量存储
        }
    }
}
