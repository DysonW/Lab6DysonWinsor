void StackNoParams(){
int a = 5;
int b = 5;
int c = 5;
int d = 5;
int e = 5;
Main();
}
double StackWithParams(double x){
double v = 2.5;
double y = 2.5;
double z = 2.5;
double t = x + y + z + v;
Main();
return t;

}
string StackWithHeap(string F){
int a = 6;
int b = a + 5;
int c = 5;
string Reference = F;
decimal y = 1;
bool z = true;
string x = "x";
Console.WriteLine(F + x);
Main();
return F;
}
void StackOver(){
    int[] Yay = new int[1];
    StackOver();
    Main();
}
//StackNoParams();
//StackWithParams(6);
//StackWithHeap("Hello There");
//StackOver();
void Main(){
    Console.WriteLine("What would you like to do?\n1. StackNoParams\n2. StackWithParams\n3. StackWithHeap\n4. StackOverFlow\n5. Exit");
Console.WriteLine("<1 2 3 4 5>");
string Response = Console.ReadLine();
switch(Response){
    case "1":
    StackNoParams();
    break;
    case "2":
    StackWithParams(65);
    break;

    case "3":
    StackWithHeap("Hello There Tiger");
    break;
    case "4":
    StackOver();
    break;
    case "5":
    System.Environment.Exit(0);
    break;
    default:
    Console.WriteLine("What would you like to do?");
    Main();
    break;
    }
}

Main();