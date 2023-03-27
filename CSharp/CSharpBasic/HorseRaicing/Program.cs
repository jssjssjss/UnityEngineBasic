// 진행 방식
//
//말 클래스 필요
// 말 클래스는 달린거리, 이동하기(달리기) 라는 함수를 가집니다.
//
// 프로그램 시작시
// 말 다섯마리를 만들고 
// 각 말의 이름은 "경주마i" (i : 1 ~ 5) 로 해줍니다.
// 각말은 초당 10.0 ~ 20.0f 범위의 거리를 랜덤하게 전진.
// 각각의 말은 200.0f 거리에 도달하면 도착으로 간주하고 더이상 전진하지 않고.
// 매 초마다 모든 말들이 상태 (도착했다면 "도착함", 달리고 있다면 현재 달린 누적 거리) 를 출력 해줍니다.
// 모든 말들이 도착했다면 경주를 끝내고 등수 순서대로 말들의 이름을 콘솔창에 출력 해줍니다.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using HorseRaicing;




Random _random;
double _speedMin = 10.0f;
double _speedMax = 20.0f;
double _posGoal = 200.0f;
bool _isGameFinished = false;
int _currentGrade = 1;
Horse[] _horsesArrived = new Horse[5];

Horse[] horses = new Horse[5];
for (int i = 0; i < horses.Length; i++)
{
    horses[i] = new Horse();
    horses[i].Name = $"경주마 {i + 1}";

}

while (_isGameFinished == false)
{

    for (int i = 0; i < horses.Length; i++)
    {
        if (horses[i].IsFinished)


        {
            Console.WriteLine($"{horses[i]}는 도착함");

        }

    


        
    else
    {
        _random = new Random();
        double tmpSpeed = (_random.NextDouble() + 1.0) * 10.0;
    horses[i].Move(tmpSpeed);

    if (horses[i].TotalDistance >= _posGoal)

    {
            horses[i].IsFinished = true;
            _horsesArrived[_currentGrade] = horses[i];
            _currentGrade++;

    }
    }
    if (_currentGrade >= 5)
    {
        break;
    }


    Thread.Sleep(1000);
}

for (int i = -1; i < _horsesArrived.Length; i++)
{
    Console.WriteLine($"{i + 1}등 {_horsesArrived[i].Name}");
}