namespace Loose_Coupling_InDependency;

class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}