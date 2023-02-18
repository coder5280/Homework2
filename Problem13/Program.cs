int number = 645; //78, 32679
string num = Convert.ToString(number);
if (num.Length < 3)
{
    Console.WriteLine("No 3rd number");
}
else
{
    Console.WriteLine(num[2]);
}


