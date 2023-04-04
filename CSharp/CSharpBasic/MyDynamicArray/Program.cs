using Collections;

MyDynamicArray myDynamicArray = new MyDynamicArray();
myDynamicArray.Add(5);
myDynamicArray.Add(7);
int tmplndex = myDynamicArray.FindIndex(7);
if(myDynamicArray.Remove(tmplndex))
{
    Console.WriteLine($"{tmplndex} or myDynamicArray has removed");
}

myDynamicArray.RemoveAt(tmplndex);

for (int i = 0; i < myDynamicArray.Count; i++)
{
    Console.WriteLine(myDynamicArray[i]);

}

