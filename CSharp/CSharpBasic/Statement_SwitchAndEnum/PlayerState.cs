using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_SwitchAndEnum
{

    //키워드 : 기본적으로 미리 정의 되어있는 문법
    //enum 키워드
    //열거형 사용자정의 자료형을 정의할때 사용하는 키워드
    //enum == 기본적으로 int 타입임.
    public enum PlayerState
    {
        Idle,
        Move,
        Jump,
        Attack = 10,
        Skill
    }
}
