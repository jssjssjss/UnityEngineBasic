using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    //구조체 (안에 정의된 변수들을 멤버변수들이라 한다)
    //구조체도 사용자 정의 자료형
     public struct Stats
    {
        //멤버 변수들
        public int STR;
        public int DEX;
        public int INT;
        public int LUK;

        //멤버 함수들
        public int GetCombotPower()
        
        {
            
            return STR + DEX + INT + LUK;
        
        
        }
    }
}

// C#에서는 멤버함수를 만들수 있다.


