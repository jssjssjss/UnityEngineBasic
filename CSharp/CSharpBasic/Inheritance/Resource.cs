using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Resource : IDamageable
    {
        public int Hp
        {
            get
            {
                return hp;
            }

        }

        protected int hp;

        public void Damage(IAttackable attacker, int value)
        {
            if (hp - value < 0)
            {
                Console.WriteLine($"{attacker}가 {this} 를 채집하게는데 성공하였습니다.");
                hp = 0;
            }
            else
            {
                Console.WriteLine($"{attacker} 가 {this} 를 채집 중입니다...{this}의 남은 체력 : {hp}");
                hp -= value;
            }
        }
    }
}
