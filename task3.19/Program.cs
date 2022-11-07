Console.Write("enter a 5-digit number = ");
int number = int.Parse(Console.ReadLine());
string s = number.ToString();
if (s[0].ToString() == s[4].ToString() && s[1].ToString() == s[3].ToString())
{
    Console.Write("yes");
}
else
{
   Console.Write("no"); 
}