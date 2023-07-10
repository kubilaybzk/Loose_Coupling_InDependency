namespace Loose_Coupling_InDependency;

class Gmail : IMailServer
{
 //İmplement edilen fonksiyonumuz. Burada istediğimiz gibi çalışamlar yapabileceğiz.

    public void Send(string to, string body)
    {
        Console.WriteLine("The mail send succesful with to:" + to);
        Console.WriteLine("The mail body's:" + body);
    }
}
