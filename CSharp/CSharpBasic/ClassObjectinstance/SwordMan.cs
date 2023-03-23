using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C# naming convention
// 사용자정의 자료형의 이름 : PascalCase
// public, protected, internal 멤버 변수 : PascalCase
// private 멤버 변수 = _camelCase
// 지역변수 : camelCase
// 함수 : PascalCase 
// 

// namespace
// 이름으로 메모리 공간을 식별하기 위한 키워드
// 일반적인 namespace 작명 : 팀/ 회사 이름. 기술스택이름. 세부카테고리
// 한 회사에서 같은 클래스에 이름이 필요할때 namespace 로 구분

namespace ClassObjectInstance.UISystem.Characters
{
    internal class SwordMan
    {
    
    
    }

}
 
namespace ClassObjectinstance
{

    // 클래스
    // 캡슐화 하기위한 사용자정의 자료형
    internal class SwordMan
    {

        //접근 제한자 (Access Modifiers)
        // 1. private : 외부 접근 불가능
        // 2. public : 외부 접근 가능
        // 3. inernal : 동일 어셈블리에서 접근 가능 (동일 프로젝트 내에서 접근가능)
        // 4. protected : 상속받은 자식 클래스에서만 접근 가능
        // 클래스는 캡슐화를 위한 자료형이기 때문에 기본적으로 모든 멤버는 private 이 default 이다.


        // 멤버 변수들
        //클래스는 안보이지만 private 가 생략 되있다 string _name ->  private string _name
        public string Name;
        public int Lv;
        private float _exp;
        private char _gender;

        // 클래스 생성자
        // 정의하지 않아도 default 생성자가 생략됨
        // 해당 클래스타입의 객체를 힙영역에 할당하고 해당 객체의 참조를 반환 **
        
        public SwordMan()
        {


        }


        //소멸자
        //해당 객체를 메모리 영역에서 해제할때 호출하는 함수
        ~SwordMan()
        {


        }





        //멤버 함수들 기존함수와 다르게 다른함수에 변수들에 접근이 가능하다 한클래스로 묶어놨기에
        public void Slash()
        {
            //this 키워드 : 호출한 객체 자기자신의 참조를 반환하는 키워드 (생략돼있다.)   this 에 넣어서 실행한다. 함수를 호출하여 스택영역에 복사하여 쌓을때 
            Console.WriteLine($"{this.Name} 이(가) 베기를 시전했다.");

        }
    }
}
