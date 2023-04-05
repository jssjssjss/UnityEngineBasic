using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                if (value <= _hpMin)
                    OnHpMin?.Invoke();
                else
                    OnHpChanged?.Invoke(value); // null check : ?.invoke : 대리자에 등록된 함수가 없을경우 호출하지 않는구문  ? = null 이 가능한 변수다



            }
        }
        private int _hp;
        private int _hpMax = 100;
        private int _hpMin = 0;

        // 대리자 delegate
        //public delegate void HpChangedHandler(int hp);
        //public HpChangedHandler OnHpChanged; // event 한정자 : 대리자를 외부 클래스에서 직접 호출하거나 invoke 할 수 없도록제한
        public event Action<int> OnHpChanged;
        public event Action OnHpMin;
        private PlayerUI _playerUI;

        // Generic
        public Action<int, int> action; // 반환 타입이 없고, 파라미터는 0개 ~ 16개 까지 정의되어 있으므로 쓸 수 있다.
        public Func<int ,float> func; // 반환 타입이 있고, 
        public Predicate<int> predicate; // 반환 타입이 bool, 파라미터는 1개 ~ 16개 까지


        public Player()
        {
            Hp = _hpMax;
        }

        
    }
}
