namespace Lesson10_算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算数运算符");

            //算数运算符 是用于 数值类型变量计算的运算符
            //它返回结果是数值

            #region 知识点一：赋值符号
            // =
            // 先看右边的值，再看左边 然后将其赋值给左边的变量

            string name = "冯杰林";  // 将"冯杰林" 赋值给 name 变量
            #endregion

            #region 知识点二：算数运算符

            //加 +
            //用自己计算 先计算右侧结果 再赋值给左侧变量
            int i = 1;
            i = i + 1; // 先计算 i + 1 的结果是2 再赋值给 i 变量 所以i最终是2

            //Console.WriteLine(i);
            //连续运算 先算右侧结果 再赋值给左侧变量

            //初始化时就进行运算 先算右侧结果 再赋值给左侧变量

            //减 -

            //乘 *

            //除 /

            float f = 10f / 3; // 10f 是 float 类型的10
            //默认的整数是 int 类型 除法时 如果两个整数相除 会得到一个整数结果 小数部分会被舍弃掉
            //如果想得到小数结果 需要将其中一个整数 转换成 小数类型(float 或 double)

            //Console.WriteLine(f);

            //取余 %

            #endregion

            #region 知识点三：算数运算符的 优先级
            //优先级 在混合运算时的运算顺序

            //乘除取余 优先级 高于 加减 应该先算乘除取余 再算加减
            int result = 1 + 2 * 3; // 先算 2 * 3 = 6 再算 1 + 6 = 7

            //Console.WriteLine(result);
            //括号可以改变优先级 先算括号内的内容
            result = (1 + 2) * 3; // 先算 (1 + 2) = 3 再算 3 * 3 = 9
            //Console.WriteLine(result);

            //多组括号时 从内到外 依次计算 先算最内层的括号 依次向外计算
            result = (1 + (2 + 3) * 2) * 3; // 先算 (2 + 3) = 5 再算 5 * 2 = 10 再算 1 + 10 = 11 最后算 11 * 3 = 33
            //Console.WriteLine(result);
            #endregion

            #region 知识点四：算数运算符的 复合运算符
            // +=  -=  *=  /=  %=
            // 复合运算符 是 对 算数运算符 和 赋值符号 的 简写
            // 复合运算符 是用于 自己和自己进行运算 并将结果 赋值给 自己

            // 复合运算符 只能进行一种运算 不能混合运算
            // i */-+= 2; // 错误写法
            #endregion

            #region 知识点五：算数运算符的 自增减
            // ++  --
            // 自增减 是 对 变量进行 +1 或 -1 的简写

            int a1 = 1;
            a1++; // 等同于 a = a + 1;
            --a1; // 等同于 a = a - 1;
                 //Console.WriteLine(a++); // 先输出a的值 再进行自增运算
                 //Console.WriteLine(--a); // 先进行自减运算 再输出a的值
            #endregion


            //练习
            //1.定义一个变量存储你的年龄，十年后你的年龄是多少？请输出到控制台；
            Console.WriteLine("练习1*******************");
            int age = 28;
            age = age + 10;
            Console.WriteLine("十年后你的年龄是：" + age);

            //2.计算一个半径为5的圆的面积和周长，公式：面积=半径*半径*3.14，周长：2*3.14*半径，请输出到控制台；
            Console.WriteLine("练习2*******************");
            int r = 5;
            const float PI = 3.14f;
            float area = r * r * PI;
            float perimeter = 2 * PI * r;
            Console.WriteLine("半径为5的圆的面积是：" + area);
            Console.WriteLine("半径为5的圆的周长是：" + perimeter);

            //3.计算任意三门成绩的总分、平均分打印到控制台；三门成绩均为整数类型，平均分保留两位小数；
            Console.WriteLine("练习3*******************");
            int chinese = 85;
            int math = 90;
            int english = 88;
            int totalScore = chinese + math + english;
            float averageScore = totalScore / 3f;
            Console.WriteLine("总分是：" + totalScore);
            Console.WriteLine("平均分是：" + averageScore.ToString("F2"));

            //4.商店T恤衫价格为285元/件，裤子价格为720元/条，小李在该店买了2件T恤衫和3条裤子，计算该付多少钱？打8.5折后实际支付了多少元？请输出到控制台；
            Console.WriteLine("练习4*******************");
            int tShirtPrice = 285;
            int pantsPrice = 720;
            int tShirtCount = 2;
            int pantsCount = 3;
            int totalAmount = (tShirtPrice * tShirtCount) + (pantsPrice * pantsCount);
            float discountedAmount = totalAmount * 0.85f;
            Console.WriteLine("总金额是：" + totalAmount);
            Console.WriteLine("打8.5折后实际支付了：" + discountedAmount);

            /*5.请说明 number1和number2和number3的结果
             * 
             * int a = 10, b = 20;
             * int number1 = ++a + b;
             * 31
             * a = 10;
             * b = 20;
             * int number2 = a + b++;
             * 30
             * a = 10;
             * b = 20;
             * int number3 = a++ + ++b + a++;
             * 42
             */

            //6.有两个数 a=99,b=87, 请写出两种方法交换它们的值，并打印交换后的结果到控制台。
            Console.WriteLine("练习6*******************");
            int a = 99;
            int b = 87;
            //方法一：使用第三个变量
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("方法一交换后：a=" + a + ", b=" + b);
            //方法二：不使用第三个变量
            a = 99;
            b = 87;
            a = a + b; // a = 99 + 87 = 186
            b = a - b; // b = 186 - 87 = 99
            a = a - b; // a = 186 - 99 = 87
            Console.WriteLine("方法二交换后：a=" + a + ", b=" + b);

            //7.请把987652秒通过代码转换为n天n小时n分钟n秒的格式输出到控制台。
            Console.WriteLine("练习7*******************");
            const int SecondsPerDay = 86_400;
            const int SecondsPerHour = 3_600;
            const int SecondsPerMinute = 60;
            int totalSeconds = 987652;
            int days = totalSeconds / SecondsPerDay;
            int hours = (totalSeconds % SecondsPerDay) / SecondsPerHour;
            int minutes = (totalSeconds % SecondsPerHour) / SecondsPerMinute;
            int seconds = totalSeconds % SecondsPerMinute;
            Console.WriteLine(days + "天" + hours + "小时" + minutes + "分钟" + seconds + "秒");
        }
    }
}
