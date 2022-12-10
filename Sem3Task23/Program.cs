
int number =ReadData("Введите число");
string outLine = LineBuilder(number,1);
PrintData("",outLine);
outLine = LineBuilder(number,3);
PrintData("",outLine);




// Методы

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");

}
void PrintData(string msg,string result)
{
    Console.WriteLine(msg+result);
}
string LineBuilder(int numN,int pow)
{
    string line = string.Empty;
    for(int i=1;i<numN;i++)
    {
        line = line + Math.Pow(i,pow) + "";
        
    }
    line = line + Math.Pow(numN,pow);
    return line;
}