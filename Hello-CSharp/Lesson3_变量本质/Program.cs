namespace Lesson3_变量本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量本质");

            #region 知识点一 变量的存储空间（内存中）
            // 1byte = 8bit
            // 1KB = 1024byte
            // 1MB = 1024KB
            // 1GB = 1024MB
            // 1TB = 1024GB

            // 通过sizeof(变量类型)方法，可以获取变量类型所占用的内存空间（单位：字节）
            // 有符号
            Console.WriteLine("===================== 有符号的整型变量 =====================");
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte 占用的内存空间是" + sbyteSize + "字节");
            int shortSize = sizeof(short);
            Console.WriteLine("short 占用的内存空间是" + shortSize + "字节");
            int intSize = sizeof(int);
            Console.WriteLine("int 占用的内存空间是" + intSize + "字节");
            int longSize = sizeof(long);
            Console.WriteLine("long 占用的内存空间是" + longSize + "字节");

            //无符号
            Console.WriteLine("===================== 无符号的整型变量 =====================");
            int byteSize = sizeof(byte);
            Console.WriteLine("byte 占用的内存空间是" + byteSize + "字节");
            int ushortSize = sizeof(ushort);
            Console.WriteLine("ushort 占用的内存空间是" + ushortSize + "字节");
            int uintSize = sizeof(uint);
            Console.WriteLine("uint 占用的内存空间是" + uintSize + "字节");
            int ulongSize = sizeof(ulong);
            Console.WriteLine("ulong 占用的内存空间是" + ulongSize + "字节");

            // 浮点型
            Console.WriteLine("=====================    浮点型变量    =====================");
            int floatSize = sizeof(float);
            Console.WriteLine("byte 占用的内存空间是" + byteSize + "字节");
            int doubleSize = sizeof(double);
            Console.WriteLine("double 占用的内存空间是" + doubleSize + "字节");
            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal 占用的内存空间是" + decimalSize + "字节");

            // 特殊类型
            Console.WriteLine("=====================     特殊类型     =====================");
            int boolSize = sizeof(bool);
            Console.WriteLine("bool 占用的内存空间是" + boolSize + "字节");
            int charSize = sizeof(char);
            Console.WriteLine("char 占用的内存空间是" + charSize + "字节");

            // sizeof 不能获得string类型所占用的内存大小
            // 因为 字符串长度是可变的 不定的
            //int stringSize = sizeof(string);
            //Console.WriteLine("string 占用的内存空间是" + string + "字节");

            #endregion

            #region 知识点二 变量的本质
            // 变量的本质：二进制 计算机中所有数据的本质都是二进制 是由0和1组成的
            // 为什么是二进制？
            // 数据传递是通过电信号来传递的，只有开和关两种状态，所以可以用0和1来表示这两种状态
            // 计算机中的存储单位最小是bit（位），它只能表示0和1两个数字
            // 1bit = 0 或 1
            // 后续为了方便数据展示
            // 引入 byte（字节）单位，1byte = 8bit
            // 我们一般说一个字节为8位

            // 二进制和十进制的对比
            // 二进制和十进制之间的相互string转换
            #endregion

            // 练习
            // 1. 请默写出常用的14个变量类型，以及每个类型所占用的内存空间大小
            // 2. 请将二进制11000111、001101、01010101转为十进制，写出转换过程
            // 3. 请将十进制99、1024、78937转为二进制，写出转换过程
        }
    }
}
