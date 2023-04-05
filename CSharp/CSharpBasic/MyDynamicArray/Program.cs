using Collections;

bool Match(int x)
{
    return x > 4;
}

MyDynamicArray myDynamicArray = new MyDynamicArray();
myDynamicArray.Add(5);
myDynamicArray.Add(7);
int tmplndex = myDynamicArray.FindIndex(7);
if(myDynamicArray.Remove(tmplndex))
{
    Console.WriteLine($"{tmplndex} index of myDynamicArray has removed");
}

myDynamicArray.RemoveAt(tmplndex);

for (int i = 0; i < myDynamicArray.Count; i++)
{
    Console.WriteLine(myDynamicArray[i]);

}

int tmpValue = (int)myDynamicArray.Find(x => (int)x > 4); //myDynamicArray.Find(Match);

//object : C#  모든 타입의 기반이 되는 타입
object obj = (object)1; // boxing : (object 타입 변환, 힙 영역에  object 타입 객체를 만들고 값을 할당) 
//object obj = 1; (object)생략되있음  
obj = "hi";
obj = 'A';
tmpValue = (int)obj;// unboxing : (object 객체의 데이터를 내가 원하는 자료형으로 형변환 하는것)   문자열에서 정수형으로 바뀔때는 오류가 생긴다.