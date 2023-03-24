
// 배열
// 메모리공간이 연속적인 데이터 포맷의 자료형
// 배열의 선언
// 자료형[] 이름 = new 자료형[갯수];    
// 초기화 : 자료형[] 이름 = {값1, 값2, 값3 ....};

//int[] = 인트형 인덱스가 필요하다  new int[5] = 5개의 공간이 필요하다
int[] intArr = new int[5];

// [] = 인덱서     [] 인덱서 안에 값은 인덱스
// 1차원 배열의 인덱서
// (배열의 첫번쨰 주소 + 인덱스 * 자료형) 의 주소부터 자료형 크기만큼의 데이터에 접근
intArr[0] = 1;
// intArr[5] = 1; // 크기가 n 인 배열의 인덱스 접근은 0부터 n-1 까지가능  ex   5=  5-1    == 4


Dummy[] dummies = new Dummy[3]; // Dummy 객체를 만듯거이 아니라 Dummy 객채를 참조할수 있는 공간 3개를 힙영역에 할당한것
dummies[0] = new Dummy();
dummies[1] = new Dummy();
dummies[2] = new Dummy();
class Dummy
{
    int a;
}
