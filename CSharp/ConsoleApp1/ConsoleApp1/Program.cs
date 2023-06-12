
/////////index num[0    1    2    3    4    5    6    7    8    9]
///////////////////1    2    3    4    5    6    7    8    9   10
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

string[] deck = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                  "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};


Dictionary<string, int> jokbo = new Dictionary<string, int>()
{   //dictionary에 10땡 까지 추가하기
    { "CH",999},               //38광땡
    { "AC",400},{ "AH",400},   //13,18 광떙
    { "aA", 200 },{ "bB", 220 },{ "cC", 240 },{ "dD", 260 },{ "eE", 280 },{ "fF", 300 },{ "gG", 320 },{ "hH", 340 },{ "iI", 360 },{ "jJ", 380 }, //떙
    { "ab",180},{ "aB",180},{ "Ab",180},{ "AB",180}, //알리  1,2
    { "ad",160},{ "aD",160},{ "Ad",160},{ "AD",160}, //독사  1,4
    { "ai",140},{ "aI",140},{ "Ai",140},{ "AI",140}, //구삥  1,9
    { "aj",120},{ "aJ",120},{ "Aj",120},{ "AJ",120}, //장삥  1,10
    { "di",100},{ "dI",100},{ "Di",100},{ "DI",100}, //장사  4,10
    { "df",80},{ "dF",80},{ "Df",80},{ "DF",80}, //세륙
    { "cg",1},{ "cG",1},{ "Cg",1},{ "CG",1},  //떙잡이
    {"DG",0 }                                 //광잡이

};
Dictionary<string, int> non_jokbo = new Dictionary<string, int>()
{
    {"a",1 },{"A",1 },{"b",2 },{"B",2 },{"c",3 },{"C",3 },{"d",4 },{"D",4 },{"e",5 },{"E",5 },
    {"f",6 },{"F",6 },{"g",7 },{"G",7 },{"h",8 },{"H",8 },{"i",9 },{"I",9 },{"j",10 },{"J",10 },
};

//List 사용해서 player0 만들고, 카드 2장 넣어보기.


List<string> player0 = new List<string>();
List<string> player1 = new List <string>();
List<string> player2 = new List <string>();
List<string> player3 = new List <string>();
List<string> ddang = new List<string>() { "aA", "bB", "cC", "dD", "eE", "fF", "gG", "hH", "iI"}; //떙 리스트
List<string> ddang_kill = new List<string>() { "cg", "cG", "Cg", "CG" };                                //떙잡이 리스트
List<string> ggang = new List<string>() { "AC","AH" };
List<string> ggang_kill = new List<string>() { "DG" };


List<string> player_card = new List<string>();
List<int> player_value = new List<int>();
List<int> rand_list = new List<int>();
Random rand = new Random();


for (int i = 0; i < 2; i++)
{
    int rand_num=rand.Next(0,20);
    if (true)
    {

    }

}





//랜덤 처리 방식
player0.Add(deck[1]);
player0.Add(deck[4]);

player1.Add(deck[13]);
player1.Add(deck[16]);       //광잡이

player2.Add(deck[8]);
player2.Add(deck[7]);

player3.Add(deck[10]);
player3.Add(deck[12]);      //13광


player0.Sort();
player1.Sort();
player2.Sort();
player3.Sort();



player_card.Add(player0[0] + player0[1]);
player_card.Add(player1[0] + player1[1]);
player_card.Add(player2[0] + player2[1]);
player_card.Add(player3[0] + player3[1]);


int max = 0;
bool isDDang = false;
bool isDDang_kill = false;
bool isGang = false;
bool isGang_kill = false;




//
for (int i = 0; i < 4; i++)
{
    if (jokbo.ContainsKey(player_card[i]))
    {
        player_value.Add(jokbo[player_card[i]]);
    }
    else
    {
        player_value.Add((non_jokbo[player_card[i][0].ToString()]+(non_jokbo[player_card[i][1].ToString()]) %10));
    }
}

//=====================================================================플레이서 순서및 값
for (int i = 0; i < player_value.Count; i++)
{
    Console.WriteLine("player"+i+"의 카드" + player_card[i]);
    Console.WriteLine("player "+i+"의 숫자"+player_value[i]+"");
    Console.WriteLine("");
}



//==================================================================떙  찾기
for (int i = 0; i < player_card.Count; i++)
{
    if (ddang.Contains(player_card[i]))
    {
        isDDang = true;
        Console.WriteLine("떙이 존재합니다.");
        break;
    }

}
// ================================================================떙잡이 찾기
if (isDDang)
{
    for (int i = 0; i < player_card.Count; i++)
    {
        Console.WriteLine(i + "현재위치입니다.");

        if (ddang_kill.Contains(player_card[i]))
        {
            isDDang_kill = true;
            Console.WriteLine("떙잡이가 존재합니다.");
            player_value[i] = 370;
            break;
        }

    }

}

//=====================================================================광떙 찾기
for (int i = 0; i < player_card.Count; i++)
{
    Console.WriteLine(i+"현재위치입니다.");
    if (ggang.Contains(player_card[i]))
    {
        isGang = true;
        Console.WriteLine("광떙이 존재합니다");
        break;
    }

}

//=================================================================암행어사 찾기
if (isGang)
{
    for (int q = 0; q < player_card.Count; q++)
    {
        
        if (ggang_kill.Contains(player_card[q]))
        {
            isGang_kill = true;
            Console.WriteLine("광잡이가 존재합니다");
            player_value[q] = 980;
            break;

        }
    }
}
//===========================================================맥스값 비교
int max_index = 0;

for (int i = 0; i < player_value.Count; i++)
{
    if (max < player_value[i])
        max = player_value[i];
    max_index = i;
}


for (int i = 0; i < player_value.Count; i++)
{
    if (max < player_value[i])
    {
        max = player_value[i];
        max_index = i;

    }

}
Console.WriteLine("");
Console.WriteLine(max_index+"번째 플레이어");
Console.WriteLine("최대값 :" +max);
