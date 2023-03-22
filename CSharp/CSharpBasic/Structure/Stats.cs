using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    //구조체 (안에 정의된 변수들을 멤버변수들이라 한다)
    //구조체도 사용자 정의 자료형
    //값 타입.



    //구조체 vs 클래스
    //
    // 1. 객체의 크기가 16byte 초과 -> 그냥 클래스 쓰는것을 권장
    // 값타입이 참조타입보다 빠르다
    // 기본적으로는 값타입 연산이 참조타입 연산보다 빠르기때문에 구초체의 연산이 빠르다.
    // 크기가 16 byte 를 초과하게 되면 레지스턴가 두번이상 값을 읽거나 써야하고,
    // 이 경우에 값타입 연산으로써의 장점보다 느려진다.
    //
    // 2. 함수인자/ 복잡한 수식등의 연산으로 인해 값의 전달이 빈번하게 일어날 경우
    // 구초체를 선택한다.

    // 

    struct Vector3
    {
        public float x;
        public float y;
        public float z;
    }

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


