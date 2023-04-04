using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Player
    {
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                if(_hp == value)
                    return;

                //  Tread
                //  Race condition : 어떤 함수를 쓰는 도중 다른곳에서 간섭하여 값이 바뀔수 있다.
                //  파라미터 원본을 쓰는 이유 : 다른 Tread 에서 건들여서 값이 바뀔수 있다.
                //  대리자에 하나라도 무언가 포함이 되있다면 invoke 를 사용한다.

                _hp = value;
               // OnHpChanged(value);
               // OnHpChanged.Invoke(value);  // invoke : 대리자에 등록된 함수들의  Racecondition 을 방지하기 위해 사용하는 함수
                OnHpChanged?.Invoke(value); // null check : ?.invoke : 대리자에 등록된 함수가 없을경우 호출하지 않는구문  ? = null 이 가능한 변수다


            }
        }
        private int _hp;
        private int _hpMax = 100;

        // 대리자 delegate
        public delegate void HpChangedHandler(int hp);  
        public HpChangedHandler OnHpChanged;


        public Player()
        {
            Hp = _hpMax;
        }

        
    }
}
