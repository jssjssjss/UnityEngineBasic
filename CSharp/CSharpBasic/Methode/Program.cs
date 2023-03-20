// 함수
//
// 함수 정의 형태
//
// 반환값타입 함수이름(매개변수1타입 매개변수1이름, 매개변수2타입 매개변수2이름 ,,,,,)
// {
//   연산내용
//   return 반환값;
// }


// 이렵을 받을 매개변수들 타입과 이름이 필요하고 반환값 형식또한 명시대야한다  ex) int sum(int a, int b)  { return a + b; }
//                                                                            반환갑타입 int  함수이름 int
//                                                                            

int Sum(int a, int b)
{

    // 지역변수
    // 함수(중괄호) 내에서 선언되고 해당 함수(괄호) 내에서만 접근이 가능(벗어나면 메모리 해제되는 변수)
    // 매게변수 도 지역변수에 포함된다
    int result = a + b;
   Printint(result);
    return result;

}


//void
// 반환 타입이 없을때 사용

void PrintHi()   
{
    Console.WriteLine("Hi");
   return; 
}


void Printint (int value)
{
    Console.WriteLine(value);
}


#region Manin   

//메인은 생략되어있다.
//함수 호출 형태
//함수이름 (인자1, 인자2 .....);
int result = Sum(1, 2);
Console.WriteLine(result);
Sum(3, 3);


#endregion


















