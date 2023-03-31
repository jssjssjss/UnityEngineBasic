﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //추상클래스를 받기위한 추상클래스
    internal abstract class Character : Creature, IDamageable, IAttackable
    {
        public int Hp
        {
            get
            {
                return hp;
            }

        }

        public int AttackPower
        
        {
            get 
            {
                return attackPower;
            }
        }

        protected int hp;
        protected int attackPower;

        //생성자
        public Character()
        {

        }
        // 함수(생성자) 생성자 오버로딩
        // 함수 오버로딩 : 동일한 이름이지만, 파라미터의 종류가 다른함수를 정의하는 기능
        public Character(int hp, int attackPower)
        {
            // 지역변수는 상위에 선언된 동일한 이름의 모든 변수를 가린다.
            this.hp=hp; 
            this.attackPower=attackPower;   
        }

        // virtual 키워드 : 가상키워드
        // 함수를 구현하고 해당 함수를 하위타입에서 재정희 할 수 있도록 허용함.
        public virtual void SayHi()
        {
            Console.WriteLine($"안녕, 나는 {this} 야.");

        }


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

        public void Attack(IDamageable target)
        {
            target.Damage(this, attackPower);
        }
    }
}
