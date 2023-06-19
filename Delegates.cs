namespace Delegates;
class Delegates
{
    public static double money = 55;
    public delegate string ShowMoney();
    public static string Euro(){
        return money.ToString() + " euros";
    }
    public static string Dollar(){
        return money.ToString() + " euros = " + (money * 1.09).ToString() + " dollars";
    }
    static void Main(string[] args)
    {
        ShowMoney show = Euro;
        Console.WriteLine(show());
        show = Dollar;
        Console.WriteLine(show());
    }
}
