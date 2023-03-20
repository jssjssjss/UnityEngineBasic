using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectinstance
{

    // 클래스
    // 캡슐화 하기위한 사용자정의 자료형
    internal class SwordMan
    {
        // 멤버 변수들
        string _name;
        int _Lv;
        float _exp;
        char _gender;

        //멤버 함수들 기존함수와 다르게 다른함수에 변수들에 접근이 가능하다 한클래스로 묶어놨기에
        void Slash()
        {
            Console.WriteLine($"{_name} 이(가) 베기를 시전했다.");

        }
    }
}
