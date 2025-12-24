namespace 必备知识点_随机数练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数练习题");
            //唐老狮打小怪兽
            //唐老狮攻击力为8~12之间的一个值
            //小怪兽防御为10，血量为20
            //在控制台中通过打印信息表现唐老狮打小怪兽的过程
            //描述小怪兽的掉血情况
            //伤害计算公式：攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值

            int monsterDef = 10; // 小怪兽防御力
            int monsterHp = 20; // 小怪兽血量
            Console.WriteLine("小怪兽防御力{0}，小怪兽血量{1}", monsterDef, monsterHp);

            int atk = 0;
            Random r = new Random();

            int round = 1; // 回合数
            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("回合数 -{0}-", round);
                atk = r.Next(8, 13); // 生成一个 8到12的随机数 左包含 右不包含
                Console.WriteLine("你的攻击力为：" + atk);
                int damage = 0; // 伤害值
                // 计算伤害 攻击力大于防御力时，伤害为攻击力-防御力，否则伤害为0
                if (atk > monsterDef)
                {
                    damage = atk - monsterDef;
                }
                else
                {
                    damage = 0;
                }
                round++;
                monsterHp -= damage; // 减少小怪兽血量
                if (monsterHp < 0) monsterHp = 0; // 防止血量为负数
                Console.WriteLine("小怪兽受到伤害为：" + damage);
                Console.WriteLine("小怪兽剩余血量为：" + monsterHp);
                Console.WriteLine("-----------------------");
                if (monsterHp <= 0)
                {
                    Console.WriteLine("小怪兽被你打败了！");
                    Console.WriteLine("总回合数{0}", round);
                    break;
                }
                Console.WriteLine("请按任意键继续攻击");
                Console.ReadKey(true);
            }
        }
    }
}
