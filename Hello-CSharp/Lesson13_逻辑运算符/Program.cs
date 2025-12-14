namespace Lesson13_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");

            #region 知识点一 逻辑与 &&
            //规则 对两个bool值进行逻辑运算 一假则假 全真才真
            //如下：
            //true && true 结果是 true
            //true && false 结果是 false
            //false && true 结果是 false
            //false && false 结果是 false

            //逻辑运算符 优先级 低于 条件运算符

            #endregion

            #region 知识点二 逻辑或 ||
            //规则 对两个bool值进行逻辑运算 一真则真 全假才假
            //如下：
            //true || true 结果是 true
            //true || false 结果是 true
            //false || true 结果是 true
            //false || false 结果是 false

            #endregion

            #region 知识点三 逻辑非 !
            //规则 对一个bool值进行逻辑运算 真变假 假变真
            //如下：
            //!true 结果是 false
            //!false 结果是 true

            //逻辑非 运算符 优先级 高于 逻辑与和逻辑或

            #endregion

            #region 知识点四 混合使用优先级
            //逻辑非 优先级 高于 逻辑与 逻辑或
            //逻辑与 优先级 高于 逻辑或
            //逻辑运算符 优先级 低于 条件运算符 算数运算符（逻辑非除外）
            //可以使用 括号 改变优先级 顺序 先算括号内的内容
            #endregion

            #region 知识点五 逻辑运算符的短路特性
            // 逻辑与 和 逻辑或 运算符 具有 短路特性
            // 短路特性 是指 在某些情况下 可以不必计算所有的操作数 就能确定最终结果
            // || 有真则真
            // && 有假则假
            #endregion


            bool gg;
            bool win;
            int h = 100;
            gg = true;
            win = false;
            Console.WriteLine(gg || win && h > 0);
        }
    }
}
