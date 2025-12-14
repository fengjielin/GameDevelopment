namespace Lesson2_变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 折叠变量
            // 知识点一 折叠变量
            // 主要是为了让代码看起来更清晰
            // #region #endregion 配对出现
            // 本质：编辑器提供 预处理指令
            // 只在编辑时起作用，发布或编译后不起作用
            Console.WriteLine("变量");
            #endregion

            #region 知识点二 如何申明变量
            // 变量：可以变化的容器 用于存在各种不同类型数值的一个容器
            // 不同的变量类型 可以存储不同类型的数据

            // 申明变量的格式
            // 变量类型 变量名称 = 变量值;

            // 变量类型 14种
            // 变量名称 尽量是字母 数字 下划线 组成 不能以数字开头 不能是关键字
            // 变量值 只能是 该变量类型 所能存储的值
            // = 和 ; 是固定的 不变的

            // 关键字
            // 所能存储的范围
            // 所能存储的类型

            // 1.有符号的整型变量：能存储 一定范围 正负数 包括9的变量类型

            // sbyte -128 ~ 127
            sbyte sb = 1;
            // short -32,768 ~ 32,767
            short s = 1;
            // int -21亿 ~ 21亿
            int i = 1;
            // long -9百万兆 ~ 9百万兆
            long l = 1;

            // 2.无符号的整型变量： 只能存储 一定范围的 正数 包括0 的变量类型

            // byte 0 ~ 255
            byte b = 1;
            // uint 0 ~ 42亿
            uint ui = 1;
            // ushort 0 ~ 65535
            ushort us = 1;
            // ulong 0 ~ 18百万兆
            ulong ul = 1;

            // 3.浮点型变量（小数）
            // 被抛弃的数字会四舍五入
            // 默认类型是 double
            // float 的变量值后面要加 f 或 F
            // decimal 的变量值后面要加 m 或 M

            // 有效数字：从第一个不为0的数字开始 到 最后一个数字结束 中间的0也算
            // float 能存储7/8位有效数字 不同编辑器 有效数字有可能不一样
            float f = 0.1234567890f;
            // double 能存储15~17位有效数字
            double d = 0.12345678901234567890;
            // decimal 能存储27~28位有效数字 不建议使用
            decimal dec = 0.123456789012345678901234567890m;

            // 4.字符型变量
            // bool 布尔值 只能存储 true 或 false 表示真假的数据类型
            bool bo = true;
            // char 字符型 只能存储 单个字符 该字符要用单引号括起来
            char c = 'a';
            // string 字符串型 只能存储 多个字符（字符串） 该字符串要用双引号括起来
            string str = "abc";

            // 变量必须要先声明后使用 不能无中生有
            int x = 900;
            Console.WriteLine(x);
            x = 1000;
            Console.WriteLine(x);

            #endregion

            #region 知识点三 为什么存在那么多种不同的变量类型
            // 不同的变量 能存储的范围和类型不一样 本质上是占用的内存空间不一样
            // 实际开发中 选择不同的数据（变量）类型装在不同的数据

            // eg.
            // 姓名
            //char string
            string name = "冯杰林";
            // 年龄
            // byte int
            byte age = 18;
            // 身高 cm
            float height = 175.5f;
            // 体重 kg
            float weight = 65.5f;
            // 性别 true女 false男
            bool sex = false;

            // 应用技巧
            // 数字用int 小数用float 字符串用string 真假用bool
            #endregion

            #region 知识点四 多个相同类型变量 同时声明
            int i1 = 1, i2 = 2, i3 = 3;
            float f1 = 0.1f, f2 = 0.2f, f3 = 0.3f;
            string str1 = "a1", str2 = "b2", str3 = "c3";
            bool b1 = true, b2 = false;
            #endregion

            #region 知识点五 变量初始化
            // 变量在声明时，可以不设置初始值 但不建议 因为不安全
            // 变量在使用前，必须要有一个确定的值
            int ii; // 声明变量
            ii = 10; // 初始化变量
            Console.WriteLine(ii); // 使用变量
            #endregion
        }
    }
}
