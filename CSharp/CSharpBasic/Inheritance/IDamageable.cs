using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // interface 는 default 접근제한가 public 임, 기본적으로 퍼블릭임
    // 프로퍼티, 함수 이벤트 멤버들을 추상화하기 위한  용도이므로 기본적으로 멤버들 선언만함
    // 보통 선언만 한다   void Damage(int value); 
    internal interface IDamageable
    {

        // get 접근자
        //현재 체력을 읽는 
       int Hp { get; }
        void Damage(IAttackable attacker, int value); 

    }
}
