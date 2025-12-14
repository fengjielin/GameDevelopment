namespace Lesson14_位运算
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("位运算");
            //位运算符 是用于 对整数类型变量的二进制位 进行操作的运算符

            #region 知识点一 位与 &
            // 规则 对两个二进制位进行位运算 同为1则1 有0则0
            int a = 1; //001
            int b = 5; //101
            int c = a & b;
            Console.WriteLine(c); //001

            // 8421法 128 64 32 16 8 4 2 1 比如 19=16+2+1=00010011

            #endregion

            #region 知识点二 位或 |
            // 规则 对两个二进制位进行位运算 同为0则0 有1则1
            #endregion

            #region 知识点三 异或 ^
            // 规则 对两个二进制位进行位运算 相同则0 不同则1
            #endregion

            #region 知识点四 位取反 ~
            // 规则 对一个二进制位进行位运算 0变1 1变0
            #endregion

            #region 知识点五 左移 << 和 右移 >>
            // 左移 规则 将一个数的二进制位 向左移动 指定位数 右侧空位补0
            // 右移 规则 将一个数的二进制位 向右移动 指定位数 左侧空位补0（无符号右移）或补符号位（有符号右移）

            #endregion

        }
    }
}
