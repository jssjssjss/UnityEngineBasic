using ClassObjectinstance;

//new 키워드
// 동적할당키워드



SwordMan swordMan1 = new SwordMan();
SwordMan swordMan2 = new SwordMan(); 
int a = 3;



// . 멤버 접근 연산자
swordMan1.Name = "전사";
swordMan1.Lv = 1;


swordMan2.Name = "기사";
swordMan2.Lv = 2;

swordMan1.Slash();
swordMan2.Slash();