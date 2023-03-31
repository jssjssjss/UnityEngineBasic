using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //추상클래스를 받기위한 추상클래스
    internal abstract class Monster : Creature, IDamageable
    {
        public int Hp
        {
            get
            {
                return hp;
            }

        }

        public Monster()
        {


        }

        public Monster(int hp)
        {
            this.hp = hp;
        }

        protected int hp;

        public void Damage(IAttackable attacker, int value)
        {
            if (hp - value < 0)
            {
                Console.WriteLine($"{attacker}가 {this} 를 사망하게 하였습니다.");
                hp = 0;
            }
            else
            {
                Console.WriteLine($"{attacker} 가 {this} 에게 데미지를 {value}가했습니다. {this}의 현재 체력 : {hp}");
                hp -= value;
            }
        }
    }
}
