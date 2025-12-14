namespace Lesson2_练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson2_变量的练习");

            // 1.下面代码的输出结果是什么？
            double num = 36.6;
            Console.WriteLine("num");
            // 输出了 num 字符串

            // 2.声明float类型变量时，为什么要在数字后面加 f ？
            // 因为默认的小数类型是 double 类型
            // 为了明确告诉编译器，你希望将这个数字字面量视为 float 类型，而不是 double 类型。


            // 3.请定义一系列变量来存储你的个人信息（名字、年龄、性别、身高、体重、家庭住址等），并打印出来。
            string name = "冯杰林";
            byte age = 28;
            char gender = '男';
            float height = 1.73f;
            float weight = 59.15f;
            string address = "广东省广州市天河区珠吉街道文华新大街十四巷5号102";
            Console.WriteLine("我叫" + name + "，今年" + age + "岁" + "，性别" + gender + "，身高" + height + "，体重" + weight + "kg" + "，现住在" + address);

            // 4.小明的数学考试成绩是80，语文的考试成绩是78，英语的考试成绩是98，请用变量描述并打印。
            float mathScore = 80.6f;
            float chineseScore = 78f;
            float englishScore = 98f;
            Console.WriteLine("小明的数学成绩是" + mathScore + "，语文成绩是" + chineseScore + "，英语成绩是" + englishScore);

        }
    }
}
