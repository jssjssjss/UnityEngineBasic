using Inheritance;

//  Knight knight = new Knight(); 나이트 개체화

Knight knight = new Knight(200, 50);
Goblin goblin = new Goblin(100, 20);
Wizard wizard = new Wizard(150, 70);

// 공변성(Covariance)
//하위타입을 기반타입으로 참조가 가능한 성질. 

Creature[] creatures = new Creature[2];

creatures[0] = knight;
creatures[1] = goblin;


for (int i = 0; i < creatures.Length; i++)
{
    Console.WriteLine(creatures[i].Lv);

}


knight.Attack(goblin);

knight.SayHi();
wizard.SayHi();

// 기반타입의 참조 하위타입에  같은 타입이있다면 그것을쓴다.
// 공변성(Covariance)
//하위타입을 기반타입으로 참조가 가능한 성질. 


Character character1 = knight;
Character character2 = wizard;



character1.SayHi();
character2.SayHi();

