

using System.Runtime.Serialization.Formatters;

int a = 832;
String a_tosting = a.ToString();


int strike = 0;
int ball = 0;
int out_count = 0;
bool IsBall = false;
int e = 0;

Console.WriteLine($"컴퓨터가 값을 생각했어요");


//string input = "435";

//Console.WriteLine("input 의 값은 : " + input);
//Console.WriteLine("a의 타입은 : " + a.GetType());
//Console.WriteLine("input 의 타입은 : " + input.GetType());





    for (int k = 0; k < 10; k++)
    {
        string input = Console.ReadLine();
   


    for (int i = 0; i < 3; i++)
        {
            for (int t = 0; t < 3; t++)
            {


                if (input[t] == a_tosting[i])
                {
                    IsBall = true;

                    if (i == t)
                    {
                        //Console.WriteLine("스트라이크");
                        strike++;
                        //strike = strike + 1;
                        //strike += 1;
                        continue;
                    }
                    //Console.WriteLine("볼");
                    ball++;
                }

            }
            if (!IsBall) //if는 true여야 실행되는데 !가 붙어서 반대가 된다. ex) if(true)    if(isball)=if(false)  실패   if(!isball) = if(true) 참트루 성공실행

                out_count++;

            IsBall = false;
     


        }

        Console.WriteLine("strike = " + strike);
        Console.WriteLine("ball = " + ball);
        Console.WriteLine("out_count = " + out_count);

        if (strike == 3)
        {
            Console.WriteLine("승리");
            break;
        }

    strike = 0;
    ball = 0;
    out_count = 0;
    e++;
    

    if (e>=10)
    {
        Console.WriteLine("패배");

    }

}



