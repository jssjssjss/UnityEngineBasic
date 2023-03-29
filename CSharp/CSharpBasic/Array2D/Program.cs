// const 키워드
// 상수키워드, 이 상수로 선언된 변수는 초기화만 가능하며 초기화 이후 상수처럼 사용된다.
// 이후 대입 연산 불가능함.


using System;
using System.Security.Cryptography;

const int MAP_HEIGHT = 4;
const int MAP_WIDTH = 5;


int[,] map = new int[MAP_HEIGHT, MAP_WIDTH]
    {

        { 2, 0, 0, 0,  1},
        { 0 , 1, 1, 1, 1},
        { 0 , 0, 0, 1, 1,},
        {  1, 1, 0 ,0, 3}

    };
int y = 0;
int x = 0;
int targetY = 3;
int targetX = 4;

void DisplayMap()
{
    Console.WriteLine("============================");
    for (int i = 0; i < map.GetLength(0); i++)

    {

        for (int j = 0; j < map.GetLength(1); j++)
        {

            if (map[i, j] == 0)
                Console.Write(" □");
            if (map[i, j] == 1)
                Console.Write("■");
            if (map[i, j] == 2)
                Console.Write("▣");
            if (map[i, j] == 3)
                Console.Write("★");


           
        }
        Console.WriteLine();
    }
    Console.WriteLine("======================================");
}

void MoveRight()
{
    // 맵 경계룰 벗어나지 않는지 체크
    // Map_WIDTH = 5


    if (x >= map.GetLength(1) -1)
    {
        Console.WriteLine("이동 실패, 맵 경계를 벗어남");
        return;

    }
    // 벽이 있는지 체크
    if (map[y, x +1] == 1)
    {
        Console.WriteLine("이동 실패, 벽이 막고 있음");
        return ;
    }

    map[y, x] = 0;
    x++;
    map[y, x] = 2;
    Console.WriteLine($"이동 완료, 현재 좌표 : ({x}, {y})");
    DisplayMap();



}




void MoveLeft()
{
    // 맵 경계룰 벗어나지 않는지 체크
    // Map_WIDTH = 5


    if (x <=0)
    {
        Console.WriteLine("이동 실패, 맵 경계를 벗어남");
        return;

    }
    // 벽이 있는지 체크
    if (map[y, x - 1] == 1)
    {
        Console.WriteLine("이동 실패, 벽이 막고 있음");
        return;
    }

    map[y, x] = 0;
    x--;
    map[y, x] = 2;
    Console.WriteLine($"이동 완료, 현재 좌표 : ({x}, {y})");
    DisplayMap();



}



void MoveUp()
{
    // 맵 경계룰 벗어나지 않는지 체크
    // Map_WIDTH = 5


    if (y <=0 )
    {
        Console.WriteLine("이동 실패, 맵 경계를 벗어남");
        return;

    }
    // 벽이 있는지 체크
    if (map[y -1, x ] == 1)
    {
        Console.WriteLine("이동 실패, 벽이 막고 있음");
        return;
    }

    map[y, x] = 0;
    y--;
    map[y, x] = 2;
    Console.WriteLine($"이동 완료, 현재 좌표 : ({x}, {y})");
    DisplayMap();



}

void MoveDown()
{
    // 맵 경계룰 벗어나지 않는지 체크
    // Map_WIDTH = 5


    if (y >= map.GetLength(0) - 1)
    {
        Console.WriteLine("이동 실패, 맵 경계를 벗어남");
        return;

    }
    // 벽이 있는지 체크
    if (map[y + 1, x] == 1)
    {
        Console.WriteLine("이동 실패, 벽이 막고 있음");
        return;
    }

    map[y, x] = 0;
    y++;
    map[y, x] = 2;
    Console.WriteLine($"이동 완료, 현재 좌표 : ({x}, {y})");
    DisplayMap();
}


// 게임루프
// ?= 값을 넣을수  있다는명시?
string? input;
while (true)
{
    //ReadLine 입력한 라인을 읽을수 있고 반환해준다
    
   input= Console.ReadLine();

    //Compare = 해당문자열의 정수값이 작으면 음수를 반환한다. 똑같은경우 0이 반환된다

    if (string.Compare(input, "R") == 0) MoveRight();
    else if (string.Compare(input, "L") == 0) MoveLeft();
    else if (string.Compare(input, "U") == 0) MoveUp();
    else if (string.Compare(input, "D") == 0) MoveDown();
    else
    {
        Console.WriteLine("잘못된 입렵, R,L,U,D 중 하나를 입력하세요....");
        continue;
    }

    if (y == targetY && x == targetX)
    {
        Console.WriteLine("도착함");
            break;
            }
}

