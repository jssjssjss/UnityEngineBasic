

using System.Runtime.Serialization.Formatters;

int a = 823;
String a_tosting = a.ToString();
string num;

Console.WriteLine($"컴퓨터가 값을 생각했어요");

//string input =Console.ReadLine();
string input = "435";

//Console.WriteLine("input 의 값은 : " + input);
//Console.WriteLine("a의 타입은 : " + a.GetType());
//Console.WriteLine("input 의 타입은 : " + input.GetType());

Console.WriteLine(input[0]);
Console.WriteLine(a_tosting[0]);





    for (int i = 0; i < 3; i++)
    {
        for (int t = 0; t < 3; t++)
        {


            if (input[t] == a_tosting[i])
            {
                if (i==t)
                {
                    Console.WriteLine("스트라이크");
                     continue;
                }
                Console.WriteLine("볼");
            }

            else
            {
                Console.WriteLine("다르다");
            }
            Console.WriteLine("i" + input);
            Console.WriteLine("t" + a_tosting);
        }

        Console.WriteLine("끝");
    }
   
  

