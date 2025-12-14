namespace Lesson12_条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符");
            #region 知识点一 条件运算符
            // 条件运算符 是用于 比较两个值之间的关系的运算符
            // 它返回结果是 布尔值 true 或 false
            // 常见的条件运算符有：
            // 等于 ==
            // 不等于 !=
            // 大于 >
            // 小于 <
            // 大于等于 >=
            // 小于等于 <=

            int a = 10;
            int b = 20;
            bool result = a > b; // 比较 a 是否大于 b 结果是 false
            Console.WriteLine(result);
            result = a < b; // 比较 a 是否小于 b 结果是 true
            Console.WriteLine(result);
            #endregion

            #region 知识点二 各种应用写法

            //变量与变量之间的比较
            int c = 15;
            result = a != c; // 比较 a 是否不等于 c 结果是 true
            //变量与数值之间的比较
            result = b >= 20; // 比较 b 是否大于等于 20 结果是 true
            //数值与数值之间的比较
            result = 5 <= 10; // 比较 5 是否小于等于 10 结果是 true
            //表达式与表达式之间的比较
            //条件运算符 优先级低于 算数运算符
            result = (a + b) == (c + 15); // 比较 (a + b) 是否等于 (c + 15) 结果是 true
            #endregion

            #region 知识点三 不能进行范围比较
            // 条件运算符 只能比较两个值之间的关系 不能比较一个值 是否在某个范围内
            //1 < a < 20; // 这是错误的写法
            #endregion

            #region 知识点四 不同类型之间的比较
            // 条件运算符 可以比较不同类型的值 但要注意 类型转换
            // 特殊类型 char string bool 只能同类型之间 使用 == 和 != 进行比较
            #endregion
        }
    }
}
