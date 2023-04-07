
using System.Collections;
using System.Collections.Generic;


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

IEnumerator toastEnumerator = MakeToastWorkflow();
while (toastEnumerator.MoveNext()){}

IEnumerator toastEnumerator2 = MakeToastWorkflow2();
while (toastEnumerator2.MoveNext())
{
    Console.WriteLine(toastEnumerator2.Current);
}
