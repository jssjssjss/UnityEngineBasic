﻿using Collections;
using System.Collections;
using System.Collections.Generic;

//yield 
// IEnumerator / IEnumerable 로 반복기를 구현할때 MoveNext() 에 해당하는 기능을 구현해 줄때 사용


IEnumerator MakeToastWorkflow()
{
    Console.WriteLine("토스트만들기() : 1. 인덕션을 켠다. ");
    yield return null;
    Console.WriteLine("토스트만들기() : 2. 인덕션에 팬을 올린다.");
    yield return null;
    Console.WriteLine("토스트만들기() : 3. 팬에 버터를 두른다 .");
    yield return null;
    Console.WriteLine("토스트만들기() : 4. 팬에 식빵을 올린다");

}
IEnumerator<string> MakeToastWorkflow2()
{
    yield return "토스트만들기() : 1. 인덕션을 켠다. ";
    yield return "토스트만들기() : 2. 인덕션에 팬을 올린다.";
    yield return "토스트만들기() : 3. 팬에 버터를 두른다 .";
    yield return "토스트만들기() : 4. 팬에 식빵을 올린다";

}

IEnumerable<int> WorkflowSample() { 

    yield return 1;
    yield return 2;
    yield return 3;
}



bool Match(int x)
{
    return x > 4;
}

#region Dynamic Array

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
tmpValue = (Char) obj;// unboxing : (object 객체의 데이터를 내가 원하는 자료형으로 형변환 하는것)   문자열에서 정수형으로 바뀔때는 오류가 생긴다.
Object obj2 = (Object)1;


MyDynamicArray<Dummy> dummies = new MyDynamicArray<Dummy>();
MyDynamicArray<float> floats = new MyDynamicArray<float>();

floats.Add(3.2f);
floats.Add(2.5f);
floats.Add(7.3f);
floats.Add(2.1f);

// using 구문 : IDisposable 객체의 Dispose() 호출을 보장하는 구문.
using (IEnumerator<float> enumerator = floats.GetEnumerator())
using (IEnumerator<Dummy> enumerator2 = dummies.GetEnumerator())
{
    while (enumerator.MoveNext())
    {
        Console.WriteLine(enumerator.Current);
    }
    enumerator.Reset();
}

//        Current       IEnumerable 를 넣는다
foreach (float item in floats)
{
    Console.WriteLine(item);
}

IEnumerator toastEnumerator = MakeToastWorkflow();
while (toastEnumerator.MoveNext()) { }

IEnumerator toastEnumerator2 = MakeToastWorkflow2();
while (toastEnumerator2.MoveNext())
{
    Console.WriteLine(toastEnumerator2.Current);
}
IEnumerator<int> e1 = WorkflowSample().GetEnumerator();
while (e1.MoveNext)
{
    Console.WriteLine(e1.Current);

}

IEnumerator<int> eSample = WorkflowSample();
foreach(var item in eSample)
        {
    Console.WriteLine(item);
}


ArrayList arrayList = new ArrayList();
arrayList.Add(3);
arrayList.Add("철수");
arrayList.Contains(3);

List<Dummy> list = new List<Dummy>();
list.Add(new Dummy());
list.Find(dummy => dummy.x < 0);

#endregion


class Dummy : IComparable<Dummy>
{
    public int x, y, z;
    public int CompareTo(Dummy? other)
    {
        // 삼항연산자 어떤조건? 조건이참일때값 : 조건이거짓일때값

        return (other != null) && (x == other.x) && (y == other.y) && (z == other.z) ? 0 : -1;

        if (other == null)
            return -1;

        if(x == other.x &&
           y == other.y &&
           z == other.z)
            return 0;
        else
            return 1;
    }
}

